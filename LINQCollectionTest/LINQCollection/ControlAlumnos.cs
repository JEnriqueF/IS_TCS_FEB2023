using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQCollection {
    internal class ControlAlumnos {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos() {
            carreras.Add(new Carrera { IdCarrera = 1, Nombre = "Ingeniería de software" });
            carreras.Add(new Carrera { IdCarrera = 2, Nombre = "Redes y servicios de cómputo" });

            alumnos.Add(new Alumno {
                IdAlumno = 3,
                Nombre = "Juan Prez Snchez",
                Matricula = "s090032",
                Promedio = 8.9,
                IdCarrera = 1
            });
            alumnos.Add(new Alumno { 
                IdAlumno = 1,
                Nombre = "Maria Rodríguez Martínez",
                Matricula = "s4324234",
                Promedio = 9.2,
                IdCarrera = 2
            });
            alumnos.Add(new Alumno {
                IdAlumno = 3,
                Nombre = "José Trelles Jimenez",
                Matricula = "s211111",
                Promedio = 6.5,
                IdCarrera = 2
            });
        }

        public void obtenerAlumnosPorCarrera(int idCarrera) {
            IEnumerable<Alumno> resultado = from alumno in alumnos join carrera in carreras on alumno.IdCarrera equals carrera.IdCarrera where alumno.IdCarrera == idCarrera 
                                            select alumno;

            foreach(Alumno alumno in resultado) {
                alumno.getAlumno(carreras);
            }
        }
    }
}