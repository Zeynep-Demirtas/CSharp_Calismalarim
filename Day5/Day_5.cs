using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 Alt alta 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region 2 Yan yana 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region 3 Alt alta 10 yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}

            #endregion

            #region 4 Dik üçgen

            // for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 5 Ters dik üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 6 Yarım elmas şekli

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k = 4; k >= 1; k--)
            //{
            //    for(int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 7 Baklava dilimi

            ////üst kısım
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j >= 1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++) //ardışık tek sıra halinde yıldız
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            ////alt kısım
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j >= 1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region 8 Piramit

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşluklar: Satır aşağı indikçe azalmalı
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Yıldızlar: Satır aşağı indikçe 1, 3, 5, 7, 9 diye artmalı
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine(); // Satır bittiğinde alta geç
            //}

            #endregion

            #region 9 Ters piramit

            //int n = 5;

            //for (int i = n; i >= 1; i--)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.ReadKey();
        }
    }
}
