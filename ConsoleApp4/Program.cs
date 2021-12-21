﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Daire
    {
        public double r { get; set; }
        public virtual double Hesapla()
        {
            return Math.PI * r * r; 
        }
    }
    class Silindir:Daire
    {
        public double h { get; set; }
        public override double Hesapla()
        {
            return base.Hesapla() * h;
        }
    }
    class Koni:Silindir
    {
        public override double Hesapla()
        {
            return base.Hesapla() * 0.333333;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru3:Daire,silindir,koni örneğini polymorphism kullanarak yazınız.
            Daire d = new Daire() { r = 3 };
            Console.WriteLine(d.Hesapla());
            Daire s = new Silindir() { r = 3, h = 10 };
            Console.WriteLine(s.Hesapla());
            Daire k = new Koni() { r = 3, h = 10 };
            Console.WriteLine(k.Hesapla());
        }
    }
}
