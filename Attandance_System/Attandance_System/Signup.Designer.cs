namespace Attandance_System
{
    partial class Signup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tablepanelsignup = new TableLayoutPanel();
            lastnamelabel = new AcrylicUI.Controls.AcrylicLabel();
            firstnamelabel = new AcrylicUI.Controls.AcrylicLabel();
            lastnametextbox = new AcrylicUI.Controls.AcrylicTextBox();
            firstnametextbox = new AcrylicUI.Controls.AcrylicTextBox();
            emaillabel = new AcrylicUI.Controls.AcrylicLabel();
            emailtextbox = new AcrylicUI.Controls.AcrylicTextBox();
            usernamelabel = new AcrylicUI.Controls.AcrylicLabel();
            usernametextbox = new AcrylicUI.Controls.AcrylicTextBox();
            acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            passwordtextbox = new AcrylicUI.Controls.AcrylicTextBox();
            alreadyaccountlabel = new AcrylicUI.Controls.AcrylicLabel();
            signupbtn = new AcrylicUI.Controls.AcrylicButton();
            tablepanelsignup.SuspendLayout();
            SuspendLayout();
            // 
            // tablepanelsignup
            // 
            tablepanelsignup.ColumnCount = 4;
            tablepanelsignup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablepanelsignup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablepanelsignup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablepanelsignup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablepanelsignup.Controls.Add(lastnamelabel, 2, 1);
            tablepanelsignup.Controls.Add(firstnamelabel, 1, 1);
            tablepanelsignup.Controls.Add(lastnametextbox, 2, 2);
            tablepanelsignup.Controls.Add(firstnametextbox, 1, 2);
            tablepanelsignup.Controls.Add(emaillabel, 1, 3);
            tablepanelsignup.Controls.Add(emailtextbox, 1, 4);
            tablepanelsignup.Controls.Add(usernamelabel, 2, 3);
            tablepanelsignup.Controls.Add(usernametextbox, 2, 4);
            tablepanelsignup.Controls.Add(acrylicLabel1, 1, 5);
            tablepanelsignup.Controls.Add(passwordtextbox, 1, 6);
            tablepanelsignup.Controls.Add(alreadyaccountlabel, 2, 6);
            tablepanelsignup.Controls.Add(signupbtn, 1, 7);
            tablepanelsignup.Dock = DockStyle.Fill;
            tablepanelsignup.Location = new Point(0, 0);
            tablepanelsignup.Name = "tablepanelsignup";
            tablepanelsignup.RowCount = 9;
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 17.070631F));
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7511663F));
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 7.058683F));
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 8.880279F));
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 7.06003952F));
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 8.875735F));
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 7.0645504F));
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7777777F));
            tablepanelsignup.RowStyles.Add(new RowStyle(SizeType.Percent, 19.11111F));
            tablepanelsignup.Size = new Size(800, 450);
            tablepanelsignup.TabIndex = 0;
            tablepanelsignup.Paint += tablepanelsignup_Paint;
            // 
            // lastnamelabel
            // 
            lastnamelabel.AutoSize = true;
            lastnamelabel.Dock = DockStyle.Bottom;
            lastnamelabel.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lastnamelabel.ForeColor = Color.Honeydew;
            lastnamelabel.Location = new Point(403, 107);
            lastnamelabel.Name = "lastnamelabel";
            lastnamelabel.Size = new Size(194, 24);
            lastnamelabel.TabIndex = 13;
            lastnamelabel.Text = "Enter Last Name:";
            lastnamelabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // firstnamelabel
            // 
            firstnamelabel.AutoSize = true;
            firstnamelabel.Dock = DockStyle.Bottom;
            firstnamelabel.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            firstnamelabel.ForeColor = Color.Honeydew;
            firstnamelabel.Location = new Point(203, 107);
            firstnamelabel.Name = "firstnamelabel";
            firstnamelabel.Size = new Size(194, 24);
            firstnamelabel.TabIndex = 7;
            firstnamelabel.Text = "Enter First Name:";
            firstnamelabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lastnametextbox
            // 
            lastnametextbox.BackColor = Color.FromArgb(31, 31, 31);
            lastnametextbox.BorderStyle = BorderStyle.FixedSingle;
            lastnametextbox.Dock = DockStyle.Bottom;
            lastnametextbox.ForeColor = Color.FromArgb(245, 245, 245);
            lastnametextbox.Location = new Point(403, 134);
            lastnametextbox.Name = "lastnametextbox";
            lastnametextbox.Size = new Size(194, 27);
            lastnametextbox.TabIndex = 15;
            lastnametextbox.TextChanged += lastnametextbox_TextChanged;
            // 
            // firstnametextbox
            // 
            firstnametextbox.BackColor = Color.FromArgb(31, 31, 31);
            firstnametextbox.BorderStyle = BorderStyle.FixedSingle;
            firstnametextbox.Dock = DockStyle.Bottom;
            firstnametextbox.ForeColor = Color.FromArgb(245, 245, 245);
            firstnametextbox.Location = new Point(203, 134);
            firstnametextbox.Name = "firstnametextbox";
            firstnametextbox.Size = new Size(194, 27);
            firstnametextbox.TabIndex = 14;
            firstnametextbox.TextChanged += firstnametextbox_TextChanged;
            // 
            // emaillabel
            // 
            emaillabel.AutoSize = true;
            emaillabel.Dock = DockStyle.Bottom;
            emaillabel.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            emaillabel.ForeColor = Color.Honeydew;
            emaillabel.Location = new Point(203, 177);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(194, 24);
            emaillabel.TabIndex = 16;
            emaillabel.Text = "Enter Email:";
            emaillabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailtextbox
            // 
            emailtextbox.BackColor = Color.FromArgb(31, 31, 31);
            emailtextbox.BorderStyle = BorderStyle.FixedSingle;
            emailtextbox.Dock = DockStyle.Bottom;
            emailtextbox.ForeColor = Color.FromArgb(245, 245, 245);
            emailtextbox.Location = new Point(203, 204);
            emailtextbox.Name = "emailtextbox";
            emailtextbox.Size = new Size(194, 27);
            emailtextbox.TabIndex = 17;
            emailtextbox.TextChanged += emailtextbox_TextChanged;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Dock = DockStyle.Bottom;
            usernamelabel.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            usernamelabel.ForeColor = Color.Honeydew;
            usernamelabel.Location = new Point(403, 177);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(194, 24);
            usernamelabel.TabIndex = 18;
            usernamelabel.Text = "Enter Username:";
            // 
            // usernametextbox
            // 
            usernametextbox.BackColor = Color.FromArgb(31, 31, 31);
            usernametextbox.BorderStyle = BorderStyle.FixedSingle;
            usernametextbox.Dock = DockStyle.Bottom;
            usernametextbox.ForeColor = Color.FromArgb(245, 245, 245);
            usernametextbox.Location = new Point(403, 204);
            usernametextbox.Name = "usernametextbox";
            usernametextbox.Size = new Size(194, 27);
            usernametextbox.TabIndex = 19;
            usernametextbox.TextChanged += usernametextbox_TextChanged;
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.Dock = DockStyle.Bottom;
            acrylicLabel1.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            acrylicLabel1.ForeColor = Color.Honeydew;
            acrylicLabel1.Location = new Point(203, 247);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new Size(194, 24);
            acrylicLabel1.TabIndex = 20;
            acrylicLabel1.Text = "Enter Password:";
            // 
            // passwordtextbox
            // 
            passwordtextbox.BackColor = Color.FromArgb(31, 31, 31);
            passwordtextbox.BorderStyle = BorderStyle.FixedSingle;
            passwordtextbox.Dock = DockStyle.Bottom;
            passwordtextbox.ForeColor = Color.FromArgb(245, 245, 245);
            passwordtextbox.Location = new Point(203, 274);
            passwordtextbox.Name = "passwordtextbox";
            passwordtextbox.Size = new Size(194, 27);
            passwordtextbox.TabIndex = 21;
            passwordtextbox.TextChanged += passwordtextbox_TextChanged;
            // 
            // alreadyaccountlabel
            // 
            alreadyaccountlabel.AutoSize = true;
            alreadyaccountlabel.Cursor = Cursors.Hand;
            alreadyaccountlabel.Dock = DockStyle.Fill;
            alreadyaccountlabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            alreadyaccountlabel.ForeColor = Color.FromArgb(192, 192, 192);
            alreadyaccountlabel.Location = new Point(403, 271);
            alreadyaccountlabel.Name = "alreadyaccountlabel";
            alreadyaccountlabel.Size = new Size(194, 31);
            alreadyaccountlabel.TabIndex = 22;
            alreadyaccountlabel.Text = "Already have account? Login";
            alreadyaccountlabel.TextAlign = ContentAlignment.MiddleCenter;
            alreadyaccountlabel.Click += alreadyaccountlabel_Click;
            // 
            // signupbtn
            // 
            signupbtn.Anchor = AnchorStyles.Left;
            signupbtn.Cursor = Cursors.Hand;
            signupbtn.Default = false;
            signupbtn.Image = null;
            signupbtn.ImagePadding = 367737;
            signupbtn.Location = new Point(203, 312);
            signupbtn.Name = "signupbtn";
            signupbtn.Padding = new Padding(5);
            signupbtn.Size = new Size(194, 40);
            signupbtn.TabIndex = 23;
            signupbtn.Text = "Sign Up";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(tablepanelsignup);
            Location = new Point(0, 0);
            Name = "Signup";
            Text = "Sign Up";
            Load += Signup_Load;
            tablepanelsignup.ResumeLayout(false);
            tablepanelsignup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablepanelsignup;
        private AcrylicUI.Controls.AcrylicLabel firstnamelabel;
        private AcrylicUI.Controls.AcrylicLabel lastnamelabel;
        private AcrylicUI.Controls.AcrylicTextBox firstnametextbox;
        private AcrylicUI.Controls.AcrylicTextBox lastnametextbox;
        private AcrylicUI.Controls.AcrylicLabel emaillabel;
        private AcrylicUI.Controls.AcrylicTextBox emailtextbox;
        private AcrylicUI.Controls.AcrylicLabel usernamelabel;
        private AcrylicUI.Controls.AcrylicTextBox usernametextbox;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicTextBox passwordtextbox;
        private AcrylicUI.Controls.AcrylicLabel alreadyaccountlabel;
        private AcrylicUI.Controls.AcrylicButton signupbtn;
    }
}
