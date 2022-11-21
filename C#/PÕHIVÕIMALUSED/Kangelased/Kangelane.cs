using System;

namespace Kangelane
{
    class Kangelane
    {
        private string nimi;
        private string asukoht;

        public Kangelane(string nimi, string asukoht)
        {
            Nimi = nimi;
            Asukoht = asukoht;
        }

        public string Nimi { get => nimi; set => nimi = value; }
        public string Asukoht { get => asukoht; set => asukoht = value; }

        public virtual int Päästa(int arv)
        {
            double tulemus = arv;
            return (int)Math.Round(tulemus * 0.95);
        }

        public override string ToString()
        {
            return Nimi + " on kangelane, kes valvab linna" + Asukoht + ".";
        }
    }
}