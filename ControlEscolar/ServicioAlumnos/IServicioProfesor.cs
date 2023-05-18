using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioAlumnos {
    [ServiceContract]
    internal interface IServicioProfesor {
        [OperationContract]
        Profesor obtenerProfesor(string numPersonal);
    }
}