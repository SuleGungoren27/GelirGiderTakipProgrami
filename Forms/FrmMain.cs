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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenForm(new FrmIncome());
            lbTitle.Text = "Gelirler Tablosu";
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmIncome());
            lbTitle.Text = "Gelirler Tablosu";
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmExpense());
            lbTitle.Text = "Giderler Tablosu";
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCategory());
            lbTitle.Text = "Kategoriler Tablosu";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void OpenForm(Form f)
        {
            panel2.Controls.Clear();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.WindowState = FormWindowState.Maximized;
            f.BackColor = SystemColors.ActiveCaption;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ForeColor = SystemColors.HotTrack;
            f.Show();

        }
    }
}
