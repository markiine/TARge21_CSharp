using System;
using System.Collections.Generic;
using System.Linq;

namespace Kontrolltöö_Harjutamine_DMK
{
    class Program
    {
        static void Main(string[] args)
        {
            // P1_Tuttavad();
            // P2_Arvud();
            // P3_Vanused();
            // P4_Pikkused();
            P5_Sugu();


        }

        /// <summary>
        /// a. Loo kaks listi mehed ja naised
        /// b. Kumbagisse küsi kasutajalt vanuseid
        /// c. Loo alamprogramm, milles arvutatakse keskmine vanus
        /// d. Kirjuta ekraanile kummad on keskmiselt vanemad ja kui suur on erinevus
        /// </summary>

        private static void P5_Sugu()
        {
            List<int> mehed = new(); // using system mingi nr 2
            List<int> naised = new();
            Console.WriteLine("Sisesta vanuseid. Lõpetamiseks tee tühi sisestus - vajuta enter!");
            string input;
            bool onMees = true;

            do
            {
                input = KüsiVanust(onMees?mehed:naised, $"Sisesta {(onMees?"mehe":"naise")} vanus: ");
                onMees = !onMees;

            } while (input != string.Empty);

            double MehedKeskmine = ArvutaKeskmine(mehed);
            double NaisedKeskmine = ArvutaKeskmine(naised);

            if (MehedKeskmine > NaisedKeskmine)
            {
                Console.WriteLine($"Mehed on kesmiselt vanemad {MehedKeskmine - NaisedKeskmine} aasta võrra.");
            }
            else if (MehedKeskmine < NaisedKeskmine)
            {
                Console.WriteLine($"Naised on kesmiselt vanemad {NaisedKeskmine - MehedKeskmine} aasta võrra.");
            }
            else
            {
                Console.WriteLine($"Mehed ja naised on keskmiselt võrdselt vanad.");
            }

        }

        private static double ArvutaKeskmine(List<int> numbrid)
        {
            double summa = 0;
            foreach (var arv in numbrid)
            {
                summa += arv;
            }

            /* võib ka for-iga
            for (int i = 0; i < numbrid.Count; i++)  siin Count sest listiga tegemist
            {
                summa += numbrid[i];
            }*/

            return summa / numbrid.Count;
            // return numbrid.Average();  sama lahendus (system.linq on sees)
        }

        private static string KüsiVanust(List<int> list, string küsimus)
        {
            string input;
            Console.Write(küsimus);
            input = Console.ReadLine();
            if (input != string.Empty)
            {
                list.Add(int.Parse(input));
            }

            return input;
        }

        /// <summary>
        /// a. Loo massiiv 5 võrdselt jaotatud pikkusega
        /// b. Küsi kasutajalt 10 inimese pikkused
        /// c. Alamprogrammis leia millises pikkuse vahemikus on enim sisestusi
        /// d. Kuva tulemus ekraanile
        /// </summary>


        private static void P4_Pikkused()
        {
            int[] piirid = { 100, 125, 150, 175, 200 };   // tee if lausetega ja kohaindeksiga :)
            int[] pikkused = new int[10];
            for (int i = 0; i < pikkused.Length; i++)
            {
                Console.WriteLine($"Sisesta {i + 1}. inimese pikkus (cm):");
                int pikkus = int.Parse(Console.ReadLine());
                pikkused[i] = pikkus;
            }

            int EnamusÜlemIndex = LeiaEnamusPikkus(pikkused, piirid);

            if (EnamusÜlemIndex == 0)
            {
                Console.WriteLine($"Enamus pikkused on kuni {piirid[EnamusÜlemIndex]}");
            }

            else if (EnamusÜlemIndex == -1)
            {
                Console.WriteLine($"Enamus pikkusi on üle {piirid[piirid.Length-1]}");
            }

            else
            {
                Console.WriteLine($"Enamus pikkuseid jäi vahemikku {piirid[EnamusÜlemIndex - 1]} - {piirid[EnamusÜlemIndex]}");
            }
            

        }

        private static int LeiaEnamusPikkus(int[] pikkused, int[] piirid)
        {
            Array.Sort(piirid);
            int[] kogused = new int [piirid.Length];
            foreach (var pikkus in pikkused)
            {
                for (int i = 0; i < piirid.Length; i++)
                {
                    if (pikkus <= piirid[i])
                    {
                        kogused[i]++;
                        break;

                    }

                }
            }
            var enim = kogused.Max();
            var ÜlePiiri = pikkused.Length - kogused.Sum();

            if (ÜlePiiri > enim)
            {
                return -1;
            }
            return Array.IndexOf(kogused, enim);
        }




        /// <summary>
        /// a. Küsi kasutajalt 5 inimese nimed ja vanused salvesta need eraldi massiividesse
        /// b. Alamprogrammis leia vanima inimese nimi ja vanus
        /// c. Kuva tulemus ekraanile
        /// </summary>

        private static void P3_Vanused()
        {
            string[] nimed = new string[5];
            int[] vanused = new int[nimed.Length];

            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine($"Sisesta {i + 1}. nimi:");  // Line võib ära kustutada siis tuleb samale reale
                string nimi = Console.ReadLine();
                nimed[i] = nimi;
                Console.WriteLine($"Sisesta {nimi} vanus:");  // võib jätta {i + 1}.
                int vanus = int.Parse(Console.ReadLine());
                vanused[i] = vanus;

            }

            (string vanimaNimi, int vanimaVanus) = LeiaVanim(nimed, vanused);
            Console.WriteLine($"Kõige vanem on {vanimaNimi} ja ta on {vanimaVanus} aastane.");


        }

        private static (string vanimaNimi, int vanimaVanus) LeiaVanim(string[] nimed, int[] vanused)
        {
            var vanimNimi = "";
            var VanimVanus = 0;

            for (int i = 0; i < vanused.Length; i++)
            {
                if (vanused[i] > VanimVanus)
                {
                    VanimVanus = vanused[i];
                    vanimNimi = nimed[i];
                }
            }

            return (vanimNimi, VanimVanus);
        }



        /// <summary>
        /// a. Küsi kasutajalt üks arv vahemikus 5-10, ära jätka enne, kui arv on antud vahemikus
        /// b. Loo arvu suurune massiv
        /// c. Alamprogrammis - täida massiiv teadetega mitu korda kasutaja vale arvu sisestas
        /// d. Kuva massiivi andmed ekraanile
        /// </summary>

        private static void P2_Arvud()
        {
            int arv;
            int valeSisestused = -1;

            do
            {
                valeSisestused++;
                Console.WriteLine("Sisesta arv vahemikus 5-10:");
                arv = int.Parse(Console.ReadLine());

            } while (arv < 5 || arv > 10);

            string[] teated = new string[arv];
            TäidaTeatedega(teated, valeSisestused);

            foreach (var teade in teated)
            {
                Console.WriteLine(teade);
            }

        }

        private static void TäidaTeatedega(string[] teated, int valeSisestused)
        {
            string teade = $"Sisestasid arvu valesti {valeSisestused} korda.";
            Array.Fill(teated, teade);

            /* (Array on lihtsam)

            for (int i = 0; i < teated.Length; i++)
            {
                teated[i] = teade;
            }*/
        }



        /// <summary>
        /// a. Loo massiv 3 nimega
        /// b. Küsi kasutajalt iga nime kohta kas ta tunneb teda, kui ei tunne lase uus nimi sisestada
        /// c. Alamprogrammiga asendada massiivis tundmatu nimi sisestatuga
        /// d. Kirjuta ekraanile kõik nimed eraldi reale
        /// </summary>

        private static void P1_Tuttavad()
        {
            string[] nimed = { "Jane", "Anni", "Eve" };
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine($"Kas tunnete nime {nimed[i]} (jah/ei)?");
                string vastus = Console.ReadLine();
                if (vastus == "ei")
                {
                    Console.WriteLine("Sisesta tuttava nimi:");
                    string uusNimi = Console.ReadLine();
                    AsendaNimi(nimed, i, uusNimi);
                }
            }
            Console.WriteLine("Sinu tuttavad:");
            foreach (var nimi in nimed)
            {
                Console.WriteLine($"{nimi}");
            }
        }
        private static void AsendaNimi(string[] nimed, int i, string uusNimi)
        {
            nimed[i] = uusNimi;
        }



    }
}
