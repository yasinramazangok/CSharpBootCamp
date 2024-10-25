using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthCSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("On the way of software development!");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen belirlenen metnin ekrana kaç kere yazılmasını istediğinizi sayı olarak giriniz : ");
            //int lastValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= lastValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}

            #endregion

            #region Decision Structures With For Loop

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);


            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);


            //int count = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            //1-2-4-8-16-...

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda " + bacterium + " bakteri vardır." );
            //}

            #endregion

            #region While Loop

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("On the way of software development!");
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Example Quiz Question

            // Write the code that calculates the sum of digits of a 3-digit number entered from the     keyboard.

            // 456

            //Console.Write("Sayıyı Giriniz : ");
            //int number = int.Parse(Console.ReadLine());
            //int onesDigit, tensDigit, hundredsDigit;
            //int sum;

            //onesDigit = number % 10;
            //tensDigit = (number % 100) / 10;
            //hundredsDigit = number / 100;

            //Console.WriteLine("Yüzler basamağı : " + hundredsDigit);
            //Console.WriteLine("Onlar basamağı : " + tensDigit);
            //Console.WriteLine("Birler basamağı : " + onesDigit);

            //sum = onesDigit + tensDigit + hundredsDigit;

            //Console.WriteLine("Girilen sayının rakamları toplamı : " + sum);

            #endregion

            Console.Read();
        }
    }
}
