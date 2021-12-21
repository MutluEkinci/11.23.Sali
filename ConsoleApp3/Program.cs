using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Musteri
    {
        public int MusID { get; set; }
        public string MusAdSoyad { get; set; }
        public double Cari { get; set; }

        public override string ToString()
        {
            return MusID + " " + MusAdSoyad + " " + Cari;
        }
    }
    class Personel
    {
        public int PerID { get; set; }
        public string PerAdSoyad { get; set; }
        public int Maas { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru2:Personel ve musteri siniflari olusturup icerisindeki datalari ekrana yazdiriniz.

            Musteri m = new Musteri() { MusID = 111, MusAdSoyad = "Cevdet Korkmaz", Cari = -1000 };
            Personel p = new Personel() { PerID = 234, PerAdSoyad = "Selami Dursun", Maas = 4500 };
            Console.WriteLine(m.MusID + " " + m.MusAdSoyad + " " + m.Cari);
            Console.WriteLine(p.PerID + " " + p.PerAdSoyad + " " + p.Maas);

            Console.WriteLine(m);
            Console.WriteLine(p);
            Console.WriteLine(m.ToString());//tostringini çağırdı.ama gerek yok zaten yazmasak da çağırıyor.
            Console.WriteLine(p.ToString());


        }
    }
}
