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
            #region If Else
            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
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

            //if(capital=="ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Bilgiler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3,avarage;
            //string result="Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + avarage);

            //if(avarage>0 & avarage <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(avarage>50 & avarage <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(avarage>70 & avarage <= 84)
            //{
            //    result = "Sonuç orta";
            //}
            //if (avarage > 84)
            //{
            //    result = "Sonuç Çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();
            //if(city=="adana" | city=="ankara" | city=="bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez ");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            //}
            #endregion

            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("Birinci sayının ikinci sayıya bölümünden kalan: "+result);

            //char team;
            //Console.Write("Takım giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team=='G'| team == 'g')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team=='F' | team == 'f')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if(team=='B' | team == 'b')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje uygulamaları
            //Console.WriteLine("*******C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write(" detayını görmek istediğiniz men" +
            //    " seçimi:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Ana Yemekler-----------");
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Karnıbahar");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Çorbalar---------");
            //    Console.WriteLine("1-Ezogelin");
            //    Console.WriteLine("2-Mercimek");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Pizzalar------");
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Ton Balıklı");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------İçecekler---------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Fanta");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Tatlılar---------");
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Künefe");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız:");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    default: Console.Write("Hatalı Veri girişi"); break;
            //
            #endregion

            #region Switch case hesap makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("İşlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma: " + result);
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
