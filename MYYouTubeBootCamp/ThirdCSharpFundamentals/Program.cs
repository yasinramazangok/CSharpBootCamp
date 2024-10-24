using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdCSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen şifreyi giriniz : ");
            //string password;

            //password = Console.ReadLine();

            //if (password == "12345")
            //{
            //    Console.WriteLine("Şifre doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış!");
            //}

            //string capitalCity, country;

            //Console.Write("Başkenti giriniz : ");
            //capitalCity = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capitalCity == "Ankara" & country == "Türkiye")
            //{
            //    Console.Write("Doğru giriş yaptınız!");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş!");
            //}

            //int number;

            //Console.Write("Bir sayı giriniz : ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış!");
            //}

            //int exam1, exam2, exam3, average;
            //string state = string.Empty;

            //Console.Write("1. sınav notunu giriniz : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sınav notunu giriniz : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. sınav notunu giriniz : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız : " + average);

            //if (average >= 0 & average < 50)
            //{
            //    state = "Kötü";
            //}
            //if (average >= 50 & average < 70)
            //{
            //    state = "Orta";
            //}
            //if (average >= 70 & average < 85)
            //{
            //    state = "İyi";
            //}
            //if (average >= 85 & average <= 100)
            //{
            //    state = "Çok İyi";
            //}
            //else
            //{
            //    state = "Hata! Ortalamanız eksi veya 100'den büyük olamaz!";
            //}

            //Console.WriteLine("Not Durumu : " + state);

            //string city;

            //Console.Write("Lütfen şehir giriniz : ");
            //city = Console.ReadLine();

            //if (city == "Hatay" | city == "Ankara" | city == "Eskişehir" | city == "İstanbul")
            //{
            //    Console.WriteLine("Şehir bulundu!");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir bulunamadı!");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz : ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Hatalı kullanıcı adı!");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş başarılı!");
            //}

            #endregion

            #region Modulo Operations

            //int number, result;
            //number = 26;

            //result = number % 5;
            //Console.WriteLine(result); // result = 1 

            //int number1, number2, result;

            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //number2 = int.Parse(Console.ReadLine());

            //result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan ( modulo ) : " + result);

            //int number1;

            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());

            //if (number1 % 2 == 0) {
            //    Console.WriteLine("Girilen sayı çifttir!");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı tektir!");
            //}

            #endregion

            #region Decision Structures With Char Variables

            //char team;

            //Console.Write("Lütfen takım sembolünü giriniz : ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Takımınız : Fenerbahçe!");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Takımınız : Galatasaray!");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Takımınız : Beşiktaş!");
            //}

            #endregion

            #region Example Project

            //Console.WriteLine("****** GÖK Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü için seçim yapın : ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen kaçıncı ayı görmek istediğinizi sayı olarak giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Giriş!"); break;
            //}

            #endregion

            #region Calculator

            //int number1, number2, result;
            //char operation;

            //Console.Write("1. sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz : ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz : ");
            //operation = char.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark : " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm : " + result);
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
