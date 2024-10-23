using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = Encoding.UTF8;

            /*
            
            CultureInfo turkishCulture = new CultureInfo("tr-TR");

            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice.ToString("C", turkishCulture));

            */

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " ₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " ₺");
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine();
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("*** Sipariş Tutarı ***");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("---- Elmanın Toplam Tutarı : " + appleTotalPrice + " ₺");
            //Console.WriteLine("---- Portakalın Toplam Tutarı : " + orangeTotalPrice + " ₺");
            //Console.WriteLine("---- Çileğin Toplam Tutarı : " + strawberryTotalPrice + " ₺");
            //Console.WriteLine("---- Patatesin Toplam Tutarı : " + potatoTotalPrice + " ₺");
            //Console.WriteLine("---- Domatesin Toplam Tutarı : " + tomatoTotalPrice + " ₺");
            //Console.WriteLine("*** Toplam : " + totalPrice + " ₺");
            //Console.WriteLine("-----------------------------------------------");

            #endregion

            #region Char Variables

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region String Data Input From Keyboard

            //Console.WriteLine("**** THY Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerTCIdentityNumber;
            //int passengerAge;

            //Console.Write("Yolcu adını giriniz : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadını giriniz : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe bilgisini giriniz : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir bilgisini giriniz : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu TC kimlik numarasını giriniz : ");
            //passengerTCIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu yaşını giriniz : ");
            //passengerAge = int.Parse(Console.ReadLine()); // Only converts string to integer.
            ////passengerAge = Convert.ToInt32(Console.ReadLine()); // It also converts different data types to integer.

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("*** Bilet Önizleme ***");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu TC Kimlik Numarası : " + passengerTCIdentityNumber);
            //Console.WriteLine("Yolcu Yaşı : " + passengerAge);
            //Console.WriteLine("İlçe : "+ passengerDistrict);
            //Console.WriteLine("İl : " + passengerCity);
            //Console.WriteLine("-----------------------------------");

            #endregion

            #region Integer Data Input From Keyboard And Conversions

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar : " + totalPrice);

            #endregion

            #region Double Data Input From Keyboard And Conversions

            //double exam1, exam2, exam3, result;

            //// We used the CultureInfo class to input data with ','

            //Console.Write("1. sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine(), new CultureInfo("tr-TR"));

            //Console.Write("2. sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine(), new CultureInfo("tr-TR"));

            //Console.Write("3. sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine(), new CultureInfo("tr-TR"));

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız : " + result);

            #endregion

            #region Char Data Input From Keyboard

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz. Erkek için E, Kadın için K tuşuna basınız : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine();

            //if(gender == 'E' || gender == 'e')
            //    Console.WriteLine("Cinsiyetiniz : Erkek");

            //if (gender == 'K' || gender == 'k')
            //    Console.WriteLine("Cinsiyetiniz : Kadın");

            #endregion

            Console.Read();
        }
    }
}
