using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    // Clase Alumno que hereda de Persona
    class Alumno : Persona
    {
        public int NumeroAlumno { get; set; }
    }

    // Clase Profesor que hereda de Persona
    class Profesor : Persona
    {
        public string Materia { get; set; }
    }
}
