using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //

            List<Persona> personas = new List<Persona>();

            // Cargamos 5 nombres de personas y sus edades
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de la persona:");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Es esta persona un alumno (A) o un profesor (P)?");
                char tipo = char.Parse(Console.ReadLine());

                if (tipo == 'A')
                {
                    Console.WriteLine("Ingrese el número de alumno:");
                    int numeroAlumno = int.Parse(Console.ReadLine());
                    personas.Add(new Alumno { Nombre = nombre, Edad = edad, NumeroAlumno = numeroAlumno });
                }
                else if (tipo == 'P')
                {
                    Console.WriteLine("Ingrese la materia que imparte:");
                    string materia = Console.ReadLine();
                    personas.Add(new Profesor { Nombre = nombre, Edad = edad, Materia = materia });
                }
            }


            Console.WriteLine("Las personas mayores de edad son:");
            foreach (var persona in personas)
            {
                if (persona.Edad >= 18)
                {
                    if (persona is Alumno)
                    {
                        Console.WriteLine("Es un alumno con número de alumno: " + (persona as Alumno).NumeroAlumno);
                    }
                    else if (persona is Profesor)
                    {
                        Console.WriteLine("Es un profesor que imparte la materia: " + (persona as Profesor).Materia);
                    }
                }
            }

        }
    }
}
