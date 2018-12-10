using ejemplo_de_listas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemplo_de_listas.Controllers
{
    public class InicioController : Controller
    {
        private Alumno db = new Alumno();
        // GET: Inicio
        public ActionResult Index()
        {
            List<string> materias = new List<string>()
            {
                "matematica", "Algoritmia", "MVC Basico",
                "ingles", "contabilidad", "MVC Intermedio",
                "histora de internet", "use tools", "LinQ",
            };

            var query = from n in materias
                        where n.StartsWith("m")
                        select n;
            //Constraint: busca todos los elementos de la lista
            //atartsWith:  busca el primer valor de la lista
            //endswith:  busca el ultimo valor de la lista 

            return View(query.ToList());
        }
     
        public ActionResult Estudia()
        {
            List<Alumno> alumnos = new List<Alumno>();
        
            Alumno alum1 = new Alumno();
            {
                    alum1.IdAlumno = 1;
                    alum1.Carnet = 001;
                    alum1.Nombre = "jose";
                    alum1.Materia = "matematica";
                    alum1.Promedio = alum1.Promedio;
                    alum1.Fecha = alum1.Fecha;
                    alumnos.Add(alum1);
             }

            Alumno alum2 = new Alumno();
            {
                alum2.IdAlumno = 1;
                alum2.Carnet = 001;
                alum2.Nombre = "jose";
                alum2.Materia = "matematica";
                alum2.Promedio = 2;
                alum2.Fecha = alum2.Fecha;
                alumnos.Add(alum2);
            }

            Alumno alum3 = new Alumno();
            {
                alum3.IdAlumno = 1;
                alum3.Carnet = 001;
                alum3.Nombre = "jose";
                alum3.Materia = "matematica";
                alum3.Promedio = 9;
                alum3.Fecha = alum3.Fecha;
                alumnos.Add(alum3);
            }

            //ViewBag.nombre = BNombre;
            ////ViewBag.materia = BMateria;
            ////ViewBag.promedio = BPromedio;

            //var query = from Alumno in alumnos
            //            where alumnos.
            //            select alumnos;

            return View(alumnos.ToList());                               
                
                       
     }     
       
    }
}