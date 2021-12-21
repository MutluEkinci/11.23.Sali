using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._11Salı
{
    class Uye
    {
        public static void Login()
        {

        }
    }
    class Admin : Uye
    {

    }
    abstract class Sekil
    {

    }
    class Kare : Sekil
    {

    }
    sealed class Kup : Kare
    {

    }
    //class zar : Kup
    static class Matematik//içindeki her şey static member olamk zorunda.
    {
        public static void Islem()
        {

        }
    }
    //static class Geometri : Matematik
    class Program
    {
        static void Main(string[] args)
        {
            /*
                          / new / :
            normal class  /  1  / 1
            abstract class/  0  / 1 (kütüphane amacıyla kullanılır.ortak özellikleri bir sonraki nesle aktarmak için kullanılır.)
            sealed class  /  1  / 0 (hiyerarşik yapıyı nerde sonlandırıcağımızı karar veririz.başkasının yazdığımız kodu çalmasını engeller.)
            static class  /  0  / 0 (hiç bişey tanımlamamıza gerek kalmadan içindeki metodları kullanmamızı sağlar.Bir class staticse içindeki her şey statictir.)
            */
            //Math m = new Math();
            //console
            //string str = "aaaaa";
            //string.
            //Array.
            //Array.Empty//dizi abstract yani içindeki obje belli değil,soyut bir kavram olduğu için array abstract bir sınıftır.

            Uye uye = new Uye();
            Admin admin = new Admin();
            //Sekil sekil = new Sekil();






        }
    }
}
