using DominioBolillero;
using System;
using System.Collections.Generic;

namespace BolilleroConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulacion simulacion = new Simulacion(0, 10);
            long cantDeSimulaciones = 10000;
            List<byte> jugadas = new List<byte> { 8 };

            Console.WriteLine($"Cantidad de ganadas: {simulacion.JugarN(jugadas, cantDeSimulaciones)}");

            Console.ReadLine();
        }
    }
}
