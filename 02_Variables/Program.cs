using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //////double number;
            //////number = 4.65;
            ////Console.WriteLine(number);

            //Console.WriteLine("****Fiyat Listesi****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;
            //applePrice = 20.95;
            //orangePrice = 23.65;
            //strawberryPrice = 12.45;
            //potato =23.55;
            //tomato = 6.98;



            //Console.WriteLine("----elma birim fiyatı: " + applePrice + " kuruş");
            //Console.WriteLine("----portakal birim fiyatı: " + orangePrice + " kuruş");
            //Console.WriteLine("----çilek birim fiyatı: " + strawberryPrice + " kuruş");
            //Console.WriteLine("----patates birim fiyatı: " + potato + " kuruş");
            //Console.WriteLine("----domates birim fiyatı: " + tomato + " kuruş");


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 3.456;
            //strawberryGram = 0.567;
            //potatoGram = 10;
            //tomatoGram = 2.345;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Elmanın fiyatı: "+appleTotalPrice); 

            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Portakalın fiyatı: "+ orangeTotalPrice);

            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Çileğin fiyatı: " + strawberryTotalPrice);

            //double potatoTotalPrice = potatoGram * potato;
            //Console.WriteLine("Patatesin fiyatı: " + potatoTotalPrice);

            //double tomatoTotalPrice = tomatoGram * tomato;
            //Console.WriteLine("Domatesin fiyatı: " + tomatoTotalPrice);


            //double Total =appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine("----\n");
            //Console.WriteLine("Toplam Tutar: " + Total);
            #endregion
            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion
            #region Klavyeden Veri Girişleri
            //Console.WriteLine("***CSharp Hava Yolları Yolcu Bilgi***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;


            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();


            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();


            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("----------------");
            //Console.Write("Yolcu: "+passengerName+" "+passengerSurname+" "+passengerAge+" "+" "+passengerIdentityNumber + passengerDistrict+"/"+ passengerCity);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1250;
            //computerPrice = 23750;
            //chairPrice = 500;
            //tvPrice = 12000;

            //int shoecount, computercount, chaircount, tvcount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoecount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computercount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chaircount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //tvcount = int.Parse(Console.ReadLine());

            //int totalPrice = shoecount * shoePrice + computercount * computerPrice + chairPrice * chaircount + tvcount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("sınav ortalamanız: "+result);


            #endregion

            #region Klavyeden Karekter Girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Sectiğiniz cinsiyet: " + gender);
            #endregion
            Console.ReadLine();

            

        }
    }
}
