using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 Double Değişkenler

            Console.WriteLine("***** Fiayt Listesi *****");
            Console.WriteLine();

            double applePrice = 14.85;
            double orangePrice = 20.95;
            double strawberryPrice = 45;
            double potatoPrice = 9.74;
            double tomatoPrice = 6.88;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"---- Elma Birim Fiyatı: {applePrice}" + " TL");
            Console.WriteLine($"---- Portakal Birim Fiyatı: {orangePrice}" + " TL");
            Console.WriteLine($"---- Çilek Birim Fiyatı: {strawberryPrice}" + " TL");
            Console.WriteLine($"---- Patates Birim Fiyatı: {potatoPrice}" + " TL");
            Console.WriteLine($"---- Domates Birim Fiyatı: {tomatoPrice}" + " TL");

            Console.WriteLine();

            double appleGram = 1.245;
            double orangeGram = 2.650;
            double strawberryGram = 0.750;
            double potatoGram = 4.859;
            double tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine($"Alınan Ürün: Elma" + "-- Birim Fiyat: " + applePrice + "-- Gramaj: "
                + appleGram + "-- Toplam Tutar: " + appleTotalPrice);

            Console.WriteLine($"Alınan Ürün: Portakal" + "-- Birim Fiyat: " + orangePrice + "-- Gramaj: "
                + orangeGram + "-- Toplam Tutar: " + orangeTotalPrice);

            Console.WriteLine($"Alınan Ürün: Çilek" + "-- Birim Fiyat: " + strawberryPrice + "-- Gramaj: "
                + strawberryGram + "-- Toplam Tutar: " + strawberryTotalPrice);

            Console.WriteLine($"Alınan Ürün: Patates" + "-- Birim Fiyat: " + potatoPrice + "-- Gramaj: "
                + potatoGram + "-- Toplam Tutar: " + potatoTotalPrice);

            Console.WriteLine($"Alınan Ürün: Domates" + "-- Birim Fiyat: " + tomatoPrice + "-- Gramaj: "
                + tomatoGram + "-- Toplam Tutar: " + tomatoTotalPrice);

            Console.WriteLine();
            Console.WriteLine();

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + potatoTotalPrice + tomatoTotalPrice + strawberryTotalPrice;

            Console.WriteLine($"Alışveriş Toplam Tutar: {shoppingTotalPrice}");


            #endregion

            #region 2 Klavyeden Veri Girişleri

            Console.WriteLine("**** C# Hava Yolları Yolcu Bilgisic ****");
            Console.WriteLine();


            string passengerName, passengerSurname, passengerDistrict,
                passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("------------------------------");

            Console.WriteLine($"Yolcu TC Kimlik No: {passengerIdentityNumber} - Yolcu Ad Soyad: {passengerName} {passengerSurname} {passengerDistrict} / {passengerCity} {passengerAge}");

            #endregion

            #region 3 Dönüşümler

            int shoesPrice, computerPrice, chairPrice, tvPrice;

            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldıgınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldıgınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldıgınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldıgınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice +
                chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine($"Toplam Ödemeniz Gereken Tutar: {totalPrice}");

            #endregion

            #region 4 Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            Console.Write("1. Sınav Notunu Girin: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("2. Sınav Notunu Girin: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3. Sınav Notunu Girin: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine($"Sınav Ortalamanız: {result}");

            #endregion

            Console.ReadKey();
        }
    }
}
