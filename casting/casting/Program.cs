using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // fungsi casting ialah ketika kita mau menetapkan dari suatu tipe datadata ke tipe data lainnya seperti class maupun enum

            //int a = 2.5;
            //int b = 2;
            //int hasil = a + b;

            // kode diatas akan error karena kita tidak bisa menghubah integer ke double

            // solusinya kita convert terlebih dahulu menggunakan casting
            // contoh :
            // perhatikan kode dibawah ini :
            double a = 2.5;
            int b = 2;
            int hasil = (int)a + b;
            Console.WriteLine(hasil);

            // tetapi disini terjadi masalah kita tidak bisa mengubah tipe data numeric ke tipe data string dengan casting 
        }
    }
}
