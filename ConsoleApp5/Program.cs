using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Kare
    {
        public ConsoleColor Renk { get; set; }
        public int Uzunluk { get; set; }
        public int Genislik { get; set; }
        public virtual void Cizdir()
        {
            Console.ForegroundColor = Renk;
            for (int i = 0; i < Uzunluk; i++)
            {
                for (int j = 0; j < Genislik; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
    class Ucgen:Kare
    {
        public override void Cizdir()
        {
            Console.ForegroundColor = Renk;
            for (int i = 0; i <= Uzunluk; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 4:Ekrana kare,dortgen ya da ucgen cizebilen nesneleri oop kullanarak yazınız.

            ArrayList sekiller = new ArrayList();
            sekiller.Add(new Kare() { Genislik = 10, Uzunluk = 10, Renk = ConsoleColor.White });
            sekiller.Add(new Ucgen() { Genislik = 15, Uzunluk = 20, Renk = ConsoleColor.DarkBlue });
            
            Kare k = new Kare() { Uzunluk = 5, Genislik = 5, Renk = ConsoleColor.Red };
            k.Cizdir();
            Kare u = new Ucgen() { Uzunluk = 5, Genislik = 8 ,Renk=ConsoleColor.Yellow};
            u.Cizdir();
            foreach (Kare a in sekiller)
            {
                a.Cizdir();
            }

        }
    }
}
