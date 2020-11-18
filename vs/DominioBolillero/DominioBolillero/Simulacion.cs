using System;
using System.Collections.Generic;
using System.Text;

namespace DominioBolillero
{
    public class Simulacion
    {
        Bolillero bolillero;
        public List<long> JugarNVeces { get; set; }

        public Simulacion(byte inicio, byte fin)
        {
            bolillero = new Bolillero(inicio, fin);
        }

        public bool Jugar(List<byte> jugadas, Bolillero bolillero)
        {
            var bolillaSacada = 0;
            bolillero.Reingresar();
            foreach (var bolillaJugada in jugadas)
            {
                bolillaSacada = bolillero.SacarBolilla();
                if (bolillaSacada != bolillaJugada)
                {
                    return false;
                }
            }

            return true;


        }

        public long JugarN(List<byte> jugadas, long cantDeJugadas, Bolillero bolillero)
        {

            long ganadas = 0;
            for (long ind = 0; ind < cantDeJugadas; ind++)
            {
                if (this.Jugar(jugadas, bolillero))
                {
                    ganadas++;
                }
            }

            return ganadas;
        }


        // TP Nº1 Fase 2

        public int simularSinHilos(List<byte> jugadas, long CantDeJugadas, Bolillero bolillero)
        {
            return JugarNVeces(jugadas, CantDeJugadas, bolillero);
        }

        public int simularConHilos()
        {
            var 
             
        }

    }
}
