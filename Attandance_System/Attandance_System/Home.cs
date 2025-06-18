using System;
using System.Drawing;
using System.Windows.Forms;
using AcrylicUI.Forms;
using AcrylicUI.Resources;

namespace Attandance_System
{
    public partial class Home : AcrylicForm
    {
        private readonly UC_addstudent ucAdd;
        private readonly UC_markattandance ucMark;
        private readonly UC_Viewattandance ucView;
        private readonly UC_Deleteentry ucDelete;
        private readonly int currentUserId;
        private readonly string currentUsername;

        public Home(int userId, string firstName)
        {
            InitializeComponent();
            currentUserId = userId;
            currentUsername = firstName;

            // Set welcome message
            nameofusername.Text = $"{firstName}!";

            // Initialize form properties
            this.SuspendLayout();
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AutoScroll = true;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.IsAcrylic = true;
            this.BackColor = Colors.DarkBackground;
            this.ResumeLayout(false);

            // Initialize user controls once
            ucAdd = new UC_addstudent(currentUserId);
            ucMark = new UC_markattandance(currentUserId);
            ucView = new UC_Viewattandance(currentUserId);
            ucDelete = new UC_Deleteentry(currentUserId);

            // Set up user controls
            InitializeUserControls();
        }

        private void InitializeUserControls()
        {
            panelcontent.SuspendLayout();

            ucAdd.Dock = DockStyle.Fill;
            ucMark.Dock = DockStyle.Fill;
            ucView.Dock = DockStyle.Fill;
            ucDelete.Dock = DockStyle.Fill;

            ucAdd.Visible = false;
            ucMark.Visible = false;
            ucView.Visible = false;
            ucDelete.Visible = false;

            panelcontent.Controls.Add(ucAdd);
            panelcontent.Controls.Add(ucMark);
            panelcontent.Controls.Add(ucView);
            panelcontent.Controls.Add(ucDelete);

            panelcontent.ResumeLayout(true);
        }

        private void ShowControl(UserControl control)
        {
            panelcontent.SuspendLayout();
            foreach (Control c in panelcontent.Controls)
            {
                c.Visible = false;
            }
            control.Visible = true;
            panelcontent.ResumeLayout(true);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        private void addstudent_Click(object sender, EventArgs e) => ShowControl(ucAdd);
        private void markattandance_Click(object sender, EventArgs e) => ShowControl(ucMark);
        private void viewattandance_Click(object sender, EventArgs e) => ShowControl(ucView);
        private void deleteentry_Click(object sender, EventArgs e) => ShowControl(ucDelete);

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void Home_Load(object sender, EventArgs e) { }
        private void nameofusername_Click(object sender, EventArgs e) { }
        private void panelcontent_Paint(object sender, PaintEventArgs e) { }
    }
}