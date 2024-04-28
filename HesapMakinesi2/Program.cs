using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        
        string[] islemSecenekleri = { "Toplama", "Çıkarma", "Çarpma", "Bölme" };

        // Kullanıcıdan Seçim Al
        Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        for (int i = 0; i < islemSecenekleri.Length; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, islemSecenekleri[i]);
        }
        int inputIslemNo = int.Parse(Console.ReadLine());

        
        if (inputIslemNo < 1 || inputIslemNo > islemSecenekleri.Length)
        {
            Console.WriteLine("Geçersiz seçim!");
            return;
        }

        Console.WriteLine("Kaç adet rakam ile işlem yapmak istiyorsunuz?");
        int rakamSayisi = int.Parse(Console.ReadLine());

        // Rakamları Al 
        double sonuc = 0;
        for (int i = 0; i < rakamSayisi; i++)
        {
            Console.WriteLine("{0}. Sayıyı giriniz:", i + 1);
            double sayi = double.Parse(Console.ReadLine());

            //Tekrarlı kullan
            switch (inputIslemNo)
            {
                case 1:
                    if (i == 0)
                        sonuc = sayi;
                    else
                        sonuc += sayi;
                    break;
                case 2:
                    if (i == 0)
                        sonuc = sayi;
                    else
                        sonuc -= sayi;
                    break;
                case 3:
                    if (i == 0)
                        sonuc = sayi;
                    else
                        sonuc *= sayi;
                    break;
                case 4:
                    if (i == 0)
                        sonuc = sayi;
                    else if (sayi == 0)
                    {
                        Console.WriteLine("Sıfıra bölme hatası!");
                        return;
                    }
                    else
                        sonuc /= sayi;
                    break;
            }
        }

        // Sonucu Göster
        Console.WriteLine("Sonuç: {0}", sonuc);

        string devamEtsin = "";
        while (devamEtsin !="e")
        {
            Console.WriteLine("\n Devam etmek istiyor musunuz (e harfine basmadan işleminiz sonlanmayacak!!!!)");
            devamEtsin = Console.ReadLine();

        }
    }
}
