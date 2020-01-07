using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //string parametre alan void methoda ekrandan alınan kelime gönderilecek bu kelimede ki harf sayıları bulunacak

        private static void Hesap(string gelen)
        {
            int adet = 0;
            char i;
            for (i = 'a'; i <= 'z'; i++)
            {

                for (int k = 0; k < gelen.Length; k++)
                {
                    if (i == gelen[k])
                    {
                        adet++;
                    }

                }

                if (adet != 0)
                {
                    Console.WriteLine("{0} harfi kelimede {1}", i, adet);
                }
                adet = 0;
            }

        }

        static void Main(string[] args)
        {
            string kelime;
            Console.Write("Kelime giriniz :");
            kelime = Console.ReadLine();
            Hesap(kelime);
            Console.ReadLine();
        }
    }
}
