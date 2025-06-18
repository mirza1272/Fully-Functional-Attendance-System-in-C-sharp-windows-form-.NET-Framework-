using System;
using System.Windows.Forms;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace Attandance_System
{
    public partial class Signup : AcrylicForm
    {
        // Connection string
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Attandance_System;Integrated Security=True;Encrypt=False";

        public Signup()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.AutoScroll = true;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.IsAcrylic = true;
            this.BackColor = Colors.DarkBackground;
        }

        private void tablepanelsignup_Paint(object sender, PaintEventArgs e)
        {
            TableLayoutPanel panel = sender as TableLayoutPanel;
            if (panel != null)
            {
                panel.BackColor = Color.FromArgb(50, Colors.DarkBackground);
                panel.ForeColor = Color.White;

                using (Pen borderPen = new Pen(Color.FromArgb(80, 255, 255, 255), 1))
                {
                    e.Graphics.DrawRectangle(borderPen, panel.DisplayRectangle);
                }
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            // Any initial logic if needed
        }

        private void alreadyaccountlabel_Click(object sender, EventArgs e)
        {
            // Move to Login form
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void firstnametextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void lastnametextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void emailtextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string firstName = firstnametextbox.Text.Trim();
            string lastName = lastnametextbox.Text.Trim();
            string email = emailtextbox.Text.Trim();
            string username = usernametextbox.Text.Trim();
            string password = passwordtextbox.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if username already exists
                if (UsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert new user into database
                if (CreateUser(firstName, lastName, email, username, password))
                {
                    MessageBox.Show("Account created successfully! Redirecting to login...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            // Basic email validation using regex
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool UsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private bool CreateUser(string firstName, string lastName, string email, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Users (first_name, last_name, email, username, password) 
                                VALUES (@FirstName, @LastName, @Email, @Username, @Password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}