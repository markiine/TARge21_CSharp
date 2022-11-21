using System;

namespace ARVESTUS_DagneMarkiineKotkas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hinne3_1();
            Hinne3_2();
            // Hinne3_3();
            // Hinne4_III();
            // Hinne5_A();
            // Hinne5_Punkt();

        }

        /// <summary>
        ///  ??????? 
        /// </summary>
        
        private static void Hinne5_Punkt()
        {
            var nimed = new string[5];
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.Write($"Sisesta{i+1}. nimi: ");
                nimed[i] = Console.ReadLine();
            }

            if (nimed[nimed.Length-1] != "Juku" && nimed[0] != "Mari")
            {
                for (int i = nimed.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(nimed[i]);
                }
            }
        }

        private static void Hinne5_A()
        {
            // Küsib nädalapäeva ja vastab teavitustega

            Console.WriteLine("Sisesta nädalapäev (väikeste tähetedega): ");
            string päev = Console.ReadLine();
            if (päev == "esmaspäev")
            {
                Console.WriteLine("Tere!");
            }
            if (päev == "teisipäev")
            {
                Console.WriteLine("Hei!");
            }
            if (päev == "kolmapäev")
            {
                Console.WriteLine("Tsau!");
            }
            if (päev == "neljapäev")
            {
                Console.WriteLine("Hi!");
            }
            if (päev == "reede")
            {
                Console.WriteLine("Juhhei!");
            }
            if (päev == "laupäev")
            {
                Console.WriteLine("Tervist!");
            }
            if (päev == "pühapäev")
            {
                Console.WriteLine("Tsauki!");
            }
            if (päev == "")
            {
                Console.WriteLine("Sellist nädalapäeva ei ole olemas!");
            }
            
            // Seda ülesanne saab lühemalt teha ka switch-i abil, aga pole veel seda õppinud - õigem else if!
        }




        private static void Hinne4_III()
        {
            // Programm, mis küsib kuubi külje pikkuse ja arvutab ruumala

            Console.Write("Sisesta kuubi külje pikkus sentimeetrites (ümardatud täisarv): ");
            int arv = int.Parse(Console.ReadLine());
            int ruumala = arv * arv * arv;
            Console.WriteLine($"Kuubi ruumala on {ruumala} kuupsentmeetrit.");
        }


        private static void Hinne3_3()
        {
            // 5 liikmelise massiivivi loomine, algväärtuste andmiseks vajalik kood
            int [] m = new int[5] { 1, 2, 3, 4, 5 };
            // m on massiiv, [nende vahel mitu tk sees], {nende vahel väärtused}
        }


        private static void Hinne3_2()
        {
            // valin näiteks korduslauseks for-i

            /* SÜNTAKS
            for (väide 1; väide kaks; väide 3)
            {
                käivitatav kood mida väljastada
            }
            */

            ////// NÄIDE //////

            // Prinditakse sõna "Tere!" 5 korda

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Tere!");
            }
        }

        private static void Hinne3_1()
        {
            /* SÜNTAKS
            if (tingimus)
            {
                käivitatav kood kui tingimus on õige
            }
            */

            ////// NÄIDE //////
            
            // Küsib kasutajalt nime, kui sisestatud nimi on Mari, siis vastus on õige!

            Console.WriteLine("Palun sisestage nimi: ");
            string nimi = Console.ReadLine();
            if (nimi == "Mari")
            {
                Console.WriteLine("Vastus on õige!");
            }
            // kuna pole kasutatud else-i siis teise nime korral väljundit ei anna, selle saab aga juurde teha nii

            /*
            else
            {
                käivitatav kood kui tingimus on vale
            }
            */

            else
            {
                Console.WriteLine("Proovi veel!");
            }
            
        }
    }
}
