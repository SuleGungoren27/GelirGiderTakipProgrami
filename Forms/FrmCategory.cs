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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GelirGiderTakip.Forms
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            GetCategoryList();
            dgIncome.Visible = false;
            dgExpense.Visible = false;
            GetIncomeList();
            GetExpenseList();
            lbExp.Visible = false;
            lbInc.Visible = false;
        }

        void GetCategoryList()
        {


            var categories = db.Categories.ToList();
            dgCategories.Rows.Clear();
            foreach (var category in categories)
            {
                dgCategories.Rows.Add(category.Id, category.Name, category.Type, category.Created, category.Updated);
            }

        }

        void Calculate()
        {
            double amount = 0;
            for (int i = 0; i < dgIncome.Rows.Count; i++)
            {
                amount += Convert.ToDouble(dgIncome.Rows[i].Cells[2].Value.ToString());
            }
            lbIncome.Text = amount.ToString("0.00 TL");

            double price = 0;
            for (int i = 0; i < dgExpense.Rows.Count; i++)
            {
                price += Convert.ToDouble(dgExpense.Rows[i].Cells[2].Value.ToString());
            }
            lbExpense.Text = price.ToString("0.00 TL");

            double diff = amount - price;
            lbDiff.Text = diff.ToString("0.00 TL");
            if (diff < 0)
            {
                lbDiff.ForeColor = Color.Red;
            }
            else
            {
                lbDiff.ForeColor = Color.Green;
            }
        }
        void GetIncomeList()
        {
            dgIncome.Rows.Clear();
            var incomes = db.Incomes.ToList();
            foreach (var income in incomes)
            {
                dgIncome.Rows.Add(income.Id, income.Date, income.Amount, income.Description, income.Type);
            }
            Calculate();
        }

        void GetExpenseList()
        {
            dgExpense.Rows.Clear();
            var expenses = db.Expenses.ToList();
            foreach (var expense in expenses)
            {
                dgExpense.Rows.Add(expense.Id, expense.Date, expense.Amount, expense.Description, expense.Type);
            }
            Calculate();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cbType.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            var category = new Category();

            category.Name = txtName.Text;
            category.Type = cbType.Text;
            category.Created = DateTime.Now;
            category.Updated = DateTime.Now;


            db.Categories.Add(category);
            db.SaveChanges();


            MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCategoryList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || cbType.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);


            var category = db.Categories.Where(s => s.Id == id).SingleOrDefault();
            if (category == null)
            {
                MessageBox.Show("Kategori bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            category.Name = txtName.Text;
            category.Type = cbType.Text;
            category.Updated = DateTime.Now;
            db.Categories.Update(category);
            db.SaveChanges();


            MessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCategoryList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kategori Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);


            var category = db.Categories.Where(s => s.Id == id).SingleOrDefault();
            if (category == null)
            {
                MessageBox.Show("Kategori bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Categories.Remove(category);
            db.SaveChanges();


            MessageBox.Show("Kategori başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCategoryList();
        }

        private void dgCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgCategories.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgCategories.CurrentRow.Cells[1].Value.ToString();
            cbType.Text = dgCategories.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgIncome.Visible = true;
            dgCategories.Visible = true;
            dgExpense.Visible = true;
            lbExp.Visible = true;
            lbInc.Visible = true;
        }

        private void dgIncome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIncomeId.Text = dgIncome.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgIncome.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgIncome.CurrentRow.Cells[3].Value.ToString();

            dgIncome.Visible = true;
            dgCategories.Visible = true;
            dgExpense.Visible = true;
        }

        private void dgExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExpenseId.Text = dgExpense.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgExpense.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgExpense.CurrentRow.Cells[3].Value.ToString();

            dgIncome.Visible = true;
            dgCategories.Visible = true;
            dgExpense.Visible = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
