using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioConvertidor {
    internal class ServicioTemperatura : IServicioTemperatura {
        public float convertirCelsiusAFahrenheit(float celsius) {
            float resultadoFahhrenheit = celsius * 1.8f + 32;
            return resultadoFahhrenheit;
        }

        public float convertirFahrenheitACelsius(float fahrenheit) {
            float resultadoCelsius = fahrenheit - 32 / 1.8f;
            return resultadoCelsius;
        }
    }
}