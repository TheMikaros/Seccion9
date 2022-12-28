using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3- Crear una Clase Base "Vehículo", y 3 clases derivadas de Vehículo,
            //Coche, Barco, Avión, crea unos métodos en vehículo, y sobrecargarlos
            //en la clase derivada.

            // Creamos un coche, un barco y un avión
            Coche coche = new Coche { Marca = "Ford", Modelo = "Fiesta", NumeroRuedas = 4 };
            Barco barco = new Barco { Marca = "Boaty McBoatface", Modelo = "Ocean Explorer", NumeroRemos = 4 };
            Avion avion = new Avion { Marca = "Boeing", Modelo = "747", NumeroAlas = 2 };

            // Mostramos la información de cada vehículo
            Console.WriteLine("Información del coche:");
            coche.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Información del barco:");
            barco.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Información del avión:");
            avion.MostrarInformacion();
        }
    }

   
}
