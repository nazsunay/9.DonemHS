using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // input : kullanıcıdan aldığımız veriler
            // output : kullanıcıya gösterdiğimiz veriler
            // prefix : ön ek 

            ///////////////////////////////////////// 

            //string kullaniciAdi = "nazlı";
            //string sifre = "1234";

            //Console.WriteLine("kullanıcı adınız");
            //string inputKullaniciAdi = Console.ReadLine();
            //Console.WriteLine("sifrenizi giriniz");
            //string inputSifre = Console.ReadLine();
            //if (inputKullaniciAdi==kullaniciAdi&& sifre==inputSifre)
            //{
            //    Console.WriteLine("true");
            //}

            ///////////////////////////////////////////////

            /// Admin ve Editör kullanarak giriş yapılmasını sağlama:
            //string admin = "Nazlı";
            //string editor = "Naz";
            //string adminSifre = "1234";
            //string editorSifre = "123";

            //Console.WriteLine("Kullanıcı Adınız");
            //string inputKullaniciAdi= Console.ReadLine();

            //Console.WriteLine("Sifre Giriniz");
            //string sifre = Console.ReadLine();

            //if (admin==inputKullaniciAdi && sifre==adminSifre)
            //{
            //    Console.WriteLine("Hosgeldin Admin");
            //    Console.WriteLine("---------");
            //    Console.WriteLine("1- Ne yapmak istersiniz");
            //    Console.WriteLine("2- İşlemlerinizi kontrol edin");
            //}
            //else if (editor==inputKullaniciAdi && sifre==editorSifre){
            //    Console.WriteLine("Hosgeldin Editor");
            //    Console.WriteLine("-----------");
            //    Console.WriteLine("1- Ne yapmak istersin ");
            //    Console.WriteLine("2- İşlemleriniz kontrol edin");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş");
            //}

            //Console.ReadLine();

            /////////////////////////////////////////

            //Diz-Array
            string[] meyveler = new string[] { "Elma", "Armut", "Çilek", "Kavun" };
            Console.WriteLine(meyveler[0]);


        }
    }
}
