using System;

namespace Massiivid
{
    class Program
    {
        /*
        public static void Main(string[] arg)
        {
            int[] m = new int[3];
            m[0] = 40;
            m[1] = 48;
            m[2] = 33;
            Console.WriteLine(m[1]);
        }
        */


        /*
        public static void Main(string[] arg)
        {
            int[] m = new int[3]; // nüüd võib ka int [13] nt olla, sest m.Length
            m[0] = 40;
            m[1] = 48;
            m[2] = 33;
            int summa = 0;
            for (int i = 0; i < m.Length; i++)
            {
                summa += m[i];
            }
            Console.WriteLine(summa);  // ("=" + summa)
        }
        */


        /*
        // eelmise ül sama
        public static void Main(string[] arg)
        {
            int[] m = new int[3]; // nüüd võib ka int [13] nt olla, sest m.Length
            m[0] = 40;
            m[1] = 48;
            m[2] = 33;
            KuvaSummaTehe(m); // parem klõps ja exract.. int kuni lõupuni
            int[] arvud = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            KuvaSummaTehe(arvud);
        }

        private static void KuvaSummaTehe(int[] m)
        {
            int summa = 0;
            for (int i = 0; i < m.Length; i++)
            {
                summa += m[i];
            }
            Console.WriteLine(summa);  // ("=" + summa)
        }
        */


        /*
        public static int LeiaSumma(int[] mas)
        {
            int summa = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                summa += mas[i];
            }
            return summa;
        }
        public static void Main(string[] arg)
        {
            int[] m = new int[3] { 40, 48, 33 };
            int vastus = LeiaSumma(m);
            Console.WriteLine(vastus);
        }
        */


        /*
        public static void Main(string[] arg)
        {
            int[] m = new int[5] { 66, 4, 40, 48, 33 };
            Array.Sort(m);
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }

        }
        */


        /*
        public static void Main(string[] arg)
        {
            string[] nimed = { "Jaan", "Jaanika", "Juss", "Julia" };
            string[] kohad = nimed;
            Console.WriteLine(kohad[0]);
            Console.WriteLine(nimed[0]);
            kohad = (string[])nimed.Clone();
            kohad[0] = "Teet";
            Console.WriteLine(kohad[0]);
            Console.WriteLine(nimed[0]);
            Array.Clear(kohad, 0, kohad.Length);

            foreach (var koht in kohad)
            {
                Console.WriteLine(koht); // koht.length annab errori, sest sõne default on null
            }

            Console.WriteLine($"Julia asub massiivis kohal: {Array.IndexOf(nimed, "Julia")}");
            Console.WriteLine($"Julia asub massiivis kohal: {Array.IndexOf(kohad, "Julia")}");



            LisaTervitus(nimed);
            KuvaMassiv(nimed);

        }

        private static void KuvaMassiv(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void LisaTervitus(string[] nimed)
        {
            for (int i = 0; i < nimed.Length; i++)
            {
                nimed[i] = "Tere, " + nimed[i];
            }
        }




        /* ??????
        

        static void Tryki(int[] mas)
        {
            for(int i = 0; i<mas.Length; i++)
        {
            Console.WriteLine(mas[i]);
        }
        Console.WriteLine();
        }

        public static void Main(string[] arg)
        {
            int[] m = new int[3]{40, 48, 33};
            int[] m2 = m; //Viide samale massiivile
            Tryki(m2);
            m[1] = 32;
            Tryki(m2);
            int[] m3 = (int[])m.Clone(); //Andmete koopia
            m[1] = 20;
            Tryki(m3);
            Array.Clear(m3, 0, m3.Length); //Tühjendus
            Tryki(m3);
            Console.WriteLine(Array.IndexOf(m,33));
            Console.WriteLine(Array.IndexOf(m,17)); //puuduv element

        }
        ?????????
        */


        /*
        public static void Main(string[] arg)
        {
            int[] m = new int[3]{40, 48, 33};
            foreach (int arv in m)
            {
                Console.WriteLine(arv);
            }
        
        */

        /*
        public static void Main(string[] arg)
        {
            int[,] m = new int[2, 3]
        {
            {40, 48, 33},
            {17, 23, 36}
        };
            Console.WriteLine(m[0, 1]); //48
            Console.WriteLine("M66dete arv: " + m.Rank);
            Console.WriteLine("Ridade arv: " + m.GetLength(0));
            Console.WriteLine("Veergude arv: " + m.GetLength(1));
            //elemente mõõtmes nr. 1
            int summa = 0;
            foreach (int arv in m)
            {
                summa += arv;
            }
            Console.WriteLine("Summa: " + summa);

        }
        */


        /*
        public static void Main(string[] arg)
        {
            int[,] tabel = new int[3, 6];
            tabel[2, 2] = 17;
            KuvaMassiiv(tabel);
            int[,] ruut =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            KuvaMassiiv(ruut);
            int[][] massivideMassiv =
            {
                new int[]{1, 2, 3},
                new int[]{1, 2, 3, 4, 5, 6},
            };


        }

        private static void KuvaMassiiv(int[,] tabel)
        {
            for (int i = 0; i < tabel.GetLength(0); i++)  // i ja j on read ja veerud
            {
                for (int j = 0; j < tabel.GetLength(1); j++)
                {
                    Console.Write($"{tabel[i, j],5}");
                }
                Console.WriteLine();
            }
        }
        */


        /*
        static void KorrutaKahega(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = mas[i] * 2;
            }
        }
        static void Tryki(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
        }
        public static void Main(string[] arg)
        {
            int[] m = new int[3] { 40, 48, 33 };
            KorrutaKahega(m);
            Tryki(m);
        }
        */


        /////////// ÜLESANDED //////////////


        /*
        // Küsi kasutaja käest viis arvu ning väljasta need tagurpidises järjekorras.

        public static void Main(string[] arg)
        {
            int[] m = new int[5];
            for (int nr = 1; nr <= 5; nr++)  //kui i = 0 , siis ($"Sisesta {i+1}. täisarv:")

            {
                Console.WriteLine("Sisesta {0}. arv:", nr);
                int arv = int.Parse(Console.ReadLine());        // siis m[i] = ...
                m[nr-1] = arv;
            }

            Array.Reverse(m);               // või siis forr - tähendabki reverse

            foreach (var arv in m)
            {
                Console.WriteLine(arv);             // (m[i])
            }

           
        }
        */


        /*
        // Loo alamprogramm massiivi väärtuste aritmeetilise keskmise leidmiseks.Katseta.

        public static double AritmeetilineKeskmine(int [] m)
        {
            int summa = 0;
            for (int i = 0; i < m.Length; i++)
            {
                summa += m[i];
            }
            return summa / m.Length;
        }

        public static void Main(string [] arg)
        {
            int[] m = new int[3] { 40, 52, 38 };
            Console.WriteLine(AritmeetilineKeskmine(m));
            
        }
        */

        


        /*
        // Loo alamprogramm, mis suurendab kõiki massiivi elemente ühe võrra.Katseta.

        public static int[] SuurendaMasiiv(int [] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                m[i] += 1;
            }
            return m;

        }

        public static void Main(string[] arg)
        {
            int[] m = new int[6] { 40, 4, 9, 16, 52, 38 };
            int[] uus = SuurendaMasiiv(m);
            for (int nr = 0; nr < m.Length; nr++)
            {
                Console.WriteLine(uus[nr]);
            }

        }
        */


        /*
        // Sorteeri massiiv ning väljasta selle keskmine element.

        public static void Main(string [] arg)
        {
            int[] m = new int[5] { 40, 4, 9, 16, 38 };
            Array.Sort(m);
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }

            Console.WriteLine("");
            Console.WriteLine(m[(m.Length-1)/2]);

        }
        */



        /*



        /// KORRUTUSTABEL ///

        public static void Main(string[] argumendid)
        {
            int ridadearv = 10, veergudearv = 10;
            if (argumendid.Length == 2)
            {
                ridadearv = int.Parse(argumendid[0]);
                veergudearv = int.Parse(argumendid[1]);
            }
            for (int rida = 1; rida <= ridadearv; rida++)
            {
                for (int veerg = 1; veerg <= veergudearv; veerg++)
                {
                    Console.Write("{0, 5}", rida * veerg); //5 kohta
                }
                Console.WriteLine();

            }
        }

        /// KORRUTUSTABEL VARIANT 2 ///

        public static void Main(string[] arg)
        {
            int[,] korrutustabel = new int[10, 10];
            for (int veerg = 0; veerg < 10; veerg++)
            {
                for (int rida = 0; rida < 10; rida++)
                {
                    korrutustabel[rida, veerg] = (rida + 1) * (veerg + 1);
                }
            }
            for (int veerg = 0; veerg < 10; veerg++)
            {
                Console.WriteLine("");
                for (int rida = 0; rida < 10; rida++)
                {
                    Console.Write("{0, 5}",korrutustabel[rida, veerg]);
                }
            }


        */




        // Koosta kahemõõtmeline massiiv ning täida korrutustabeli väärtustega.Küsi massiivist kontrollimiseks väärtusi.

        public static void Main(string[] arg)
        {
            int[,] korrutustabel = new int[10, 10];
            for (int rida = 0; rida < 10; rida++)
            {
                for (int veerg = 0; veerg < 10; veerg++)
                {
                    korrutustabel[rida, veerg] = (rida + 1) * (veerg + 1);
                }
            }
            Console.WriteLine(korrutustabel[5, 8]);  // siin on ideksiga [] sees, järgmises õige arvuga
            Console.WriteLine("");
        
            int[,] korrutustabelUus = new int[11, 11];
            for (int ridaUus = 1; ridaUus < 11; ridaUus++)
            {
                for (int veergUus = 1; veergUus < 11; veergUus++)
                {
                    korrutustabelUus[ridaUus, veergUus] = (ridaUus) * (veergUus);
                }
            }
            Console.WriteLine(korrutustabelUus[9, 7]);


        }
            
    }
}

