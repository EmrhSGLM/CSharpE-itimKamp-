using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x;y;z)
            // x : başlangıç
            // y : bitiş
            // z : artış-azalış

            //int i;

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampi");
            //}

            //for (int i = 1; i <= 20; i ++)
            //{
            //       Console.Write(i + " "); // Output : 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.Write(i + " "); // Output : 3 6 9 12 15 18 21 24 27 30 33 36 39 42 45 48
            //}

            //Console.Write("Lütfen ekrana yazilmasini istediginiz adedi yaziniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşaşın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            // 1 den 100'e kadar 5'e bolunen sayilari console yazdiriniz
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //1 den 10'a kadar olan sayıları toplayınız
            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine("totalValue: " + totalValue);

            // 1'den 20'e kadar olan çift sayilarin toplami
            //int totalValue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }
            //}
            //Console.WriteLine("totalValue: " + totalValue);

            //1 ile 50 arasında 7'e tam bolunen kac tane sayi vardir ?
            //int count = 0;
            //for (int i = 1; i < 51; i++)
            //{
            //    if (i % 7 == 0) count++;
            //}
            //Console.WriteLine("count: " + count);

            // 1 bakteri turu her saatin sonunda kendini 2'ye bolerek cogaliyor.
            // Başlangicta 1 bakteri olduguna göre, 24 saatin sonunda kac bakteri vardir
            //int bacteriomCount = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteriomCount = bacteriomCount * 2; //bacteriomCount *=  2;
            //    Console.WriteLine(i + ". saatin sonunda bakteri sayisi: " + bacteriomCount);
            //}


            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //    İşlemler
            //}
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            // 1 den 10 a kadar 3 e bolunen sayilar
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            // 1 den 10 a kadar olan sayilari toplami
            //int i = 1;
            //int sum = 0;
            //while (i < 11)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);




            #endregion

            #region Projects

            //klavyeden girilen 3 basamaklı sayinin basamaklari
            //toplamini hesaplayan kodu yaziniz 
            //Console.Write("Lutfen 3 basamakli sayi giriniz : ");
            //int number = int.Parse(Console.ReadLine());
            //int firstNumber = number;
            //int ones, tens, hundreds;
            //int sum = 0;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
            //Console.WriteLine(ones);
            //Console.WriteLine(tens);
            //Console.WriteLine(hundreds);
            //sum = ones + tens + hundreds;

            //while (number != 0)
            //{
            //    sum += number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine("Girilen sayisinin rakamlari toplami : " + sum);

            #endregion




            Console.Read();
        }
    }
}
