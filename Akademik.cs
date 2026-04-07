
using System;

namespace UPMS
{
    public class Profesor : Personel, IZamYapabilir
    {
        public double SabitUcret { get; set; } = 200000;
        public int DersSaati { get; set; }
        public double DersSaatUcreti { get; set; } = 3000;

        public Profesor(string ad, string soyad, string tc, int dersSaati) : base(ad, soyad, tc)
        {
            DersSaati = dersSaati;
        }

        public override double MaasHesapla(int dersSaati = 0)
        {
            return SabitUcret + (DersSaati * DersSaatUcreti);
        }

        public void ZamYap()
        {
            SabitUcret *= 1.2;
            DersSaatUcreti *= 1.5;
        }
    }

    public class Docent : Personel, IZamYapabilir
    {
        public double SabitUcret { get; set; } = 160000;
        public int DersSaati { get; set; }
        public double DersSaatUcreti { get; set; } = 2000;

        public Docent(string ad, string soyad, string tc, int dersSaati) : base(ad, soyad, tc)
        {
            DersSaati = dersSaati;
        }

        public override double MaasHesapla(int dersSaati = 0)
        {
            return SabitUcret + (DersSaati * DersSaatUcreti);
        }

        public void ZamYap()
        {
            SabitUcret *= 1.2;
            DersSaatUcreti *= 1.5;
        }
    }

    public class DrOgretimUyesi : Personel, IZamYapabilir
    {
        public double SabitUcret { get; set; } = 130000;
        public int DersSaati { get; set; }
        public double DersSaatUcreti { get; set; } = 1000;

        public DrOgretimUyesi(string ad, string soyad, string tc, int dersSaati) : base(ad, soyad, tc)
        {
            DersSaati = dersSaati;
        }

        public override double MaasHesapla(int dersSaati = 0)
        {
            return SabitUcret + (DersSaati * DersSaatUcreti);
        }

        public void ZamYap()
        {
            SabitUcret *= 1.2;
            DersSaatUcreti *= 1.5;
        }
    }

    public class ArastirmaGorevlisi : Personel, IZamYapabilir
    {
        public double SabitUcret { get; set; } = 100000;

        public ArastirmaGorevlisi(string ad, string soyad, string tc) : base(ad, soyad, tc) {}

        public override double MaasHesapla(int dersSaati = 0)
        {
            return SabitUcret;
        }

        public void ZamYap()
        {
            SabitUcret *= 1.2;
        }
    }
}
