using FinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCRMEntities database = new FinancialCRMEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ziraatBankBalance = database.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = database.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankasiBalance = database.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblisBankasiBalance.Text = isBankasiBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";

            var bankProcess1 = database.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount + " " + bankProcess1.ProcessDate;

            var bankProcess2 = database.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3 = database.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " " + bankProcess3.ProcessDate;

            var bankProcess4 = database.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " " + bankProcess4.ProcessDate;

            var bankProcess5 = database.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " " + bankProcess5.ProcessDate;
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }
    }
}
