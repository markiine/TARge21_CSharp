
using System;

namespace Kordused
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("WHILE");
            int loendur = 1;
            while (loendur <= 5)
            {
                Console.WriteLine($"Tere {loendur}. matkaja");
                loendur++;
            }
            Console.WriteLine("FOR");
            for (int nr = 0; nr < 5; nr++)
            {
                Console.WriteLine($"Tere {nr+1}. matkaja");
            }
            Console.WriteLine("FOREACH");
            int[] arvud = { 1, 2, 3, 4, 5 };
            foreach (var arv in arvud)
            {
                Console.WriteLine($"Tere {arv}. matkaja");
            }
            Console.WriteLine("DO WHILE");
            int jrkNR = 0;
            do
            {
                Console.WriteLine($"Tere {++jrkNR}. matkaja");
            } while (jrkNR < 5);

            Console.WriteLine();
            Console.WriteLine();
            
            int tund;
            do
            {
                Console.WriteLine("Sisesta tund vahemikus 0-23");
                tund = int.Parse(Console.ReadLine());
            } while (tund < 0 || tund > 23);
            Console.WriteLine("Tubli, sisestasid {0}.", tund);

            */

            /*
             // Trüki arvude ruudud ühest kahekümneni
             int nr = 1;
             int ruut;
             while (nr <= 20)
             {
                 ruut = nr * nr;
                 Console.WriteLine($"{ruut}");
                 nr += 1;
             }

             */

            /*
            // Küsi kasutajalt viis arvu ning väljasta nende summa
            
                    // Console.WriteLine("Sisesta esimene arv:");
                    // int arv1 = int.Parse(Console.ReadLine());
                    // Console.WriteLine("Sisesta teine arv:");
                    // int arv2 = int.Parse(Console.ReadLine());
                    // Console.WriteLine("Sisesta kolmas arv:");
                    // int arv3 = int.Parse(Console.ReadLine());
                    // Console.WriteLine("Sisesta neljas arv:");
                    // int arv4 = int.Parse(Console.ReadLine());
                    // Console.WriteLine("Sisesta viies arv:");
                    // int arv5 = int.Parse(Console.ReadLine());

                    // Console.WriteLine("Viie arvu summa on {0}.", arv1 + arv2 + arv3 + arv4 + arv5);
            */


            int summa = 0;
            for (int nr = 1; nr <= 5; nr++)

            {
                Console.WriteLine("Sisesta {0}. arv:", nr);
                int arv = int.Parse(Console.ReadLine());
                summa += arv;

            }


            Console.WriteLine("Viie arvu summa on {0}.", summa);






            // Ütle kasutajale "Osta elevant ära!". Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant".

            string vastus;
            do
            {
                Console.WriteLine("Osta elevant ära!");
                vastus = Console.ReadLine();
            }
            while (vastus != "elevant");
            Console.WriteLine("Tubli!");



        }
    }
}
    