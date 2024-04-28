using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevler
{
    internal class ifElse
    {
  
            public static void Main(string[] args)
            {
                // Hikayenin başlangıcı
                Console.WriteLine("Bir varmış, bir yokmuş...");

                // Kahramanın ismi
                Console.WriteLine("Kahramanımızın ismi nedir?");
                string isim = Console.ReadLine();

                // Hikayenin başlangıç seçimi
                Console.WriteLine($"{isim} bir gün bir ormanda yürürken bir yol ayrımına geldi. Hangi yola gidecek?");
                Console.WriteLine("1. Sola dön");
                Console.WriteLine("2. Sağa dön");

                int secim = int.Parse(Console.ReadLine());

                // Sola dön seçimi
                if (secim == 1)
                {
                    Console.WriteLine($"{isim} sol yola döndü ve bir kulübeye rastladı. Kulübede yaşlı bir kadın yaşıyordu. Yaşlı kadın ona bir elma verdi ve elmayı yiyip yememesini sordu.");
                    Console.WriteLine("1. Elmayı ye");
                    Console.WriteLine("2. Elmayı yeme");

                    int elmaSecim = int.Parse(Console.ReadLine());

                // Elmayı ye seçimi
                if (elmaSecim == 1 ) 
                    {
                        Console.WriteLine($"{isim} elmayı yedi ve bir dev haline geldi. Dev ne yapacağını seçmesi gerekiyor.");
                        Console.WriteLine("1. İnsanlara Saldır");
                        Console.WriteLine("2. Ormanda yaşa");

                        int devSecim = int.Parse(Console.ReadLine());

                        // Şehre saldır seçimi
                        if (devSecim == 1)
                        {
                            Console.WriteLine($"{isim} İnsanlara saldırdı ve şehri yerle bir etti. Dev bir canavara dönüştü. Hikayenin sonu.");
                        }
                        // Ormanda yaşa seçimi
                        else if (devSecim == 2)
                        {
                            Console.WriteLine($"{isim} ormanda yaşamayı seçti ve huzurlu bir hayat yaşadı. Hikayenin sonu.");
                        }
                    }
                    // Elmayı yeme seçimi
                    else if (elmaSecim == 2)
                    {
                        Console.WriteLine($"{isim} elmayı yemedi ve yaşlı kadına teşekkür edip yoluna devam etti. Hikayenin sonu.");
                    }
                }
                // Sağa dön seçimi
                else if (secim == 2)
                {
                    Console.WriteLine($"{isim} sağ yola döndü ve bir nehre ulaştı. Nehri nasıl geçeceğini seçmesi gerekiyor.");
                    Console.WriteLine("1. Köprüden geç");
                    Console.WriteLine("2. Yüzerek geç");

                    int nehirSecim = int.Parse(Console.ReadLine());

                    // Köprüden geç seçimi
                    if (nehirSecim == 1)
                    {
                        Console.WriteLine($"{isim} köprüden geçti ve bir şehre geldi. Şehirde bir prenses ile tanıştı.");
                        Console.WriteLine("Prenses kahramana aşık oldu ve kahramanımız prensese aşık oldu.");
                        Console.WriteLine("1. evlendiler");
                        
                        int evlilik = int.Parse(Console.ReadLine());

                        //  düğün sonucu
                        if (evlilik ==1)
                        {
                            // Kahraman ve prenses evlendi
                            Console.WriteLine($"{isim} ve prenses evlendiler ve mutlu bir şekilde yaşadılar.");
                        }
                        else
                        {
                            // Kahraman ve prenses evlenemedi
                            Console.WriteLine($"Prensesin babası {isim}'i kabul etmedi. Hikayenin sonu.");
                        }
                    }
                    // Yüzerek geç seçimi
                    else if (nehirSecim == 2)
                    {
                        Console.WriteLine($"{isim} nehri yüzerek geçmeye çalıştı, ancak akıntıya kapıldı ve boğuldu. Hikayenin sonu.");
                    }
                }

                // Hikayenin sonu
                Console.WriteLine($"...ve böylece {isim}'in hikayesi sona erdi.");
               Console.ReadLine();
            }
        }
     
    }

