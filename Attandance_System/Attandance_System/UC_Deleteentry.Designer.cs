namespace Attandance_System
{
    partial class UC_Deleteentry
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
            panelmenuindelete = new AcrylicUI.Controls.AcrylicPanel();
            attandancedelete = new AcrylicUI.Controls.AcrylicButton();
            studentdelete = new AcrylicUI.Controls.AcrylicButton();
            Panelcontentindelete = new AcrylicUI.Controls.AcrylicPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            tableLayoutPanel1.SuspendLayout();
            panelmenuindelete.SuspendLayout();
            Panelcontentindelete.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(panelmenuindelete, 0, 0);
            tableLayoutPanel1.Controls.Add(Panelcontentindelete, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(778, 606);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelmenuindelete
            // 
            panelmenuindelete.Controls.Add(attandancedelete);
            panelmenuindelete.Controls.Add(studentdelete);
            panelmenuindelete.Dock = DockStyle.Fill;
            panelmenuindelete.Location = new Point(3, 3);
            panelmenuindelete.Name = "panelmenuindelete";
            panelmenuindelete.Size = new Size(149, 600);
            panelmenuindelete.TabIndex = 0;
            panelmenuindelete.Paint += panelmenuindelete_Paint;
            // 
            // attandancedelete
            // 
            attandancedelete.Cursor = Cursors.Hand;
            attandancedelete.Default = false;
            attandancedelete.Dock = DockStyle.Top;
            attandancedelete.Image = null;
            attandancedelete.ImagePadding = 8;
            attandancedelete.Location = new Point(0, 40);
            attandancedelete.Name = "attandancedelete";
            attandancedelete.Padding = new Padding(5);
            attandancedelete.Size = new Size(149, 40);
            attandancedelete.TabIndex = 1;
            attandancedelete.Text = "Delete Attandance";
            attandancedelete.UseVisualStyleBackColor = false;
            attandancedelete.Click += attandancedelete_Click;
            // 
            // studentdelete
            // 
            studentdelete.Cursor = Cursors.Hand;
            studentdelete.Default = false;
            studentdelete.Dock = DockStyle.Top;
            studentdelete.Image = null;
            studentdelete.ImagePadding = 7;
            studentdelete.Location = new Point(0, 0);
            studentdelete.Name = "studentdelete";
            studentdelete.Padding = new Padding(5);
            studentdelete.Size = new Size(149, 40);
            studentdelete.TabIndex = 0;
            studentdelete.Text = "Delete Student";
            studentdelete.UseVisualStyleBackColor = false;
            studentdelete.Click += studentdelete_Click;
            // 
            // Panelcontentindelete
            // 
            Panelcontentindelete.Controls.Add(tableLayoutPanel2);
            Panelcontentindelete.Dock = DockStyle.Fill;
            Panelcontentindelete.Location = new Point(158, 3);
            Panelcontentindelete.Name = "Panelcontentindelete";
            Panelcontentindelete.Size = new Size(617, 600);
            Panelcontentindelete.TabIndex = 1;
            Panelcontentindelete.Paint += Panelcontentindelete_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2350082F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.79903F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9659643F));
            tableLayoutPanel2.Controls.Add(acrylicLabel1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(617, 600);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.Dock = DockStyle.Fill;
            acrylicLabel1.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acrylicLabel1.ForeColor = Color.Honeydew;
            acrylicLabel1.Location = new Point(97, 200);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new Size(437, 200);
            acrylicLabel1.TabIndex = 0;
            acrylicLabel1.Text = "Please Choose What to delete!";
            acrylicLabel1.TextAlign = ContentAlignment.MiddleCenter;
            acrylicLabel1.Click += acrylicLabel1_Click;
            // 
            // UC_Deleteentry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Deleteentry";
            Size = new Size(778, 606);
            Load += UC_Deleteentry_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelmenuindelete.ResumeLayout(false);
            Panelcontentindelete.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AcrylicUI.Controls.AcrylicPanel panelmenuindelete;
        private AcrylicUI.Controls.AcrylicPanel Panelcontentindelete;
        private AcrylicUI.Controls.AcrylicButton attandancedelete;
        private AcrylicUI.Controls.AcrylicButton studentdelete;
        private TableLayoutPanel tableLayoutPanel2;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
    }
}
