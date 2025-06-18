using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attandance_System
{
    public partial class UC_Deleteentry : UserControl
    {
        private readonly int currentUserId;

        public UC_Deleteentry(int userId)
        {
            InitializeComponent();
            this.Name = "UC_Deleteentry";
            currentUserId = userId;
        }

        private void UC_Deleteentry_Load(object sender, EventArgs e)
        {

        }

        private void panelmenuindelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowControl(UserControl control)
        {
            Panelcontentindelete.Controls.Clear();  // remove old control
            control.Dock = DockStyle.Fill;  // fill the panel
            Panelcontentindelete.Controls.Add(control);  // add new one
        }

        private void Panelcontentindelete_Paint(object sender, PaintEventArgs e)
        {
            UC_deleteattandance delatt = new UC_deleteattandance(currentUserId);
            UC_deletestudent delstudent = new UC_deletestudent(currentUserId);

            Panelcontentindelete.Controls.Add(delatt);
            Panelcontentindelete.Controls.Add(delstudent);

            delatt.Dock = DockStyle.Fill;
            delstudent.Dock = DockStyle.Fill;

            delatt.Visible = false;
            delstudent.Visible = false;
        }

        private void studentdelete_Click(object sender, EventArgs e)
        {
            UC_deletestudent uc = new UC_deletestudent(currentUserId);
            ShowControl(uc);
        }

        private void attandancedelete_Click(object sender, EventArgs e)
        {
            UC_deleteattandance uc = new UC_deleteattandance(currentUserId);
            ShowControl(uc);
        }

        private void acrylicLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}