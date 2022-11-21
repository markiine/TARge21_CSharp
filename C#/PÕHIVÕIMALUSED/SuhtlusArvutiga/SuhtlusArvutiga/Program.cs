using System;

namespace SuhtlusArvutiga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun eesnimi:");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);

            Console.WriteLine();

            Console.WriteLine("Esimene arv:");
            string tekst1 = Console.ReadLine();
            int arvuke1 = int.Parse(tekst1);
            Console.WriteLine("Teine arv:");
            int arvuke2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis on {2}",
                    arvuke1, arvuke2, arvuke1 * arvuke2);

            Console.WriteLine();

            // Küsi kahe inimese nimed ning teata, et täna on nad pinginaabrd
            Console.WriteLine("Palun sisesta üks eesnimi:");
            string eesnimi1 = Console.ReadLine();
            Console.WriteLine("Palun sisesta teine eesnimi:");
            string eesnimi2 = Console.ReadLine();
            Console.WriteLine($"{eesnimi1} ja {eesnimi2}, teie olete täna pinginaabrid.");
            /* Console.Writeline("Kui vana sa oled?")
             * int vanus = int.Parse(Console.Readline());
             * Console.Writeline($"{eesnimi} on {vanus} aastat vana.");
             */

            Console.WriteLine();

            // Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala
            Console.WriteLine("Palun sisesta toa pikkus:");
            string pikkus = Console.ReadLine();
            int arv1 = int.Parse(pikkus);
            Console.WriteLine("Palun sisesta toa laius:");
            string laius = Console.ReadLine();
            int arv2 = int.Parse(laius);
            Console.WriteLine($"Ristkülikulise toa põranda pindala on {arv1 * arv2}.");
            // või variant2 peale küsimist
            // int pikkus = int.Parse(Console.Readline());
            // Console.Writeline("Põranda pindala on {0} ruutmeetrit.", pikkus * laius);

            Console.WriteLine();

            // Leia 30% hinnasoodustusega hinna põhjal alghind
            Console.WriteLine("Palun sisesta toote soodushind:");
            string soodushind = Console.ReadLine();
            int hind = int.Parse(soodushind);
            Console.WriteLine($"Toote alghind oli {hind * 100 / 70}");
            // või variant2 peale küsimist
            //
        }
    }
}
