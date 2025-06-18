using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Attandance_System
{
    public partial class UC_addstudent : UserControl
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Attandance_System;Integrated Security=True;Encrypt=False";
        private readonly int currentUserId;
        private ErrorProvider errorProvider;

        public UC_addstudent(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            errorProvider = new ErrorProvider();
            InitializeGenderComboBox();
        }

        private void InitializeGenderComboBox()
        {
            gendercombobox.BeginUpdate();
            gendercombobox.Items.Clear();
            gendercombobox.Items.AddRange(new object[] { "Choose Gender", "Male", "Female" });
            gendercombobox.SelectedIndex = 0;
            gendercombobox.EndUpdate();
        }

        private void contacttextbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(contacttextbox.Text))
            {
                if (!Regex.IsMatch(contacttextbox.Text, @"^[0-9]*$"))
                {
                    errorProvider.SetError(contacttextbox, "Only numbers are allowed");
                }
                else
                {
                    errorProvider.SetError(contacttextbox, "");
                }
            }
        }

        private void addstudentbtn_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            errorProvider.Clear();

            // Validate all fields
            if (string.IsNullOrWhiteSpace(nametextbox.Text))
            {
                errorProvider.SetError(nametextbox, "Name is required");
                return;
            }

            if (gendercombobox.SelectedIndex <= 0)
            {
                errorProvider.SetError(gendercombobox, "Gender is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(contacttextbox.Text) || contacttextbox.Text.Length < 10)
            {
                errorProvider.SetError(contacttextbox, "Valid contact number required (10 digits)");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Students 
                                   (Name, Gender, Contact) 
                                   VALUES (@Name, @Gender, @Contact)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", nametextbox.Text.Trim());
                    command.Parameters.AddWithValue("@Gender", gendercombobox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Contact", contacttextbox.Text.Trim());

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nametextbox.Clear();
                        gendercombobox.SelectedIndex = 0;
                        contacttextbox.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("A student with this contact number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_addstudent_Load(object sender, EventArgs e) { }
        private void nametextbox_TextChanged(object sender, EventArgs e) { }
        private void gendercombobox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}