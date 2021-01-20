using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriBilgisi musteri1 = new MusteriBilgisi();
            musteri1.Id = 987654321;
            musteri1.Adi = "Ezel";
            musteri1.Yas = 45;

            MusteriBilgisi musteri2 = new MusteriBilgisi();
            musteri2.Id = 123456789;
            musteri2.Adi = "Cengiz";
            musteri2.Yas = 38;

            MusteriBilgisi musteri3 = new MusteriBilgisi();
            musteri3.Id = 135797982;
            musteri3.Adi = "Kerpeten Ali";
            musteri3.Yas = 59;

            MusteriBilgisi musteri4 = new MusteriBilgisi();
            musteri4.Id = 135797986;
            musteri4.Adi = "Tefo";
            musteri4.Yas = 32;




            MusteriBilgisi[] musteriler = new MusteriBilgisi[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Ad"+":" + musteri.Adi);
                Console.WriteLine("Yas"+":" + musteri.Yas);
                Console.WriteLine("---------");
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            Console.WriteLine("----------");
            musteriManager.Listele(musteri1);
            Console.WriteLine("----------"  );
            musteriManager.Sil(musteri2);






















        }
    }
}



