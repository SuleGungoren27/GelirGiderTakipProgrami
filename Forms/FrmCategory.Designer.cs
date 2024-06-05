namespace GelirGiderTakip.Forms
{
    partial class FrmCategory
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            cbType = new ComboBox();
            dgCategories = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtId = new TextBox();
            label3 = new Label();
            label7 = new Label();
            txtExpenseId = new TextBox();
            txtDescription = new TextBox();
            txtAmount = new TextBox();
            dtDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSearch = new Button();
            dgIncome = new DataGridView();
            dgExpense = new DataGridView();
            label8 = new Label();
            txtIncomeId = new TextBox();
            label9 = new Label();
            lbIncome = new Label();
            lbExpense = new Label();
            label11 = new Label();
            lbDiff = new Label();
            label10 = new Label();
            lbExp = new Label();
            lbInc = new Label();
            label14 = new Label();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgExpense).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 351);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 394);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Tür";
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 348);
            txtName.Name = "txtName";
            txtName.Size = new Size(117, 23);
            txtName.TabIndex = 2;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(148, 391);
            cbType.Name = "cbType";
            cbType.Size = new Size(117, 23);
            cbType.TabIndex = 3;
            // 
            // dgCategories
            // 
            dgCategories.AllowUserToAddRows = false;
            dgCategories.AllowUserToDeleteRows = false;
            dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategories.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgCategories.Location = new Point(350, 50);
            dgCategories.Name = "dgCategories";
            dgCategories.ReadOnly = true;
            dgCategories.RowHeadersWidth = 51;
            dgCategories.RowTemplate.Height = 25;
            dgCategories.Size = new Size(562, 174);
            dgCategories.TabIndex = 4;
            dgCategories.CellDoubleClick += dgCategories_CellDoubleClick;
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
            // Column2
            // 
            Column2.HeaderText = "Adı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tür";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Created";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Updated";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(139, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(300, 434);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(217, 478);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(148, 50);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(117, 23);
            txtId.TabIndex = 8;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 53);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 9;
            label3.Text = "Kategori No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 149);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 41;
            label7.Text = "Gider No";
            // 
            // txtExpenseId
            // 
            txtExpenseId.Location = new Point(147, 146);
            txtExpenseId.Name = "txtExpenseId";
            txtExpenseId.ReadOnly = true;
            txtExpenseId.Size = new Size(118, 23);
            txtExpenseId.TabIndex = 40;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(148, 309);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(118, 23);
            txtDescription.TabIndex = 39;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(147, 269);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(118, 23);
            txtAmount.TabIndex = 38;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(147, 225);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(182, 23);
            dtDate.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 312);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 36;
            label4.Text = "Açıklama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 272);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 35;
            label5.Text = "Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 231);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 34;
            label6.Text = "Tarih";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(191, 175);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "Gözat";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgIncome
            // 
            dgIncome.AllowUserToAddRows = false;
            dgIncome.AllowUserToDeleteRows = false;
            dgIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIncome.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column7, Column6 });
            dgIncome.Location = new Point(514, 252);
            dgIncome.Name = "dgIncome";
            dgIncome.ReadOnly = true;
            dgIncome.RowHeadersWidth = 51;
            dgIncome.RowTemplate.Height = 25;
            dgIncome.Size = new Size(596, 174);
            dgIncome.TabIndex = 43;
            dgIncome.CellDoubleClick += dgIncome_CellDoubleClick;
            // 
            // dgExpense
            // 
            dgExpense.AllowUserToAddRows = false;
            dgExpense.AllowUserToDeleteRows = false;
            dgExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExpense.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn9 });
            dgExpense.Location = new Point(930, 49);
            dgExpense.Name = "dgExpense";
            dgExpense.ReadOnly = true;
            dgExpense.RowHeadersWidth = 51;
            dgExpense.RowTemplate.Height = 25;
            dgExpense.Size = new Size(596, 174);
            dgExpense.TabIndex = 44;
            dgExpense.CellDoubleClick += dgExpense_CellDoubleClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(32, 107);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 46;
            label8.Text = "Gelir No";
            // 
            // txtIncomeId
            // 
            txtIncomeId.Location = new Point(148, 104);
            txtIncomeId.Name = "txtIncomeId";
            txtIncomeId.ReadOnly = true;
            txtIncomeId.Size = new Size(117, 23);
            txtIncomeId.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(409, 528);
            label9.Name = "label9";
            label9.Size = new Size(168, 20);
            label9.TabIndex = 47;
            label9.Text = "Toplam Gelir Miktarı";
            // 
            // lbIncome
            // 
            lbIncome.AutoSize = true;
            lbIncome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIncome.Location = new Point(624, 528);
            lbIncome.Name = "lbIncome";
            lbIncome.Size = new Size(44, 20);
            lbIncome.TabIndex = 48;
            lbIncome.Text = "0 TL";
            // 
            // lbExpense
            // 
            lbExpense.AutoSize = true;
            lbExpense.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbExpense.Location = new Point(944, 528);
            lbExpense.Name = "lbExpense";
            lbExpense.Size = new Size(44, 20);
            lbExpense.TabIndex = 50;
            lbExpense.Text = "0 TL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1044, 528);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 51;
            label11.Text = "Fark";
            // 
            // lbDiff
            // 
            lbDiff.AutoSize = true;
            lbDiff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDiff.Location = new Point(1110, 528);
            lbDiff.Name = "lbDiff";
            lbDiff.Size = new Size(44, 20);
            lbDiff.TabIndex = 52;
            lbDiff.Text = "0 TL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(729, 528);
            label10.Name = "label10";
            label10.Size = new Size(174, 20);
            label10.TabIndex = 53;
            label10.Text = "Toplam Gider Miktarı";
            // 
            // lbExp
            // 
            lbExp.AutoSize = true;
            lbExp.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbExp.Location = new Point(930, 28);
            lbExp.Name = "lbExp";
            lbExp.Size = new Size(133, 18);
            lbExp.TabIndex = 54;
            lbExp.Text = "Giderler Tablosu";
            // 
            // lbInc
            // 
            lbInc.AutoSize = true;
            lbInc.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbInc.Location = new Point(514, 231);
            lbInc.Name = "lbInc";
            lbInc.Size = new Size(128, 18);
            lbInc.TabIndex = 55;
            lbInc.Text = "Gelirler Tablosu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(350, 28);
            label14.Name = "label14";
            label14.Size = new Size(155, 18);
            label14.TabIndex = 56;
            label14.Text = "Kategoriler Tablosu";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Tarih";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Miktar";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Açıklama";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Kategori Adı";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Kategori No";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tarih";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Miktar";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Açıklama";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
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
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1542, 586);
            Controls.Add(label14);
            Controls.Add(lbInc);
            Controls.Add(lbExp);
            Controls.Add(label10);
            Controls.Add(lbDiff);
            Controls.Add(label11);
            Controls.Add(lbExpense);
            Controls.Add(lbIncome);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtIncomeId);
            Controls.Add(dgExpense);
            Controls.Add(dgIncome);
            Controls.Add(btnSearch);
            Controls.Add(label7);
            Controls.Add(txtExpenseId);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(dtDate);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgCategories);
            Controls.Add(cbType);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCategory";
            Text = "FrmCategory";
            Load += FrmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private ComboBox cbType;
        private DataGridView dgCategories;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtId;
        private Label label3;
        private Label label7;
        private TextBox txtExpenseId;
        private TextBox txtDescription;
        private TextBox txtAmount;
        private DateTimePicker dtDate;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSearch;
        private DataGridView dgIncome;
        private DataGridView dgExpense;
        private Label label8;
        private TextBox txtIncomeId;
        private Label label9;
        private Label lbIncome;
        private Label lbExpense;
        private Label label11;
        private Label lbDiff;
        private Label label10;
        private Label lbExp;
        private Label lbInc;
        private Label label14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}