using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 - Kategori Ekleme İşlemi
            {
                // Crud --> Create-Read-Update-Delete

                Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
                Console.WriteLine("");

                Console.WriteLine("---------------------------");
                Console.Write("Eklemek İstediğiniz Kategori Adı: ");
                string categoryName = Console.ReadLine();

                SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;" +
                    "initial catalog=EgitimKampiDb;integrated security = true");

                connection.Open();
                SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
                command.Parameters.AddWithValue("@p1", categoryName);
                command.ExecuteNonQuery(); //Sorguyu koşulsuz bir şekilde çalıştırır.
                                           //Sorgudan herhangi bir sonuç beklenmez.
                connection.Close();

                Console.Write("Kategori başarıyla eklendi!");

            }
            #endregion

            #region 2 Ürün Ekleme İşlemi
            {
                Console.WriteLine();
                Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
                Console.WriteLine();

                Console.WriteLine("---------------------------");
                string productName;
                decimal productPrice;
                //bool productStatus;

                Console.Write("Eklemek İstediğiniz Ürün Adı: ");
                productName = Console.ReadLine();

                Console.Write("Eklemek İstediğiniz Ürün Fiyatı: ");
                productPrice = decimal.Parse(Console.ReadLine());

                SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;" +
                    "Initial Catalog = EgitimKampiDb; integrated security = true");
                connection.Open();
                SqlCommand command = new SqlCommand("insert into TblProduct(ProductName, ProductPrice, " +
                    "ProductStatus) values(@productName, @productPrice, @productStatus)", connection);
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@productPrice", productPrice);
                command.Parameters.AddWithValue("@productStatus", true);
                command.ExecuteNonQuery();

                connection.Close();

                Console.Write("Ürün başarıyla eklendi!");

            }
            #endregion

            #region 3 Ürün Listeleme İşlemi
            {
                Console.WriteLine();
                Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
                Console.WriteLine();

                Console.WriteLine("---------------------------");
                SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;" +
                    "Initial Catalog = EgitimKampiDb; integrated security = true");

                connection.Open();
                SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command); //SQL'den verileri C#'a çekebilmek için kullanılır.
                                                                      //Verileri doldurmak için kullanılır.
                DataTable dataTable = new DataTable();//Verileri geçici olarak tutmak için kullanılır.
                                                      //Verileri tablo formatında tutar.
                adapter.Fill(dataTable); //Verileri doldurur.
                                         //SQL'den çekilen verileri DataTable'a doldurur.

                foreach (DataRow row in dataTable.Rows) //DataTable'daki her bir satırı temsil eder.
                    //DataRow, DataTable'daki bir satırı temsil eder.
                //Verileri kullanıcıya göstermek için kullanılır.
                {
                    foreach (var item in row.ItemArray) //Satırdaki her bir hücreyi temsil eder.
                                                        //ItemArray, DataRow'daki hücrelerin değerlerini içeren bir dizi döndürür. 
                                                        //Verileri kullanıcıya göstermek için kullanılır.
                    {
                        Console.Write(item.ToString() + " "); // toString() metodu, nesnenin string temsilini döndürür.
                        //Verileri kullanıcıya göstermek için kullanılır.
                    }
                    Console.WriteLine();
                }

                connection.Close();
            }
            #endregion

            #region 4 Ürün Silme İşlemi
            {
                Console.WriteLine();
                Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
                Console.WriteLine();

                Console.WriteLine("---------------------------");

                Console.Write("Silinecek Ürün Id'si: ");
                int productId = int.Parse(Console.ReadLine());
                SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;" +
                    "Initial Catalog = EgitimKampiDb; integrated security = true");

                connection.Open();

                SqlCommand command = new SqlCommand("Delete From TblProduct Where[Product Id] = @ProductId",connection);
                command.Parameters.AddWithValue("@productId", productId);
                command.ExecuteNonQuery();

                connection.Close();

                Console.WriteLine("Silme İşlemi Yapıldı!");

            }
            #endregion

            #region 5 Ürün Güncelleme İşlemi
            {
                Console.WriteLine();
                Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
                Console.WriteLine();

                Console.WriteLine("---------------------------");
                
                Console.Write("Güncellenecek Ürün Id'si: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Güncellenecek Ürün Adı: ");
                string productName = Console.ReadLine();

                Console.Write("Gücellencek Ürün Fiyatı: ");
                decimal productPrice = decimal.Parse(Console.ReadLine());

                SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;" +
                    "Initial Catalog=EgitimKampiDb;integrated security=true");

                connection.Open();
                SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@ProductName, " +
                    "ProductPrice=@ProductPrice Where [Product Id]=@ProductId", connection); //Köşeli parantez kullanımı,
                //SQL sorgularında sütun adlarında boşluk veya özel karakterler varsa kullanılır.
                //Bu şekilde SQL, sütun adını doğru şekilde tanır.

                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@ProductPrice", productPrice);
                command.Parameters.AddWithValue("@ProductId", productId);
                command.ExecuteNonQuery();

                connection.Close();

                Console.WriteLine("Güncelleme İşlemi Yapıldı!");

            }
            #endregion
            Console.ReadKey();
        }
    }
}
