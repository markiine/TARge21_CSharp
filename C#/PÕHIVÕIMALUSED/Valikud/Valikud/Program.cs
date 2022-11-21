/*
using System;

namespace Valikud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun nimi:");
            string eesnimi = Console.ReadLine();
            if (eesnimi == "Mari")
            {
                Console.WriteLine("Tule homme minu juurde!");
            }
            else
            {
                Console.WriteLine("Mind pole homme kodus.");
            }

            Console.WriteLine();

            Console.WriteLine("Sisesta oma vanus:");
            int vanus = int.Parse(Console.ReadLine());
            if (vanus > 6 && vanus <= 14) // 7-14
            {
                Console.WriteLine("Sinu jaoks on lapsepilet");
            }
            if (vanus < 7 || vanus > 14) // mitte 7-14
            {
                Console.WriteLine("Sulle lapsepilet ei sobi");
            }

            Console.WriteLine();

            decimal pirnihind = 1.70M;
            Console.WriteLine("Mitu pirni ostad?");
            decimal kogus = decimal.Parse(Console.ReadLine());
            decimal summa = kogus * pirnihind; // korrutatakse ühe pirni hinnaga
            Console.WriteLine("Kas kilekotti ka soovid? (jah/ei)");
            string vastus = Console.ReadLine();
            if (vastus == "jah")
            {
                summa += 0.7m;
            }
            Console.WriteLine($"Kogusumma: {summa}");


            Console.WriteLine();
            */

using System;

namespace Valikud
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            // Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi(soovitav toasoojus talvel).

            Console.WriteLine("Sisesta toa temperatuur:");
            int temperatuur = int.Parse(Console.ReadLine());

            if (temperatuur > 18)
            {
                Console.WriteLine("Talve korral on piisavalt soe.");
            }
            else
            {
                Console.WriteLine("Hakka kütma.");
            }

            Console.WriteLine();
            */


            /*
            // Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk(piirid pane ise paika)

            int lühikePiir = 150;
            int pikkPiir = 180;

            Console.WriteLine("Palun sisesta oma pikkus sentimeetrites:");
            int pikkus = int.Parse(Console.ReadLine());

            if (pikkus < lühikePiir)
            {
                Console.WriteLine("Oled lühikest kasvu");
            }
            else if (pikkus > pikkPiir)
            {
                Console.WriteLine("Oled pikka kasvu");
            }
            else
            {
                Console.WriteLine("Oled keskmist kasvu");
            }

            Console.WriteLine();
            */


            /*
            // Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk(mitu tingimusplokki võib olla üksteise sees).
            int mehelühikePiir = 160;
            int mehepikkPiir = 190;
            int naiselühikePiir = 150;
            int naisepikkPiir = 180;

            Console.WriteLine("Sisesta oma pikkus sentimeetrites:");
            int suguPikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Kas oled mees? [jah/ei]");
            string suguMees = Console.ReadLine().ToLower();

            if (suguPikkus < mehelühikePiir && suguMees == "jah" ||
                suguPikkus < naiselühikePiir && suguMees != "jah")
            {
                Console.WriteLine("Oled lühikest kasvu.");
            }
            else if (suguPikkus > mehepikkPiir && suguMees == "jah" ||
                suguPikkus > naisepikkPiir && suguMees != "jah")
            {
                Console.WriteLine("Oled pikka kasvu.");
            }
            else
            {
                Console.WriteLine("Oled keskmist kasvu.");
            }
            
            Console.WriteLine();
            */


            // Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.
            decimal piimHind = .6m;
            decimal saiHind = .8m;
            decimal leibHind = 1.19m;
            decimal summa = 0;

            Console.WriteLine($"Kas soovid piima {piimHind} eurot?");
            if (Console.ReadLine().ToLower() == "jah")
            {
                summa += piimHind;
            }
            Console.WriteLine($"Kas soovid piima {saiHind} eurot?");
            if (Console.ReadLine().ToLower() == "jah")
            {
                summa += saiHind;
            }
            Console.WriteLine($"Kas soovid leiba {leibHind} eurot?");
            if (Console.ReadLine().ToLower() == "jah")
            {
                summa += leibHind;
            }
            Console.WriteLine($"Ostetud kraam läheb kokku maksma {summa} eurot.");
        }
    }
}