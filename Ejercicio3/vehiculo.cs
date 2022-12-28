using Ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
     // Clase base Vehículo
    class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // Método MostrarInformacion de la clase base
        public void MostrarInformacion()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
        }
    }

    // Clase derivada Coche que hereda de Vehículo
    class Coche : Vehiculo
    {
        public int NumeroRuedas { get; set; }

        // Sobrecarga del método MostrarInformacion de la clase base en la clase Coche
        public new void MostrarInformacion()
        {
            // Llamamos al método MostrarInformacion de la clase base
            base.MostrarInformacion();
            // Mostramos la información específica de la clase Coche
            Console.WriteLine("Número de ruedas: " + NumeroRuedas);
        }
    }


// Clase derivada Barco que hereda de Vehículo
class Barco : Vehiculo
{
    public int NumeroRemos { get; set; }

    // Sobrecarga del método MostrarInformacion de la clase base en la clase Barco
    public new void MostrarInformacion()
    {
        // Llamamos al método MostrarInformacion de la clase base
        base.MostrarInformacion();

        // Mostramos la información específica de la clase Barco
        Console.WriteLine("Número de remos: " + NumeroRemos);
    }
}

// Clase derivada Avion que hereda de Vehículo
class Avion : Vehiculo
{
    public int NumeroAlas { get; set; }

    // Sobrecarga del método MostrarInformacion de la clase base en la clase Avion
    public new void MostrarInformacion()
    {
        // Llamamos al método MostrarInformacion de la clase base
        base.MostrarInformacion();

        // Mostramos la información específica de la clase Avion
        Console.WriteLine("Número de alas: " + NumeroAlas);
    }
}

}
