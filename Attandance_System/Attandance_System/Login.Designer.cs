namespace Attandance_System
{
    partial class Login
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
            loginformtablelayout = new TableLayoutPanel();
            usernamelabelinlogin = new AcrylicUI.Controls.AcrylicLabel();
            usernametextboxinlogin = new AcrylicUI.Controls.AcrylicTextBox();
            acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            paswordtextboxinlogin = new AcrylicUI.Controls.AcrylicTextBox();
            Loginbtn = new AcrylicUI.Controls.AcrylicButton();
            loginformtablelayout.SuspendLayout();
            SuspendLayout();
            // 
            // loginformtablelayout
            // 
            loginformtablelayout.ColumnCount = 4;
            loginformtablelayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            loginformtablelayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            loginformtablelayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            loginformtablelayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            loginformtablelayout.Controls.Add(usernamelabelinlogin, 1, 0);
            loginformtablelayout.Controls.Add(usernametextboxinlogin, 2, 0);
            loginformtablelayout.Controls.Add(acrylicLabel1, 1, 1);
            loginformtablelayout.Controls.Add(paswordtextboxinlogin, 2, 1);
            loginformtablelayout.Controls.Add(Loginbtn, 1, 2);
            loginformtablelayout.Dock = DockStyle.Fill;
            loginformtablelayout.Location = new Point(0, 0);
            loginformtablelayout.Name = "loginformtablelayout";
            loginformtablelayout.RowCount = 4;
            loginformtablelayout.RowStyles.Add(new RowStyle(SizeType.Percent, 32.4315567F));
            loginformtablelayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.111111F));
            loginformtablelayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            loginformtablelayout.RowStyles.Add(new RowStyle(SizeType.Percent, 41.77778F));
            loginformtablelayout.Size = new Size(800, 450);
            loginformtablelayout.TabIndex = 0;
            loginformtablelayout.Paint += loginformtablelayout_Paint;
            // 
            // usernamelabelinlogin
            // 
            usernamelabelinlogin.AutoSize = true;
            usernamelabelinlogin.Dock = DockStyle.Bottom;
            usernamelabelinlogin.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            usernamelabelinlogin.ForeColor = Color.Honeydew;
            usernamelabelinlogin.Location = new Point(203, 121);
            usernamelabelinlogin.Name = "usernamelabelinlogin";
            usernamelabelinlogin.Size = new Size(194, 24);
            usernamelabelinlogin.TabIndex = 0;
            usernamelabelinlogin.Text = "Enter Username:";
            usernamelabelinlogin.TextAlign = ContentAlignment.BottomLeft;
            // 
            // usernametextboxinlogin
            // 
            usernametextboxinlogin.BackColor = Color.FromArgb(31, 31, 31);
            usernametextboxinlogin.BorderStyle = BorderStyle.FixedSingle;
            usernametextboxinlogin.Dock = DockStyle.Bottom;
            usernametextboxinlogin.ForeColor = Color.FromArgb(245, 245, 245);
            usernametextboxinlogin.Location = new Point(403, 115);
            usernametextboxinlogin.Name = "usernametextboxinlogin";
            usernametextboxinlogin.Size = new Size(194, 27);
            usernametextboxinlogin.TabIndex = 1;
            usernametextboxinlogin.TextChanged += usernametextboxinlogin_TextChanged;
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.Dock = DockStyle.Fill;
            acrylicLabel1.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            acrylicLabel1.ForeColor = Color.Honeydew;
            acrylicLabel1.Location = new Point(203, 145);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new Size(194, 41);
            acrylicLabel1.TabIndex = 2;
            acrylicLabel1.Text = "Enter Password:";
            acrylicLabel1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // paswordtextboxinlogin
            // 
            paswordtextboxinlogin.BackColor = Color.FromArgb(31, 31, 31);
            paswordtextboxinlogin.BorderStyle = BorderStyle.FixedSingle;
            paswordtextboxinlogin.Dock = DockStyle.Bottom;
            paswordtextboxinlogin.ForeColor = Color.FromArgb(245, 245, 245);
            paswordtextboxinlogin.Location = new Point(403, 156);
            paswordtextboxinlogin.Name = "paswordtextboxinlogin";
            paswordtextboxinlogin.Size = new Size(194, 27);
            paswordtextboxinlogin.TabIndex = 3;
            paswordtextboxinlogin.TextChanged += paswordtextboxinlogin_TextChanged;
            // 
            // Loginbtn
            // 
            Loginbtn.Anchor = AnchorStyles.Left;
            Loginbtn.Cursor = Cursors.Hand;
            Loginbtn.Default = false;
            Loginbtn.Image = null;
            Loginbtn.ImagePadding = 18;
            Loginbtn.Location = new Point(203, 205);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Padding = new Padding(5);
            Loginbtn.Size = new Size(173, 37);
            Loginbtn.TabIndex = 4;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(loginformtablelayout);
            Location = new Point(0, 0);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            loginformtablelayout.ResumeLayout(false);
            loginformtablelayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginformtablelayout;
        private AcrylicUI.Controls.AcrylicLabel usernamelabelinlogin;
        private AcrylicUI.Controls.AcrylicTextBox usernametextboxinlogin;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicTextBox paswordtextboxinlogin;
        private AcrylicUI.Controls.AcrylicButton Loginbtn;
    }
}