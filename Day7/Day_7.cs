using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü
            {

            //1: Değişken türü
            //2: Değişken adı
            //3: In
            //4: Liste, Koleksiyon, Dizi Adı

            string[] cities = { "Milano", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            foreach(string x in cities)
            {
                Console.WriteLine(x);
            }

            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 2 * 5, 6578, 10394 };

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 2 * 5, 6578, 10394 };

            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 2 * 5, 6578, 10394 };

            int total = 0;

            foreach(int i in numbers)
            {
                total+= i;
            }

            Console.WriteLine(total);

            List<int> numbers = new List<int>()
            {
                1,2,3,4,5,8
            };

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            } //Foreach döngüsü sadece diziler için değil listeleri yazdırmak için de kullanılır

            string word = "Merhaba";

            foreach(char c in word) // Her bir karakteri tek tek yazar
            {
                Console.WriteLine(c);
            }

            }
            #endregion

            #region 2 Örnek sınav sistemi uygulaması
            {

            Console.Write("***** C#Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("---------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            //Öğrenci isimleri ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini girin: ");
                studentNames[i]=Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu girin: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav ortalaması
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if(studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("---------------------------------");
            }

            }
            #endregion

            Console.ReadKey();
        }
    }
}


