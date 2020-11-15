using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominioBolillero
{
    public class Bolillero
    {
        public int jugarNVeces { get; set; }

        public List<byte> bolillaAdentro { get; set; }

        public List<byte> bolillaAfuera { get; set; }

        public int cantDeBolillas { get; set; }

        Random r = new Random(DateTime.Now.Millisecond);

        public Bolillero()
        {

        }

        public Bolillero(byte inicio, byte fin)
        {
            List<byte> bolillaAdentro = new List<byte>();
            List<byte> bolillaAfuera = new List<byte>();
            //int cargarBolillero = new int();
        }

        internal int SacarBolilla()
        {
            throw new NotImplementedException();
        }

        public byte SacarBolilla(byte unaBolillaAfuera)
        {
            byte bolilla = bolillaAdentro[r.Next(bolillaAdentro.Count)];
            bolillaAfuera.Add(bolilla);
            bolillaAdentro.Remove(bolilla);
            return bolilla;

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
