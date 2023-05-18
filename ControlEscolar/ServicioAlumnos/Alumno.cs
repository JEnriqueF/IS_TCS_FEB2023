using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServicioAlumnos {
    [DataContract]
    internal class Alumno {
        [DataMember]
        public string matricula { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string apellidos { get; set; }
        [DataMember]
        public int edad { get; set; }
    }
}