using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hikayeyazma
{
    internal class Class1
    {
        static void Main(string[] args)
        { // if döngü ödevi
          //Karakter ismi
          //Kulübeye girmesi
          //Kıza yardım etmesi




            //Karakter İsmi
            Console.WriteLine("Kahramanımızın ismi Nedir?");
            string isim = Console.ReadLine();

            // Kahramanın nereye gideceği
            Console.WriteLine($"{isim}  bir gün otomobilini alarak bir yola çıkar. Nereye gideceğini bilmeden öylece yola koyulur. Önüne bir yol ayrımı çıkar");
            Console.WriteLine("1. yön");
            Console.WriteLine("2. yön");

            int yolSecim = int.Parse(Console.ReadLine());
            //1. yönü seçerse
            if (yolSecim == 1)
            {
                Console.WriteLine($"{isim} nereye gittiğini bilmeden karanlık ormana girer. Çıkmak için bir yol bulmaya çalışır ancak önünde sadece bir kulübe vardır Kulübeye girecek(1), Kulübeye girmeyecek(2) ");

                int kulubeSecim = int.Parse(Console.ReadLine());
                //Kulübeye girecek
                if (kulubeSecim == 1)
                {
                    Console.WriteLine($"{isim} Klübeye girer ve içeride bir kız çocuğunu görür. Tek başına ağlayan kız çocuğunu gören {isim} ona burada ne yaptığını ve neden burada olduğunu sorar kız ona yolunu kaybettiğini ve tüm gün orada kalmak zorunda olduğunu söyler. {isim} onu eve götürmek için bir karar vermesi gerekir eve götürecek(1), Orada bırakacak(2)");
                    //eve götürecek mi?
                    int eveGotur = int.Parse(Console.ReadLine());
                    if (eveGotur == 1)
                    {
                        Console.WriteLine($"{isim} Kızı arabaya koyarak ona evini tarif etmesini ister ve yola koyulur ama kız evinin yolunu bilmediği için onu evine veya karakola götürmek ister kıza sorar seni nereye götüreyim? Kendi evine götüecek(1),Karakola götürecek(2)");
                        // Kızın seçimi 1 ev, 2 Karakol
                        int kizinsecimi = int.Parse(Console.ReadLine());
                        if (kizinsecimi == 1)
                        {
                            Console.WriteLine($"{isim} Kızı kendi evine götürür. sabah olunca ailesini bulmak ve kızı karakola götürmek için ikna eder ve ailesine teslim eder");

                        }

                        else if (kizinsecimi == 2)
                        { Console.WriteLine($"{isim} kızı karakola götürür .Ailesi kısa zamanda bulunan kız evine döner. {isim} yardım etmiş olmanın gururuyla evine doğru yola çıkar"); }

                    }
                    // orada bırakıp gidecek
                    else if (eveGotur == 2)
                    {
                        Console.WriteLine($"{isim} küçük kızı orada yapayalnız bırakarak evine dönmeye çalışır");
                    }

                }
                else if (kulubeSecim == 2)
                {
                    Console.WriteLine($"{isim} Kulübeye girmekten korkarak arabasından inmeden geldiği yoldan geri dönerek önüne çıkan diğer yolu tercih edip evine döner");
                }

            }
            else if (yolSecim == 2)
            {
                Console.WriteLine($"{isim} Aydınlık bir yoldan geçerek bir sahil kasabasına doğru ilerler sakinliğin tadını çıkardıktan sonra evine geri döner");

            }


            Console.ReadLine();
        }
    }
}
