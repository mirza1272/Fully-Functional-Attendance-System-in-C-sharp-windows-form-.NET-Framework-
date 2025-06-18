namespace Attandance_System
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Panelmenu = new AcrylicUI.Controls.AcrylicPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            logoutbtn = new AcrylicUI.Controls.AcrylicButton();
            deleteentry = new AcrylicUI.Controls.AcrylicButton();
            viewattandance = new AcrylicUI.Controls.AcrylicButton();
            markattandance = new AcrylicUI.Controls.AcrylicButton();
            addstudent = new AcrylicUI.Controls.AcrylicButton();
            nameofusername = new AcrylicUI.Controls.AcrylicLabel();
            hellolabel = new AcrylicUI.Controls.AcrylicLabel();
            panelcontent = new AcrylicUI.Controls.AcrylicPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            wellabel = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel2 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel3 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel4 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel5 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel6 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel7 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel8 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel9 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel10 = new AcrylicUI.Controls.AcrylicLabel();
            tableLayoutPanel1.SuspendLayout();
            Panelmenu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelcontent.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(Panelmenu, 0, 0);
            tableLayoutPanel1.Controls.Add(panelcontent, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(980, 612);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Panelmenu
            // 
            Panelmenu.Controls.Add(tableLayoutPanel2);
            Panelmenu.Controls.Add(nameofusername);
            Panelmenu.Controls.Add(hellolabel);
            Panelmenu.Dock = DockStyle.Fill;
            Panelmenu.Location = new Point(3, 3);
            Panelmenu.Name = "Panelmenu";
            Panelmenu.Size = new Size(190, 606);
            Panelmenu.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(logoutbtn, 0, 5);
            tableLayoutPanel2.Controls.Add(deleteentry, 0, 3);
            tableLayoutPanel2.Controls.Add(viewattandance, 0, 2);
            tableLayoutPanel2.Controls.Add(markattandance, 0, 1);
            tableLayoutPanel2.Controls.Add(addstudent, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 109);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(190, 497);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.None;
            logoutbtn.Cursor = Cursors.Hand;
            logoutbtn.Default = false;
            logoutbtn.Image = null;
            logoutbtn.ImagePadding = 97;
            logoutbtn.Location = new Point(37, 414);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Padding = new Padding(5);
            logoutbtn.Size = new Size(115, 39);
            logoutbtn.TabIndex = 5;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // deleteentry
            // 
            deleteentry.Cursor = Cursors.Hand;
            deleteentry.Default = false;
            deleteentry.Dock = DockStyle.Fill;
            deleteentry.Image = null;
            deleteentry.ImagePadding = 78;
            deleteentry.Location = new Point(3, 225);
            deleteentry.Name = "deleteentry";
            deleteentry.Padding = new Padding(5);
            deleteentry.Size = new Size(184, 68);
            deleteentry.TabIndex = 3;
            deleteentry.Text = "Delete Entry";
            deleteentry.UseVisualStyleBackColor = false;
            deleteentry.Click += deleteentry_Click;
            // 
            // viewattandance
            // 
            viewattandance.Cursor = Cursors.Hand;
            viewattandance.Default = false;
            viewattandance.Dock = DockStyle.Fill;
            viewattandance.Image = null;
            viewattandance.ImagePadding = 78;
            viewattandance.Location = new Point(3, 151);
            viewattandance.Name = "viewattandance";
            viewattandance.Padding = new Padding(5);
            viewattandance.Size = new Size(184, 68);
            viewattandance.TabIndex = 2;
            viewattandance.Text = "View Attandance";
            viewattandance.UseVisualStyleBackColor = false;
            viewattandance.Click += viewattandance_Click;
            // 
            // markattandance
            // 
            markattandance.Cursor = Cursors.Hand;
            markattandance.Default = false;
            markattandance.Dock = DockStyle.Fill;
            markattandance.Image = null;
            markattandance.ImagePadding = 78;
            markattandance.Location = new Point(3, 77);
            markattandance.Name = "markattandance";
            markattandance.Padding = new Padding(5);
            markattandance.Size = new Size(184, 68);
            markattandance.TabIndex = 1;
            markattandance.Text = "Mark Attandance";
            markattandance.UseVisualStyleBackColor = false;
            markattandance.Click += markattandance_Click;
            // 
            // addstudent
            // 
            addstudent.Cursor = Cursors.Hand;
            addstudent.Default = false;
            addstudent.Dock = DockStyle.Fill;
            addstudent.Image = null;
            addstudent.ImagePadding = 63;
            addstudent.Location = new Point(3, 3);
            addstudent.Name = "addstudent";
            addstudent.Padding = new Padding(5);
            addstudent.Size = new Size(184, 68);
            addstudent.TabIndex = 0;
            addstudent.Text = "Add Student";
            addstudent.UseVisualStyleBackColor = false;
            addstudent.Click += addstudent_Click;
            // 
            // nameofusername
            // 
            nameofusername.AutoSize = true;
            nameofusername.Font = new Font("Georgia", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            nameofusername.ForeColor = Color.Honeydew;
            nameofusername.Location = new Point(28, 60);
            nameofusername.Name = "nameofusername";
            nameofusername.Size = new Size(213, 27);
            nameofusername.TabIndex = 1;
            nameofusername.Text = "Name of Username";
            nameofusername.Click += nameofusername_Click;
            // 
            // hellolabel
            // 
            hellolabel.AutoSize = true;
            hellolabel.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            hellolabel.ForeColor = Color.Honeydew;
            hellolabel.Location = new Point(9, 17);
            hellolabel.Name = "hellolabel";
            hellolabel.Size = new Size(63, 24);
            hellolabel.TabIndex = 0;
            hellolabel.Text = "Hello,";
            // 
            // panelcontent
            // 
            panelcontent.Controls.Add(tableLayoutPanel3);
            panelcontent.Dock = DockStyle.Fill;
            panelcontent.Location = new Point(199, 3);
            panelcontent.Name = "panelcontent";
            panelcontent.Size = new Size(778, 606);
            panelcontent.TabIndex = 1;
            panelcontent.Paint += panelcontent_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9448F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.3941F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6611042F));
            tableLayoutPanel3.Controls.Add(wellabel, 1, 0);
            tableLayoutPanel3.Controls.Add(acrylicLabel1, 1, 2);
            tableLayoutPanel3.Controls.Add(acrylicLabel2, 1, 3);
            tableLayoutPanel3.Controls.Add(acrylicLabel3, 1, 4);
            tableLayoutPanel3.Controls.Add(acrylicLabel4, 1, 5);
            tableLayoutPanel3.Controls.Add(acrylicLabel5, 1, 7);
            tableLayoutPanel3.Controls.Add(acrylicLabel6, 1, 8);
            tableLayoutPanel3.Controls.Add(acrylicLabel7, 1, 9);
            tableLayoutPanel3.Controls.Add(acrylicLabel8, 1, 10);
            tableLayoutPanel3.Controls.Add(acrylicLabel9, 1, 11);
            tableLayoutPanel3.Controls.Add(acrylicLabel10, 1, 12);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 16;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.049025F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.049027F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 4.56181765F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 4.56181765F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.3865447F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.3865447F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 4.56181765F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.19327235F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.19327235F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.19327235F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.19327235F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.19327235F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.19327235F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2.40888071F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2.55943561F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 31.3154488F));
            tableLayoutPanel3.Size = new Size(778, 606);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // wellabel
            // 
            wellabel.AutoSize = true;
            wellabel.Dock = DockStyle.Fill;
            wellabel.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wellabel.ForeColor = Color.Honeydew;
            wellabel.ImageAlign = ContentAlignment.TopCenter;
            wellabel.Location = new Point(134, 0);
            wellabel.Name = "wellabel";
            wellabel.Size = new Size(518, 54);
            wellabel.TabIndex = 0;
            wellabel.Text = "Welcome To Attandance System";
            wellabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel1.ForeColor = Color.Honeydew;
            acrylicLabel1.Location = new Point(134, 108);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new Size(320, 24);
            acrylicLabel1.TabIndex = 1;
            acrylicLabel1.Text = "Created by: Mirza Haseeb Rahman";
            // 
            // acrylicLabel2
            // 
            acrylicLabel2.AutoSize = true;
            acrylicLabel2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel2.ForeColor = Color.Honeydew;
            acrylicLabel2.Location = new Point(134, 135);
            acrylicLabel2.Name = "acrylicLabel2";
            acrylicLabel2.Size = new Size(308, 24);
            acrylicLabel2.TabIndex = 2;
            acrylicLabel2.Text = "Department of Computer Science";
            // 
            // acrylicLabel3
            // 
            acrylicLabel3.AutoSize = true;
            acrylicLabel3.Dock = DockStyle.Bottom;
            acrylicLabel3.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel3.ForeColor = Color.Honeydew;
            acrylicLabel3.Location = new Point(134, 162);
            acrylicLabel3.Name = "acrylicLabel3";
            acrylicLabel3.Size = new Size(518, 38);
            acrylicLabel3.TabIndex = 3;
            acrylicLabel3.Text = "This is a desktop-based application that allows institutions to manage student attendance efficiently. It provides a user-friendly interface for both administrators and regular users.";
            // 
            // acrylicLabel4
            // 
            acrylicLabel4.AutoSize = true;
            acrylicLabel4.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel4.ForeColor = Color.Honeydew;
            acrylicLabel4.Location = new Point(134, 200);
            acrylicLabel4.Name = "acrylicLabel4";
            acrylicLabel4.Size = new Size(508, 38);
            acrylicLabel4.TabIndex = 4;
            acrylicLabel4.Text = "The system is designed to simplify the process of tracking student attendance, reduce manual errors, and maintain accurate records for reporting and analysis.";
            // 
            // acrylicLabel5
            // 
            acrylicLabel5.AutoSize = true;
            acrylicLabel5.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel5.ForeColor = Color.Honeydew;
            acrylicLabel5.Location = new Point(134, 265);
            acrylicLabel5.Name = "acrylicLabel5";
            acrylicLabel5.Size = new Size(129, 19);
            acrylicLabel5.TabIndex = 5;
            acrylicLabel5.Text = "key Features,";
            // 
            // acrylicLabel6
            // 
            acrylicLabel6.AutoSize = true;
            acrylicLabel6.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel6.ForeColor = Color.Honeydew;
            acrylicLabel6.Location = new Point(134, 284);
            acrylicLabel6.Name = "acrylicLabel6";
            acrylicLabel6.Size = new Size(189, 18);
            acrylicLabel6.TabIndex = 6;
            acrylicLabel6.Text = "- Secure -Login and Signup";
            // 
            // acrylicLabel7
            // 
            acrylicLabel7.AutoSize = true;
            acrylicLabel7.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel7.ForeColor = Color.Honeydew;
            acrylicLabel7.Location = new Point(134, 303);
            acrylicLabel7.Name = "acrylicLabel7";
            acrylicLabel7.Size = new Size(187, 18);
            acrylicLabel7.TabIndex = 7;
            acrylicLabel7.Text = "- Add and Delete Students  ";
            // 
            // acrylicLabel8
            // 
            acrylicLabel8.AutoSize = true;
            acrylicLabel8.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel8.ForeColor = Color.Honeydew;
            acrylicLabel8.Location = new Point(134, 322);
            acrylicLabel8.Name = "acrylicLabel8";
            acrylicLabel8.Size = new Size(293, 18);
            acrylicLabel8.TabIndex = 8;
            acrylicLabel8.Text = "- Mark Daily Attendance (Present/Absent) ";
            // 
            // acrylicLabel9
            // 
            acrylicLabel9.AutoSize = true;
            acrylicLabel9.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel9.ForeColor = Color.Honeydew;
            acrylicLabel9.Location = new Point(134, 341);
            acrylicLabel9.Name = "acrylicLabel9";
            acrylicLabel9.Size = new Size(259, 18);
            acrylicLabel9.TabIndex = 9;
            acrylicLabel9.Text = "- View and Filter Attendance Records ";
            // 
            // acrylicLabel10
            // 
            acrylicLabel10.AutoSize = true;
            acrylicLabel10.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel10.ForeColor = Color.Honeydew;
            acrylicLabel10.Location = new Point(134, 360);
            acrylicLabel10.Name = "acrylicLabel10";
            acrylicLabel10.Size = new Size(176, 18);
            acrylicLabel10.TabIndex = 10;
            acrylicLabel10.Text = "- User Role Management";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(980, 612);
            Controls.Add(tableLayoutPanel1);
            Location = new Point(0, 0);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            tableLayoutPanel1.ResumeLayout(false);
            Panelmenu.ResumeLayout(false);
            Panelmenu.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panelcontent.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AcrylicUI.Controls.AcrylicPanel Panelmenu;
        private AcrylicUI.Controls.AcrylicLabel hellolabel;
        private AcrylicUI.Controls.AcrylicLabel nameofusername;
        private AcrylicUI.Controls.AcrylicPanel panelcontent;
        private AcrylicUI.Controls.AcrylicLabel welcomelabl;
        private TableLayoutPanel tableLayoutPanel2;
        private AcrylicUI.Controls.AcrylicButton deleteentry;
        private AcrylicUI.Controls.AcrylicButton viewattandance;
        private AcrylicUI.Controls.AcrylicButton markattandance;
        private AcrylicUI.Controls.AcrylicButton addstudent;
        private AcrylicUI.Controls.AcrylicButton logoutbtn;
        private TableLayoutPanel tableLayoutPanel3;
        private AcrylicUI.Controls.AcrylicLabel wellabel;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel2;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel3;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel4;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel5;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel6;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel7;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel8;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel9;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel10;
    }
}