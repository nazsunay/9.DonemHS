using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string kullaniciAdi = "Nazlı";
                string sifre = "1234";

                Console.Write("Kullanıcı adınızı giriniz: ");
                string girilenKullaniciAdi = Console.ReadLine();
                
                Console.Write("Şifrenizi giriniz: ");
                string girilenSifre = Console.ReadLine();
               
                if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == sifre)
                {
                    Console.WriteLine("Hoş geldiniz!");
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
                }

                Console.ReadLine();
           
        }
     
    }

 
}

