using System;

namespace KäsudMitmesFailis
{
    class Program
    {
        public static void Main(string[] arg)
        {
            // Console.WriteLine(Abivahendid.korruta(3, 6));
            int summa = Abivahendid.liida(5, 6);
            int korrutis = Abivahendid.korruta(5, 6);

            Console.WriteLine(summa);
            Console.WriteLine(korrutis);



            // Lisa käsklus täisarvude astendamiseks tsükli abil.Katseta

            int astendus = Abivahendid.astenda(5, 6);

            // Lisa kolmas fail paari tärnidest kujundeid joonistava funktsiooniga. Katseta peaprogrammis mõlema abifaili funktsioonide väljakutseid.

            Console.Write("Ruut:");
            Console.WriteLine("");
            Joonistaja.Teeruut(10);  // Uude faili pirnikese alt joonistaja class ja siis pirnikese alt generate 
            Console.WriteLine("");
            Console.Write("Joon:");
            Console.WriteLine("");
            Joonistaja.Teejoon(5);



        }










    }
}
