using System;

namespace Pärilus
{
    class Program
    {
        static bool KasMahubAllveelaeva(Inimene isik)
        {
            if (isik != null)
            {
                return false;
            }
            return isik.AnnaPikkus() < 165 || isik is Modell && isik.AnnaPikkus() <= 170; ;
        }

        static void Main(string[] args)
        {
            Inimene inim1 = new Inimene(13);
            inim1.YtleVanus();
            Modell modell1 = new Modell(19, 60);
            modell1.YtleVanus();
            modell1.Esitle();

            Modell modell2 = new Modell(30, 70, 171);
            modell2.YtleVanus();
            modell2.Esitle();

            Inimene inimModell = new Modell(11, 40);
            inimModell.YtleVanus();

            Console.WriteLine("Rahvas kõneleb:");

            Inimene[] rahvas = new Inimene[100];
            for (int i = 0; i < rahvas.Length; i++)
            {
                if (i < 5)
                {
                    rahvas[i] = new Modell(17, 65, 167 + i % 10);
                }
                else
                {
                    rahvas[i] = new Modell(25, 166 + i % 10);
                }
                rahvas[i].YtleVanus();
                if (KasMahubAllveelaeva(rahvas[i]))
                {
                    Console.WriteLine("Jah mahub.");
                }
            }

            Console.WriteLine("----- Ülekatte demo -----");
            Inimene inimene = new Inimene(35);
            Daam daam = new Daam(35);
            inimene.YtleVanus();
            daam.YtleVanus();

            Inimene inimDaam = new Daam(35);
            inimDaam.YtleVanus();  //reaalselt kutsutakse välja daami vanus

        }
    }
}
