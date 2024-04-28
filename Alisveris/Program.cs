using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //\n boşluk
            // Ürünler ve Fiyatla
            string[] urunler = { "Elma", "Muz", "Domates", "Salatalık", "Süt", "Peynir", "Karpuz", "Çilek", "Ekmek", "Su" };
            double[] fiyatlar = { 2.5, 3.0, 1.5, 2.0, 5.0, 10.0, 4.1, 5.0, 15.0, 5.0 };


            double toplamFiyat = 0.0;


            // Ürün Seçimi
            while (true)
            {
                Console.WriteLine("\nMevcut Ürünler:");
                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]} TL");
                }

                Console.Write("\nHangi ürünü istiyorsunuz (1/2 vs): ");
                string secim = Console.ReadLine();

                if (secim == "t")
                {
                    break; // 't' tuşuna basıldığında döngüden çık
                }

                int secimIndex = int.Parse(secim) - 1;
                Console.WriteLine("Seçtiğiniz ürün: " + urunler[secimIndex]);
                //Console.WriteLine("Toplam Fiyat "+toplamFiyat);
                //toplamFiyat += fiyatlar[secimNo];

                //bool veriRakamMi = int.TryParse(Console.Readline(),out yas);

                int secimNo;
                if (int.TryParse(secim, out secimNo) && secimNo > 0 && secimNo <= urunler.Length)
                {
                    toplamFiyat += fiyatlar[secimNo - 1];
                    Console.WriteLine($"{urunler[secimNo - 1]} seçildi. Toplam fiyat: {toplamFiyat:0.00} TL");
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim!");
                }
            }

            // Sonuç
            Console.WriteLine("\n\nAlışveriş tamamlandı!");
            Console.WriteLine($"Toplam Fiyat: {toplamFiyat:0.00} TL");
            //
        }


    }

}
