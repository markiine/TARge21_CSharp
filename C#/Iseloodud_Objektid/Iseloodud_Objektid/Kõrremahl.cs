using System;

namespace Iseloodud_Objektid
{
    public class Kõrremahl
    {
        private string _maitse;
        private double _kangus;
        private string _värvus;
        private double _kogusLiitrites;
        private string _tootja;
        // kui võtad kõik valikusse siis peaks tulema välja kohe otse konstruktori valik

        public Kõrremahl(string maitse, string värvus, double kogusLiitrites, string tootja, double kangus = 100)
        {
            _maitse = maitse;
            _värvus = värvus;
            _kogusLiitrites = kogusLiitrites;
            _tootja = tootja;

            _kangus = kangus;

        }

        public void LahjendaVeega(double veeKogus)
        {
            if (veeKogus > 0)
            {
                _kogusLiitrites += veeKogus;
                _kangus -= veeKogus * 100 / _kogusLiitrites;
            }
        }

        /// <summary>
        /// Teeb olemasoleva kõrremahla kaheks võrdseks pakiks
        /// </summary>
        /// <returns> teise poole pakist </returns>
        
        public Kõrremahl PakendaÜmber()
        {
            _kogusLiitrites = _kogusLiitrites / 2;  //   /= 2
            return new Kõrremahl(_maitse, _värvus, _kogusLiitrites, _tootja, _kangus);
        }

        public int MitmeleInimesele()
        {
            const double inimesePiir = 1;
            return (int)Math.Ceiling(_kogusLiitrites / inimesePiir);
        }

        public void KuvaAndmed()
        {
            Console.WriteLine($"Maitse: {_maitse}");
            Console.WriteLine($"Kangus: {_kangus} %");
            Console.WriteLine($"Kogus: {_kogusLiitrites} liitrit");
            Console.WriteLine($"Selle suudab ära juua {MitmeleInimesele()} inimest");
        }
    }
}
