using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class havaDurumu
{
    
    
        static void Main(string[] args)
        {
            Console.Write("Bugünkü sıcaklığı derece cinsinden int olarak giriniz: ");
            int sicaklikInt = int.Parse(Console.ReadLine());

            string tavsiye = HavaDurumuTavsiye(sicaklikInt);
            Console.WriteLine(tavsiye);



            int sicaklik = sicaklikInt; // Int'i int olarak kullan

            if (sicaklik < 10)
            {
                return "Çok soğuk! Kazak, mont, bere ve eldiven gibi kalın giysiler giymeniz önerilir.";
            }
            else if (sicaklik < 15)
            {
                return "Soğuk. Kazak, hırka ve uzun pantolon gibi kat kat giyinmeniz önerilir.";
            }
            else if (sicaklik < 20)
            {
                return "Serin. Uzun kollu tişört, gömlek veya ince kazak ve pantolon giymeniz önerilir.";
            }
            else if (sicaklik < 25)
            {
                return "Mükemmel! Rahat bir tişört ve pantolon giymeniz yeterli.";
            }
            else if (sicaklik < 30)
            {
                return "Sıcak. Tişört, şort ve sandalet gibi hafif giysiler giymeniz önerilir.";
            }
            else
            {
                return "Çok sıcak! Havadar giysiler ve bol su içmeyi unutmayın.";
            }
        }
    
        
}
