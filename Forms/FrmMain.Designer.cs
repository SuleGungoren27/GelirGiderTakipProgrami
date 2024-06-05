namespace GelirGiderTakip.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            lbTitle = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnIncome = new ToolStripButton();
            btnExpense = new ToolStripButton();
            btnCategory = new ToolStripButton();
            btnExit = new ToolStripButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 119);
            panel1.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(12, 78);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(109, 20);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "Alt Başlık";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(376, 27);
            label1.TabIndex = 1;
            label1.Text = "Gelir - Gider Takip Programı";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnIncome, btnExpense, btnCategory, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(906, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnIncome
            // 
            btnIncome.Image = (Image)resources.GetObject("btnIncome.Image");
            btnIncome.ImageTransparentColor = Color.Magenta;
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(64, 22);
            btnIncome.Text = "Gelirler";
            btnIncome.Click += btnIncome_Click;
            // 
            // btnExpense
            // 
            btnExpense.Image = (Image)resources.GetObject("btnExpense.Image");
            btnExpense.ImageTransparentColor = Color.Magenta;
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(68, 22);
            btnExpense.Text = "Giderler";
            btnExpense.Click += btnExpense_Click;
            // 
            // btnCategory
            // 
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageTransparentColor = Color.Magenta;
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(84, 22);
            btnCategory.Text = "Kategoriler";
            btnCategory.Click += btnCategory_Click;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(52, 22);
            btnExit.Text = "Çıkış";
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 408);
            panel2.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 527);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnIncome;
        private ToolStripButton btnExpense;
        private ToolStripButton btnCategory;
        private ToolStripButton btnExit;
        private Panel panel2;
        private Label lbTitle;
        private Label label1;
    }
}