namespace Attandance_System
{
    partial class UC_addstudent
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
            studentaddlabel = new AcrylicUI.Controls.AcrylicLabel();
            namelabel = new AcrylicUI.Controls.AcrylicLabel();
            nametextbox = new AcrylicUI.Controls.AcrylicTextBox();
            acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            gendercombobox = new AcrylicUI.Controls.AcrylicComboBox();
            acrylicLabel2 = new AcrylicUI.Controls.AcrylicLabel();
            contacttextbox = new AcrylicUI.Controls.AcrylicTextBox();
            addstudentbtn = new AcrylicUI.Controls.AcrylicButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.37451F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6473656F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9781227F));
            tableLayoutPanel1.Controls.Add(studentaddlabel, 1, 0);
            tableLayoutPanel1.Controls.Add(namelabel, 1, 2);
            tableLayoutPanel1.Controls.Add(nametextbox, 1, 3);
            tableLayoutPanel1.Controls.Add(acrylicLabel1, 1, 5);
            tableLayoutPanel1.Controls.Add(gendercombobox, 1, 6);
            tableLayoutPanel1.Controls.Add(acrylicLabel2, 1, 8);
            tableLayoutPanel1.Controls.Add(contacttextbox, 1, 9);
            tableLayoutPanel1.Controls.Add(addstudentbtn, 1, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.51418161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.514181F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.31255674F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.31255674F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.125023F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.31255674F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.31255674F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.125023F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.31255674F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.31255674F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3465347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0363035F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.4424839F));
            tableLayoutPanel1.Size = new Size(778, 606);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // studentaddlabel
            // 
            studentaddlabel.AutoSize = true;
            studentaddlabel.Dock = DockStyle.Fill;
            studentaddlabel.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentaddlabel.ForeColor = Color.Honeydew;
            studentaddlabel.Location = new Point(138, 0);
            studentaddlabel.Name = "studentaddlabel";
            studentaddlabel.Size = new Size(473, 39);
            studentaddlabel.TabIndex = 0;
            studentaddlabel.Text = "Add Student Here!";
            studentaddlabel.TextAlign = ContentAlignment.MiddleCenter;
            studentaddlabel.UseMnemonic = false;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Dock = DockStyle.Bottom;
            namelabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelabel.ForeColor = Color.Honeydew;
            namelabel.Location = new Point(138, 86);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(473, 24);
            namelabel.TabIndex = 1;
            namelabel.Text = "Enter Name:";
            // 
            // nametextbox
            // 
            nametextbox.BackColor = Color.FromArgb(31, 31, 31);
            nametextbox.BorderStyle = BorderStyle.FixedSingle;
            nametextbox.ForeColor = Color.FromArgb(245, 245, 245);
            nametextbox.Location = new Point(138, 113);
            nametextbox.Name = "nametextbox";
            nametextbox.Size = new Size(473, 27);
            nametextbox.TabIndex = 2;
            nametextbox.TextChanged += nametextbox_TextChanged;
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.Dock = DockStyle.Bottom;
            acrylicLabel1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel1.ForeColor = Color.Honeydew;
            acrylicLabel1.Location = new Point(138, 162);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new Size(473, 24);
            acrylicLabel1.TabIndex = 3;
            acrylicLabel1.Text = "Enter Gender:";
            // 
            // gendercombobox
            // 
            gendercombobox.DrawMode = DrawMode.OwnerDrawVariable;
            gendercombobox.FormattingEnabled = true;
            gendercombobox.Location = new Point(138, 189);
            gendercombobox.Name = "gendercombobox";
            gendercombobox.Size = new Size(473, 28);
            gendercombobox.TabIndex = 4;
            gendercombobox.SelectedIndexChanged += gendercombobox_SelectedIndexChanged;
            // 
            // acrylicLabel2
            // 
            acrylicLabel2.AutoSize = true;
            acrylicLabel2.Dock = DockStyle.Bottom;
            acrylicLabel2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acrylicLabel2.ForeColor = Color.Honeydew;
            acrylicLabel2.Location = new Point(138, 238);
            acrylicLabel2.Name = "acrylicLabel2";
            acrylicLabel2.Size = new Size(473, 24);
            acrylicLabel2.TabIndex = 5;
            acrylicLabel2.Text = "Enter Contact:";
            // 
            // contacttextbox
            // 
            contacttextbox.BackColor = Color.FromArgb(31, 31, 31);
            contacttextbox.BorderStyle = BorderStyle.FixedSingle;
            contacttextbox.ForeColor = Color.FromArgb(245, 245, 245);
            contacttextbox.Location = new Point(138, 265);
            contacttextbox.Name = "contacttextbox";
            contacttextbox.Size = new Size(473, 27);
            contacttextbox.TabIndex = 6;
            contacttextbox.TextChanged += contacttextbox_TextChanged;
            // 
            // addstudentbtn
            // 
            addstudentbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addstudentbtn.Cursor = Cursors.Hand;
            addstudentbtn.Default = false;
            addstudentbtn.Image = null;
            addstudentbtn.ImagePadding = 97;
            addstudentbtn.Location = new Point(138, 344);
            addstudentbtn.Name = "addstudentbtn";
            addstudentbtn.Padding = new Padding(5);
            addstudentbtn.Size = new Size(200, 40);
            addstudentbtn.TabIndex = 7;
            addstudentbtn.Text = "Add Student";
            addstudentbtn.UseVisualStyleBackColor = false;
            addstudentbtn.Click += addstudentbtn_Click;
            // 
            // UC_addstudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_addstudent";
            Size = new Size(778, 606);
            Load += UC_addstudent_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AcrylicUI.Controls.AcrylicLabel studentaddlabel;
        private AcrylicUI.Controls.AcrylicLabel namelabel;
        private AcrylicUI.Controls.AcrylicTextBox nametextbox;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicComboBox gendercombobox;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel2;
        private AcrylicUI.Controls.AcrylicTextBox contacttextbox;
        private AcrylicUI.Controls.AcrylicButton addstudentbtn;
    }
}
