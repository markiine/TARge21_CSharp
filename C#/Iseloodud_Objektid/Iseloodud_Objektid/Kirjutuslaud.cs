using System;
namespace Iseloodud_Objektid
{
    public class Kirjutuslaud : Laud
    {
        private Sahtel[] _sahtlid;

        
        public Kirjutuslaud(double pikkus, double laius, double kõrgus, int sahtleid, int lauajalad = 4, string materjal = "puit", string vastupidavus = "hea") : base(pikkus, laius, kõrgus, lauajalad, materjal, vastupidavus)
        {
           LooSahtlid(sahtleid);
        }

        /// <summary>
        /// loob laua alla sahtlid, mis asuvad kõrvuti ja jagunevad võrdselt
        /// sahtli kõrgus on 1/6 kõrgusest
        /// üks sahtel on lukustatuv ja kõikidest sahtlitest iga 10-s on valepõhjaga
        /// </summary>
        /// <param name="sahtleid"> sahtlite kogus </param>
        /// <returns> loodud sahtlitega massiiv </returns>

        private void LooSahtlid(int sahtleid)
        {
            _sahtlid = new Sahtel[sahtleid];
            byte sahtliLaius = (byte)(_laius / sahtleid);
            byte sahtliKõrgus = (byte)(_kõrgus / 6);

            for (int i = 0; i < _sahtlid.Length; i++)
            {
                _sahtlid[i] = new Sahtel((byte)_pikkus, sahtliLaius, sahtliKõrgus, i == 0);
            }
            
        }
        public override string ToString()
        {
            string result = "\n";
            foreach (var sahtel in _sahtlid)
            {
                result += sahtel.ToString() + "\n";
            }

            return base.ToString() + $"Kirjutuslaud: " + result;
        }
    }
}
