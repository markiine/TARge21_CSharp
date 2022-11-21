using System;

namespace Isikukood
{
    class Program
    {
        static void Main(string[] args)
        {
            /// * Koosta klass isikukoodi andmete hoidmiseks
            /// * Lisa käsklus sünnikuupäeva küsimiseks
            /// * Lisa käsklus sünnikuu küsimiseks sõnana
            /// * Lisa käsklus sünniaasta väljastamiseks ka sajandit arvestades
            /// * Kontrolli isikukoodi objekti tegemisel koodi pikkust.
            /// * Kontrolli isikukoodi kontrollisumma õigsust vastavalt järgnevale algoritmile
            /// Isikukoodi kontrolli algoritm
            /// Isikukoodis peavad kõik sugu ning kuupäeva tähistavad väärtused olema
            /// võimalikud ning viimane kontrollnumber arvutatakse järgneva algoritmi järgi:
            /// liidetakse kokku esimese üheksa numbri korrutised igale arvule vastava
            /// järjekorranumbriga, kümnenda numbri puhul ühega ning leitakse saadud summa
            /// jääk jagamisel 11 - ga.Kui jääk on võrdne kümnega, siis tehakse arvutus
            /// uuesti ning võetakse teguriteks vastavalt 3, 4, 5, 6, 7, 8, 9, 1, 2, 3.
            /// Näide: isikukoodi 37605030299 kontroll.Summa =
            /// 1 * 3 + 2 * 7 + 3 * 6 + 4 * 0 + 5 * 5 + 6 * 0 + 7 * 3 + 8 * 0 + 9 * 2 + 1 * 9 = 108
            /// 108 jääk jagamisel 11 - ga on 9 => isikukoodi viimane number peab olema
            /// üheksa.



            var kood = new Isikukood("49211097634");

            Console.WriteLine($"Oled sündinud {kood.AnnaPäev()}. päeval");
            Console.WriteLine($"Oled sündinud {kood.AnnaKuu()}. kuul nimega {kood.AnnaKuuNimi()}");
            Console.WriteLine($"Oled sündinud {kood.AnnaAasta()}. aastal");
            Console.WriteLine($"Sinu sünnipäev on {kood.AnnaSünnipäev().ToLongDateString()}");
            Console.WriteLine($"Sinu isikukoodi viimaseks numbriks on {kood.AnnaJääk()}");







        }
    }
}
