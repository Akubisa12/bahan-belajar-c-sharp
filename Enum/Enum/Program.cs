using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum hari
        {
            senin,
            selasa,
            rabu, 
            kamis, 
            jumat,
            sabtu,
            minggu,
        }
        // mengubah urutan dari enum
        enum hari2
        {
            senin = 1,
            selasa,
            rabu,
            kamis,
            jumat,
            sabtu,
            minggu,
        }
        // untuk menambahkan nilai ke dalam enum kita bisa menggunakan tanda koma( , )
        // dan hari merupakan indentifier 
        static void Main(string[] args)
        {
            // enum adalah tipe data yang berisi constanta
            // harus membuat diluar fungsi main(tepatnya diatas)

            // coba mendeklarasikan enum
            //hari2 sekarang;
            //sekarang = (hari2)2;
            //Console.WriteLine(sekarang);


            // menampilkan langsung nilai ke dalam enum
            //Console.WriteLine(hari.senin);
            hari2 sekarang;
            sekarang = (hari2)Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sekarang);

            tampilkanhari(sekarang);

            // mengunakan if 
            //if(sekarang == hari.rabu)
            //{
                //Console.WriteLine("Sekarang hari rabu");
            //}

            //membuat fungsi dengan switch dengan params enum
            void tampilkanhari(hari2 _sekarang)
            {
                int i = (int)sekarang;
                switch (i)
                {
                    case 1:
                        Console.WriteLine("senin");
                        break;
                    case 2:
                        Console.WriteLine("selasa");
                        break;
                    case 3:
                        Console.WriteLine("rabu");
                        break;
                    case 4:
                        Console.WriteLine("kamis");
                        break;
                    case 5:
                        Console.WriteLine("jumat");
                        break;
                    case 6:
                        Console.WriteLine("sabtu");
                        break;
                    case 7:
                        Console.WriteLine("minggu");
                        break;
                    default:
                        Console.WriteLine("Tidak ada");
                        break;
                }
            }

        }
    }
}
