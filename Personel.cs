
using System;

namespace UPMS
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }

        public Personel(string ad, string soyad, string tcNo)
        {
            Ad = ad;
            Soyad = soyad;
            TcNo = tcNo;
        }

        public abstract double MaasHesapla(int dersSaati = 0);
        public virtual void BilgiGoster()
        {
            Console.WriteLine($"{Ad} {Soyad} - TC: {TcNo}");
        }
    }
}
