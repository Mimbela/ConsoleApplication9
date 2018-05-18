using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList milista = new ArrayList();
            StreamReader fichero;
            StreamWriter salida;

            fichero = File.OpenText("datos.txt");
            salida = File.CreateText("salidaDatos1.txt");
            string linea;

            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                {
                    milista.Add(linea);
                }

            } while (linea != null);

            foreach (string frase in milista)
            {
                if (milista.IndexOf(frase) % 2 == 0)
                {
                    //par
                    salida.WriteLine(frase);
                }
                else
                {
                    //impar
                    Console.WriteLine(frase);
                }
            }

            fichero.Close();
            salida.Close();
            Console.ReadKey();
        }
    }
}
/*Las listas:
Es una estructura dinámica en la que se puede añadir elementos sin tantas restricciones.
Se pueden introducir nuevos datos en ambos extremos, así como entre dos elementos existentes
Incluso de forma ordenada, de modo que cada nuevo dato se introduzca automáticamente en la posición adecuada para que todos ellos queden en orden.
En  C# no tenemos ninguna clase "List" que represente una lista genérica, pero sí dos variantes : una lista ordenada ("SortedList") y una lista a cuyos elementos se puede acceder como a los de un array ("ArrayList").
*/
/*ArrayList:
Añadir datos en la última posición con "Add "
Insertar en cualquier otra con "Insert "
Recuperar cualquier elemento usando corchetes.
Ordenar toda la lista con "Sort "
*/
/*ejercicio:
 crea un programa que lea el contenido de un fichero de texto, lo almacene línea por líea
 en un Arraylist, luego muestre en pantalla las líneas impares y 
 finalmente vuelque a otro fichero de texto las líneas pares*/

/*StreamWriter es la clase que representa a un fichero en el que podemos escribir*/
/*StreamReader , Para leer de un fichero no usaremos StreamWriter, sino StreamReader.​
Si queremos abrir un fichero que ya existe, usaremos OpenText, en lugar de CreateText. ​
Para leer del fichero, usaríamos ReadLine, como hacíamos en la consola​*/
