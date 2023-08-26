using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Aritmatika
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Penjumlahan = +
             2. Pengurangan = -
             3. Perkalian = *
             4. Pembagian = /
             5. Modulus atau sisa bagi = %
             */

            // Penjumlahan = +
            //int A = 5;
            //int B = 3;
            //Console.WriteLine(A + B);

            // Membuat Program Sederhana
            int A;
            int B;
            Console.WriteLine("Masukan Angka1:");
            A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Masukan Ankga2:");
            B = Convert.ToInt16(Console.ReadLine());
            double aDbl = Convert.ToDouble(A);
            double bDbl = Convert.ToDouble(B);
            Console.WriteLine("Hasil dari A + B = " + Convert.ToInt16(A + B));
            Console.WriteLine("Hasil dari A - B = " + Convert.ToInt16(A - B));
            Console.WriteLine("Hasil dari A * B = " + Convert.ToInt16(A * B));
            Console.WriteLine("Hasil dari A / B = " + Convert.ToDouble(aDbl / bDbl));
            Console.WriteLine("Hasil dari A % B = " + Convert.ToInt16(A % B));
        }
    }
}
