using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // convert class adalah mengubah tipe data ke tipe data lainnya
            int A;
            Console.WriteLine("Masukan Angka:");
            A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Angka: " + A);

            //kita coba jumlahkan
            int B;
            Console.WriteLine("Masukan Nilai B:");
            B = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(A + B);
        }
    }
}
