using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinası
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //v1
            //- Kullanıcıya kaç adet rakam toplamak istediğini soralım.
            //-Girdiği rakamlara göre toplam ve ortalama sonuç gösterelim.

            
             Console.WriteLine("Kaç adet rakam toplamak istiyorsunuz?");
            int adet = int.Parse(Console.ReadLine());

            
            int toplam = 0;
            int ortalama = 0;

            
            for (int i = 1; i <= adet; i++)
            {
                Console.Write($"{i}. sayıyı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
            }

            
            ortalama = toplam / adet;

            // Sonuçları ekrana yazdıralım
            Console.WriteLine("Toplam: {0}", toplam);
            Console.WriteLine("Ortalama: {0}", ortalama);





        }
    }
}
    




