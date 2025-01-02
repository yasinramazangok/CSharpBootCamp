using MYYouTubeBootCamp601.Entities;
using MYYouTubeBootCamp601.Services;
using System;
using System.Collections.Generic;
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

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerOperations.GetAllCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerOperations.DeleteCustomer(txtCustomerId.Text);
            MessageBox.Show("Müşteri silme işlemi başarılı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updatedCustomer = new Customer()
            {
                CustomerId = txtCustomerId.Text,
                Name = txtName.Text,
                City = txtCity.Text,
                Balance = Convert.ToDecimal(txtBalance.Text),
                ShoppingCount = Convert.ToInt32(txtShoppingCount.Text)
            };

            customerOperations.UpdateCustomer(updatedCustomer);
            MessageBox.Show("Müşteri güncelleme başarılı!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            Customer customers = customerOperations.GetById(id);
            dataGridView1.DataSource = new List<Customer> { customers };
        }
    }
}
