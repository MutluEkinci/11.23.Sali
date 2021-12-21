using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Araba
    {
        public virtual void Sur()
        {
            Console.WriteLine("Araba Sür....");
        }
    }
    class Ferrari:Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Ferrari Sür....");
        }
    }
    class BMW : Araba
    {
        public override void Sur()
        {
            Console.WriteLine("BMW Sür....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {/*
           3-)Polymorphism(Çok Şekillilik,Çok biçimlilik)
           Aynı isimli bir memberin farklı sınıflarda farklı şekillerde çalışmasına denir.Özel bir durumun çözümüdür aslında.Her yerde karşımıza çıkıcak.
         */

            //Araba a1 = new Araba();
            //Ferrari f1 = new Ferrari();
            //BMW b1 = new BMW();
            Araba a1 = new Araba();
            Araba f1 = new Ferrari();
            Araba b1 = new BMW();

            a1.Sur();
            f1.Sur();
            b1.Sur();
            
        }
    }
}
