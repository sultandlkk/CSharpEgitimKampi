using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü
            //foreach 4 tane parametre alır(1;2;3;4)
            //1:değişken türü
            //2:değişken adı
            //3:in
            //4:Liste,koleksiyon ya da dizi

            //string[] cities = { "adana", "bursa", "samsun" };
            //foreach (string item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //int[]  numbers = { 12,2,3,56,45,366,343,2,4 };
            //foreach (int sayi in numbers)
            //{
            //    if (sayi % 2 == 0) { 
            //    Console.WriteLine(sayi);
            //    }
            //}

            //int[] numbers = { 12, 2, 3, 56, 45, 366, 343, 2, 4 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7
            //};
            //Console.WriteLine(numbers);
            //foreach (int sayi in numbers)
            //{
            //    Console.WriteLine(sayi);
            //}

            //string word = "MERHABA";
            //foreach (char harf in word)
            //{
            //    Console.WriteLine(harf);
            //}
            #endregion
            #region ÖRNEK1
            //sınıftaki öğrenci sayısını alır
            Console.Write("Öğrenci sayısını giriniz: ");
            int students = int.Parse(Console.ReadLine());

            //öğrenci isimlerini ve ortalamayı saklayacak diziler
            string[] studentName = new string[students];
            double[] studentsAvarage = new double[students];

            for(int i = 0; i < students; i++)
            {
                Console.Write($"\n{i + 1}. öğrencinin adını giriniz: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;


                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"{studentName[i]} isimli öğrencinin {j+1}. notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentsAvarage[i] =totalExamResult / 2.00;

            }
            Console.WriteLine("\n---------Öğrenci bilgileri ve ortalamalar-----");

            for (int i = 0; i < students; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin Ortalaması: {studentsAvarage[i]} ");

                if (studentsAvarage[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten gecti.");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı.");
                }
            }




            #endregion
            Console.Read();

        }
    }
}
