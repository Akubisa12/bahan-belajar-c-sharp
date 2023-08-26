using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_While_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            // bentuk while
            //while (kondisi)
            //{
            // code
            // increment
            //}

            //int a = 0;
            //while (a < 5)
            //{
            //Console.WriteLine("Benar bahwa A kurang dari 5");
            //a++;
            //}

            // jika kita letakan a++ diluar looping maka akan terjadi infinite loop(looping tanpa henti)

            //bentuk do while
            //do
            //{

            //} while(true);

            //int a = 0;
            //do
            //{
            //Console.WriteLine("Benar bahwa A kurang dari 5");
            //a++;
            //} //while (a < 5);

            //perbedaan:
            // while : melakukan pengecekan kondisi terlebih dahulu baru melakukan perulangan
            // do while : melakukan perulangan terlebih dahulu kemudian pemeriksaan kondisi/syarat dan jika kondisi tidak terpenuhi maka akan dijalankan minimal sekali.

            //contoh perbedaan while dengan do while
            //int a = 0;
            //do
            //{
            //Console.WriteLine("ini adalah looping do while");
            //} while (a < 0);

            //while (a < 0)
            //{
            //Console.WriteLine("ini adalah looping while");
            //}

            // membuat program sederhana dengan menggunakan do while
            //string username = "";
            //while (username != "admin")
            //{
                //Console.Write("Username:");
                //username = Console.ReadLine();
                //if (username != "admin")
                //{
                    //Console.WriteLine("username tidak ada!!!");
                //}
            //}
        }
    }
}
