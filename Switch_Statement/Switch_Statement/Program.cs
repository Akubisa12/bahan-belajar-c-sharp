using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat program sederhana
            int jurusan;
            Console.WriteLine("Pilih Jurusan: ");
            Console.WriteLine("1. RPL");
            Console.WriteLine("2. TKJ");
            Console.WriteLine("3. Multimedia");
            jurusan = Convert.ToInt32(Console.ReadLine());
            switch (jurusan)
            {
                case 1:
                    Console.WriteLine("Pelajarannya adalah Pemrograman");
                    break;
                case 2:
                    Console.WriteLine("Pelajarannya adalah Komputer dan Jaringan");
                    break;
                case 3:
                    Console.WriteLine("Pelajarannya adalah Desain grafis");
                    break;
                default:
                    Console.WriteLine("Jurusan tidak ada!");
                    break;
            }
        }
    }
}
