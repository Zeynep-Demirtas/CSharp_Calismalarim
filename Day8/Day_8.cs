using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 Void metotlar (Geriye değer döndürmeyen metotlar)
            {
                {
                    //() olanlar metottur
                    //Geriye değer döndürmeyen metotlar
                    //Customer--> Listele, ekle, sil, güncelle
                    //Void

                    void CustomerList()
                    {
                        Console.WriteLine("Ali Yıldız");
                        Console.WriteLine("Ayşe Yıldız");
                        Console.WriteLine("Hakan Öztürk");
                        Console.WriteLine("Merve Çınar");
                    }

                    CustomerList();
                }

                {
                    void Sum()
                    {
                        int x = 1;
                        int y = 2;
                        int z = x + y;
                        Console.WriteLine(z);
                    }

                    Sum();
                }

            }
            #endregion

            #region 2 Geriye değer döndürmeyen string parametreli metotlar
            {
                {
                    void WriteMethod(string customerName)
                    {
                        Console.WriteLine(customerName);
                    }

                    WriteMethod("Mehmet Yıldırım");
                }

                {
                    void CustomerCard(string name, string surName)
                    {
                        Console.WriteLine("Müşteri: " + name + " " + surName);
                    }

                    CustomerCard("Mehmet", "Yıldız");
                    CustomerCard("Ayşegül", "Kaya");
                }
            }
            #endregion

            #region 3 Geriye değer döndürmeyen int parametreli metotlar
            {
                {
                    void Sum(int number1,int number2,int number3)
                    {
                        int result = (number1 + number2 + number3);
                        Console.WriteLine(result);
                    }

                    Sum(4, 5, 6);
                }
            }
            #endregion

            #region 4 Geriye değer döndüren metotlar
            {
                {
                    string CustomerName()
                    {
                        return "Buse Yıldız";
                    }
                }

                {
                    string StudentCard()
                    {
                        string name = "Ali";
                        string surname = "Kaya";

                        return name + " " + surname;
                    }

                    Console.WriteLine(StudentCard());
                }
            }
            #endregion

            #region 5 Geriiye değer döndüren string parametreli metotlar
            {
                {
                    string CountryCard(string name, string capital, string flagColor)
                    {
                        string cardInfo = "Ülke: " + name + " --Başkent: " + capital + " --Bayrak Rengi: " + flagColor;
                        return cardInfo;
                    }

                    string x, y, z;

                    Console.Write("Ülke adını giriniz: ");
                    x = Console.ReadLine();

                    Console.Write("Başkentini giriniz: ");
                    y = Console.ReadLine();

                    Console.Write("Bayrak Rengini giriniz: ");
                    z = Console.ReadLine();

                    Console.WriteLine(CountryCard(x, y, z));
                    Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
                }
            }
            #endregion

            #region 6 Geriye değer döndüren int parametreli metotlar
            {
                {
                    int Sum(int number1, int number2)
                    {
                        int result = number1 + number2;
                        return result;
                    }

                    Console.WriteLine(Sum(45, 98));
                    Console.WriteLine(Sum(36, 25));
                    Console.WriteLine(Sum(44, 36));
                    Console.WriteLine(Sum(14, 20));
                }
            }
            #endregion

            #region 7 Örnek uygulama
            {
                string ExamResult(string studentName, int exam1, int exam2, int exam3)
                {
                    int result = (exam1 + exam2 + exam3) / 3;
                    if (result >= 50)
                    {
                        return studentName + " " + "isimli öğrenci sınavı geçti -- Ortalama: " + result;
                    }
                    else
                    {
                        return studentName + " " + "isimli öğrenci başarısız oldu -- Ortalama: " + result;
                    }
                }

                Console.WriteLine(ExamResult("Ali", 25, 41, 55));
                Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            }
            #endregion

            Console.ReadKey();
        }
    }
}
