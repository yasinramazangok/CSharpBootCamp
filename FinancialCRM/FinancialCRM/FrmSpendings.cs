using FinancialCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCRMEntities database = new FinancialCRMEntities();

        private void GetListAll()
        {
            var categories = database.Spendings
                              .Select(s => new
                              {
                                  s.SpendingId,
                                  s.SpendingTitle,
                                  s.SpendingDate,
                                  s.Category.CategoryName
                              }).ToList();

            dataGridView1.DataSource = categories;

            dataGridView1.Columns["SpendingId"].HeaderText = "Harcama Id";
            dataGridView1.Columns["SpendingTitle"].HeaderText = "Harcamalar";
            dataGridView1.Columns["SpendingDate"].HeaderText = "Tarih";
            dataGridView1.Columns["CategoryName"].HeaderText = "Kategori Adı";
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            GetListAll();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
