using System;

namespace Tutvustus
{
    public class Riidelapp
    {
        private int _pikkus;
        private int _laius;
        private string _toon;

        public Riidelapp(int pikkus, int laius, string toon)
        {
            _pikkus = pikkus;
            _laius = laius;
            _toon = toon;

        }

        /*
        public int GetPikkus() { return _pikkus; }
        public int GetLaius() { return _laius; }
        public string GetToon() { return _toon; }
        public double GetPindala() { return _pikkus * _laius; }
        */

        public void KuvaAndmed()
        {
            Console.WriteLine(" ----- Riidelapi andmed: ----- ");
            Console.WriteLine($"Pikkus:\t{_pikkus} mm.");
            Console.WriteLine($"Laius:\t{_laius} mm.");
            Console.WriteLine($"Pindala: {AnnaPindala()/1000000.0:0.00} m2.");
            Console.WriteLine($"Toon:\t{_toon}.");
        }

        public int AnnaPindala()
        {
            return _pikkus * _laius;
        }

        public void Poolita()
        {
            if (_pikkus > _laius)
            {
                _pikkus = _pikkus / 2;
            }
            else
            {
                _laius = _laius / 2;  // variant ka _laius /= 2
            }
        }

        public Riidelapp PoolitaUuega()
        {
            Poolita();
            return new Riidelapp(_pikkus, _laius, _toon);
        }

        public Riidelapp Poolita(int AllesJäävProtsent)
        {
            if (_pikkus > _laius)
            {
                var JääkPikkus = (100 - AllesJäävProtsent) * _pikkus / 100;
                _pikkus -= JääkPikkus;
                return new Riidelapp(JääkPikkus, _laius, _toon);
            }
            else
            {
                var JääkLaius = (100 - AllesJäävProtsent) * _pikkus / 100;
                _laius -= JääkLaius;
                return new Riidelapp(_pikkus, JääkLaius, _toon);
            }
            
        }
    }
}
