namespace Attandance_System
{
    partial class UC_deleteattandance
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
            acrylicLabel2 = new AcrylicUI.Controls.AcrylicLabel();
            idtextbox = new AcrylicUI.Controls.AcrylicTextBox();
            acrylicLabel3 = new AcrylicUI.Controls.AcrylicLabel();
            datetimepick = new DateTimePicker();
            delattbtn = new AcrylicUI.Controls.AcrylicButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.26256F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.9886551F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7487841F));
            tableLayoutPanel1.Controls.Add(acrylicLabel1, 1, 0);
            tableLayoutPanel1.Controls.Add(acrylicLabel2, 1, 1);
            tableLayoutPanel1.Controls.Add(idtextbox, 1, 2);
            tableLayoutPanel1.Controls.Add(acrylicLabel3, 1, 3);
            tableLayoutPanel1.Controls.Add(datetimepick, 1, 4);
            tableLayoutPanel1.Controls.Add(delattbtn, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.04778F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.04778F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.955631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.951084F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.833333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.04778F));
            tableLayoutPanel1.Size = new Size(617, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.Dock = DockStyle.Fill;
            acrylicLabel1.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acrylicLabel1.ForeColor = Color.Honeydew;
            acrylicLabel1.Location = new Point(90, 0);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new Size(432, 102);
            acrylicLabel1.TabIndex = 0;
            acrylicLabel1.Text = "Delete Attandance Here!";
            acrylicLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // acrylicLabel2
            // 
            acrylicLabel2.AutoSize = true;
            acrylicLabel2.Dock = DockStyle.Bottom;
            acrylicLabel2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel2.ForeColor = Color.Honeydew;
            acrylicLabel2.Location = new Point(90, 180);
            acrylicLabel2.Name = "acrylicLabel2";
            acrylicLabel2.Size = new Size(432, 24);
            acrylicLabel2.TabIndex = 1;
            acrylicLabel2.Text = "Enter Student id:";
            acrylicLabel2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // idtextbox
            // 
            idtextbox.BackColor = Color.FromArgb(31, 31, 31);
            idtextbox.BorderStyle = BorderStyle.FixedSingle;
            idtextbox.ForeColor = Color.FromArgb(245, 245, 245);
            idtextbox.Location = new Point(90, 207);
            idtextbox.Name = "idtextbox";
            idtextbox.Size = new Size(432, 27);
            idtextbox.TabIndex = 2;
            idtextbox.TextChanged += idtextbox_TextChanged;
            // 
            // acrylicLabel3
            // 
            acrylicLabel3.AutoSize = true;
            acrylicLabel3.Dock = DockStyle.Bottom;
            acrylicLabel3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel3.ForeColor = Color.Honeydew;
            acrylicLabel3.Location = new Point(90, 274);
            acrylicLabel3.Name = "acrylicLabel3";
            acrylicLabel3.Size = new Size(432, 24);
            acrylicLabel3.TabIndex = 3;
            acrylicLabel3.Text = "Enter date of attandance:";
            acrylicLabel3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // datetimepick
            // 
            datetimepick.Location = new Point(90, 301);
            datetimepick.Name = "datetimepick";
            datetimepick.Size = new Size(432, 27);
            datetimepick.TabIndex = 4;
            datetimepick.ValueChanged += datetimepick_ValueChanged;
            // 
            // delattbtn
            // 
            delattbtn.Cursor = Cursors.Hand;
            delattbtn.Default = false;
            delattbtn.Image = null;
            delattbtn.ImagePadding = 8;
            delattbtn.Location = new Point(90, 366);
            delattbtn.Name = "delattbtn";
            delattbtn.Padding = new Padding(5);
            delattbtn.Size = new Size(200, 57);
            delattbtn.TabIndex = 5;
            delattbtn.Text = "Delete Attandance";
            delattbtn.UseVisualStyleBackColor = false;
            delattbtn.Click += delattbtn_Click;
            // 
            // UC_deleteattandance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_deleteattandance";
            Size = new Size(617, 600);
            Load += UC_deleteattandance_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel2;
        private AcrylicUI.Controls.AcrylicTextBox idtextbox;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel3;
        private DateTimePicker datetimepick;
        private AcrylicUI.Controls.AcrylicButton delattbtn;
    }
}
