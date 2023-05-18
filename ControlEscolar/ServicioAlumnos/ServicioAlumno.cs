using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioAlumnos {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumno : IServicioAlumno {
        Alumno IServicioAlumno.obtenerAlumno(string matricula) {
            Alumno alumno = new Alumno();
            alumno.matricula = matricula;
            alumno.nombre = "Juan";
            alumno.apellidos = "Pérez Hernández";
            alumno.edad = 21;
            return alumno;
        }

        List<Alumno> IServicioAlumno.obtenerAlumnos() {
            List<Alumno> lista = new List<Alumno>();
            Alumno alumno;
            Random random = new Random();

            for (int i = 1; i <= 100; i++) {
                alumno = new Alumno();

                alumno.matricula = "s0100" + i;
                alumno.nombre = "Alumno " + i;
                alumno.apellidos = "Apellidos...";
                alumno.edad = random.Next(17,80);

                lista.Add(alumno);
            }
            return lista;
        }
    }
}