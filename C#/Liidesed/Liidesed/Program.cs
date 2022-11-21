using System;

namespace Liidesed
{
    class Program
    {

        static void TuleSünnipäevale(IViisakas v)
        {
            v.KoputaUksele(3);
            v.Tervita("vanaema");
        }


        static void Main(string[] args)
        {
            var inimene = new Inimene(22);
            var laps = new Laps(5);
            var koer = new Koer();
            // TuleSünnipäevale(inimene);
            TuleSünnipäevale(laps);
            TuleSünnipäevale(koer);
        }
    }
}
