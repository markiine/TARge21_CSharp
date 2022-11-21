using System;

namespace KäsudMitmesFailis
{
    public class Joonistaja
    {
        public static void Teeruut(int a)
        {
            int ridadearv = a, veergudearv = a;

            for (int rida = 0; rida < ridadearv; rida++)
            {
                
                for (int veerg = 0; veerg < veergudearv; veerg++)
                {
                    Console.Write("*");
                }
                
            }
        }

        public static void Teejoon(int a)
        {
            for (int rida = 0; rida < a; rida++)
            {
                Console.Write("*");
            }
        }
    }
}