using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fungsi_dengan_return
{
    class Program
    {
        static void Main(string[] args)
        {
            int tambah(int a, int b)
            {
                return a + b;
            }
            int kurang(int a,int b)
            {
                return a - b;
            }
            //int hasil = tambah(5, 5) + 10;

            int hasil = tambah(kurang(15, 5), 5) + 10; // 10 + 5 + 10 = 25

            bool ApakahLulus(int nilai)
            {
                if (nilai < 78)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            Console.Write("Masukan nilai: ");
            int _nilai = Convert.ToInt32(Console.ReadLine());
            if (ApakahLulus(_nilai))
            {
                Console.WriteLine("Kamu Lulus!!");
            }
            else
            {
                Console.WriteLine("Kamu Tidak Lulus");
            }

            //Console.WriteLine(hasil);
        }
    }
}
