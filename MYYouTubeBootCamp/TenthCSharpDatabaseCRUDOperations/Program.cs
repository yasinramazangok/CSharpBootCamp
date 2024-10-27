using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthCSharpDatabaseCRUDOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            #region Add Category

            //Console.Write("Eklemek istediğiniz menü ismini giriniz : ");

            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("server = MEHMETALIGOK; database = CSharpBootCampDatabase; integrated security = true; trustservercertificate = true;");

            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Insert into Categories (Name) values (@categoryName)", sqlConnection);

            //sqlCommand.Parameters.AddWithValue("@categoryName", categoryName);
            //sqlCommand.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi!");

            #endregion

            #region Add Product

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.WriteLine("Eklemek istediğiniz ürün bilgilerini giriniz!");
            //Console.Write("Ürün Adı : ");

            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı : ");

            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("server = MEHMETALIGOK; database = CSharpBootCampDatabase; integrated security = true; trustservercertificate = true;");

            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Insert into Products (Name, Price, Status) values (@productName, @productPrice, @productStatus)", sqlConnection);

            //sqlCommand.Parameters.AddWithValue("@productName", productName);
            //sqlCommand.Parameters.AddWithValue("@productPrice", productPrice);
            //sqlCommand.Parameters.AddWithValue("@productStatus", true);

            //sqlCommand.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.WriteLine("Ürün başarıyla eklendi!");

            #endregion

            #region Listing Product

            //Console.WriteLine("Bütün ürünler aşağıda listelenmiştir!");
            //Console.WriteLine();

            //SqlConnection sqlConnection = new SqlConnection("server = MEHMETALIGOK; database = CSharpBootCampDatabase; integrated security = true; trustservercertificate = true;");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Select * from Products", sqlConnection);

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //DataTable dataTable = new DataTable();

            //sqlDataAdapter.Fill(dataTable);

            //foreach (DataRow rowItem in dataTable.Rows)
            //{
            //    foreach (var item in rowItem.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //sqlConnection.Close();

            #endregion

            #region Delete Product

            //Console.Write("Silmek istediğiniz ürün ID'sini giriniz : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("server = MEHMETALIGOK; database = CSharpBootCampDatabase; integrated security = true; trustservercertificate = true;");

            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Delete from Products where ProductId = @productId", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@productId", productId);

            //sqlCommand.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.WriteLine("Ürün silindi!");

            #endregion

            #region Update Product

            //int productId;
            //string productName;
            //decimal productPrice;

            //Console.WriteLine("Güncellemek istediğiniz ürün bilgilerini giriniz!");

            //Console.Write("Ürün ID : ");
            //productId= int.Parse(Console.ReadLine());

            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("server = MEHMETALIGOK; database = CSharpBootCampDatabase; integrated security = true; trustservercertificate = true;");

            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Update Products set Name = @productName, Price = @productPrice where ProductId = @productId", sqlConnection);

            //sqlCommand.Parameters.AddWithValue("@productId", productId);
            //sqlCommand.Parameters.AddWithValue("@productName", productName);
            //sqlCommand.Parameters.AddWithValue("@productPrice", productPrice);

            //sqlCommand.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.WriteLine("Ürün başarıyla güncellendi!");

            #endregion

            Console.Read();

        }
    }
}
