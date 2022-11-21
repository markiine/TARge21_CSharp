namespace Iseloodud_Objektid
{
    public class Sahtel
    {
        private bool _OnLukustav;
        private bool _OnValePõhi;
        private byte _pikkus;
        private byte _laius;
        private byte _kõrgus;
        private static uint _sahtliteKoguarv = 0;

        public Sahtel(byte pikkus, byte laius, byte kõrgus, bool onLukustav = false, bool onValePõhi = false)
        {
            
            _pikkus = pikkus;
            _laius = laius;
            _kõrgus = kõrgus;
            _OnLukustav = onLukustav;
            _OnValePõhi = onValePõhi;
            _OnValePõhi = ++_sahtliteKoguarv % 10 == 0;
            
        }
        public override string ToString()
        {
            return $"Sahtel: {_kõrgus}x{_laius}x{_kõrgus}; {(_OnLukustav ? "Lukustatav" : "")} {(_OnValePõhi ? "Valepõhjaga" : "")}";
        }
    }

}