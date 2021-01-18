using System;

namespace CountIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not repeat your self - Kendini  Tekrarlama
            // Kategori->KAtegoriler olarak degistirmek istesek manuel olarak yapilmasi hataya sebep olur
            //Console.WriteLine("Kategori");
            //Console.WriteLine("Kategori");
            //Console.WriteLine("Kategori");
            //Console.WriteLine("Kategori");


            // type safety = tip guvenligi
            // deger tutucu - alias- takma isim  kategoriEtiketi
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi == true)       //  if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanici ayarlari Butonu...");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
