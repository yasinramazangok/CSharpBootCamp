using MYYouTubeBootCampModule501.Dtos;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MYYouTubeBootCampModule501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=YASINRAMAZANGOK;initial catalog=CSharpBootCamp501Database;integrated security=true");
        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * From Products";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into Products (Name,Stock,Price,Category) values (@Name,@Stock,@Price,@Category)";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", txtProductName.Text);
            parameters.Add("@Stock", txtProductStock.Text);
            parameters.Add("@Price", txtProductPrice.Text);
            parameters.Add("@Category", txtProductCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Yeni Kitap Ekleme İşlemi Başarılı");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Products Where ProductId=@ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap Silme İşlemi Başarılı");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Products Set Name=@Name,Price=@Price, Stock=@Stock, Category=@Category where ProductId=@ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", txtProductName.Text);
            parameters.Add("@Stock", txtProductStock.Text);
            parameters.Add("@Price", txtProductPrice.Text);
            parameters.Add("@Category", txtProductCategory.Text);
            parameters.Add("@ProductId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap Güncelleme İşlemi Başarılı Bir Şekilde Yapıldı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query1 = "Select Count(*) From Products";
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
            lblTotalProductCount.Text = productTotalCount.ToString();

            string query2 = "Select Name From Products Where Price=(Select Max(Price) From Products)";
            var maxPriceName = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPriceProductName.Text = maxPriceName.ToString();

            string query3 = "Select Count(Distinct(Category)) From Products";
            var distinctProductCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblDistinctCategoryCount.Text = distinctProductCount.ToString();
        }
    }
}
