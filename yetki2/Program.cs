using System;

class yetki2
{
    private string kullaniciAdi;
    private string sifre;

    public yetki2(string kullaniciAdi)
    {
        this.kullaniciAdi = kullaniciAdi;
        this.sifre = ""; // Başlangıçta şifre yok
    }

    public void SifreBelirle()
    {
        Console.Write("Yeni şifrenizi giriniz: ");
        string yeniSifre = Console.ReadLine();

        Console.Write("Şifrenizi tekrar giriniz: ");
        string tekrarSifre = Console.ReadLine();

        if (yeniSifre == tekrarSifre)
        {
            this.sifre = yeniSifre;
            Console.WriteLine("Şifre başarıyla belirlendi!");
        }
        else
        {
            Console.WriteLine("Girilen şifreler eşleşmiyor. Lütfen tekrar deneyin.");
        }
    }

    public bool GirisYap(string girilenKullaniciAdi, string girilenSifre)
    {
        if (kullaniciAdi == girilenKullaniciAdi && sifre == girilenSifre)
        {
            Console.WriteLine("Hoş geldiniz, " + kullaniciAdi + "!");
            return true;
        }
        else
        {
            Console.WriteLine("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kullanıcı adınızı giriniz: ");
        string kullaniciAdi = Console.ReadLine();

        yetki2 hesap = new yetki2(kullaniciAdi);

        // Kullanıcı şifre belirlemeyi seçerse
        Console.WriteLine("\nŞifre belirlemek ister misiniz? (evet/hayır)");
        string sifreBelirleSecimi = Console.ReadLine().ToLower();

        if (sifreBelirleSecimi == "evet")
        {
            hesap.SifreBelirle();
        }

        // Giriş işlemini gerçekleştir
        Console.WriteLine("\nGiriş yapmak için kullanıcı adınızı ve şifrenizi giriniz:");
        Console.Write("Kullanıcı adı: ");
        string girilenKullaniciAdi = Console.ReadLine();
        Console.Write("Şifre: ");
        string girilenSifre = Console.ReadLine();

        if (hesap.GirisYap(girilenKullaniciAdi, girilenSifre))
        {
            // Giriş yapıldıktan sonra yapılacak işlemler...
            // (Örneğin, menü gösterme, işlemler gerçekleştirme vb.)
        }
        Console.ReadLine();
    }
}
