using System;
namespace Isikukood
{
    public class Isikukood
    {
        private string _ik;

        public Isikukood(string isikukood)
        {
            if (isikukood.Length != 11)
            {
                throw new ArgumentOutOfRangeException("Isikukood peab olema 11 kohaline");
            }
            _ik = isikukood;
            try
            {
                AnnaSünnipäev();
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Isikukoodis olevate andmete põhjal tekkis olematu kuupäev.");
            }


            if (int.Parse(_ik.Substring(0, 1)) > 6)
            {
                throw new ArgumentException("Esimene number ei tohi olla väiksem kui 1 ja suurem kui 6.");
            }

            
            if (AnnaJääk() != int.Parse(_ik.Substring(10, 1)))
            {
                throw new ArgumentException("Isikukoodi viimane number on vale!");
            }
        }

        public int AnnaPäev()
        {
            return int.Parse(_ik.Substring(5, 2));
        }

        public int AnnaKuu()
        {
            return int.Parse(_ik.Substring(3, 2));
        }

        public string AnnaKuuNimi()
        {
            string[] kuuNimed = { "", "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai", "Juuni", "Juuli", "August", "September", "Oktoober", "November", "Detsember" };
            return kuuNimed[AnnaKuu()];
        }

        public int AnnaAasta()
        {
            var esimeneNumber = int.Parse(_ik.Substring(0, 1));
            var aasta = 0;

            // Esimese numbri järgi leida sobiv sajand
            if (esimeneNumber < 3)
            {
                aasta = 1800;
            }

            else if (esimeneNumber < 5)
            {
                aasta = 1900;
            }

            else if (esimeneNumber < 7)
            {
                aasta = 2000;
            }

            else
            {
                aasta = 2100;
            }

            // liida sajandile teine ja kolmas number
            aasta += int.Parse(_ik.Substring(1, 2));
            return aasta;
        }

        public DateTime AnnaSünnipäev()
        {
            return new DateTime(AnnaAasta(), AnnaKuu(), AnnaPäev());
        }


        public int AnnaJääk()
        {
            int summa1 = 0;
            int[] kordajad1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            for (int i = 0; i < kordajad1.Length; i++)
            {
                int arv1 = kordajad1[i] * int.Parse(_ik.Substring(i, 1));
                summa1 += arv1;
            }

            int jääk = summa1 % 11;
            int summa2 = 0;


            if (jääk == 10)
            {
                int[] kordajad2 = { 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };
                for (int i = 0; i < kordajad2.Length; i++)
                {
                    int arv2 = kordajad2[i] * int.Parse(_ik.Substring(i, 1));
                    summa2 += arv2;
                }
                int jääkUus = summa2 % 11;
                jääk = jääkUus;
                return jääk;
            }

            return jääk;

        }
    }
}
