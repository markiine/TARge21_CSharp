using System;
using System.Collections.Generic;
using System.IO;

namespace Kangelane
{
    class Program
    {
        static void Main(string[] args)
        {
            string fail = "kangelased.txt";
            LoeFaili(fail); // loeme failist info sisse

            // loome andmete põhjal kangelased, lisame nad kangelaste listi ja rakendame päästa funktsiooni 1000 inimese kohta 
            int päästetavad = 1000;
            int i = 0;
            while (i < nimed.Count)
            {
                if (nimed[i].Contains("*"))
                {
                    SuperKangelane superkangelane = new SuperKangelane(nimed[i], asukohad[i]);
                    kangelased.Add(superkangelane);
                    Console.WriteLine("Loodi superkangelane! " + superkangelane);
                    Console.WriteLine(superkangelane.Nimi + " päästis " + päästetavad + " inimesest " + superkangelane.Päästa(päästetavad));
                }
                else
                {
                    Kangelane kangelane = new Kangelane(nimed[i], asukohad[i]);
                    kangelased.Add(kangelane);
                    Console.WriteLine("Loodi kangelane! " + kangelane);
                    Console.WriteLine(kangelane.Nimi + " päästis " + päästetavad + " inimesest " + kangelane.Päästa(päästetavad));
                }
                i++;
            }
            // kontrolliks väljastame kangelaste listi
            Console.WriteLine("----------------------");
            kangelased.ForEach(i => Console.WriteLine(i));
        }

        public static List<string> nimed = new List<string>();
        public static List<string> asukohad = new List<string>();
        public static List<Kangelane> kangelased = new List<Kangelane>();

        public static void LoeFaili(string input)
        {
            FileStream f = new FileStream(input, FileMode.Open, FileAccess.Read);
            StreamReader sisse = new StreamReader(f);
            string rida = sisse.ReadLine();

            while (rida != null)
            {
                string[] words = rida.Split("/"); // eraldame nime ja asukoha

                // lisame kangelase nime ja asukoha listi ja hakkame töötama uuega
                nimed.Add(words[0]);
                asukohad.Add(words[1]);
                rida = sisse.ReadLine();
            }
        }
    }
}