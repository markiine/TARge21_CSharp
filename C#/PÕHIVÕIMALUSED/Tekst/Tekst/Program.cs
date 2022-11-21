using System;

namespace Tekst
{
    class Program
    {
        /*
        public static void Main(string[] arg)
        {
            string s = "Juku tuli kooli";
            Console.WriteLine("Pikkus: " + s.Length);
            Console.WriteLine(s.Substring(5, 4));
            Console.WriteLine("'tuli' kohal " + s.IndexOf("tuli"));

            string s2 = s.Insert(9, " vara");
            Console.WriteLine(s2);
            string s3 = s.Remove(5, 5); //Kuuendast alates viis tähte
            Console.WriteLine(s3);
            if (s.StartsWith("Juku"))
            {
                Console.WriteLine("Algab Jukuga");
            }
            if (s.IndexOf("kala") == -1)
            {
                Console.WriteLine("Siin ei ole kala");
            }
            Console.WriteLine(s.Replace("tuli", "jooksis"));

            Console.WriteLine("");

            string l = "Tallinn,Tartu,Narva";
            string[] linnad = l.Split(new char[] { ',' });
            foreach (string linn in linnad)
            {
                Console.WriteLine(linn);
            }
            Console.WriteLine(String.Join("; ", linnad));

            Console.WriteLine("");

            string nimedSõne = "Mia Mall Mell";
            string[] nimed = nimedSõne.Split();
            foreach (var nimi in nimed)
            {
                Console.WriteLine(nimi);
            }

            Console.WriteLine(string.Join(" ja ", nimed)); // nii ei ole Mia Mall ja Mell vahel tühja
        }
        */
        

        
        //////   ÜLESANDED  ///////

        public static void Main(string[] arg)
        {
            // Trüki inimese nime eelviimane täht

            Console.WriteLine("Sisestage nimi:");
            string nimi = Console.ReadLine();
            int nimePikkus = nimi.Length;
            Console.WriteLine($"Nime eelviimane täht on {nimi[nimePikkus - 2]}");

            // Teata, kas sisestatud nimi algab A-ga

            if (nimi.ToLower().StartsWith("a"))
            {
                Console.WriteLine("Nimi algab A-ga");
            }

            else
                Console.WriteLine("Nimi ei alga A-ga");

            // Trüki sisestatud nimi välja suurtähtedega

            Console.WriteLine(nimi.ToUpper());



            // Teata, kas lauses leidub sõna "ja"

            Console.WriteLine("Sisesta lause:");
            string s = Console.ReadLine();

            // string s = "Malle ja Kalle rääkisid pargipingil juttu.";
            if (s.IndexOf(" ja ") == -1)
            {
                Console.WriteLine("Siin lauses ei ole ja-d");
            }
            else
                Console.WriteLine("Siin lauses on ja");

            // Asenda olemasolu korral "ja" sõnaga "ning" ja teata asendusest

                Console.WriteLine(s.Replace(" ja ", " ning "));

            // Trüki välja lause kõige pikem sõna

            Console.WriteLine("Lause pikkus: " + s.Length);
            string[] lause = s.Split(new char[] { ' ' });
            Boolean first = true;
            string longest = "";
            foreach (string sõna in lause)
            {
                // Console.WriteLine(sõna);
                // Console.WriteLine(sõna.Length);
                if (first)
                {
                    longest = sõna;
                    first = false;

                }

                if (sõna.Length > longest.Length)
                {
                    longest = sõna;
                }
            }

            Console.WriteLine(longest);

            }
     

        }
    }