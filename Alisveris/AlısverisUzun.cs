//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Alisveris
//{
//    internal class AlısverisUzun
//    {
//        static void Main(string[] args)
//        {
//            // Ürünler ve Fiyatlar
//            string[] urunler = { "Elma", "Muz", "Süt", "Peynir", "Ekmek" };
//            double[] fiyatlar = { 2.5, 3, 5, 10, 1.5 };

//            // Sepet ve Toplam Fiyat
//            List<(string, double, int)> sepet = new List<(string, double, int)>();
//            double toplamFiyat = 0;

//            // Kullanıcı ile Etkileşim
//            while (true)
//            {
//                // Ürün Listesi Gösterme
//                for (int i = 0; i < urunler.Length; i++)
//                {
//                    Console.WriteLine("{0}. {1} - {2} TL", i + 1, urunler[i], fiyatlar[i]);
//                }

//                //// Ürün Seçimi
//                Console.Write("Hangi ürünü istiyorsunuz (0 = bitir): ");
//                int secim = int.Parse(Console.ReadLine());
//                if (secim == 0)
//                    break;

//                Console.Write("Kaç adet istiyorsunuz: ");
//                int adet = int.Parse(Console.ReadLine());

//                // Stok Kontrolü (v4 için)
//                int stokDurumu = 10; // Örnek stok durumu
//                if (adet > stokDurumu)
//                {
//                    Console.WriteLine($"Maalesef, {urunler[secim - 1]} stoğumuz yetersiz ({stokDurumu} adet kaldı).");
//                    continue;
//                }

//                //// Ürün Sepete Ekleme
//                //sepet.Add((urunler[secim - 1], fiyatlar[secim - 1], adet));
//                //toplamFiyat += fiyatlar[secim - 1] * adet;

//                //// Stok Güncelleme (v4 için)
//                //stokDurumu -= adet;
//            }

//            //// Sepet ve Toplam Fiyat Gösterme
//            //Console.WriteLine("\nSepetiniz:");
//            //foreach (int i in sepet)
//            //{
//            //    Console.WriteLine($"{i.Item1} ({i.Item3} adet) - {i.Item1 * i.Item3} TL");
//            //}
//            //Console.WriteLine($"Toplam Fiyat: {toplamFiyat} TL");

//            // Ödeme ve Para Üstü (v3 için)
//            Console.Write("\nÖdeme tutarınızı girin: ");
//            double odemeTutari = double.Parse(Console.ReadLine());
//            double paraUstu = odemeTutari - toplamFiyat;
//            Console.WriteLine($"Para Üstü: {paraUstu} TL");
//        }
//    }
//}

