using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR DÖNGÜ

            //int i;
            //for (i = 0; i <=20; i++)
            //{
            //    Console.Write(i);
            //}
            //for (int i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Write("Lütfen ekranda kaç kere yazdırmak istediğiniz sayıyı giriniz: ");
            //int sayac = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= sayac; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion
            #region FOR DÖNGÜLERİ İLE KARAR YAPILARI
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 5 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //int totalvalue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0) { 
            //    totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(totalvalue);
            //int count = 0;
            //for (int i = 0; i <=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);
            //int bakteri=1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ". saatte " + bakteri + " bakteri oluştu");
            //}

            #endregion
            #region WHİLE DÖNGÜSÜ
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i+".adım - "+"merhbalarrr");
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
            #region SINAV SORUSU
            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yaz.
            //Console.Write("lütfen üç basamaklı sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            ////134
            //int ones, tens, hundreds;
            //int sum;


            //hundreds = sayi / 100;
            //Console.WriteLine("yüzler basamağı: " + hundreds);
            //tens = sayi / 10 % 10;
            //Console.WriteLine("onlar basamağı: " + tens);
            //ones = sayi % 10;
            //Console.WriteLine("birler basamağı: "+ones);

            //sum = ones + tens + hundreds;
            //Console.WriteLine("basamak değerlerin toplamı: "+sum);

            #endregion
            Console.ReadLine();
        }
    }
}
