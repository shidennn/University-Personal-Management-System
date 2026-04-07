
using System;

namespace UPMS
{
    public class Memur : Personel, IZamYapabilir
    {
        public double SabitUcret { get; set; } = 90000;

        public Memur(string ad, string soyad, string tc) : base(ad, soyad, tc) {}

        public override double MaasHesapla(int dersSaati = 0)
        {
            return SabitUcret;
        }

        public void ZamYap()
        {
            SabitUcret *= 1.3;
        }
    }

    public class TeknikPersonel : Personel, IZamYapabilir
    {
        public double SabitUcret { get; set; } = 96000;

        public TeknikPersonel(string ad, string soyad, string tc) : base(ad, soyad, tc) {}

        public override double MaasHesapla(int dersSaati = 0)
        {
            return SabitUcret;
        }

        public void ZamYap()
        {
            SabitUcret *= 1.3;
        }
    }
}
