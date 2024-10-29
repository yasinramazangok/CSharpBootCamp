using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhCSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop

            // The foreach loop takes 4 parameters.

            // "Variable type", "Variable name", "In", "List, Collection, Array"


            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if(number %2 == 0)
            //        { Console.WriteLine(number); }
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3, 4,5,6,7,8
            //};

            //Console.WriteLine(numbers); // System.Collections.Generic.List`1[System.Int32]

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string tagline = "On the way of software development!";

            //foreach (char item in tagline)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Example of Examination System Application

            //Console.WriteLine("***** GÖK Eğitim Kurumları Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("------------------------------");
            //Console.WriteLine();
            //Console.Write("Lütfen sınıf mevcudunu giriniz : ");

            //int studentCount = int.Parse(Console.ReadLine());
            
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //string[] students = new string[studentCount];
            //double[] examGradeAverages = new double[studentCount];
            //double totalExamGrade = 0, examGrade = 0;

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{ i + 1 }. öğrencinin adını giriniz : ");

            //    students[i] = Console.ReadLine();

            //    Console.WriteLine();

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{ students[i] } adlı öğrencinin { j + 1 }. sınav notunu giriniz : ");

            //        examGrade = double.Parse(Console.ReadLine());
            //        totalExamGrade += examGrade;
            //    }

            //    Console.WriteLine();

            //    examGradeAverages[i] = totalExamGrade / 3;
            //    totalExamGrade = 0;
            //}

            //Console.WriteLine();

            //for (int i = 0;i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"***** {students[i] } adlı öğrencinin not ortalaması : {examGradeAverages[i] } *****");

            //    if (examGradeAverages[i] >= 0 & examGradeAverages[i] < 50)
            //        Console.WriteLine("Ders Durumu : Kaldı");

            //    else if (examGradeAverages[i] >= 50 & examGradeAverages[i] <= 100)
            //        Console.WriteLine("Ders Durumu : Geçti");

            //    else Console.WriteLine("Hatalı not girişi!");

            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}
