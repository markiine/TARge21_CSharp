using System;
using System.IO;

namespace TekstiFailid
{
    class Program
    {
        /*
        public static void Main(string[] arg)
        {
            FileStream f = new FileStream("inimesed.txt", FileMode.Create, FileAccess.Write);
            // FileMode.Create loomine, FileMode.Append lisamine
            StreamWriter valja = new StreamWriter(f);
            valja.WriteLine("Juku");
            valja.WriteLine("Kati");
            valja.Close(); // tekstifail läheb bin-i sisse kaugee peitu
        }
        */

        /*
        //loopimisel ei saa nii kasutada
        public static void Main(String[] arg)
        {
            File.WriteAllText("tervitus.txt", "tere maailm"); // File.AppendAllText("tervitus.txt", "\nkuku");
        }
        */

        /*
        public static void Main(string[] arg)
        {
            FileStream f = new FileStream("inimesed.txt", FileMode.Append, FileAccess.Write);
            StreamWriter valja = new StreamWriter(f);
            valja.WriteLine("Siim");
            valja.WriteLine("Sass");
            valja.Close();
        }
        */

        /*
        public static void Main(string[] arg)
        {
            FileStream f = new FileStream("nimekesed.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(f);
            string nimi = string.Empty;
            do
            {
                Console.WriteLine("Sisesta nimi, mida salvestada: ");
                nimi = Console.ReadLine();
                if (nimi != "")
                {
                    writer.WriteLine(nimi);
                }
            }
            while (nimi != "");
            writer.WriteLine("Rasmus");
            writer.WriteLine("Mia");
            writer.Close(); // tekstifail läheb bin-i sisse kaugele peitu
        }
        */


        /*
        public static void Main(string[] arg)
        {
            FileStream f = new FileStream("tervitus.txt", FileMode.Open, FileAccess.Read);
            StreamReader sisse = new StreamReader(f);
            string rida = sisse.ReadLine();
            while (rida != null)
            {
                Console.WriteLine(rida);
                rida = sisse.ReadLine();

            }
        }
        */

        /*
        public static void Main(string[] arg)
        {
            var nimed = File.ReadAllLines("nimekesed.txt");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {nimed[i]}");
            }
        }
        */


        /*
        public static void Main(string[] arg)
        {
            String[] andmed = File.ReadAllLines("tervitus.txt");
            for (int i = 0; i < andmed.Length; i++)
            {
                Console.WriteLine(i + ". " + andmed[i]);

            }

        }
        */



        ///////  ÜLESANDED //////


        /*
        public static void Main(string[] arg)
        {
            FileStream fail = new FileStream("ülesanded.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fail);

            int nr = 1;
            int ruut;
            int kokku;
            int summa = 0;

            while (nr <= 20)
            {
                ruut = nr * nr;
                kokku = nr * ruut;
                writer.WriteLine($"{nr} {ruut} {kokku}");
                nr += 1;
                summa += kokku;
            }
            writer.WriteLine($"Summa on: {summa}");
            Console.WriteLine($"Summa on: {summa}");

            writer.Close();
        */




        // Tekita programmi abil fail, milles oleksid arvud ja nende ruudud ühest kahekümneni.

        public static void Main(string[] arg)
        {
            FileStream fail = new FileStream("ruudud.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fail);

            int nr = 1;
            int ruut;
            
            while (nr <= 20)
            {
                ruut = nr * nr;
                writer.WriteLine($"{nr} {ruut}");
                nr += 1;
            }
            
            writer.Close();


        // Iga hinna kõrval on ka selle hinnaga müüdud kauba kogus. Korruta igal real hind kogusega ning liida lõpuks summad kokku.

            var HinnadKogused = File.ReadAllLines("ruudud.txt");
            var summa = 0;
            foreach (var rida in HinnadKogused)
            {
                var hind_kogus = rida.Split();
                var hind = int.Parse(hind_kogus[0]);
                var kogus = int.Parse(hind_kogus[1]);
                summa += hind * kogus;
            }

            Console.WriteLine($"Summa on: {summa}");


        // Võrreldes eelmise ülesandega kirjuta teise faili igale reale esimese faili vastaval real oleva hinna ja koguse korrutis.
            
            FileStream f = new FileStream("hinnad.txt", FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(f);

            foreach (var read in HinnadKogused)
            {
                var hind_kogus = read.Split();
                var hind = int.Parse(hind_kogus[0]);
                var kogus = int.Parse(hind_kogus[1]);
                summa += hind * kogus;
                write.WriteLine(hind * kogus);
                
            }

            write.Close();


        // Tekstifaili igal real on müüdud kauba hind. Arvuta programmi abil nende hindade summa.

            f = new FileStream("hinnad.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(f);
            string line = reader.ReadLine();
            summa = 0;
            while (line != null)
            {
                summa += int.Parse(line);
                line = reader.ReadLine();
            }
            Console.WriteLine($"Summa on: {summa}");

        }
    }
}