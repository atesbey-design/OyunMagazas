using System;
using System.Collections.Generic;

namespace OyunMagazası
{
    class Program
    {///Taslaktır.Kısmi Şekilde bitirilmiştir.
        static void Main(string[] args)
        {
            YenıOyuncu oyuncu = new YenıOyuncu();
            GırısMetod gırısMetod = new GırısMetod();
            EskıOyuncu oyuncu1 = new EskıOyuncu();
            Console.WriteLine("'Yazılımcı Bey Youtube' OYUNUNA HOŞ GELDİNİZ\n Kayıtlı Bir Kullanıcı İseniz Lüten 1'e Basın.\n Kayıt Olmak İçin Lütfen 2'ye Basınız");
            string secim = Console.ReadLine();
            if (secim == "1") 
            {

                gırısMetod.GırısYap(oyuncu1);
                
            }
            else if(secim=="2")
            {

                gırısMetod.HesapOlustur(oyuncu);
                
            }



        }
    }
}
