using System;
using System.Collections.Generic;
using System.Text;

namespace DominioBolillero
{
    public class Simulacion
    {
        Bolillero bolillero;
        public List<long> jugarNveces { get; set; }
        
        public Simulacion(byte inicio, byte fin)
        {
            bolillero = new Bolillero(inicio, fin);
        }

        public bool Jugar(List<byte> jugadas)
        {
            var bolillaSacada = 0;
            bolillero.Reingresar();
            foreach(var bolillaJugada in jugadas)
            {
                bolillaSacada = bolillero.SacarBolilla();
                if (bolillaSacada != bolillaJugada)
                {
                    return false;
                }
            }

            return true;


        }

        public long JugarN(List<byte> jugadas, long cantDeJugadas)
        {

            long ganadas = 0;
            for (long ind = 0; ind < cantDeJugadas; ind++)
            {
                if (this.Jugar(jugadas))
                {
                    ganadas++;
                }
            }

            return ganadas; 
        }

    }
}
