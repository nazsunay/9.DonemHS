using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaUstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                
                Console.WriteLine("Sipariş tutarını giriniz: ");
                int  siparisTutari = int.Parse(Console.ReadLine());
   
                Console.WriteLine("\nÖdeme şeklini seçiniz:");
                Console.WriteLine("1 - Nakit");
                Console.WriteLine("2 - Kredi Kartı");
                Console.WriteLine("Seçiminizi giriniz: (1),(2) ");
                int odemeSekli = int.Parse(Console.ReadLine());

                //Nakit
                if (odemeSekli == 1) 
                {
                    Console.WriteLine("\nNakit ödeme miktarını giriniz: ");
                    int nakitOdeme = int.Parse(Console.ReadLine());

                    int paraUstu = nakitOdeme - siparisTutari;

                    if (paraUstu > 0)
                    {
                        Console.WriteLine($"Ödeme alındı. Para üstü: {paraUstu} TL");
                    }
                    else if (paraUstu == 0)
                    {
                        Console.WriteLine("Ödeme yapıldı.");
                    }
                    else
                    {
                        Console.WriteLine($"Eksik tutar ödediniz. {-paraUstu} TL daha ödemeniz gerekiyor.");
                    }
                }
                // Kredi Kartı
                else if (odemeSekli == 2) 
                {
                    Console.WriteLine("Kredi kartı ile ödemeniz işleniyor...");
                    Console.WriteLine("Ödeme alındı.");
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 giriniz.");
                }
                Console.ReadLine();
            
        }

    }
}

