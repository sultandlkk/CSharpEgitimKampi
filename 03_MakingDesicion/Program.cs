using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF Else
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");

            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("başkentinizi giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("ülkenizi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //    Console.WriteLine("bilgiler doğru");
            //else
            //{
            //    Console.WriteLine("hatalı giriş");
            //}

            //int number;
            //Console.WriteLine("sayı giriiniz");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayi doğrudur");
            //}
            //else
            //{
            //    Console.WriteLine("sayi yanlişş");
            //}

            //int exam1, exam2, exam3, average;
            //string result="hatalı girişller";

            //Console.WriteLine("sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması: " + average);

            //if(average>0 & average <= 50)
            //{
            //    result="sonuç berbattt";

            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç ehh";

            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "iyi işte";

            //}
            //if (average > 84)
            //{
            //    result = "very delicionss";

            //}
            //Console.WriteLine(result);//ilk değer olmadığı için gösteriyor

            //string city;
            //Console.Write("şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");

            //}

            #endregion

            #region MOD İŞLEMLERİ
            //int number;
            //number = 26;
            //int sonuc = number % 3;
            //Console.WriteLine(sonuc);

            //Console.Write("lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.sayının 2.sayıya bölümünden kalan: "+ result);

            //Console.Write("lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("sayı çift");
            //}
            //else
            //{
            //    Console.Write("sayı tektir");
            //}

            //char team;
            //Console.Write("bir harf giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if(team =='g' | team== 'G')
            //{
            //    Console.Write("sen halis muhlis GALATASARAYLISINN");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.Write("sen halis muhlis FENERBAHÇELİSİN");
            //}
            //else if(team == 'b' | team == 'B')
            //{
            //    Console.Write("sen halis muhlis BEŞİKTAŞKLISIN");
            //}
            //else if(team == 't' | team == 'T')
            //{
            //    Console.Write("sen halis muhlis TRABZONSPORLUSUN uşağum");
            //}
            //else
            //{
            //    Console.Write("seni ben çözemedim");
            //}
            #endregion

            #region ÖRNEK UYGULAMA

            //Console.WriteLine("****#C eğitim kampı****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("1-ANA YEMEKLER");
            //Console.WriteLine("2-ÇORBALAR");
            //Console.WriteLine("3-SALATALAR");
            //Console.WriteLine("4-TATLILAR");
            //Console.WriteLine("5-İÇECEKLER");
            //Console.WriteLine("-------------------------");

            //string menuItem;
            //Console.Write("Hangi kategori sayı seçiniz:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("--------ANA YEMEKLER------");
            //    Console.WriteLine("1.Köri soslu tavuk\n2.Etliekmek\n3.Adana Kebap\n4.Lahmacun");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("--------Çorbalar------");
            //    Console.WriteLine("1.Tavuk Çorbası\n2.Domates Çorbası\n3.Kelle Paça\n4.Mercimek Çorbası");

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("--------SALATALAR------");
            //    Console.WriteLine("1.Akdeniz Salatası\n2.Çoban Salata\n3.Patates Salatası\n4.Makarnalı Salata");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("--------ANA YEMEKLER------");
            //    Console.WriteLine("1.Tavuk Göğsü\n2.Sütlaç\n3.Şekerpare\n4.Dondurmalı Helva");

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("--------ANA YEMEKLER------");
            //    Console.WriteLine("1.Ayran\n2.Soda\n3.Kola\n4.Şalgam");

            //}




            #endregion

            #region SWİTCH CASE
            //Console.Write("Lütfen ay giriniz:");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("hatalı giriş"); break;

            //}
            #endregion
            #region SWİTCH CASE HESAP MAKİNESİ
            int n1, n2, result;
            char symbol;

            Console.Write("ilk sayıyu giriniz:");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("ikinci sayıyu giriniz:");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("yapmak istediğiniz işlemi seçiniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = n1 + n2;
                    Console.WriteLine("Toplam sonucu:" + result);
                    break;

                case '-':
                    result = n1 - n2;
                    Console.WriteLine("Çıkarma sonucu:" + result);
                    break;

                case 'x':
                    result = n1 * n2;
                    Console.WriteLine("Çarpım sonucu:" + result);
                    break;
                case '/':
                    result = n1 / n2;
                    Console.WriteLine("Bölüm sonucu:" + result);
                    break;
                default: Console.WriteLine("geçersiz değerrr"); break;

            }


            #endregion





            Console.Read();
        }
    }
}
