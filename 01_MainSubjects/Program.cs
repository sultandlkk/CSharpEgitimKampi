using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            ////Console.Write("Merhaba Dünya");
            ////Console.WriteLine("selamm");

            //Console.WriteLine("****yemek kategorileri****");
            //Console.WriteLine();
            //Console.WriteLine("1-Corbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-Salatalar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****yemek kategorileri****");
            #endregion

            #region SringDegiskenler

            //string customerName, customerSurname, customerPhone, customerEmai, district, city;

            //customerName = "ali";
            //customerSurname = "çınar";
            //customerPhone = "+90 573 849 84 45";
            //customerEmai = "deneme@gmail.com";
            //district = "kadıköy";
            //city = "izmir";
            //Console.WriteLine("***Rezevasyon Kartı***");
            //Console.WriteLine();
            //Console.WriteLine("Müşter: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone + "\nEmail: " + customerEmai);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------");


            //customerName = "Ayşegül";
            //customerSurname = "Yılmaz";
            //customerPhone = "+90 546 734 13 38";
            //customerEmai = "deneme1@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("Müşter: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone + "\nEmail: " + customerEmai);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------");

            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice =10;
            int friesPrice = 50;
            int lemonadePrice = 45;

            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("---Kola: " + cokePrice+"TL");
            Console.WriteLine("---Kola: " + cokePrice+"TL");
            Console.WriteLine("---Kola: " + cokePrice+"TL");
      
            Console.WriteLine("---Hamburger: " + hamburgerPrice+"TL");
            Console.WriteLine("---Hamburger: " + hamburgerPrice+"TL");
            Console.WriteLine("---Hamburger: " + hamburgerPrice+"TL");
          
            Console.WriteLine("---Kızartma: " + friesPrice+"TL");
            Console.WriteLine("---Kızartma: " + friesPrice+"TL");
        
            Console.WriteLine("---Limonata: " + lemonadePrice+"TL");
            Console.WriteLine("---Limonata: " + lemonadePrice+"TL");
            Console.WriteLine("---Limonata: " + lemonadePrice+"TL");
            Console.WriteLine();
            Console.WriteLine("****Restoran Menü Fiyatı***");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int lemonCount;

            int totalHamburgerPrice = 0;

            hamburgerCount = 7;
            cokeCount = 5;
            waterCount=12;
            friesCount = 4;
            lemonCount = 9;


            totalHamburgerPrice = hamburgerCount*hamburgerPrice;
            Console.WriteLine("----------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            int totalCokePrice = cokeCount*cokePrice;
            Console.WriteLine("----------------");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            int totalWaterPrice = waterCount*waterPrice;
            Console.WriteLine("----------------");
            Console.WriteLine("su Tutarı: " + totalWaterPrice + "TL");
            int totalfriesPrice = friesCount*friesPrice;
            Console.WriteLine("----------------");
            Console.WriteLine("Kızartma Tutarı: " + totalfriesPrice + "TL");
            int totalLemonadePrice = lemonadePrice*lemonCount;
            Console.WriteLine("----------------");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine();

            int total = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalfriesPrice + totalLemonadePrice;


            Console.WriteLine("toplam ödenecek tutar: "+total+"TL");

            #endregion

            Console.Read();
        }
    }
}
