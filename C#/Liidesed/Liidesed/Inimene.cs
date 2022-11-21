using System;
namespace Liidesed
{
    public class Inimene 
    {
        protected int _vanus;
        protected int _pikkus;

        public Inimene(int vanus, int pikkus)
        {
            _vanus = vanus;
            _pikkus = pikkus;
        }

        public Inimene(int vanus) : this(vanus, -1)  // võib ka pikkuse fikseerida, aga saab teha ka this võtmesõnaga
        {

        }

        public virtual void YtleVanus()
        {
            Console.WriteLine("Minu vanus on " + _vanus + " aastat");

        }
        public int AnnaPikkus()
        {
            return _pikkus;
        }

        public void Tervita(string keda) // inimene ei ole viisakas, seega : IViisakas on ülevalt ära kustutatud, aga kuna laps on inimene siis loeb siit
        {
            Console.WriteLine("Tere, " + keda + "!");
        }
    }
}