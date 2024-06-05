namespace GelirGiderTakip.Forms
{
    partial class FrmIncome
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtDate = new DateTimePicker();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            cbCategory = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cbType = new ComboBox();
            dgIncome = new DataGridView();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtId = new TextBox();
            label7 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgIncome).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 128);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Tarih";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 175);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 223);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Açıklama";
            // 
            // dtDate
            // 
            dtDate.Location = new Point(155, 122);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(182, 23);
            dtDate.TabIndex = 5;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(155, 172);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(118, 23);
            txtAmount.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(155, 220);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(118, 23);
            txtDescription.TabIndex = 7;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(155, 291);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(118, 23);
            cbCategory.TabIndex = 8;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 294);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 9;
            label5.Text = "Kategori Ad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 338);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 10;
            label6.Text = "Adı";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.Enabled = false;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(155, 335);
            cbType.Name = "cbType";
            cbType.Size = new Size(118, 23);
            cbType.TabIndex = 11;
            // 
            // dgIncome
            // 
            dgIncome.AllowUserToAddRows = false;
            dgIncome.AllowUserToDeleteRows = false;
            dgIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIncome.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5, Column7, Column6 });
            dgIncome.Location = new Point(360, 49);
            dgIncome.Name = "dgIncome";
            dgIncome.ReadOnly = true;
            dgIncome.RowHeadersWidth = 51;
            dgIncome.RowTemplate.Height = 25;
            dgIncome.Size = new Size(619, 253);
            dgIncome.TabIndex = 12;
            dgIncome.CellDoubleClick += dgIncome_CellDoubleClick;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(55, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(223, 384);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(134, 427);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(155, 66);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(39, 69);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 17;
            label7.Text = "Gelir No";
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tarih";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Miktar";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Açıklama";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Kategori Adı";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Kategori No";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            Column6.Width = 125;
            // 
            // FrmIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 501);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgIncome);
            Controls.Add(cbType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(dtDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FrmIncome";
            Text = "Income";
            Load += FrmIncome_Load;
            ((System.ComponentModel.ISupportInitialize)dgIncome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtDate;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private ComboBox cbCategory;
        private Label label5;
        private Label label6;
        private ComboBox cbType;
        private DataGridView dgIncome;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtId;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
    }
}