using System;

namespace Riidelapp
{
    class Program
    {
        static void Main(string[] args)
        {
            /////  KIRJELDUS /////
            /// * Koosta klass riidelapi andmete hoidmiseks: pikkus, laius, toon
            /// * Koosta riidelappidest massiiv.
            /// * Koosta uus lapimassiiv, kuhu pannakse osa eelmisest massiivist pärit lappe ja osa muid lappe(kaltsukott).
            /// * Arvuta mõlema massiivi puhul välja seal leiduvate lappide pindalade summa.
            /// * Koosta riidelapi klassile staatiline käsklus näitamaks loodud riidelappide keskmist pindala.
            /// Lappide puudumisel väärtuseks - 1.
            /// Lisa vajalikud staatilised muutujad(lappide arv, kogupindala).


            Riidelapp riidelapp = new Riidelapp(1500, 3000, "Sinine");

            Riidelapp[] riidelapid = new Riidelapp[50];
            Random random = new Random();
            for (int i = 0; i < riidelapid.Length; i++)
            {
                riidelapid[i] = new Riidelapp(random.Next(50), random.Next(150), Riidelapp.toonid[random.Next(Riidelapp.toonid.Length)]);
                riidelapid[i].KuvaAndmed();
            }

            Console.WriteLine("------------------ Kaltsukott ------------------");
            Riidelapp[] kaltsukott = new Riidelapp[riidelapid.Length];
            for (int i = 0; i < riidelapid.Length; i++)
            {
                if (riidelapid[i].OnKalts())
                {
                    kaltsukott[i] = riidelapid[i];
                }
                else
                {
                    kaltsukott[i] = new Riidelapp(5, 5, "Kollane");
                }
                kaltsukott[i].KuvaAndmed();

            }

            int riidelappidePindaladeSumma = LeiaPindaladeSumma(riidelapid);
            int kaltsukottidePindaladeSumma = LeiaPindaladeSumma(kaltsukott);
            int keskminePindala = Riidelapp.ArvutaKeskminePindala();

            Console.WriteLine($"Riidelappide pindala: {riidelappidePindaladeSumma}");
            Console.WriteLine($"Kaltsukoti pindala: {kaltsukottidePindaladeSumma}");
            Console.WriteLine($"Riidelapi ja kaltsukoti keskmine pindala: {(riidelappidePindaladeSumma + kaltsukottidePindaladeSumma) / (riidelapid.Length + kaltsukott.Length)}");
            Console.WriteLine($"Riidelapp isendite keskmine pindala: {keskminePindala}");

        }

        private static int LeiaPindaladeSumma(Riidelapp[] riidelapid)
        {
            var summa = 0;
            foreach (var lapp in riidelapid)
            {
                summa += lapp.AnnaPindala();
            }
            return summa;
        }

    }
}
