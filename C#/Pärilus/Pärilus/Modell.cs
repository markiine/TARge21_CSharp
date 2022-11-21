using System;
namespace Pärilus
{
    public class Modell : Inimene
    {
        protected int _ümbermõõt;

        public Modell(int vanus, int ümbermõõt, int pikkus = -1) : base(vanus, pikkus)
        {
            _ümbermõõt = ümbermõõt;
        }

        public void Esitle()
        {
            YtleVanus();
            Console.WriteLine("Mu ümbermõõduks on " + _ümbermõõt + " sentimeetrit");
            if (_pikkus == -1)
            {
                Console.WriteLine("Pikkuse andmed puuduvad.");
            }
            else
            {
                Console.WriteLine($"Minu pikkus on {_pikkus} cm.");
            }
            

        }

    
    }
}
