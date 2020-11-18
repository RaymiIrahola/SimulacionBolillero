using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominioBolillero
{
    public class Bolillero: ICloneable
    {
        public int jugarNVeces { get; set; }

        public List<byte> bolillaAdentro { get; set; }

        public List<byte> bolillaAfuera { get; set; }

        public int cantDeBolillas { get; set; }

        Random r { get; set; }

        public Bolillero()
        {
            r = new Random(DateTime.Now.Millisecond);
            bolillaAdentro = new List<byte>();
            bolillaAfuera = new List<byte>();
        }

        private Bolillero(Bolillero original)
        {
            bolillaAdentro = new List<byte>(original.bolillaAdentro);
            bolillaAfuera = new List<byte>(original.bolillaAfuera);
        }

        public Bolillero(byte inicio, byte fin) : this() 
        {
            CargartBolillero(inicio, fin);
        }

        public byte SacarBolilla()
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

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
