using GelirGiderTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GelirGiderTakip.Forms
{
    public partial class FrmIncome : Form
    {
        public FrmIncome()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void FrmIncome_Load(object sender, EventArgs e)
        {
            GetIncomeList();
            LoadCategories();
            Type();
        }

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
        void GetIncomeList()
        {
            dgIncome.Rows.Clear();
            var incomes = db.Incomes.ToList();
            foreach (var income in incomes)
            {
                dgIncome.Rows.Add(income.Id, income.Date, income.Amount, income.Description, income.Type);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var income = new Income();

            income.Amount = float.Parse(txtAmount.Text);
            income.Description = txtDescription.Text;
            income.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
            income.Type = cbType.Text;
            income.Date = dtDate.Value;
            income.Created = DateTime.Now;
            income.Updated = DateTime.Now;


            db.Incomes.Add(income);
            db.SaveChanges();

            MessageBox.Show("Gelir başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetIncomeList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtAmount.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var income = db.Incomes.Where(s => s.Id == id).SingleOrDefault();
            if (income == null)
            {
                MessageBox.Show("Gelir Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            income.Amount = float.Parse(txtAmount.Text);
            income.Description = txtDescription.Text;
            income.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
            income.Type = cbType.Text;
            income.Date = dtDate.Value;
            income.Created = DateTime.Now;
            income.Updated = DateTime.Now;
            db.Incomes.Update(income);

            db.SaveChanges();

            MessageBox.Show("Gelir başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetIncomeList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Gelir Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var income = db.Incomes.Where(s => s.Id == id).SingleOrDefault();
            if (income == null)
            {
                MessageBox.Show("Gelir Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.Incomes.Remove(income);
            db.SaveChanges();

            MessageBox.Show("Gelir başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetIncomeList();
        }

        private void dgIncome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgIncome.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgIncome.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgIncome.CurrentRow.Cells[3].Value.ToString();
            cbType.Text = dgIncome.CurrentRow.Cells[4].Value.ToString();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType.SelectedValue = cbCategory.SelectedValue;
        }
    }
}
