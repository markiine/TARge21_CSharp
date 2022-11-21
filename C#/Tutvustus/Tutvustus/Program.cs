using System;

namespace Tutvustus
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var arv1 = 11; // väärtustüüp
            var arv2 = arv1; // var arv2 = 11

            var arvud = new[] { 1, 2, 3 };
            var numbrid = arvud;
            numbrid[0] = 11;
            Console.WriteLine(arvud[0]);
            */

            //////  TUND - Punkti programmiga teisel lehel //////

            // KLASSIMUUTUJA
            Punkt.KuvaPunktideKogus();

            var p1 = new Punkt(3, 4, 5);  // isend punktiklassist
            Punkt p2 = p1;
            Console.WriteLine(p1.GetX());
            Console.WriteLine(p2.GetX());
            p2.SEtX(5);

            Console.WriteLine(p1.GetX());
            Console.WriteLine(p2.GetX());
            Console.WriteLine(p1.GetKaugusNullist());

            Punkt.KuvaPunktideKogus(); // KLASSIMUUTUJA


            // PUNKTIMASSIV
            Punkt[] punktid = new Punkt[50];  // tekitab mälupiirkonna nt 50 punkti jaoks
            Random random = new Random();
            Console.WriteLine(punktid[5]); // tühja rea väljastab, sest pole
            for (int i = 0; i < punktid.Length; i++)  // tsükkel tekitab masiivi punktid
            {
                punktid [i] = new Punkt(random.Next(), random.Next(), random.Next());
            }

            Punkt.KuvaPunktideKogus();
            Console.WriteLine(punktid[5]);

            //////// ÜLESANDED ////////

            /*
            /// Koosta klass riidelapi andmete hoidmiseks: pikkus, laius, toon
            /// Lisa käsklus lapi andmete väljatrükiks

            var lapp1 = new Riidelapp(1500, 2000, "sinine");
            lapp1.KuvaAndmed();

            /// Lisa käsklus lapi pindala arvutamiseks
            int pindala = lapp1.AnnaPindala();

            /// Lisa meetod(alamprogramm) lapi poolitamiseks: pikem külg tehakse poole lühemaks.
            lapp1.Poolita();
            lapp1.KuvaAndmed(); // Pikkus on 1500; Laius on 1000
            lapp1.Poolita();
            lapp1.KuvaAndmed(); // Pikkus on 750; Laius on 1000

            /// Poolitamise meetod lisaks algse lapi poolitamisele väljastab ka uue samasuguse algsest poole väiksema eksemplari.
            Riidelapp lapp2 = lapp1.PoolitaUuega();
            Console.WriteLine("----- UUEGA POOLITAMINE -----");
            lapp1.KuvaAndmed();
            lapp2.KuvaAndmed();

            /// Lisa teine poolitusmeetod, kus saab määrata, mitme protsendi peale lõigatakse pikem külg
            Riidelapp lapp3 = lapp1.Poolita(25);
            Console.WriteLine("----- PROTSENDIGA POOLITAMINE -----");
            lapp1.KuvaAndmed();
            lapp3.KuvaAndmed();
            */




        }
    }
}
