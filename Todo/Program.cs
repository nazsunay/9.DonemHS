using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<string> gorevler = new List<string>()
                {
                   "1.Görevleri Listele",
                   "2.Görevleri Ekle",
                   "3.Görevleri Sil"

                };
            int sec = int.Parse(Console.ReadLine());
            if (sec==1)
            {


                foreach (string gorev in gorevler)
                {

                    Console.WriteLine(gorev);
                    Console.WriteLine("1.Mailleri kontrol et");
                    Console.WriteLine("1.Mailleri kontrol et");
                    Console.WriteLine("2.Bursa Müşteri Taleplerini Kontrol et");
                    Console.WriteLine("3.Revize müşteriler ile iletişime geç");
                    Console.WriteLine("4.Hediye gönderilecek müşterilerin listesini oluştur");

                }
            }
            Console.WriteLine("Eklemek İstediğiniz Görevi Giriniz");
            string inputEklenen = Console.ReadLine();
           
            gorevler.Add(inputEklenen);

            foreach (string gorev in gorevler)
            {
                Console.WriteLine(gorev);

            }

            Console.WriteLine("Sİlmek İstediğiniz görevin Numarasını giriniz");
            int inputNumber= int.Parse(Console.ReadLine());
            if (inputNumber>0 && inputNumber<= gorevler.Count)
            {
                gorevler.RemoveAt(inputNumber-1);
                Console.WriteLine("Silindi");
            }

            int secim= int.Parse(Console.ReadLine());
            if (secim==1)
            {
                
                gorevler.Remove(gorevler[1]);
            }
            else if (secim==2)
            {
                gorevler.Remove(gorevler[2]);
            }
            else if (secim==3)
            {
                gorevler.Remove(gorevler[3]);
            }

            Console.WriteLine(secim);

        }
    }
}
