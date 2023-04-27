using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioConvertidor {
    [ServiceContract]
    internal interface IServicioTemperatura {
        [OperationContract]
        float convertirCelsiusAFahrenheit(float celsius);
        [OperationContract]
        float convertirFahrenheitACelsius(float fahrenheit);
    }
}