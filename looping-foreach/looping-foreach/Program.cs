using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looping_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //for each
            // untuk array yang tidak diketahui nilainya dan biasa banyak di gunakan dalam OOP(Object Oriented Programming)
            string[] siswa = { "siswa1", "siswa2", "siswa3", "siswa4", "siswa5", "siswa6" };
            foreach(string name in siswa)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("================================PERBEDAAN=================================");
            for(int i = 0; i < 5; i+=2)
            {
                Console.WriteLine(siswa[i]);
            }
            //KESIMPULAN: jadi untuk looping for urutan nya bisa kita rubah tetapi kalau kita menggunakan looping foreach urutan nya tidak bisa kita ubah
        }
    }
}
