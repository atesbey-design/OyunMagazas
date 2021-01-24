using System;
using System.Collections.Generic;
using System.Text;

namespace OyunMagazası
{
    class GırısMetod
    {

        public void HesapOlustur(OyuncuBılgı oyuncu)

        {
            List<OyuncuBılgı> oyuncular = new List<OyuncuBılgı> {oyuncu};
            YenıOyuncu oyuncu1 = new YenıOyuncu();
            Console.WriteLine("Lutfen Adınızı Giriniz");
            oyuncu1.Adı = Console.ReadLine();
            Console.WriteLine("Lutfen Soyadınızı Giriniz");
            oyuncu1.Soyad = Console.ReadLine();
            Console.WriteLine("Lutfen TcNo Giriniz");
            oyuncu1.TcNo = Console.ReadLine();
            Console.WriteLine("Kullanıcı Nickinzi giriniz");

            oyuncu1.KullanıcıNıck = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            oyuncu1.Sıfre = Console.ReadLine();
            oyuncular.Add(oyuncu1);
            GırısMetod gırıs = new GırısMetod();
            gırıs.GırısYap(oyuncu);
        }
        public void GırısYap(OyuncuBılgı oyuncu1)
        {
            List<YenıOyuncu> oyuncular = new List<YenıOyuncu> {};
            foreach (var bilgiler in oyuncular)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz");
                string ad = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz");
                string sifre = Console.ReadLine();
                if (sifre==bilgiler.Sıfre & ad==bilgiler.KullanıcıNıck)
                {
                    Console.WriteLine("уαzıℓıм¢ı вєу уσυтυвє ¢нαииєℓ");
                }
                else
                {
                    Console.WriteLine("dene");
                }
            }


        }
    }
}
