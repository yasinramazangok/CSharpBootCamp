﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SixthCSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Array Examples

            // VariableType [] ArrayName = new VariableType[Index Count]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[3]); // Kahire
            //Console.WriteLine(cities[5]); // System.IndexOutOfRangeException


            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            ////Console.WriteLine(numbers[7]); // 748
            //Console.WriteLine(numbers[5]); // 0 because it is default value for integer arrays.


            //string[] cities = {"Prag","Roma","Atina","Ankara","Bursa"};

            //Console.WriteLine(cities[3]); // Ankara

            #endregion

            #region Listing All Elements In The Array

            /*
            string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe"};

            for (int i = 0; i <= colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            
            for (int i = 0; i <= colors.Length; i++)
            {
                Console.WriteLine(colors[i]); // System.IndexOutOfRangeException
            }
            */


            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) 
            //        Console.WriteLine(numbers[i]);
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);


            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };

            //Console.WriteLine(persons.Length);

            #endregion

            #region Array Methods

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };

            //Array.Sort(numbers); // Ascending

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };

            //Array.Reverse(numbers); // Reverse

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };

            //int index = Array.IndexOf(customers, "Merve");

            //Console.WriteLine(index);


            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };

            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max());

            //Console.WriteLine("Dizinin en küçük elemanı : " + numbers.Min());

            #endregion

            #region Getting Value From The User

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine("Dizideki sayıların toplamı : " + sum);


            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
