using System;

namespace Entity
{
    public class Estampilla
    {
        public string Identificacion { get; set; }
        public int nContrato { get; set; }
        public string oContrato { get; set; }
        public decimal vrContrato { get; set; }
        public string apoyoEmergenciaCovid19 { get; set; }
        public decimal vrEstampilla { get; set; }
        public void CalcularVrEstampilla()
        {
            if (apoyoEmergenciaCovid19.Equals("S") || apoyoEmergenciaCovid19.Equals("s"))
            {
                vrEstampilla = vrContrato * 1% +vrContrato;
            }
            else
            {
                vrEstampilla = vrContrato * 2% +vrContrato;
            }
        }
    }
}


