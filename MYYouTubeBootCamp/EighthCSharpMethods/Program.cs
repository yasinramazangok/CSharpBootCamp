using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EighthCSharpMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //void CustomerList()
            //{
            //    Console.WriteLine("Yasin");
            //    Console.WriteLine("Ramazan");
            //    Console.WriteLine("GÖK");
            //    Console.WriteLine("senior learner 🧑‍🏫 junior developer 🧑‍💻");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int a = 1;
            //    int b = 2;
            //    int c = a + b;
            //    Console.WriteLine(c);
            //}

            //Sum();

            #endregion

            #region Void Methods With Parameters

            //void WriteName(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteName("Yasin Ramazan GÖK");


            //void ShowCustomerInfo(string name, string job, int age)
            //{
            //    Console.WriteLine("Müşteri Bilgileri : " + name + ", " + job + ", " + age);
            //}

            //ShowCustomerInfo("Yasin Ramazan GÖK", ".NET Backend Developer", 26);
            //ShowCustomerInfo("Mehmet Ali GÖK", "Embedded System Engineer", 24);


            //int result = 0;

            //void Sum(int number1, int number2, int number3)
            //{
            //    result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 65, 23);

            #endregion

            #region Methods That Return a Value

            //string WriteName()
            //{
            //    return "Yasin Ramazan GÖK";
            //}

            //WriteName();


            //string ShowStudentInfo()
            //{
            //    string name = "Yasin Ramazan GÖK";
            //    string job = ".NET Backend Developer";

            //    return name + ", " + job;
            //}

            //Console.WriteLine(ShowStudentInfo());

            #endregion

            #region Methods with Parameters That Return a Value 

            //string ShowCountryInfo(string _countryName, string _capital, string _flagColor)
            //{
            //    string countryInfo = "Ülke Bilgileri --> Adı : " + _countryName + ", Başkenti : " + _capital + ", Bayrak Rengi : " + _flagColor;
            //    return countryInfo;
            //}

            //string countryName, capital, flagColor;

            //Console.Write("Ülke adını giriniz : ");
            //countryName = Console.ReadLine();

            //Console.Write("Ülkenin başkentinin adını giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkenin bayrak renklerini giriniz : ");
            //flagColor = Console.ReadLine();

            //Console.WriteLine(ShowCountryInfo(countryName, capital, flagColor));

            //Console.WriteLine(ShowCountryInfo("Türkiye", "Ankara", "Kırmızı-Beyaz"));


            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(12, 35));
            //Console.WriteLine(Sum(98, 45));
            //Console.WriteLine(Sum(24, 90));
            //Console.WriteLine(Sum(55, 11));

            #endregion

            #region Example Application

            string ShowExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result < 50)
                    return "Öğrenci Adı : " + student + " --> " + "*** Not Ortalaması : " + result + " *** Ders Geçme Durumu : Kaldı!";

                else
                    return "Öğrenci Adı : " + student + " --> " + "*** Not Ortalaması : " + result + " *** Ders Geçme Durumu : Geçti!";
            }

            Console.WriteLine(ShowExamResult("Yasin", 65, 35, 40));
            Console.WriteLine(ShowExamResult("Ramazan", 85, 35, 90));

            #endregion

            Console.Read();
        }
    }
}
