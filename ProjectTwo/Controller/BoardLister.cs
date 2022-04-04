using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo.Actions
{
    internal static class BoardLister
    {
        public static void Listele(this List<Card> list, string listName)
        {
            Console.WriteLine("{0} Line", listName);
            Console.WriteLine("*********************");
            
            foreach (var item in list)
            {
                Console.WriteLine("Başlık       : " + item.Baslık);
                Console.WriteLine("İçerik       : " + item.Icerik);
                Console.WriteLine("Atanan Kişi  : " + item.Atanan);
                Console.WriteLine("Büyüklük     : " + item.BüyüklükKodu);
                Console.WriteLine();
            }
            if (list.Count == 0)
            {
                Console.WriteLine("{0} Listesi Boş!\n", listName);
            }
        }
    }
}
