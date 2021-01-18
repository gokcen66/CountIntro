﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
         string urunAdi= "Elma";
         double fiyati = 15;
         string Aciklama = "Amasya elmasi";

        string[] meyveler = new string[] { };
        
        Urun urun1 = new Urun();
        urun1.Adi="Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elmasi";

        Urun urun2 = new Urun();
         urun2.Adi = "Karpuz";
         urun2.Fiyati = 80;
         urun2.Aciklama = "Diyarbakir karpuzu";

            
            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip guvenli -- tanimlanan verinin type belirtilmesi

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("=====================");
            }

       

            Console.WriteLine("------Metodlar------");

            //instance-ornek
            // encapsulation  - Kapsulleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yesil Armut",12,10);
            sepetManager.Ekle2("Elma","Yesil elma",12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakir karpuzu",12,8);
           

        }
    }
}
