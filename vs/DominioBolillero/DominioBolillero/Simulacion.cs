using System;
using System.Collections.Generic;
using System.Text;

namespace DominioBolillero
{
    public class Simulacion
    {
        Bolillero bolillero = new Bolillero();
        public List<long> jugarNveces { get; set; }
        
        public Simulacion(byte inicio, byte fin)
        {

        }

        public bool Jugar(List<byte> jugadas)
        {
            var comparar = 0;
            bolillero.Reingresar();
            foreach(var bolillaJugada in jugadas)
            {
                comparar = bolillero.SacarBolilla();
                if (comparar != bolillaJugada)
                {
                    return false;
                }
            }

            return true;


        }

        public long JugarN(List<byte> jugadas, long cantDeJugadas)
        {

            //var representar = 0;
            for (int ind = 0; ind < ; ind++)
            {

            }
        }

    }
}
