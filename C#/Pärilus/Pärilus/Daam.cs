using System;
namespace Pärilus
{
    public class Daam : Inimene
    {
        public Daam(int vanus) : base(vanus)
        {
        }
        public override void YtleVanus()
        {
            Console.WriteLine($"Minu vanus on {_vanus - 5 } aastat");
        }
    }
}
