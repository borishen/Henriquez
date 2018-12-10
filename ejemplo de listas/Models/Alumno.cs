using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejemplo_de_listas.Models
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double Promedio { get; set; }
        public DateTime Fecha { get; set; }

            }
}