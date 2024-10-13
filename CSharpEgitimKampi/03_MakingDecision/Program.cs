using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If


            //string password;
            //Console.Write("Lutfen sifrenizi giriniz: ");
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            ////if (capital.ToLower()=="ankara" & country.ToLower()=="türkiye")
            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandi.");
            //}else
            //{
            //    Console.WriteLine("hatali veri");
            //}

            //int sayi;
            //Console.Write("Sayi giriniz");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayi dogru");
            //}else
            //{
            //    Console.WriteLine("Sayi hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "";

            //Console.Write("Sınav1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sinavlarin Ortalamasi: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lutfen sehir ismi giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lutfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}

            #endregion

            #region Mod islemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lutfen 1.sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2.sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. Sayinin 2.Sayiya bölümünden kalan: " + result);

            //Console.Write("Lutfen sayiyi giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayi çift sayidir ... ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi tek sayidir ... ");
            //}

            #endregion

            #region Char Değişkenler ile Karar

            //char team;
            //Console.WriteLine("Lutfen takım sembolunu giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}


            #endregion

            #region Ornek Proje Uygulamasi

            //Console.WriteLine("***** C# Eğitim Kampi Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçeçekler");
            //Console.WriteLine("5- Tatlilar");
            //Console.WriteLine("--------------------------------");


            //string menuItem;
            //Console.Write("Detayi görmek istediginiz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------- Ana Yemekler -------------------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartm Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("--------------- Ana Yemekler -------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------- Çorbalar -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Merimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("--------------- Çorbalar -------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------- Pizzalar -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("--------------- Pizzalar -------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------- İçeçekler -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("--------------- İçeçekler -------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------- Tatlilar -------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Traliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("--------------- İçeçekler -------------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay grişi yapiniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatali veri girişi"); break;
            //}


            #endregion

            #region Switch case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayiyi Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayiyi Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen yapmak istediğiniz işlemi seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark : " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm : " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı işlem");
            //        break;
            //}

            #endregion

            Console.Read();

        }
    }
}
