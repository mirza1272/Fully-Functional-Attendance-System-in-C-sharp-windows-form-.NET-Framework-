using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attandance_System
{
    public partial class UC_Viewattandance : UserControl
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Attandance_System;Integrated Security=True;Encrypt=False";
        private readonly int currentUserId;

        public UC_Viewattandance(int userId)
        {
            InitializeComponent();
            this.Name = "UC_Viewattandance";
            currentUserId = userId;

            // Clear the DataGridView initially
            gridviewtoseeattandance.DataSource = null;
            gridviewtoseeattandance.Rows.Clear();
            gridviewtoseeattandance.Columns.Clear();
        }

        private void btnofshowattandance_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT a.Att_id, s.Student_id, s.Name, a.date, a.status 
                                    FROM Attendance a
                                    INNER JOIN Students s ON a.student_id = s.Student_id
                                    ORDER BY a.date DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Only set the DataSource if there's data to show
                    if (dt.Rows.Count > 0)
                    {
                        gridviewtoseeattandance.DataSource = dt;
                        gridviewtoseeattandance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        gridviewtoseeattandance.Columns["Att_id"].Visible = false; // Hide the attendance ID
                    }
                    else
                    {
                        MessageBox.Show("No attendance records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridviewtoseeattandance.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridviewtoseeattandance.DataSource = null;
            }
        }

        private void UC_Viewattandance_Load(object sender, EventArgs e)
        {
            // Don't load data automatically anymore
            // The grid will be empty until the button is clicked
        }

        private void gridviewtoseeattandance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Removed the message box that was showing user info
            // You can keep this empty or add other functionality if needed
        }
    }
}