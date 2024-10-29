using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NinthCSharpDatabaseOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** GÖK Ürün - Kategori Bilgi Sistemi *****");
            //Console.WriteLine();
            //Console.WriteLine();

            //string tableNumber;

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("1 - Kategoriler");
            //Console.WriteLine("2 - Ürünler");
            //Console.WriteLine("3 - Siparişler");
            //Console.WriteLine("4 - Çıkış Yap");

            //Console.Write("Lütfen listelemek istediğiniz tablo numarasını giriniz : ");
            //tableNumber = Console.ReadLine();

            //Console.WriteLine("-----------------------------------------------");

            //SqlConnection sqlConnection = new SqlConnection("server = MEHMETALIGOK; database = CSharpBootCampDatabase; integrated security = true; trustservercertificate = true;");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Select * from Categories", sqlConnection);

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //DataTable dataTable = new DataTable();

            //sqlDataAdapter.Fill(dataTable);

            //foreach (DataRow rowItem in dataTable.Rows)
            //{
            //    foreach (var item in rowItem.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            //sqlConnection.Close();

            Console.Read();
        }
    }
}
