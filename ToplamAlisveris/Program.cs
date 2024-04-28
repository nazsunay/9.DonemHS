using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamAlisveris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] urunler = {"Elma","Armut","Kiraz","Süt","Peynir","Su","Ekmek","Doates","Salatalık","Tavuk","Makarna","Turşu" };
            double[] Fiyatlar = {10.0 ,20.5,6.0,8.0,5.0,5.0,9.8,7.6,12.5,13,5};

            int[] stoklar = {8,32,5,6,4,12,21,50,13,14 };
            string alinanUrunler = "";
            double toplamTutar = 0.0; ;

            for (int i = 0; i <urunler.Length; i++)
            {
                Console.WriteLine((i+1) + " " + urunler[i] + " ");
                Console.WriteLine(Fiyatlar[i] + "TL  ");
                Console.Write(stoklar[i] + "");
            }

            //Ürün istemi
            Console.WriteLine("Kaç Adet Ürün istiyorsunuz");
            int istenenUrun = int.Parse(Console.ReadLine());

            for (int i = 0; i < istenenUrun; i++)
            {
                Console.WriteLine("Almak İstediğiniz Ürünü Giriniz ");
                int inputUrun = int.Parse(Console.ReadLine());
                Console.WriteLine("Kaç adet Almak İstiyorsunuz");
                int inputKacAdet = int.Parse(Console.ReadLine());
               
            }

            Console.WriteLine($"Aldığınız Ürünler {alinanUrunler} Toplam Ödenecek Tutar: {toplamTutar} TL");
            Console.WriteLine("Ödemek İstediğiniz Tutar");
            double odenenTutar = double.Parse(Console.ReadLine());

            if (odenenTutar >= toplamTutar)
            {
                Console.WriteLine($"Para Üstü: {odenenTutar - toplamTutar} TL  ");

            }
            else if (odenenTutar> toplamTutar)
            {
                Console.WriteLine($"Eksik ödeme {toplamTutar - odenenTutar } TL daha lütfen ");

            }
            else
            {
                Console.WriteLine("Ödeme Başarılı");
            }
        }
    }
}
