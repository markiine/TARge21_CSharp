using System;
namespace Iseloodud_Objektid
{
    public class Laud
    {
        private int _lauajalad;
        private string _materjal;
        private string _vastupidavus;
        protected double _pikkus;
        protected double _laius;
        protected double _kõrgus;


        public Laud(double pikkus, double laius, double kõrgus, int lauajalad = 4, string materjal = "puit", string vastupidavus = "hea")
        {
            _lauajalad = lauajalad;
            _materjal = materjal;
            _vastupidavus = vastupidavus;
            _pikkus = pikkus;
            _laius = laius;
            _kõrgus = kõrgus;
        }

        
        public double Pindala()
        {
            return _pikkus * _laius;
            
        }
        public double JalgadePikkus()
        {
            return _kõrgus * _lauajalad;
        }


        public void KuvaAndmed()
        {
            Console.WriteLine($"Lauajalgu: {_lauajalad}");
            Console.WriteLine($"Materjal: {_materjal}");
            Console.WriteLine($"Vastupidavus: {_vastupidavus}");
            Console.WriteLine($"Laua pikkus: {_pikkus} m");
            Console.WriteLine($"Laua laius: {_laius} m");
            Console.WriteLine($"Laua kõrgus: {_kõrgus} m");
            Console.WriteLine($"Laua pindala on: {Pindala()} m2");
            Console.WriteLine($"Jalgade kogupikkus on: {JalgadePikkus()} m");


        }
        public override string ToString()
        {
            return $"Lauajalgu: {_lauajalad}\nMaterjal: {_materjal}\nVastupidavus: {_vastupidavus}\nLaua pikkus: {_pikkus} m\nLaua laius: {_laius} m\nLaua kõrgus: {_kõrgus} m\nLaua pindala on: {Pindala()} m2\nJalgade kogupikkus on: {JalgadePikkus()} m";
        }
    }
}
