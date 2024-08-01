using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_ayın_hangi_mevsime_ait_olduğu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ayı girin");
            string ay = Console.ReadLine();

            switch (ay)
            {
                case "ocak": Console.WriteLine("Kış"); break;
                case "şubat": Console.WriteLine("Kış"); break;
                case "mart": Console.WriteLine("İlkbahar"); break;
                case "nisan": Console.WriteLine("İlkbahar"); break;
                case "mayıs": Console.WriteLine("İlkbahar"); break;
                case "haziran": Console.WriteLine("Yaz"); break;
                case "temmuz": Console.WriteLine("Yaz"); break;
                case "ağustos": Console.WriteLine("Yaz"); break;
                case "eylül": Console.WriteLine("Sonbahar"); break;
                case "ekim": Console.WriteLine("Sonbahar"); break;
                case "kasım": Console.WriteLine("Sonbahar"); break;
                case "aralık": Console.WriteLine("Kış"); break;
                default:Console.WriteLine("Böyle bir ay yok");break;
            }

            Console.ReadLine();

        }
    }
}
