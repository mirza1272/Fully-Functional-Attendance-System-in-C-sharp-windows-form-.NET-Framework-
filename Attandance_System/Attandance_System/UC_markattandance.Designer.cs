namespace Attandance_System
{
    partial class UC_markattandance
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
            markattlbl = new AcrylicUI.Controls.AcrylicLabel();
            studentidlabel = new AcrylicUI.Controls.AcrylicLabel();
            idtextbox = new AcrylicUI.Controls.AcrylicTextBox();
            attdatelbl = new AcrylicUI.Controls.AcrylicLabel();
            datetimepicker = new DateTimePicker();
            statuslabel = new AcrylicUI.Controls.AcrylicLabel();
            comboboxforstatus = new AcrylicUI.Controls.AcrylicComboBox();
            addattbtn = new AcrylicUI.Controls.AcrylicButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.55969F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.34018F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1001282F));
            tableLayoutPanel1.Controls.Add(markattlbl, 1, 0);
            tableLayoutPanel1.Controls.Add(studentidlabel, 1, 1);
            tableLayoutPanel1.Controls.Add(idtextbox, 1, 2);
            tableLayoutPanel1.Controls.Add(attdatelbl, 1, 3);
            tableLayoutPanel1.Controls.Add(datetimepicker, 1, 4);
            tableLayoutPanel1.Controls.Add(statuslabel, 1, 5);
            tableLayoutPanel1.Controls.Add(comboboxforstatus, 1, 6);
            tableLayoutPanel1.Controls.Add(addattbtn, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.44562F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4456224F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.64350271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.64350271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.64350271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.64350271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7260723F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2112207F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4456224F));
            tableLayoutPanel1.Size = new Size(778, 606);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // markattlbl
            // 
            markattlbl.AutoSize = true;
            markattlbl.Dock = DockStyle.Fill;
            markattlbl.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            markattlbl.ForeColor = Color.Honeydew;
            markattlbl.Location = new Point(131, 0);
            markattlbl.Name = "markattlbl";
            markattlbl.Size = new Size(502, 93);
            markattlbl.TabIndex = 0;
            markattlbl.Text = "Mark Attandance Here!";
            markattlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // studentidlabel
            // 
            studentidlabel.AutoSize = true;
            studentidlabel.Dock = DockStyle.Bottom;
            studentidlabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentidlabel.ForeColor = Color.Honeydew;
            studentidlabel.Location = new Point(131, 162);
            studentidlabel.Name = "studentidlabel";
            studentidlabel.Size = new Size(502, 24);
            studentidlabel.TabIndex = 1;
            studentidlabel.Text = "Enter Student id:";
            // 
            // idtextbox
            // 
            idtextbox.BackColor = Color.FromArgb(31, 31, 31);
            idtextbox.BorderStyle = BorderStyle.FixedSingle;
            idtextbox.ForeColor = Color.FromArgb(245, 245, 245);
            idtextbox.Location = new Point(131, 189);
            idtextbox.Name = "idtextbox";
            idtextbox.Size = new Size(502, 27);
            idtextbox.TabIndex = 2;
            idtextbox.TextChanged += idtextbox_TextChanged;
            // 
            // attdatelbl
            // 
            attdatelbl.AutoSize = true;
            attdatelbl.Dock = DockStyle.Bottom;
            attdatelbl.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attdatelbl.ForeColor = Color.Honeydew;
            attdatelbl.Location = new Point(131, 254);
            attdatelbl.Name = "attdatelbl";
            attdatelbl.Size = new Size(502, 24);
            attdatelbl.TabIndex = 3;
            attdatelbl.Text = "Enter Attandance Date:";
            // 
            // datetimepicker
            // 
            datetimepicker.Location = new Point(131, 281);
            datetimepicker.Name = "datetimepicker";
            datetimepicker.Size = new Size(502, 27);
            datetimepicker.TabIndex = 4;
            datetimepicker.ValueChanged += datetimepicker_ValueChanged;
            // 
            // statuslabel
            // 
            statuslabel.AutoSize = true;
            statuslabel.Dock = DockStyle.Bottom;
            statuslabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statuslabel.ForeColor = Color.Honeydew;
            statuslabel.Location = new Point(131, 346);
            statuslabel.Name = "statuslabel";
            statuslabel.Size = new Size(502, 24);
            statuslabel.TabIndex = 5;
            statuslabel.Text = "Enter Status:";
            // 
            // comboboxforstatus
            // 
            comboboxforstatus.DrawMode = DrawMode.OwnerDrawVariable;
            comboboxforstatus.FormattingEnabled = true;
            comboboxforstatus.Location = new Point(131, 373);
            comboboxforstatus.Name = "comboboxforstatus";
            comboboxforstatus.Size = new Size(502, 28);
            comboboxforstatus.TabIndex = 6;
            comboboxforstatus.SelectedIndexChanged += comboboxforstatus_SelectedIndexChanged;
            // 
            // addattbtn
            // 
            addattbtn.Cursor = Cursors.Hand;
            addattbtn.Default = false;
            addattbtn.Image = null;
            addattbtn.ImagePadding = 8;
            addattbtn.Location = new Point(131, 438);
            addattbtn.Name = "addattbtn";
            addattbtn.Padding = new Padding(5);
            addattbtn.Size = new Size(200, 40);
            addattbtn.TabIndex = 7;
            addattbtn.Text = "Add attandance";
            addattbtn.UseVisualStyleBackColor = false;
            addattbtn.Click += addattbtn_Click;
            // 
            // UC_markattandance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_markattandance";
            Size = new Size(778, 606);
            Load += UC_markattandance_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AcrylicUI.Controls.AcrylicLabel markattlbl;
        private AcrylicUI.Controls.AcrylicLabel studentidlabel;
        private AcrylicUI.Controls.AcrylicTextBox idtextbox;
        private AcrylicUI.Controls.AcrylicLabel attdatelbl;
        private DateTimePicker datetimepicker;
        private AcrylicUI.Controls.AcrylicLabel statuslabel;
        private AcrylicUI.Controls.AcrylicComboBox comboboxforstatus;
        private AcrylicUI.Controls.AcrylicButton addattbtn;
    }
}
