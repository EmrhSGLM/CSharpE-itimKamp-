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

            Console.OutputEncoding = Encoding.UTF8;

            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyati:" + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyati:" + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyati:" + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyati:" + potatoPrice + " ₺");
            //Console.WriteLine("---- Domates Birim Fiyati:" + tomatoPrice + " ₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Urun: Elma - " + "Birim Fiyat: " + applePrice + "- Gramaj: " + appleGram + " - Toplam Tutar : " + appleTotalPrice);
            //Console.WriteLine("Alınan Urun: Portakal - " + "Birim Fiyat: " + orangePrice + "- Gramaj: " + orangeGram + " - Toplam Tutar : " + orangeTotalPrice);
            //Console.WriteLine("Alınan Urun: Çilek - " + "Birim Fiyat: " + strawberryPrice + "- Gramaj: " + strawberryGram + " - Toplam Tutar : " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Urun: Patates - " + "Birim Fiyat: " + potatoPrice + "- Gramaj: " + potatoGram + " - Toplam Tutar : " + potatoTotalPrice);
            //Console.WriteLine("Alınan Urun: Domates - " + "Birim Fiyat: " + tomatoPrice + "- Gramaj: " + tomatoGram + " - Toplam Tutar : " + tomatoTotalPrice);

            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alişveriş Toplam Tutari : " + shoppingTotalPrice + " ₺");




            #endregion

            #region Char Değişkenleri

            // ABCDEFGH
            // DEF...
            // TOPLANTI SAAT 20:00'DE
            // string "" char '' tanimlanir
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine("char değişken : " + symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yollari Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adi : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No : " + passengerIdentityNumber + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname +" " + 
            //    passengerDistrict + "/" + passengerCity + " " + passengerAge);



            #endregion

            #region Klavyeden TamSayi Girişleri ve Dönüşümleri

            // ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldiginiz ayakkabi sayisini giriniz :  ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldiginiz bilgisayar sayisini giriniz :  ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldiginiz sandalye sayisini giriniz :  ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldiginiz televizyon sayisini giriniz :  ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice 
            //    + computerCount*computerPrice
            //    + chairCount*chairPrice
            //    + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gerekn Tutar : " + totalPrice);


            #endregion

            #region Klavyeden Ondalikli Sayi İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Dönem Sonu Ortalamasi : " + result); 
            // Virgülden sonra kaç basamak alınacak gösterilecek 

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;

            Console.Write("Lütfen cinsiyet seçiniz : ");
            //try // Exception Deneme
            //{
            //    gender = char.Parse(Console.ReadLine());
            //    Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);

            //}
            //catch (System.FormatException e)
            //{
            //    Console.Write("Hata : " + e);
            //}

            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);


            #endregion

            Console.Read();
        }
    }
}
