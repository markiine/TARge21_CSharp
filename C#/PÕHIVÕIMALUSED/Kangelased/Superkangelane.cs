using System;

namespace Kangelane
{
    class SuperKangelane : Kangelane
    {
        private double osavus;
        private static Random random = new Random();

        public SuperKangelane(string nimi, string asukoht) : base(nimi, asukoht)
        {
            osavus = Math.Round(random.NextDouble() * 4 + 1, 2);
        }

        public override int Päästa(int arv)
        {
            double tulemus = (osavus + 95) / 100;
            return (int)Math.Round(arv * tulemus);
        }

        public override string ToString()
        {
            return Nimi + " on kangelane, kes valvab linna" + Asukoht + ". Tema osavus on " + osavus + " %";
        }
    }
}