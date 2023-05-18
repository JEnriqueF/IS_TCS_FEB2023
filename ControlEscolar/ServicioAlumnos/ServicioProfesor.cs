using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioAlumnos {
    internal class ServicioProfesor : IServicioProfesor {
        public Profesor obtenerProfesor(string numPersonal) {
            Profesor profesor = new Profesor();
            profesor.numPersonal = numPersonal;
            profesor.nombre = "José";
            profesor.apellidos = "Sánchez Pérez";
            return profesor;
        }
    }
}