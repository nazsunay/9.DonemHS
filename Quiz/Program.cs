using System;

class Program
{
    static void Main(string[] args)
    {
        //\n boşluk
        // Sorular 
        string[] sorular = { "Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?" };
        string[] cevaplar = { "mavi", "Ankara" };
        string[] secenekler = { "kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir" };

        
        int dogruSayisi = 0;
        int yanlisSayisi = 0;

        // Soruları Sor
        for (int i = 0; i < sorular.Length; i++)
        {
            // Soruyu Gösterme
            Console.WriteLine($"\n{i + 1}. Soru: {sorular[i]}");

            //cevap
            string[] secenekleriParcala = secenekler[i].Split('|');
            for (int j = 0; j < secenekleriParcala.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {secenekleriParcala[j]}");
            }

            // Kullanıcıdan Cevap
            Console.Write("Cevabınız (1/2/3): ");
            string kullaniciCevabi = Console.ReadLine();

            // Cevabı Değerlendir
            int secimNo;

            if (int.TryParse(kullaniciCevabi, out secimNo) &&
                secimNo > 0 && secimNo <= secenekleriParcala.Length)
            {
                string secilenCevap = secenekleriParcala[secimNo - 1].ToLower();
                string dogruCevap = cevaplar[i].ToLower();

                if (secilenCevap == dogruCevap)
                {
                    Console.WriteLine("Doğru cevap!");
                    dogruSayisi++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap! Doğru cevap: {0}", dogruCevap);
                    yanlisSayisi++;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }
        }

        
        Console.WriteLine("\n\nSonuçlar:");
        Console.WriteLine($"Doğru Cevap Sayısı: {dogruSayisi}");
        Console.WriteLine($"Yanlış Cevap Sayısı: {yanlisSayisi}");
    }
}
