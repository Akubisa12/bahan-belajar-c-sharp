using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void
{
    class Program
    {
        static void Main(string[] args)
        {
            // void 
            // biasa disebut method / function


            //tampilkan();
            //void tampilkan()
            //{
            //for(int i = 0; i < 5; i++)
            //{
            //Console.WriteLine("Hallo semuanya");
            //}
            //}

            // jika void tampilkan kita letakan diluar void main maka akan terjadi error :  An object reference is required for the-non-static
            // field, mthod, or property 'Program.tampilkan()"
            // solusinya adalah tambahkan keyword static dibelakang void tampilkan

            //menggunakan params
            //penjumlahan(20, 5);
            //kuadrat(5);
            //pembagian(45, 3);

            // menjalankan program sederhana
            login();
        }

        static void penjumlahan(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void kuadrat(int a)
        {
            Console.WriteLine("Kuadrat dari " + a + " adalah " + a * a);
        }

        static void pembagian(double a, double b)
        {
            Console.WriteLine(a + " dibagi " + b + " = " + a / b);
        }

        // membuat program sederhana
        static void login()
        {
            string username = "";
            string password = "";
            while(username != "admin" && password != "admin")
            {
                Console.Write("Username: ");
                username = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();
                if(username != "admin" && password != "admin")
                {
                    Console.WriteLine("username atau password salah!");
                    Console.Clear(); // fungsi nya : membersihkan program console
                }
                if(username == "admin" && password == "admin")
                {
                    Console.WriteLine("Selmaat datang admin!");
                }
            }
        }
    }
}
