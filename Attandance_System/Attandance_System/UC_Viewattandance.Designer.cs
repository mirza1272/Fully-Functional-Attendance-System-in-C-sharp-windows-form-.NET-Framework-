namespace Attandance_System
{
    partial class UC_Viewattandance
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
            btnofshowattandance = new AcrylicUI.Controls.AcrylicButton();
            gridviewtoseeattandance = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewtoseeattandance).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(acrylicLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnofshowattandance, 0, 1);
            tableLayoutPanel1.Controls.Add(gridviewtoseeattandance, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.39604F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.90099049F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.70297F));
            tableLayoutPanel1.Size = new Size(778, 606);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.Dock = DockStyle.Fill;
            acrylicLabel1.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acrylicLabel1.ForeColor = Color.Honeydew;
            acrylicLabel1.Location = new Point(3, 0);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new Size(772, 63);
            acrylicLabel1.TabIndex = 0;
            acrylicLabel1.Text = "View Attandance Here!";
            acrylicLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnofshowattandance
            // 
            btnofshowattandance.Anchor = AnchorStyles.None;
            btnofshowattandance.Cursor = Cursors.Hand;
            btnofshowattandance.Default = false;
            btnofshowattandance.Image = null;
            btnofshowattandance.ImagePadding = 10;
            btnofshowattandance.Location = new Point(261, 73);
            btnofshowattandance.Name = "btnofshowattandance";
            btnofshowattandance.Padding = new Padding(5);
            btnofshowattandance.Size = new Size(256, 40);
            btnofshowattandance.TabIndex = 1;
            btnofshowattandance.Text = "Press here to See Attandance";
            btnofshowattandance.UseVisualStyleBackColor = false;
            btnofshowattandance.Click += btnofshowattandance_Click;
            // 
            // gridviewtoseeattandance
            // 
            gridviewtoseeattandance.AllowUserToAddRows = false;
            gridviewtoseeattandance.AllowUserToDeleteRows = false;
            gridviewtoseeattandance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewtoseeattandance.Dock = DockStyle.Fill;
            gridviewtoseeattandance.Location = new Point(3, 126);
            gridviewtoseeattandance.Name = "gridviewtoseeattandance";
            gridviewtoseeattandance.ReadOnly = true;
            gridviewtoseeattandance.RowHeadersWidth = 51;
            gridviewtoseeattandance.Size = new Size(772, 477);
            gridviewtoseeattandance.TabIndex = 2;
            gridviewtoseeattandance.CellContentClick += gridviewtoseeattandance_CellContentClick;
            // 
            // UC_Viewattandance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Viewattandance";
            Size = new Size(778, 606);
            Load += UC_Viewattandance_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewtoseeattandance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicButton btnofshowattandance;
        private DataGridView gridviewtoseeattandance;
    }
}
