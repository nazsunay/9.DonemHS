using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagıtMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kazanan = 0;
            int kaybeden = 0;
            string kullaniciSecimi;

            while (true)
            {
                Console.WriteLine("Taş, Kağıt veya Makas seçin: ");
                kullaniciSecimi = Console.ReadLine();

                string[] secenekler = { "taş", "kağıt", "makas" };
                Random bilgisayarSecimi = new Random();
                string bilgisayarSecim = secenekler[bilgisayarSecimi.Next(secenekler.Length)];

                Console.WriteLine($"Bilgisayar: {bilgisayarSecim}");

                if (kullaniciSecimi == bilgisayarSecim)
                {
                    Console.WriteLine("Berabere!");
                }
                else if (
                    (kullaniciSecimi == "taş" && bilgisayarSecim == "makas") ||
                    (kullaniciSecimi == "kağıt" && bilgisayarSecim == "taş") ||
                    (kullaniciSecimi == "makas" && bilgisayarSecim == "kağıt")
                )
                {
                    kazanan++;
                    Console.WriteLine("Kazandınız!");
                }
                else
                {
                    kaybeden++;
                    Console.WriteLine("Kaybettiniz!");
                }

                Console.WriteLine($"Skor: {kazanan} - {kaybeden}");

                Console.WriteLine("\nTekrar oynamak ister misiniz? (evet/çıkış): ");
                string tekrar = Console.ReadLine().ToLower();

                if (tekrar != "evet")
                {
                    Console.WriteLine("Oyun bitti!");
                    break;
                }
            }
        }
    }
}
