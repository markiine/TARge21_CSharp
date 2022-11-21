using System;

namespace Juhuarv
{
    class Program
    {
        /*
        public static void Main(string[] arg)
        {
            Random r = new Random();
            Console.WriteLine(r.Next());
            Console.WriteLine(r.NextDouble()); //Nullist üheni
            Console.WriteLine(r.NextDouble()); //Nullist üheni
            Console.WriteLine(r.Next(20)); //Täisarv alla 20
            Console.WriteLine(r.Next(50, 100)); //Viiekümnest sajani
            string[] nimed = { "Juku", "Kati", "Mati" };
            Console.WriteLine(nimed[r.Next(nimed.Length)]); //Juhuslik nimi

        }
        */


        ////// ÜLESANDED //////

        // Trüki juhuslike teguritega korrutamisülesanne // loopima lisaks

        public static void Main(string[] arg)
        {
            Random r = new Random();
            int õigeid = 0;
            while (õigeid < 5)
            {
                int a = r.Next(10);
                int b = r.Next(10);
                int õige = a * b;

                Console.Write($"{a} * {b} = ");
                int vastus = int.Parse(Console.ReadLine());


                // Kontrolli, kas kasutaja pakutud vastus oli õige

                Console.WriteLine($"Õige vastus on: {a} * {b} = {a * b}");

                // Sõltuvalt vastuse õigsusest lase arvutil pakkuda olemasolevate hulgast valitud kiitev või julgustav kommentaar.

                string[] kiitus = { "Kiidan!", "Hästi vastatud!", "Oled tubli!" };
                string[] julgustus = { "Proovi uuesti!", "Õpi veel!", "Harjutamine teeb meistriks!" }; // võib ka olla if-i sees

                if (vastus == õige)
                {
                    Console.WriteLine("Õige. " + kiitus[r.Next(kiitus.Length)]);
                    õigeid++;
                }
                else
                {
                    Console.WriteLine(julgustus[r.Next(julgustus.Length)]);
                }
            }
        }
    }
}
