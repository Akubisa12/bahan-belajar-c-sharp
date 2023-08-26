using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mengambil_Input_User
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            Console.WriteLine("Siapa Namamu:");
            nama = Console.ReadLine();
            //ReadLine adalah fungsi untuk mengambil input dari user
            //ReadLine hanya bisa memasukan input berupa string
            Console.WriteLine("Namamu adalah: " + nama);
        }
    }
}
