using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioConvertidor {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioDivisas : IServicioDivisas {
        float valorDolar = 17.98f;

        public float convertirDolaresAPesos(float dolares) {
            float resultadoDolarAPeso = dolares * valorDolar;
            return resultadoDolarAPeso;
        }

        public float convertirPesosADolares(float pesos) {
            float resultadoPesoADolar = pesos / valorDolar;
            return resultadoPesoADolar;
        }
    }
}