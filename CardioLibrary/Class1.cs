
using System;

namespace CardioLibrary
{
    public class DataCardio
    {
        public double CalcoloBattitiMassimiCardiaci(int eta)
        {
            double battitimassimi = 0;
            battitimassimi = 220 - eta;
            return battitimassimi;
        }
        public double CalcoloBattitiMassimiinPalestra(int eta)
        {
            double battitimassimi = 0;
            double battitimassimiinpalestra = 0;
            battitimassimi = 220 - eta;
            battitimassimiinpalestra = (90 * maxbattiti) / 100;
            return battitimassimiinpalestra;
        }
        public string Battiti_Riposo(double battiti)
        {
            string risposta ="";
            if(battiti<60)
            {
                risposta = "Bradicardia";
            }
            if(battiti>=60 && battiti<=100)
            {
                risposta = "Battiti nella norma";
            }
            if(battiti>100)
            {
                risposta = "Tachicardia";
            }

        }
    }
}
