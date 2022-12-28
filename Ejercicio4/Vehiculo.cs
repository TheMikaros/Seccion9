using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Vehiculo
    {
        private int NumeroRuedas{ get; set; }
        private int NumeroPuertas { get; set; }

        // Constructor por defecto
        public Vehiculo()
        {
            NumeroRuedas = 4;
            NumeroPuertas = 4;
        }

        // Constructor con parámetros para asignar el número de ruedas y puertas
        public Vehiculo(int numeroRuedas, int numeroPuertas)
        {
            NumeroRuedas = numeroRuedas;
            NumeroPuertas = numeroPuertas;
        }

        // Constructor con parámetros para asignar el número de ruedas y el número de puertas a un valor predeterminado
        public Vehiculo(int numeroRuedas)
        {
            NumeroRuedas = numeroRuedas;
            NumeroPuertas = 4;
        }
    }
}
