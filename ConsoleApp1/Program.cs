using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Personel
    {
        public int PersonelID { get; set; }
        public string PersonedAd { get; set; }
        public string PersonelSoyad { get; set; }
        public double SatisMiktari { get; set; }
        public double Prim { get; set; }
        //public double Maas { get; set; }
        public abstract double MaasHesapla();

    }
    class Tamzamanli : Personel
    {
        public int Tabanucret { get; set; }
        public override double MaasHesapla()
        {
            Prim = SatisMiktari * 0.03;
            return Tabanucret + Prim;
        }
        //public Tamzamanli(int taban,int miktar)
        //{
        //    Tabanucret = taban;
        //    SatisMiktari = miktar;
        //    Prim = miktar * 3 / 100;
        //    Maas = taban + Prim;
        //    Console.WriteLine(Maas);
        //}
    }
    class Yarizamanli : Personel
    {
        public int CalistigiSaat { get; set; }
        public double Saatucreti { get; set; }
        public override double MaasHesapla()
        {
            Prim = SatisMiktari * 0.02;
            return (CalistigiSaat * Saatucreti) + Prim;
        }
        //public Yarizamanli(int saat,int ucret,int miktar)
        //{
        //    CalistigiSaat = saat;
        //    Saatucreti = ucret;
        //    Prim = miktar * 2 / 100;
        //    Maas = Prim + (saat * ucret);
        //    Console.WriteLine(Maas);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1: Bir satış firmasında iki farklı personel tipi istihtam edilmektedir. Tam zamanlı ve yarı zamanlı olmak üzere;Tam zamanlı çalışan personellerin maasları taban ucret+prim şeklinde hesaplanmaktadır. prim ise yaptıkları aylık satışın %3ü prim olarak maaslarına eklenir. Yarı zamanlı personellerin maası ise calıstığı saat * saat ucreti ;buna ilave olarak yaptıgı satısın %2si prim olarak verilmektedir.bu hesaplamalar icin gerekli olan uygulamayı yazınız.

            //Tamzamanli tam = new Tamzamanli(2866, 100);
            //Yarizamanli yari = new Yarizamanli(176, 10, 100);
            Tamzamanli cevdet = new Tamzamanli() { PersonelID = 111, PersonedAd = "cevdet", PersonelSoyad = "Korkmaz", Tabanucret = 3000, SatisMiktari = 10000 };
            Console.WriteLine(cevdet.MaasHesapla());
            Yarizamanli selami = new Yarizamanli() { PersonelID = 222, PersonedAd = "selami", PersonelSoyad = "dursun", CalistigiSaat = 10, Saatucreti = 100, SatisMiktari = 5000 };
            Console.WriteLine(selami.MaasHesapla());

            ArrayList List = new ArrayList();
            List.Add(cevdet);
            List.Add(selami);

            foreach (Personel p in List)
            {
                Console.WriteLine(p.MaasHesapla());
            }


        }
    }
}
