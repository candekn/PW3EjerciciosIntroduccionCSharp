using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        //1)Crear una función que devuelva la suma de dos números recibidos por parámetros
        private static int Suma(int n1, int n2)
        {
            return n1 + n2;
        }
        /*
        2)Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la
        cadena cortada de izquierda a derecha en 4 caracteres.
        */
        private static string CortarCadena(string cadena)
        {
            return cadena.Substring(0, 4);
        }
        /* 3)Crear una función que devuelva la fecha y hora actual */
        private static DateTime FechaActual()
        {
            return DateTime.Now;
        }
        static void Main(string[] args)
        {
            // 4)Escribir un comentario con //
            //Comentario de una linea
            Console.WriteLine("Funcion suma 10+5: {0}", Suma(10, 5));
            Console.WriteLine("Funcion cadena cortada: 'Catalina' -> {0}", CortarCadena("Catalina"));
            Console.WriteLine("Funcion fecha y hora actual: {0}", FechaActual());

            Console.ReadKey();

            //5)Escribir un comentario con /* */

            /*Este
             es
             un
             comentario
             multilinea*/

        }
    }
}
