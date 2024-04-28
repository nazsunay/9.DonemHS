using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace havaDurumu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bugünkü sıcaklığı derece cinsinden giriniz: ");
            int sicaklik = int.Parse(Console.ReadLine());

            if (sicaklik <=5)
            {
                Console.WriteLine("Hava aşırı soğuk atkı , bere , mont ve kalın bir pantolon giyinmenizi öneririm");
            }
             else if (sicaklik <= 10)
            {
                Console.WriteLine("Hava çok soğuk mont ve kalın pantolon giymenizi öneririm"); ;
            }
            else if (sicaklik <= 15)
            {
                Console.WriteLine("Hava soğuk Mont, Kalın ceket ve kalın pantolon giymenizi öneririm"); ;
            }
            else if (sicaklik <= 20)
            {
                Console.WriteLine("Hava serin Ceket, Sweatshirt vs giymenizi öneririm"); 
            }
            else if (sicaklik <= 25)
            {
                Console.WriteLine("Hava güneşli Tsirt , ince bir pantolon giymenizi "); ;
            }
            else if (sicaklik <= 30)
            {
                Console.WriteLine(" Hava sıcak Tişört, şort ve sandalet gibi hafif giysiler giymeniz önerilir."); ;
            }
            else
            {
                Console.WriteLine(" Hava çok sıcak! Havadar keten ve pamuklu kıyafetler giymenizi öneririm."); ;
            }
            Console.ReadLine();
        }    
    }
}
