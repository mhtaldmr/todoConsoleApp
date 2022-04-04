using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTwo
{
    internal static class TasınacakKart
    {
        public static void Kart(this List<Card> list, string cardTitle)
            {
            Console.WriteLine("Bulunan Kart Bilgileri:");
            Console.WriteLine("********************************");
            Console.WriteLine("Başlık       : " +   list.Where(c => c.Baslık == cardTitle).FirstOrDefault().Baslık);
            Console.WriteLine("İçerik       : " +   list.Where(c => c.Baslık == cardTitle).FirstOrDefault().Icerik);
            Console.WriteLine("Atanan Kişi  : " +   list.Where(c => c.Baslık == cardTitle).FirstOrDefault().Atanan);
            Console.WriteLine("Büyüklük     : " +   list.Where(c => c.Baslık == cardTitle).FirstOrDefault().BüyüklükKodu);
            Console.WriteLine();

        }
    }
}
