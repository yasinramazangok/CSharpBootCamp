using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCRM.Models;
using FinancialCRM.Models;

namespace FinancialCRM
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCRMEntities database = new FinancialCRMEntities();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = database.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = database.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bill bills = new Bill();
            bills.BillTitle= title;
            bills.BillAmount=amount;
            bills.BillPeriod=period;
            database.Bills.Add(bills);
            database.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = database.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = database.Bills.Find(id);
            database.Bills.Remove(removeValue);
            database.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemden Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = database.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);

            var values= database.Bills.Find(id);

            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            database.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = database.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }
    }
}
