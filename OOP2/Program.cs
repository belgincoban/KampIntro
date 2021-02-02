using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id= 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "BELGİN";
            musteri1.Soyadi = "ÇOBAN";
            musteri1.TcNo = "4522222221";


            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "52564";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";


            //gerçek müşteri- Tüzel müşteri



            Musterı musteri3 = new GercekMusteri(); 
            Musterı musteri4 = new TuzelMusteri();
            //Musteri clası hem gercekmusteri hemde tuzelmusteri nın referansını tutuyor.

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Add(musteri1);
            musterimanager.Add(musteri2);

        }
        
    }
}
