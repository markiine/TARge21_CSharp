using System;

namespace OmaloodudAndmestruktuur
{
    /*
    struct Punkt
    {
        public int x;
        public int y;
        public string nimi;
    }

    class Program
    {
    */
        /*
        public static void Main(string[] arg)
        {
            Punkt p1;
            p1.x = 3;
            p1.y = 5;
            Punkt p2 = p1;  //Väärtused kopeeritakse
            p1.x = 2;
            Console.WriteLine(p2.x + " " + p2.y);
        }
        

        public static void Main(string[] arg)
        {
             Punkt[] pd = new Punkt[10]; //mälu kohe olemas
             for (int i = 0; i < 10; i++)
             {
                 pd[i].x = i;
                 pd[i].y = i * i;
             }
             Console.WriteLine(pd[4].y);
        }
        */

        /*
        public static void Main(string[] arg)
        {
            // a-1,2 b-3,4 c-4,5
            Punkt a;
            a.x = 1;
            a.y = 2;
            a.nimi = "a"; // üles sai lisatud string nimi
            Punkt b;
            b.x = 3;
            b.y = 4;
            b.nimi = "b";
            Punkt c;
            c.x = 5;
            c.y = 5;
            c.nimi = "c";
            int[] xid = { 1, 3, 4 };
            int[] yid = { 2, 4, 5 };
            Punkt[] punktid = new Punkt[3] { a, b, c };

            Console.WriteLine(a.x + " " + punktid[0].x);
            a.x = 11;
            a.nimi = "null";
            Console.WriteLine(a.x + " " + punktid[0].x);
            // punktimasiiv
        }
        */
        


        /////// ÜLESANDED //////


        // Koosta struktuur riidelappide andmete hoidmiseks: pikkus, laius, toon
        // Katseta loodud andmetüüpi paari eksemplariga.
        // Loo lappidest väike massiiv, algväärtusta juhuarvude abil.
        // Trüki välja lappide andmed, mille mõlemad küljepikkused on vähemalt 10 cm.


    struct Riidelapp
    {
        public int p;
        public int l;
        public string t;
    }

    class Program
    {
        public static void Main(string[] arg)
        {
            string[] toonid = { "roheline", "valge", "punane" };
            Random r = new Random();
            Riidelapp a;
            a.p = 10;
            a.l = 20;
            a.t = "must"; // üles sai lisatud string nimi
            Riidelapp b;
            b.p = 30;
            b.l = 20;
            b.t = "kollane";
            Riidelapp c;
            c.p = 5;
            c.l = 5;
            c.t = "sinine";

           
            Console.WriteLine($"Pikkus: {a.p} \nLaius: {a.l} \nToon: {a.t}");
            Console.WriteLine($"Pikkus: {b.p} \nLaius: {b.l} \nToon: {b.t}");
            Console.WriteLine($"Pikkus: {c.p} \nLaius: {c.l} \nToon: {c.t}");


            Riidelapp[] lapid = new Riidelapp[10];
            for (int i = 0; i < lapid.Length; i++)
            {
                lapid[i].p = r.Next(1, 50);
                lapid[i].l = r.Next(1, 30);
                lapid[i].t = toonid[r.Next(toonid.Length)];

                if (lapid[i].p >= 10 && lapid[i].l >= 10)
                {
                    Console.WriteLine($"{i + 1} Pikkus: {lapid[i].p} Laius: {lapid[i].l} Toon: {lapid[i].t}");
                }

            }

        }

    }
}
