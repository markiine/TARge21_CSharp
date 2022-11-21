using System;

namespace Iseloodud_Objektid
{
    class Program
    {
        static void Main(string[] args)
        {

            ///// KIRJUTUSLAUD /////

            var kirjutuslaud1 = new Kirjutuslaud(60, 170, 60, 5);
            Console.WriteLine(kirjutuslaud1);
            var kirjutuslaud2 = new Kirjutuslaud(60, 170, 60, 7);
            Console.WriteLine(kirjutuslaud2);


            /*

            // SÕIDUAUTO VÄRK //

            var audi = new Sõiduauto("Audi", "sinine", 5, "sedaan");  // kui kirjutad "sedaan", siis on sedaan

            var jalamehi = audi.Sisene(3);
            Console.WriteLine($"Jala läheb {jalamehi} inimest.");
            jalamehi = audi.Sisene(3);
            Console.WriteLine($"Jala läheb {jalamehi} inimest.");


            // VEOAUTO VÄRK //

            var scania = new Veoauto("Scania", "sinine", 15000);
            scania.LaeKoorem(12000);
            scania.LaeKoorem(3000);
            Console.WriteLine(scania);

            */

            ////// AUTO //////

            /*
            var auto1 = new Auto("BMW", "sinine", 5, "sedaan");  // kui kirjutad "sedaan", siis on sedaan

            Console.WriteLine("----- Auto andmed: -----");
            auto1.KuvaAndmed();
            Console.WriteLine();

            Console.WriteLine($"Bemmi värv on {auto1.AnnaVärvus()}");
            auto1.MuudaVärv("must", true);  // tahame et oleks must metallik, sellepärast true
            Console.WriteLine($"Bemmi uus värv on {auto1.AnnaVärvus()}");
            Console.WriteLine();

            auto1.MuudaVeljeSuurus(18);
            auto1.MuudaKohad(2);
            Console.WriteLine("----- Muudetud auto andmed: -----");
            auto1.KuvaAndmed();

            Console.WriteLine();
            auto1.TuuniMoototrit();
            Console.WriteLine("----- Tuunitud mootoriga auto andmed: -----");
            auto1.KuvaAndmed();

            // annab sõnumi erroris
            // auto1.MuudaVeljeSuurus(22);
            // auto1.MuudaKohad(-2);
            // auto1.KuvaAndmed();

            Console.WriteLine();

            while (auto1.TäiustaSisestust())
            {
                Console.WriteLine("----- Täiustamine õnnestus. Täiustatud istmematerjaliga auto andmed: -----");
                auto1.KuvaAndmed();
            }
            Console.WriteLine("Enam paremaks minna ei saa!");
            
            */

            ////// KÕRREMAHL //////


            /*
            var kõrremahl1 = new Kõrremahl("laim", "sinine", 1, "Põltsamaa");
            Console.WriteLine("----- Kõrremahla andmed: -----");
            kõrremahl1.KuvaAndmed();
            Console.WriteLine();

            kõrremahl1.LahjendaVeega(2.5);
            Console.WriteLine("----- Lahjendatud kõrremahla andmed: -----");
            kõrremahl1.KuvaAndmed();
            Console.WriteLine();

            Kõrremahl kõrremahl2 = kõrremahl1.PakendaÜmber();
            Console.WriteLine("----- Ümber pakendatud -----");
            kõrremahl2.KuvaAndmed();
            Console.WriteLine();
            */


            ////// LAUD //////

            /*
            var laud1 = new Laud(2.5,1,1.5);
            Console.WriteLine("----- Laua andmed -----");
            laud1.KuvaAndmed();
            */


            ////// NÕUDEPESUMASIN //////

            /*
            var nõudepesumasin = new Nõudepesumasin(20);
            nõudepesumasin.KuvaAndmed();
            Console.WriteLine();

            while (nõudepesumasin.Täida(3) == 0) ;
            nõudepesumasin.KuvaAndmed();
            Console.WriteLine();

            nõudepesumasin.LisaTablett();
            nõudepesumasin.KuvaAndmed();
            Console.WriteLine();

            nõudepesumasin.PeseNõud();
            Console.WriteLine();
            nõudepesumasin.KuvaAndmed();
            Console.WriteLine();

            nõudepesumasin.Tühjenda();
            nõudepesumasin.KuvaAndmed();
            */

            ////// REHA //////
            /*
            var reha = new Reha("puit", 10, 150);

            if (reha.RehaOnSobivaPikkusega(180))
            {
                Console.WriteLine("See on sulle paras!");
            }
            else
            {
                Console.WriteLine("Võta pikema varrega reha!");
            }

            Console.WriteLine("Pulki on vaja: " + Reha.ArvutaPulkadeArv(1, 1.5, 53));
            */
        }
    }
}
