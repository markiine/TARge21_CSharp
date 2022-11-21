using System;
namespace Iseloodud_Objektid
{
    public class Reha
    {
        private string _varreMaterjal;
        private string _rehaMaterjal;
        private uint _pulkadeArv; // uint tähendab et ei ole miinuses int
        private uint _varrePikkus;

        // Leia max pilkade arv, nende laius 1,5cm, pulkade vahe 1cm, ruumi 53cm.
        public static int ArvutaPulkadeArv(double pulgaDiameeter, double pulkadeVahe, double rehaLaius)
        {

            return (int)Math.Ceiling((rehaLaius - pulkadeVahe) / (pulkadeVahe + pulgaDiameeter) + 1);  // vb floori asemel peab olema ceiling 
        }
   

        public Reha(string varreMaterjal, uint pulkadeArv, uint varrePikkus, string rehaMaterjal = "metall")
        {

            _varreMaterjal = varreMaterjal;
            _pulkadeArv = pulkadeArv;
            _varrePikkus = varrePikkus;
            _rehaMaterjal = rehaMaterjal;

        }

        public void VahetaVars(string materjal, uint pikkus)
        {
            _varreMaterjal = materjal;
            _varrePikkus = pikkus;
        }

        public void VahetaOts(string materjal, uint pulkadeArv)
        {
            _rehaMaterjal = materjal;
            _pulkadeArv = pulkadeArv;
        }
        public void SaeVarsLühemaks(uint pikkus)
        {
            if (pikkus >= _varrePikkus)
            {
                throw new ArgumentOutOfRangeException("Vart ei saa rohkem lõigata kui on tema pikkus!");
            }
            _varrePikkus -= pikkus;
        }

        public bool RehaOnSobivaPikkusega(uint inimesePikkus)
        {
            return 0.8 * inimesePikkus <= _varrePikkus;
        }



        /*
        public void KuvaAndmed()
        {
            Console.WriteLine("----- Reha andmed: -----");
            Console.WriteLine($"Pulkade arv: {_pulkadeArv} ");
            Console.WriteLine($"Varre pikkus: {_varrePikkus} ");
            

        }
        */
        
    }
}

