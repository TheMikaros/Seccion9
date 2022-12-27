using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas.
            //Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas
            //mayores de edad (mayores o iguales a 18 años), se tendrá que crear una clase "Persona" que
            //contenga las propiedades "Nombre" y "Edad". Utilizar todos los componentes vistos hasta la fecha
            // (bucles, funciones, clases).

            List<Persona> personas = new List<Persona>();

            // Cargamos 5 nombres de personas y sus edades
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de la persona:");
                int edad = int.Parse(Console.ReadLine());

                personas.Add(new Persona { Nombre = nombre, Edad = edad });
            }

            // Imprimimos los nombres de las personas mayores de edad
            Console.WriteLine("Las personas mayores de edad son:");
            foreach (var persona in personas)
            {
                if (persona.Edad >= 18)
                {
                    Console.WriteLine(persona.Nombre);
                }
            }

            Console.ReadLine(); 
        }
    }
}
