using System;
namespace Riidelapp
{
    public class Riidelapp
    {
        private int _pikkus;
        private int _laius;
        private string _toon;

        public static string[] toonid = { "Sinine", "Must", "Valge", "Punane" };
        private static readonly int KALTSUPIIR = 10; // konstant suurte tähtedega

        private static int _kogus = 0;
        private static int _koguPindala = 0;


        public Riidelapp(int pikkus, int laius, string toon)
        {
            _pikkus = pikkus;
            _laius = laius;
            _toon = toon;
            _kogus++;
            _koguPindala += AnnaPindala();
        }


        public static int ArvutaKeskminePindala()
        {
            if (_kogus == 0)
            {
                return -1;
            }
            return _koguPindala / _kogus;
        }



        public int AnnaPindala()
        {
            return _pikkus * _laius;
        }

        public bool OnKalts()
        {
            return _pikkus < KALTSUPIIR || _laius < KALTSUPIIR;
        }

        public void KuvaAndmed()
        {
            Console.WriteLine(" ----- Riidelapi andmed: ----- ");
            Console.WriteLine($"Pikkus:\t{_pikkus} mm.");
            Console.WriteLine($"Laius:\t{_laius} mm.");
            Console.WriteLine($"Toon:\t{_toon}.");

        }


    }
}

