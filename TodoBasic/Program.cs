using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TodoBasic
{
    internal class Program
    {
        static List<string> yapilacaklar = new List<string>()
        {
            //"1. Görevler",
            //"Mailleri Kontrol et",
            //"Bursa Listesini Revize et"
        };
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {

            Console.WriteLine("Yapılacaklar Listesi");
            Console.WriteLine("----------------------");
            for (int i = 0; i < yapilacaklar.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, yapilacaklar[i]);
            }
            Console.WriteLine("Seçenekler: ");
            Console.WriteLine("1.Görev Ekle");
            Console.WriteLine("2. Görev Sil");
            Console.WriteLine("3. Çıkış");

            int secim =int.Parse( Console.ReadLine());

            if (secim ==1)
            {
                GorevEkle();
                Menu();
            }
            else if (secim ==2)
            {
                GorevSil();
                Menu();
            }
            else if (secim ==3)
            {
                Console.WriteLine("çıkış Yapılıyor");
            }
            
        }
        static void GorevEkle()
        {

            string yeniGorev = Console.ReadLine();
            yapilacaklar.Add(yeniGorev);
            Console.WriteLine("EKleme işleme tamamlandı");
            return ;

        }
        static void GorevSil()
        {

                int gorevSirasi = int.Parse(Console.ReadLine());
                yapilacaklar.RemoveAt(gorevSirasi-1);

        }


    }

}

        