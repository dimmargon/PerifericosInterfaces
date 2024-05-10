using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p6_escritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Pasamos el nombre del fichero y la ruta al constructor
                StreamWriter sw = new StreamWriter("C:/users/dimas/desktop/ejemplo.txt");
                /*He tenido que poner esta ruta porque en 'C:' me denegaba el acceso*/
                //Escribimos una línea de texto
                sw.WriteLine("¡Hola Mundo!!!");
                //Escribimos la segunda línea de texto
                sw.WriteLine("desde la clase StreamWriter");
                //Cerramos fichero
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
