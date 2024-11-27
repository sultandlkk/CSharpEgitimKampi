using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri
            //DeğişkenTürü[] DiziAdi=new DeğişkenTürü[eleman sayısı]

            //string[] Colors = new string[4];
            //Colors[0 ]= "Kırmızı";
            //Colors[1] = "Sarı";
            //Colors[2] = "Mavi";
            //Colors[3] = "Beyaz";

            //Console.WriteLine(Colors[1]);
            //string[] cities = new string[81];
            //cities[0] = "Adana";
            //cities[1] = "Adıyaman";
            //cities[2] = "Ardahan";
            //cities[3] = "Ağrı";
            //cities[4] = "Aydın";
            //cities[5] = "Balıkesır";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 34;
            //numbers[2] = 56;
            //numbers[7] = 98;

            //Console.WriteLine(numbers[4]);//tanımlanmamış dizeyi çağırırsak otomatik 0 değerini atar.

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };





            #endregion
            #region Dizideki Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "beyaz", "Mavi", "Yeşil", "turuncu", "Pembe" };
            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] number = { 4, 87, 96, 125, 11, 45, 32 };
            //for(int i = 0; i < number.Length; i++)
            //    if (number[i]%3!=0)
            //{
            //        Console.WriteLine(number[i]);
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/' };
            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 12, 32, 56, 798, 65, 43, 1, 23, 4, 55, 656, 677, 55, 64, 6 };
            //int MaxNumber = numbers[0];

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > MaxNumber)
            //    {
            //        MaxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(MaxNumber);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region dizi metotları
            //string[] customers = { "ali", "buse", "ceren" };
            //int index = Array.IndexOf(customers, "baran");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 65, 78, 57, 49, 32, 456, 2, 34, 56, 7, 778 };
            //Console.WriteLine("dizinin en büyük değeri: " + numbers.Max() + " \ndizinin en küçük elemanı: " + numbers.Min());

            #endregion
            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i]=Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.şehir "+cities[i]);
            //}
            //int[] numbers = { 1,2,3,4,5,6,7,8,9,0 };
            //Console.WriteLine("çift sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("+++++++++++++++++++++++++++++++++");
            //Console.WriteLine("tek sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
            Console.Read();
        }

    }
}
