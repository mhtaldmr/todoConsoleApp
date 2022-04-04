


using System.Collections.Generic;

namespace ProjectTwo
{

    public static class SampleData
    {
        public static void Add(this List<Card> list)
        {
            list.Add(new Card() { Baslık = "Alışveriş", Icerik= "Peynir", Atanan = AtananKisi.Kisi[1] , BüyüklükKodu= Büyüklük.XS });
            list.Add(new Card() { Baslık = "Elektronik", Icerik = "Bilgisayar", Atanan = AtananKisi.Kisi[2], BüyüklükKodu = Büyüklük.M });
            list.Add(new Card() { Baslık = "Spor", Icerik = "Koşu", Atanan = AtananKisi.Kisi[3], BüyüklükKodu = Büyüklük.XL });
           
        }
    }
}
