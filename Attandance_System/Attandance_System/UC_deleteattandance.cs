using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attandance_System
{
    public partial class UC_deleteattandance : UserControl
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Attandance_System;Integrated Security=True;Encrypt=False";
        private readonly int currentUserId;

        public UC_deleteattandance(int userid)
        {
            InitializeComponent();
            currentUserId = userid;
            datetimepick.Value = DateTime.Today; // Set default to today
        }
        private void UC_deleteattandance_Load(object sender, EventArgs e)
        {

        }
        private void delattbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtextbox.Text))
            {
                MessageBox.Show("Please enter Student ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idtextbox.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID (numeric value)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = datetimepick.Value.Date;
            string dateString = selectedDate.ToString("yyyy-MM-dd");

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First verify student exists
                    string checkStudentQuery = "SELECT COUNT(1) FROM Students WHERE Student_id = @StudentId";
                    SqlCommand checkCmd = new SqlCommand(checkStudentQuery, connection);
                    checkCmd.Parameters.AddWithValue("@StudentId", studentId);

                    bool studentExists = (int)checkCmd.ExecuteScalar() > 0;

                    if (!studentExists)
                    {
                        MessageBox.Show("No student found with the given ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Check if attendance record exists
                    string checkAttendanceQuery = "SELECT COUNT(1) FROM Attendance WHERE student_id = @StudentId AND date = @Date";
                    SqlCommand checkAttCmd = new SqlCommand(checkAttendanceQuery, connection);
                    checkAttCmd.Parameters.AddWithValue("@StudentId", studentId);
                    checkAttCmd.Parameters.AddWithValue("@Date", selectedDate);

                    bool attendanceExists = (int)checkAttCmd.ExecuteScalar() > 0;

                    if (!attendanceExists)
                    {
                        MessageBox.Show($"No attendance record found for student {studentId} on {selectedDate.ToShortDateString()}",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (MessageBox.Show($"Are you sure you want to delete attendance record for student {studentId} on {selectedDate.ToShortDateString()}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM Attendance WHERE student_id = @StudentId AND date = @Date";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
                        deleteCmd.Parameters.AddWithValue("@StudentId", studentId);
                        deleteCmd.Parameters.AddWithValue("@Date", selectedDate);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Attendance record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No attendance record was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting attendance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void idtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetimepick_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}