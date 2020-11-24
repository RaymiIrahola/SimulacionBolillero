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

        Random r { get; set; }

        public Bolillero()
        {
            r = new Random(DateTime.Now.Millisecond);
            bolillaAdentro = new List<byte>();
            bolillaAfuera = new List<byte>();
        }

        public Bolillero(byte inicio, byte fin) : this() 
        {
            CargartBolillero(inicio, fin);
        }

        public Bolillero(int cantDeBolillas)
        {
            this.cantDeBolillas = cantDeBolillas;
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

        public object Clone() => new Bolillero(cantDeBolillas);

    }
}
