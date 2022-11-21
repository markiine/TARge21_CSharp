using System;
namespace Iseloodud_Objektid
{
    public class Sõiduauto : Auto
    {
        protected uint _reisijaid;

        public Sõiduauto(string mark, string värv, uint istekohti, string keretüüp = "luukpära") : base(mark,värv, istekohti, keretüüp)
        {
            _reisijaid = 0;
        }

        /// <summary>
        /// laseb autosse reisijaid sisse
        /// </summary>
        /// <param name="reisijateArv"> kui palju reisijaid soovib siseneda </param>
        /// <returns> kui palju reisijaid ei mahtunud autosse </returns>
        public uint Sisene(uint reisijateArv)
        {
            var vabuKohti = _istekohti - _reisijaid;
            if (reisijateArv > vabuKohti)
            {
                _reisijaid = (uint)_istekohti;
                return (uint)(reisijateArv - vabuKohti);
            }
            _reisijaid += reisijateArv;
            return 0;
        }
    }
}
