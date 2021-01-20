using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {


        public void Ekle(MusteriBilgisi musteri)
        {
            Console.WriteLine("Musteri eklendi :" + musteri.Adi);               
        }

        public void Listele(MusteriBilgisi musteri) 
        {
            Console.WriteLine("Musteri listelendi :" + musteri.Adi);         
        }
        
        public void Sil(MusteriBilgisi musteri) 
        {
            Console.WriteLine("Musteri silindi :" + musteri.Adi);      
        }






    }
}
