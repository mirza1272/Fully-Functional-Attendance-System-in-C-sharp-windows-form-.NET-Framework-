using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Attandance_System
{
    public partial class UC_markattandance : UserControl
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Attandance_System;Integrated Security=True;Encrypt=False";
        private readonly int currentUserId;
        private ErrorProvider errorProvider;

        public UC_markattandance(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            errorProvider = new ErrorProvider();
            this.Name = "UC_markattandance";
            InitializeStatusComboBox();
            datetimepicker.Value = DateTime.Today;
        }

        private void InitializeStatusComboBox()
        {
            comboboxforstatus.Items.Clear();
            comboboxforstatus.Items.Add("Choose Status");
            comboboxforstatus.Items.Add("Present");
            comboboxforstatus.Items.Add("Late");
            comboboxforstatus.Items.Add("Leave");
            comboboxforstatus.Items.Add("Absent");
            comboboxforstatus.SelectedIndex = 0;
        }

        private void idtextbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idtextbox.Text) && !int.TryParse(idtextbox.Text, out _))
            {
                errorProvider.SetError(idtextbox, "Student ID must be a number");
            }
            else
            {
                errorProvider.SetError(idtextbox, "");
            }
        }

        private void addattbtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(idtextbox.Text) || !int.TryParse(idtextbox.Text, out int studentId))
            {
                errorProvider.SetError(idtextbox, "Valid student ID required");
                return;
            }

            if (comboboxforstatus.SelectedIndex <= 0)
            {
                errorProvider.SetError(comboboxforstatus, "Status is required");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Check student exists
                    string checkQuery = "SELECT COUNT(*) FROM Students WHERE Student_id = @StudentId";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@StudentId", studentId);
                    connection.Open();

                    if ((int)checkCommand.ExecuteScalar() == 0)
                    {
                        errorProvider.SetError(idtextbox, "Student ID not found");
                        return;
                    }

                    // Check duplicate attendance
                    string dupQuery = @"SELECT COUNT(*) FROM Attendance 
                                      WHERE student_id = @StudentId 
                                      AND date = @Date";
                    SqlCommand dupCommand = new SqlCommand(dupQuery, connection);
                    dupCommand.Parameters.AddWithValue("@StudentId", studentId);
                    dupCommand.Parameters.AddWithValue("@Date", datetimepicker.Value.Date);

                    if ((int)dupCommand.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Attendance already marked for this student/date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert attendance
                    string insertQuery = @"INSERT INTO Attendance 
                                         (student_id, date, status) 
                                         VALUES (@StudentId, @Date, @Status)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@StudentId", studentId);
                    insertCommand.Parameters.AddWithValue("@Date", datetimepicker.Value.Date);
                    insertCommand.Parameters.AddWithValue("@Status", comboboxforstatus.SelectedItem.ToString());

                    if (insertCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Attendance marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idtextbox.Clear();
                        comboboxforstatus.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_markattandance_Load(object sender, EventArgs e) { }
        private void datetimepicker_ValueChanged(object sender, EventArgs e) { }
        private void comboboxforstatus_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}