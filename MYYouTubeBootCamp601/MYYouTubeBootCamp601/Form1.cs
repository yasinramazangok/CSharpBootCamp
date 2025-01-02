using MYYouTubeBootCamp601.Entities;
using MYYouTubeBootCamp601.Services;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MYYouTubeBootCamp601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperations customerOperations = new CustomerOperations();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                Name = txtName.Text,
                City = txtCity.Text,
                Balance = Convert.ToDecimal(txtBalance.Text),
                ShoppingCount = Convert.ToInt32(txtShoppingCount.Text)
            };  
            
            customerOperations.AddCustomer(customer);
            MessageBox.Show("Müşteri ekleme başarılı!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
