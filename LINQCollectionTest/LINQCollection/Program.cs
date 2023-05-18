using LINQCollection;
using System.Linq;

//Coleccion numeros
/*int[] numeros = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
Console.WriteLine("A continuacion mostramos los numeros pares que existen en el arreglo:");

//Seleccion de pares sin LINQ
List<int> lista_numeros_pares = new List<int>();
foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        lista_numeros_pares.Add(numero);
    }
}


//Seleccion de numeros pares con LINQ
//En numero se guarda los elementos de la coleccion numeros
IEnumerable<int> numeros_pares = from numero in numeros where numero % 2 == 0 select numero;

//Impresion numeros pares
foreach(int numero in numeros_pares)
{
    Console.WriteLine(numero);
}*/

//EJEMPLO CONTROL ALUMNO OBJETOS CON LINQ
ControlAlumnos controlAlumnos = new ControlAlumnos();

controlAlumnos.obtenerAlumnosPorCarrera(2);