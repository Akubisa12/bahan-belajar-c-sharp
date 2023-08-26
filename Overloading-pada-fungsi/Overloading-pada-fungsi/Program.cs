using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_pada_fungsi
{
    class Program
    {
        static void Main(string[] args)
        {
            //tambah(5,9.5);
            //tambah(2.5, 5.3);
            //tampilkan("hallo semuanya");
            //tampilkan(6, 2); -> error
            tampilkan(80);
        }
        static void tambah(int a, int b)//penjumlahan bilangan bulat
        {
            Console.WriteLine(a + b);
            Console.WriteLine("Fungsi 1");
        }
        static void tambah(double a, double b) // penjumlahan bilangan pecahan
        {
            Console.WriteLine(a + b);
            Console.WriteLine("Fungsi 2");
        }
        static void tampilkan(int a)
        {
            Console.WriteLine(a);
        }
        static void tampilkan(string a)
        {
            Console.WriteLine(a);
        }

        static void tampilkan(double a)
        {
            Console.WriteLine(a);
        }

        static void tampilkan(char a)
        {
            Console.WriteLine(a);
        }
    }
}
