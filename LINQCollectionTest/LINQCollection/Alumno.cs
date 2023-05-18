using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQCollection{
    internal class Alumno{
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public double Promedio { get; set; }
        public int IdCarrera { get; set; }

        public void getAlumno(List<Carrera> carreras) {
            Carrera carrera = carreras.FirstOrDefault(c => c.IdCarrera == IdCarrera);

            Console.WriteLine("Alumno {0} con matrícula {1} y promedio {2} con carrera {4} y ID de carrera {3}", Nombre, Matricula, Promedio,
                IdCarrera, carrera.Nombre);
        }
    }
}