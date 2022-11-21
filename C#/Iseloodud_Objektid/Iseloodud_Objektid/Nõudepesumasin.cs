using System;
namespace Iseloodud_Objektid
{
    public class Nõudepesumasin
    {
        private int _taldrikuKohad;
        private int _pestavadTaldrikud;
        private bool _onTablett;
        private Olek _olek; //nagu massiiiv
        //generate new type; public, enum, crate new file , namespace Iseloodud_Objektid lisasin ise

        public Nõudepesumasin(int taldrikuKohad)
        {
            _taldrikuKohad = taldrikuKohad;
            _olek = Olek.Laadimine;
        }


        /// <summary>
        /// Pane mustad taldrikud masinasse
        /// </summary>
        /// <param name="taldrikud"> mitu taldrikut paned </param>
        /// <returns> taldrikute kogus, mis ei mahtunud </returns>
        
        public int Täida(int taldrikud)
        {
            if (taldrikud > (_taldrikuKohad - _pestavadTaldrikud))
            {
                _pestavadTaldrikud = _taldrikuKohad;
                var jääk = taldrikud - _taldrikuKohad - _pestavadTaldrikud;
                return jääk;
            }
            _pestavadTaldrikud += taldrikud;
            return 0;
        }

        public void LisaTablett()
        {
            _onTablett = true;
        }

        public void PeseNõud()
        {
            if (_olek == Olek.Laadimine && _onTablett)
            {
                _olek = Olek.Pesu;
                Console.WriteLine("Vee sissevõtt ja vee soojendamine.");
                Console.WriteLine("Aine segatakse veega jne.");
                _onTablett = false;
                _olek = Olek.Kuivatus;
                Console.WriteLine("Nõud pestud. Toimub kuivatamine.");
                _olek = Olek.Lõpp;
            }
            else
            {
                throw new Exception($"Masin on vales olekus või tablett on sisestamata! Olek: {_olek}; Tablett sisestatud: {_onTablett}");
            }
        }

        public void Tühjenda()
        {
            if (_olek == Olek.Lõpp)
            {
                _pestavadTaldrikud = 0;
                _olek = Olek.Laadimine;
            }
            else
            {
                throw new Exception($"Masin on vales olekus! Olek: {_olek}; Tablett sisestatud: {_onTablett}");
            }
        }

        public void KuvaAndmed()
        {
            Console.WriteLine(nameof(Nõudepesumasin));
            Console.WriteLine($"Täituvus: {_pestavadTaldrikud} / {_taldrikuKohad}");
            Console.WriteLine($"Olek: {_olek}");
            Console.WriteLine($"Pesutablett: {(_onTablett ? "sees" : "puudu")}");
        }
        
    }
}
