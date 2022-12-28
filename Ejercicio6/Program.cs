using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 - Crea  una clase "Animal" con las siguientes propiedades: Tipo, color pelo, es domestico,
            // numero de patas, con el tipo de dato que creas conveniente. crea una instancia de esa clase,
            // y asigna los valores a las propiedades.

            Animal animal = new Animal
            {
                Tipo = "Gato",
                ColorPelo = "Negro",
                EsDomestico = true,
                NumeroPatas = 4
            };


        }
    }
}
