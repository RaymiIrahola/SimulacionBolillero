using System;
using System.Collections.Generic;

namespace DominioBolillero
{
    public class Bolillero
    {
        public int jugarNVeces { get; set; }
        
        public List<byte> bolillaAdentro { get; set; }
        public List<byte> bolillaAfuera { get; set; }
        Random r = new Random(DateTime.Now.Millisecond);

        public Bolillero()
        {

        }

        public Bolillero(byte inicio, byte fin)
        {
            List<byte> bolillaAdentro = new List<byte>();
            List<byte> bolillaAfuera = new List<byte>();
            int cargarBolillero = new int();
        }
        

        public byte SacarBolilla(byte unaBolillaAfuera)
        {
            
        }

        public void Reingresar()
        {
            bolillaAdentro.AddRange(bolillaAfuera);
            bolillaAfuera.Clear();
        }

        private void CargartBolillero(byte inicio, byte fin)
        {

            for (byte i = inicio; i < fin; i++)
            {
                bolillaAdentro.Add(i);
            }
        }
        

    }
}
