using System;
namespace Liidesed
{
    public class Laps : Inimene, IViisakas
    {
        public Laps(int vanus) : base(vanus)
        {

        }

        public void KoputaUksele(int korda)
        {
            Console.WriteLine("KOP");  //midagi puudu
        }
    }
}
