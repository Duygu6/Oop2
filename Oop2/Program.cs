using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 5;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Duygu";
            musteri1.Soyadi = "Pahli";
            musteri1.TcNo = "1234548";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "154851";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "15451";

            Musteri musteri3 = new GercekMusteri(); //bellekteki referans no
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

           
        }
    }
}
