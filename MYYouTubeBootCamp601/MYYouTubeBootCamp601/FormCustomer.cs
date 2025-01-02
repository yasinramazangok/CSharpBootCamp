using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYYouTubeBootCamp601
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        string connectionString = "server = localhost; port=5432; database = CSharpBootCamp601Database; user id = postgres; password = 123456";

        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Customers";

            var command = new NpgsqlCommand(query, connection);
            var dataAdapter = new NpgsqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            string customerCity = txtCity.Text;
            decimal customerBalance = decimal.Parse(txtBalance.Text);

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Customers (CustomerName, CustomerCity, CustomerBalance) VALUES (@CustomerName, @CustomerCity, @CustomerBalance)";
            var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerName", customerName);
            command.Parameters.AddWithValue("@CustomerCity", customerCity);
            command.Parameters.AddWithValue("@CustomerBalance", customerBalance);

            command.ExecuteNonQuery();

            MessageBox.Show("Müşteri ekleme başarılı!");
            connection.Close();

            GetAllCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM Customers WHERE CustomerId = @CustomerId";
            var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerId", id);
            command.ExecuteNonQuery();

            MessageBox.Show("Müşteri silme başarılı!");
            connection.Close();
            GetAllCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            string customerCity = txtCity.Text;
            decimal customerBalance = decimal.Parse(txtBalance.Text);
            int customerId = int.Parse(txtCustomerId.Text);

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE Customers SET CustomerName = @CustomerName, CustomerCity = @CustomerCity, CustomerBalance = @CustomerBalance WHERE CustomerId = @CustomerId";
            var command = new NpgsqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerName", customerName);
            command.Parameters.AddWithValue("@CustomerCity", customerCity);
            command.Parameters.AddWithValue("@CustomerBalance", customerBalance);
            command.Parameters.AddWithValue("@CustomerId", customerId);

            command.ExecuteNonQuery();

            MessageBox.Show("Müşteri güncelleme başarılı!");
            connection.Close();

            GetAllCustomers();
        }
    }
}
