using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kazanan = 0;
            int kaybeden= 0;
            string kullaniciSecimi = "";
           

            while(true)
            {
                Console.WriteLine("Tas, Kagıt , Makas seçeneğinden birini girin");
                kullaniciSecimi = Console.ReadLine();

                string[] secenekler = { "Taş", "Kağıt", "Makas" };
                Random bilgisayarSecimi = new Random();
                //int i = bilgisayarSecimi.Next(secenekler.Length);
                //string bilgisayarSecimi = secenekler[i];

                Console.WriteLine($"Bilgisayar: {bilgisayarSecimi}");

                if (kullaniciSecimi == bilgisayarSecimi)
                {
                    Console.WriteLine("Berabere");
                }
                else if (kullaniciSecimi == "taş" && bilgisayarSecimi == "makas" ||
                         kullaniciSecimi == "kağıt" && bilgisayarSecimi == "taş" ||
                         kullaniciSecimi == "makas" && bilgisayarSecimi == "kağıt")
                {
                    kazanan++;
                    Console.WriteLine("Kazandın");
                }

                //0,1,2
                //if (kullanici=="Tas" && secenek[i]=="Kağıt")
                //{
                //    kaybeden++;
                //}
                //if (kullanici == "Tas" && secenek[i] == "Makas")
                //{
                //    kazanan++;
                //}
                //if (kullanici == "Makas" && secenek[i] == "Kağıt")
                //{
                //    kazanan++;
                //}
                //if (kullanici == "Makas" && secenek[i] == "Taş")
                //{
                //    kaybeden++;
                //}
                //if (kullanici == "Kağıt" && secenek[i] == "Taş")
                //{
                //    kazanan++;
                //}
                //if (kullanici == "Kağıt" && secenek[i] == "Makas")
                //{
                //    kaybeden++;
                //}
                else
                {
                    kaybeden++;
                    Console.WriteLine("Kaybettin!");
                }

                Console.WriteLine($"Skor: {kazanan} - {kaybeden}");

                Console.WriteLine("\nTekrar oynamak ister misin? (evet/çıkış )");
                string tekrar = Console.ReadLine().ToLower();

                
                if (tekrar != "çıkış")
                {
                    Console.WriteLine("Fiinitoo!");
                    break;
                }
                //if (kullanici == bilgisayar)
                //{

                //}
                //else if (kullanici== "Tas"&& secenek[i]=="Makas" || kullanici == "Tas" && secenek[i] == "Makas" || kullanici == "Kağıt" && secenek[i] == "Taş")
                //{
                //    Console.WriteLine("Kazandınız Skor : 1");
                //}
                //else
                //{
                //    kaybeden++;
                //    Console.WriteLine("Kaybettiniz Skor : 0");
                //}

                //Console.WriteLine("************************");
                //Console.WriteLine($"Kullanıcı  :{kazanan}  yendi");
                //Console.WriteLine($"Kullanici  : {kaybeden}  yenildi" );
                

            }
            
        }
    }
}

