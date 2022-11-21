using System;

namespace Alamprogramm
{
    class Program
    {
        /*
        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }
        public static void Main(string[] arg)
        {
            int a = 4;
            int b = 6;
            Console.WriteLine("{0} korda {1} on {2}", a, b, Korruta(a, b));
            Console.WriteLine(Korruta(3, 5));
        */

        /*
        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }
        public static int Liida(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        public static int Lahuta(int arv1, int arv2)
        {
            return arv1 - arv2;
        }
        public static void Main(string[] arg)
        {
            int arv1 = 4;
            int arv2 = 6;
            Console.WriteLine("{0} korda {1} on {2}", arv1, arv2, Korruta(arv1, arv2));
            Console.WriteLine(Korruta(3, 5));
            double tulemus = Jaga(arv1, arv2);

            Console.WriteLine($"{arv1}+{arv2} = {Liida(arv1, arv2)}");
            Console.WriteLine($"{arv1}-{arv2} = {Lahuta(arv1, arv2)}");
            Console.WriteLine($"{arv1}/{arv2} = {tulemus}");
        }

        private static double Jaga(int arv1, int arv2)
        {
            return arv1 * 1.0 / arv2; //võib ka panna arv1 ette (double) muutes arv1 komaga arvuks 
        }

        */

        /*

        // Koosta alamprogramm kahe arvu keskmise leidmiseks.

        public static double Keskmine(int arv1, int arv2)
        {
            return (arv1 + arv2) / 2; //saab ka kasutada Liida ja Jaga funktsiooni ülevalt, Jaga(Liida(arv1, arv2),2);
        }
        public static void Main(string[] arg)
        {
            int arv1 = 4;
            int arv2 = 6;
            Console.WriteLine($"Arvude {arv1} ja {arv2} keskmine on {Keskmine(arv1,arv2)}");
        }

        // Console.WriteLine("{0} on kahe arvu keskmine arv.", Keskmine(a,b));

        */

        /*

        // Koosta alamprogramm etteantud arvu tärnide väljatrükiks.Katseta.

        public static void TrükiTärnid(int arv1)
        {
            for (int i = 0; i < arv1; i++)
            {
                Console.WriteLine("*");
            }


        }
        public static void Main(string[] arg)
        {
            int arv1 = 4;
            TrükiTärnid(arv1);
        }

        */

        /*

        // Küsi inimeselt kolm arvu. Iga arvu puhul joonista vastav kogus tärne ekraanile.

        
        public static void TrükiTärnid(int arv1)
        {
            for (int i = 0; i < arv1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


        public static void Main(string[] arg)
        {
            Console.WriteLine("Sisesta esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());
            TrükiTärnid(arv1);
            Console.WriteLine("Sisesta teine arv: ");
            int arv2 = int.Parse(Console.ReadLine());
            TrükiTärnid(arv2);
            Console.WriteLine("Sisesta kolmas arv: ");
            int arv3 = int.Parse(Console.ReadLine());
            TrükiTärnid(arv3);

        }

        */



        // Tärnid täiendusega /
        // Teha läbi õppematerjali Alamprogrammi osa ja lahendada ülesanded.Järgnev käib viimase osa täienduseks.
        // Koosta programm, mis kutsub seda funktsiooni välja 30 korda juhuslike positiivsete täisarvudega, mis on väiksemad kui 20. Näiteks:
        // ************
        // *********
        // **********************
        // *******
        // [...]
        // Täienda programmi:
        // Iga rea ette kirjutatakse arv, mitu sümbolit on reas.
        // 3 * * *
        // 5 * * * * *
        // [...]
        // Funktsiooni kutsutakse välja mitte 30 korda, vaid juhuslik arv kordi vahemikus 20 kuni 40.
        // Funktsioon saab ette ühe argumendi asemel kaks argumenti: lisaks arvule ka sümboli, mida trükitakse.
        // TrykiTärnid(4,"@")
        // 4 @ @ @ @
        // Lahendusena saata Program.cs faili sisu kirja sisuna aadressile kristjan.kivikangur @tthk.ee
        // Kirja teemaks panna "rühmanimi, omanimi, C# alamprogramm"


        public static void TrükiTärnid(int arv1, string sümbol)
        {
            Console.Write($" {arv1}");
            for (int i = 0; i <= arv1; i++)
            {
                Console.Write($"{sümbol}");
            }
        }
        public static void Main(string[] args)
        {
            Random suvaline = new Random();
            int juhuslikarv1 = suvaline.Next(20, 40);

            TrükiTärnid(juhuslikarv1, " @");

        }
    }
}