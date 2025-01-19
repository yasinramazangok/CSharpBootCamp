using FinancialCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCRMEntities database = new FinancialCRMEntities();

        private void GetListAll()
        {
            var categories = database.Categories
                              .Select(c => new
                              {
                                  c.CategoryId,
                                  c.CategoryName
                              }).ToList();

            dataGridView1.DataSource = categories;

            dataGridView1.Columns["CategoryId"].HeaderText = "Kategori Id";
            dataGridView1.Columns["CategoryName"].HeaderText = "Kategori Adı";
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            GetListAll();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            Category category = new Category();
            category.CategoryName = categoryName;

            database.Categories.Add(category);
            database.SaveChanges();

            txtCategoryId.Clear();
            txtCategoryName.Clear();

            MessageBox.Show("Kategori eklendi!", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetListAll();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(txtCategoryId.Text);

            var category = database.Categories.Find(categoryId);
            database.Categories.Remove(category);
            database.SaveChanges();

            txtCategoryId.Clear();
            txtCategoryName.Clear();

            GetListAll();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
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

        private void btnDashboard_Click(object sender, EventArgs e)
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
