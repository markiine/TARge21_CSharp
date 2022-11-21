using System;
namespace Iseloodud_Objektid
{
    // 1. klassi loomine
    public class Auto
    {
        // hiljem juurde tuunime moototit, static sest ei pea isegi autot olemas olema
        private static Random _random = new Random();
        // 2. väljade loomine
        private string _värv;
        private string _mark;
        private double _kiirendus;
        private int _tippkiirus;
        private bool _metallikVärv;
        private string _istmeMaterjal;

        // suurus
        protected uint _istekohti;  // hiljem vaja sõiduauto jaoks et oleks protected
        private string _keretüüp;
        private int _veljeDiameeter;

        // 3. konstruktor, avalik meetod
        public Auto(string mark, string värv, uint istekohti, string keretüüp = "luukpära")
        // kui sulus keretüüp="luukpära" , siis see valikuline parameeter, võib olla ainult lõpus
        // siis ei pea programmis seda väärtust sulgudesse kirjutama
        {
            // 4. väljade väärtustamine
            _mark = mark;
            _värv = värv;
            _istekohti = istekohti;
            _keretüüp = keretüüp;

            _veljeDiameeter = 17;
            _istmeMaterjal = "veluur";
            _kiirendus = 9;
            _tippkiirus = 200;

        }
        // 5. tee midagi kasulikku
        public string AnnaVärvus()
        {
            var tulemus = _värv;
            if (_metallikVärv)
            {
                tulemus += " metallik";
            }
            return tulemus;
        }
        public void MuudaVärv(string värv, bool onMetallik = false)
        {
            _värv = värv;
            _metallikVärv = onMetallik;
        }

        // velgede diameetri muutmine

        public void MuudaVeljeSuurus(int veljeDiameeter)
        {
            if (veljeDiameeter > 0)
            {
                _veljeDiameeter = veljeDiameeter;
            }
            
        }


        // istmekohtade muutmine

        public void MuudaKohad(uint istekohti)
        {
            if (istekohti < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(istekohti), "Istekohti ei tohi olla negaiivne ARV!");
                // annab erroris väljastuse ""
            }
            _istekohti = istekohti;
        }


        // kuva kõik andmed

        public void KuvaAndmed()
        {
            Console.WriteLine($"Auto mark on: {_värv}");
            Console.WriteLine($"Auto värvus on: {_mark}");
            Console.WriteLine($"Auto kiirendus on: {_kiirendus}");
            Console.WriteLine($"Auto tippkiirus on: {_tippkiirus}");
            Console.WriteLine($"Auto metallikvärv on: {_metallikVärv}");
            Console.WriteLine($"Auto istmematerjal on: {_istmeMaterjal}");
            Console.WriteLine($"Auto istekohti on: {_istekohti}");
            Console.WriteLine($"Auto keretüüp on: {_keretüüp}");
            Console.WriteLine($"Auto velje diameeter on: {_veljeDiameeter}");

        }
        public override string ToString()  // üheks pikaks sõneks ümber kirjutamine.
        {
            return $"Mark on: {_värv}\nVärvus on: {_mark}\nKiirendus on: {_kiirendus}\nTippkiirus on: {_tippkiirus}\nMetallikvärv on: {_metallikVärv}\nIstmematerjal on: {_istmeMaterjal}\nIstekohti on: {_istekohti}\nKeretüüp on: {_keretüüp}\nVelje diameeter on: {_veljeDiameeter}";
        }

        public virtual void TuuniMoototrit()
        {
            var muutusProtsent = _random.Next(5) + _random.NextDouble();
            if (_random.Next(2) == 0)
            {
                _kiirendus -= _kiirendus * muutusProtsent / 100;
            }
            else
            {
                _kiirendus += _kiirendus * muutusProtsent / 100;
            }
        }

        /// <summary>
        /// täiustab istmematerjali - valib järgmise saadava oleva
        /// </summary>
        /// <returns> kas täiustamine õnnestus </returns>

        public bool TäiustaSisestust()
        {
            string[] materjalid = { "linane", "veluur", "vinüül", "nahk", "alcantara", "veegan nahk" };

            var praegusePositsioon = Array.IndexOf(materjalid, _istmeMaterjal);
            if (praegusePositsioon == materjalid.Length -1)
            {
                return false;
            }
            _istmeMaterjal = materjalid[praegusePositsioon + 1];
            return true; // else pole vaja, sest niikaua ketrab kuni õige
        }
    }
}
