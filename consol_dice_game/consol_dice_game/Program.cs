using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bu projede bool, int ve float değişken, Random Fonksiyonu, Foreach Döngüsü, if-else koşul yapısı, Conditional Operatör kullanıldı.
// Random fonksiyonu ile zar atıldı ve gelen değerler sıralandı, toplandı, ortalaması alındı ve koşul yapılarıyla bir takım mesajlar verildi.
namespace lvl2_operands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool basari = true;                    // Zar toplamları 20 üzeri için
            int atisToplam = 0;                    // Zar toplamları için.
            int atisNumarasi = 1;                  // Atış sıralamaları için.
            int atis1, atis2, atis3, atis4, atis5; // 5 zar atışı tanımladım.
            Random zar = new Random();             // Random fonksiyonundan bir obje oluşturdum.
            atis1 = zar.Next(1, 11);                  // Bu fonksiyondan 1 ile 10 arası 5 zar atışı yaptım.
            atis2 = zar.Next(1, 11);                  // Next komutu aralık belirtir. İlk değer dahil, ikincisi değil.
            atis3 = zar.Next(1, 11);
            atis4 = zar.Next(1, 11);
            atis5 = zar.Next(1, 11);
            float ort = (atis1 + atis2 + atis3 + atis4 + atis5) / 5f; // 5 zar atışının ortalamasını aldım ve küsüratları da görmek istedim.
            int[] atislar = { atis1, atis2, atis3, atis4, atis5 };    // Ayrıca her bir atışı tek tek dizi elemanı olarak tanımlardım.

            foreach (int atis in atislar)                             // Foreach döngüsü ile her gelen zarı tek tek yazdırıp, topladım.
            {
                Console.WriteLine(atisNumarasi + ". Zarın Sonucu: " + atis);
                atisToplam += atis;                                   // Her elemanı sırayla atisToplam değişkenine ekledim.
                atisNumarasi++;                                       // Döngü her döndüğünde bir sonraki atış numarasına geçmesini sağladım.
            }

            if (ort > 5) // Ortalama zar değerine göre bir yazı yazdırdım. Ve bu yazıyı da koşullandırdım.
            {
                Console.WriteLine(ort > 7 ? "Çok iyi zar attın. Ortalama: " + ort : "Güzel zar attın. Ortalama: " + ort);
            }
            else
            {
                Console.WriteLine(ort <= 3 ? "Sen bu oyunu oynama kanka. Ortalama: " + ort : "Şansız günündesin hocam. Ortalama: " + ort);
            }
            if (atisToplam >= 20)             // bool başarı koşulu ekledim.
            {
                basari = true;              // Toplamlar 20den büyükse true değeri almak istedim.
            }
            else
            {
                basari = false;             // Aksi taktirde basari false değerine döndü.
            }
            if (basari == true)              // True ise tebrik mesajı ve toplam değer yazdırdım.
            {
                Console.WriteLine("Tebrikler güzel zarlar geldi. Toplam: " + atisToplam);
            }
            else                            // False ise başka bir mesaj ile yine toplamı belirttim.
            {
                Console.WriteLine("Bugün şansın yerinde değil. Toplam: " + atisToplam);
            }
            Console.ReadLine();
        }
    }
}
