using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attandance_System
{
    public partial class UC_deletestudent : UserControl
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Attandance_System;Integrated Security=True;Encrypt=False";
        private readonly int currentUserId;

        public UC_deletestudent(int userid)
        {
            InitializeComponent();
            currentUserId = userid;
        }

        private void delstudentbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idornametextbox.Text))
            {
                MessageBox.Show("Please enter Student ID or Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First find the student
                    string searchQuery = "SELECT Student_id, Name FROM Students WHERE Student_id = @Id OR Name LIKE @Name";
                    SqlCommand searchCmd = new SqlCommand(searchQuery, connection);

                    if (int.TryParse(idornametextbox.Text, out int studentId))
                    {
                        searchCmd.Parameters.AddWithValue("@Id", studentId);
                        searchCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    }
                    else
                    {
                        searchCmd.Parameters.AddWithValue("@Id", DBNull.Value);
                        searchCmd.Parameters.AddWithValue("@Name", "%" + idornametextbox.Text + "%");
                    }

                    using (SqlDataReader reader = searchCmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No student found with the given ID or Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Read the first student (we'll assume unique IDs and take first match for names)
                        reader.Read();
                        studentId = reader.GetInt32(0);
                        string studentName = reader.GetString(1);

                        // Close the reader before executing other commands
                        reader.Close();

                        if (MessageBox.Show($"Are you sure you want to delete student {studentName} (ID: {studentId}) and all their attendance records?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            DeleteStudentWithAttendance(connection, studentId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteStudentWithAttendance(SqlConnection connection, int studentId)
        {
            // Use transaction to ensure both deletions succeed or fail together
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                // First delete attendance records
                string deleteAttendanceQuery = "DELETE FROM Attendance WHERE student_id = @StudentId";
                SqlCommand attendanceCmd = new SqlCommand(deleteAttendanceQuery, connection, transaction);
                attendanceCmd.Parameters.AddWithValue("@StudentId", studentId);
                int attendanceDeleted = attendanceCmd.ExecuteNonQuery();

                // Then delete the student
                string deleteStudentQuery = "DELETE FROM Students WHERE Student_id = @StudentId";
                SqlCommand studentCmd = new SqlCommand(deleteStudentQuery, connection, transaction);
                studentCmd.Parameters.AddWithValue("@StudentId", studentId);
                int studentsDeleted = studentCmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show($"Successfully deleted student and {attendanceDeleted} attendance records",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                idornametextbox.Clear();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void idornametextbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add live search functionality here
        }
    }
}