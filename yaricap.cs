using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programlamayaGirisVize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yarıçap Bilgisi Giriniz: ");
            int yaricap = Convert.ToInt32(Console.ReadLine());

            int sonucAlan = 3 * yaricap * yaricap;
            int sonucCevre = 2 * 3 * yaricap;

            Console.WriteLine("Girdiğiniz Bilgiye Göre Daire'nin Alanı: " + sonucAlan);
            Console.WriteLine("Girdiğiniz Bilgiye Göre Daire'nin Çevresi: " + sonucCevre);
        }
    }
}
