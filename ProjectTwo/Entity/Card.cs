using System.Collections.Generic;

namespace ProjectTwo
{
    internal partial class Program
    {
        public class Card
        {
            public string Baslık { get; set; }
            public string Icerik { get; set; }
            public List<string> AtananKisi { get; set; }
            public List<string> Büyüklük { get; set; }


            public Card()
            {
                AtananKisi = new List<string>();
                Büyüklük = new List<string>() { "XS", "S", "M", "L", "XL" };
            }

        }

    }
}
