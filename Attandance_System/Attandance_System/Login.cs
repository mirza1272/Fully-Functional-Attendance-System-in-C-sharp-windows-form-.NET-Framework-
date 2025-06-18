using System;
using System.Windows.Forms;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System.Data.SqlClient;
using System.Drawing;

namespace Attandance_System
{
    public partial class Login : AcrylicForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Attandance_System;Integrated Security=True;Encrypt=False";

        public Login()
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

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void loginformtablelayout_Paint(object sender, PaintEventArgs e)
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

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametextboxinlogin.Text.Trim();
            string password = paswordtextboxinlogin.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT User_id, first_name FROM Users WHERE username = @Username AND password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string firstName = reader.GetString(1);

                        this.Hide();
                        Home home = new Home(userId, firstName);
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernametextboxinlogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void paswordtextboxinlogin_TextChanged(object sender, EventArgs e)
        {
        }
    }
}