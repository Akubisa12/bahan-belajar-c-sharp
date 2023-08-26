using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengkondisian2
{
    class Program
    {
        static void Main(string[] args)
        {
            //if nested => pengokondisian bersarang
            // membuat program sederhana(LOGIN)
            string username;
            string password;
            Console.Write("masukan username: ");
            username = Console.ReadLine();
            if(username == "admin")
            {
                Console.Write("masukan password: ");
                password = Console.ReadLine();

                if (password == "admin")
                {
                    Console.WriteLine("Selamat datang Admin");
                }
                else
                {
                    Console.WriteLine("Password Salah!!!");
                }
            }
            else
            {
                Console.WriteLine("Username Salah!!!");
            }
        }
    }
}
