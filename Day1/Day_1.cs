using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restoran Menüsü
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerPrices= 300;
            int pizzaPrices = 250;
            int cokePrices = 35;
            int lemonadePrices = 30;
            int friesPrices = 50;
            int waterPrices = 10;

            Console.WriteLine("Hamburger:" + hamburgerPrices + " TL");
            Console.WriteLine("Pizza: " + pizzaPrices + " TL");
            Console.WriteLine("Kola: " + cokePrices + " TL");
            Console.WriteLine("Limonata: " + lemonadePrices + " TL");
            Console.WriteLine("Kızartma: " + friesPrices + " TL");
            Console.WriteLine("Su: " + waterPrices + " TL");

            Console.WriteLine();

            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");

            int hamburgerCount = 3;
            int pizzaCount = 0;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int lemonadeCount = 0;

            int totalHamburgerPrices = hamburgerPrices * hamburgerCount;
            int totalPizzaPrices= pizzaPrices * pizzaCount;
            int totalFriesPrices= friesPrices * friesCount;
            int totalCokePrices= cokePrices * cokeCount;
            int totalLemonadePrices= lemonadePrices * lemonadeCount;
            int totalWaterPrices= waterPrices * waterCount;

            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrices + " TL");
            Console.WriteLine("Pizza TUtarı: " + totalPizzaPrices + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrices + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrices + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrices + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrices + " TL");

            int totalPrices = totalHamburgerPrices + totalPizzaPrices + 
                totalFriesPrices + totalCokePrices + totalLemonadePrices + totalWaterPrices;

            Console.WriteLine();

            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrices + " TL");

            Console.ReadKey();

            #endregion
                
        }
    }
}
