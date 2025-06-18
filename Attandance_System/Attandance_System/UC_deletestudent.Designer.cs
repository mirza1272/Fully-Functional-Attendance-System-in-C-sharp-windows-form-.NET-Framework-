namespace Attandance_System
{
    partial class UC_deletestudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            studentidlabel = new AcrylicUI.Controls.AcrylicLabel();
            idornametextbox = new AcrylicUI.Controls.AcrylicTextBox();
            delstudentbtn = new AcrylicUI.Controls.AcrylicButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8571415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.31169F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.83117F));
            tableLayoutPanel1.Controls.Add(acrylicLabel1, 1, 0);
            tableLayoutPanel1.Controls.Add(studentidlabel, 1, 2);
            tableLayoutPanel1.Controls.Add(idornametextbox, 1, 3);
            tableLayoutPanel1.Controls.Add(delstudentbtn, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000029F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0312481F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.34375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.166667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tableLayoutPanel1.Size = new Size(617, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.Dock = DockStyle.Fill;
            acrylicLabel1.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acrylicLabel1.ForeColor = Color.Honeydew;
            acrylicLabel1.Location = new Point(113, 0);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new Size(384, 59);
            acrylicLabel1.TabIndex = 0;
            acrylicLabel1.Text = "Delete Student Here!";
            acrylicLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // studentidlabel
            // 
            studentidlabel.AutoSize = true;
            studentidlabel.Dock = DockStyle.Bottom;
            studentidlabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentidlabel.ForeColor = Color.Honeydew;
            studentidlabel.Location = new Point(113, 179);
            studentidlabel.Name = "studentidlabel";
            studentidlabel.Size = new Size(384, 24);
            studentidlabel.TabIndex = 1;
            studentidlabel.Text = "Enter Student id or Name:";
            studentidlabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // idornametextbox
            // 
            idornametextbox.BackColor = Color.FromArgb(31, 31, 31);
            idornametextbox.BorderStyle = BorderStyle.FixedSingle;
            idornametextbox.ForeColor = Color.FromArgb(245, 245, 245);
            idornametextbox.Location = new Point(113, 206);
            idornametextbox.Name = "idornametextbox";
            idornametextbox.Size = new Size(384, 27);
            idornametextbox.TabIndex = 2;
            idornametextbox.TextChanged += idornametextbox_TextChanged;
            // 
            // delstudentbtn
            // 
            delstudentbtn.Cursor = Cursors.Hand;
            delstudentbtn.Default = false;
            delstudentbtn.Image = null;
            delstudentbtn.ImagePadding = 8;
            delstudentbtn.Location = new Point(113, 290);
            delstudentbtn.Name = "delstudentbtn";
            delstudentbtn.Padding = new Padding(5);
            delstudentbtn.Size = new Size(200, 40);
            delstudentbtn.TabIndex = 3;
            delstudentbtn.Text = "Delete Student";
            delstudentbtn.UseVisualStyleBackColor = false;
            delstudentbtn.Click += delstudentbtn_Click;
            // 
            // UC_deletestudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_deletestudent";
            Size = new Size(617, 600);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicLabel studentidlabel;
        private AcrylicUI.Controls.AcrylicTextBox idornametextbox;
        private AcrylicUI.Controls.AcrylicButton delstudentbtn;
    }
}
