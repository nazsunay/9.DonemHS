using System;

class ParaUstuHesaplama
{
    static void Main(string[] args)
    {
        //bool devam = true;

        //while (devam)
        //{
        //    // Sipariş tutarını girin
        //    Console.Write("Sipariş tutarını giriniz: ");
        //    double siparisTutari = double.Parse(Console.ReadLine());

        //    // Ödeme şeklini seçin
        //    Console.WriteLine("\nÖdeme şeklini seçiniz:");
        //    Console.WriteLine("1 - Nakit");
        //    Console.WriteLine("2 - Kredi Kartı");
        //    Console.Write("Seçiminizi giriniz: ");
        //    int odemeSekli = int.Parse(Console.ReadLine());

        //    // Ödeme işlemini gerçekleştir
        //    if (odemeSekli == 1) // Nakit
        //    {
        //        Console.Write("Nakit ödeme miktarını giriniz: ");
        //        double nakitOdeme = double.Parse(Console.ReadLine());

        //        double paraUstu = nakitOdeme - siparisTutari;

        //        if (paraUstu > 0)
        //        {
        //            Console.WriteLine($"Ödeme alındı. Para üstü: {paraUstu} TL");
        //        }
        //        else if (paraUstu == 0)
        //        {
        //            Console.WriteLine("Ödeme tam olarak yapıldı.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Eksik tutar ödediniz. {-paraUstu} TL daha ödemeniz gerekiyor.");
        //        }
        //    }
        //    else if (odemeSekli == 2) // Kredi Kartı
        //    {
        //        Console.WriteLine("Kredi kartı ile ödemeniz işleniyor...");
        //        Console.WriteLine("Ödeme alındı.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 giriniz.");
        //    }

        //    // Devam etmek istiyor musunuz?
        //    Console.Write("\nYeni bir işlem yapmak ister misiniz? (evet/hayır): ");
        //    string yeniIslem = Console.ReadLine().ToLower();

        //    if (yeniIslem != "evet")
        //    {
        //        devam = false;
        //        Console.WriteLine("Programdan çıkılıyor...");
        //    }
        //}
        //while (true)
        //{
        //    Console.WriteLine("yess");
        //}

        //int kucukSayi = 5;
        //int buyukSayi = 10;
        //while (kucukSayi<buyukSayi)
        //{
        //    Console.WriteLine("yess");
            
        //    kucukSayi++;
        //}

        
        //while (true)
        //{
        //    Console.WriteLine("Şifrenizi Giriniz");
        //    string inputSifre = Console.ReadLine();

        //    if (inputSifre =="****")
        //    {
        //        Console.WriteLine("Başarılı");
        //        break;
        //    }
        //    //continue döngüyü kaldığı yerden başa sarar
        //    else
        //    {
        //        Console.WriteLine("!!!!!!");
        //    }
        //}


        string [] kullanicilar = {"nazlı","sunay","bülbül" };
        string [] sifreler = { "*", "**", "***" };
        string [] kullaniciAdlari = { "nazli", "sunay", "bulbul" };

        Console.Write("Kullanıcı Adı: ");
        string inputKullaniciAdi = Console.ReadLine();

        Console.Write("sifre: ");
        string inputSifre = Console.ReadLine() ;

        bool bulunduMu = false;
        string bulunanKullaniciAdi = "";

        for (int i = 0; i < kullanicilar.Length; i++)
        {
            if (inputKullaniciAdi == kullanicilar[i] && inputSifre == sifreler[i])
            {
                bulunduMu = true;
                bulunanKullaniciAdi = kullanicilar[i];
            }
        }

        if (bulunduMu == true)
        {
            Console.WriteLine($"Hoş Geldin {bulunanKullaniciAdi}");

        }
        else
        {
            Console.WriteLine("kullanici bulunmadı hatalı giriş");
        }
    }
}
