using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //()
            //geriye veri döndürmeyen //void //Listele,ekle,çıkar
            //geriye veri döndüren

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız.");
            //    Console.WriteLine("Berra Akpınar.");
            //    Console.WriteLine("Ceren Limon.");
            //}

            //customerList();
            //void sum()
            //{
            //    int x = 12;
            //    int y = 32;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();
            #endregion
            #region GERİYE DEĞER DÖNDÜRMEYEN METOTLAR

            //void customerCard(string name,string surname,int old)
            //{
            //    Console.WriteLine("müsterinin adı soyadı "+name+" "+surname+" yaşı "+old);
            //}

            //customerCard("ali", "yıldız", 12);
            #endregion
            #region Geriye değer döndüren metot
            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard()
            //);            
            #endregion
            #region Geriye değer döndüren parametreli metot
    
            //string countryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardinfo = "Ülke:" + countryName + "- Başkent:" + capital + "- Bayrak Rengi:" + flagColor;
            //    return cardinfo;
            //}
            //string x, y, z;
            //Console.Write("ülke adını gir: ");
            //x = Console.ReadLine();

            //Console.Write("başkentin adını gir: ");
            //y = Console.ReadLine();

            //Console.Write("bayrak rengini gir: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));
            #endregion
            Console.Read();
        }
    }
}
