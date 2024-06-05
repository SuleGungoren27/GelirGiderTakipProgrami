using GelirGiderTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelirGiderTakip.Forms
{
    public partial class FrmExpense : Form
    {
        public FrmExpense()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        void LoadCategories()
        {
            var categories = db.Categories.ToList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryId";
            cbCategory.ValueMember = "Id";
        }
        void Type()
        {
            var categories = db.Categories.ToList();
            cbType.DataSource = categories;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var expense = new Expense();

            expense.Amount = float.Parse(txtAmount.Text);
            expense.Description = txtDescription.Text;
            expense.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
            expense.Type = cbType.Text;
            expense.Date = dtDate.Value;
            expense.Created = DateTime.Now;
            expense.Updated = DateTime.Now;


            db.Expenses.Add(expense);
            db.SaveChanges();

            MessageBox.Show("Gider başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetExpenseList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtAmount.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var expense = db.Expenses.Where(s => s.Id == id).SingleOrDefault();
            if (expense == null)
            {
                MessageBox.Show("Gider Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            expense.Amount = float.Parse(txtAmount.Text);
            expense.Description = txtDescription.Text;
            expense.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
            expense.Type = cbType.Text;
            expense.Date = dtDate.Value;
            expense.Created = DateTime.Now;
            expense.Updated = DateTime.Now;
            db.Expenses.Update(expense);

            db.SaveChanges();

            MessageBox.Show("Gider başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetExpenseList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Gider Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var expense = db.Expenses.Where(s => s.Id == id).SingleOrDefault();
            if (expense == null)
            {
                MessageBox.Show("Gider Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.Expenses.Remove(expense);
            db.SaveChanges();

            MessageBox.Show("Gider başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetExpenseList();
        }

        void GetExpenseList()
        {
            dgExpense.Rows.Clear();
            var expenses = db.Expenses.ToList();
            foreach (var expense in expenses)
            {
                dgExpense.Rows.Add(expense.Id, expense.Date, expense.Amount, expense.Description, expense.Type);
            }
        }

        private void FrmExpense_Load_1(object sender, EventArgs e)
        {
            GetExpenseList();
            Type();
            LoadCategories();
        }

        private void dgExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgExpense.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgExpense.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgExpense.CurrentRow.Cells[3].Value.ToString();
            cbType.Text = dgExpense.CurrentRow.Cells[4].Value.ToString();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType.SelectedValue = cbCategory.SelectedValue;
        }
    }
}
