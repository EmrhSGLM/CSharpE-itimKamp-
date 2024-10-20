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
            #region Void Methodlar

            // () --> Method oldugunu belirtir
            // Methodlar 2'yr ayrilir
            // 1- Geriye deger döndürmeyen methodlar
            // Bunlara void nethodlar denir
            // Customer --> Listele, ekle, Sil, Güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Kemal");
            //    Console.WriteLine("Veli Cemal");
            //    Console.WriteLine("Hakan Deneme");
            //    Console.WriteLine("Kamil Dev");
            //}

            //// Method Call
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 1;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion

            #region Geriye değer döndürmeyen string parametreli methodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Emrah Saglam");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri \nAdi    : {name} \nSoyadı : {surName}");
            //}

            //CustomerCard("Emrah", "Saglam");


            #endregion

            #region Geriye değer döndürmeyen int parametreli methodlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 +number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren methodlar , return

            //string CustomerName()
            //{
            //    return "Emrah Saglam";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Hakkı";
            //    string surname = "Tuna";

            //    return name +" " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye deger döndüren string parametreli methodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke : " + countryName + " - Başkent : " + capital + " - Bayrak Rengi : " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adini giriniz : ");
            //x=Console.ReadLine();

            //Console.Write("Başkent adini giriniz : ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz : ");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine();
            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));

            #endregion

            #region Geriye deger döndüren int parametreli methodlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));


            #endregion

            #region Örnek uygulama

            //string ExamResult(string studentName, string lesson, int exam1, int exam2, int exam3)
            //{
            //    Console.WriteLine("\n----------------------------\n");
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result >= 50)
            //    {
            //        return $"Ortalama : {result}\n{studentName} isimli öğrenci {lesson} dersinden geçti";
            //    }
            //    else
            //    {
            //        return $"Ortalama : {result}\n{studentName} isimli öğrenci {lesson} dersinden kaldi.";
            //    }
            //}
            //Console.WriteLine(ExamResult("Hamza", "Matematik", 34, 54, 78));
            //Console.WriteLine(ExamResult("Ayhan", "Fizik", 12, 21 , 78));

            #endregion

            Console.Read();
        }
    }
}
