using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso cada uno de los métodos indicados.
             */
            bool t1c = Convert.ToBoolean("true");
            bool t2c = Convert.ToBoolean(1);
            bool f1c = Convert.ToBoolean("false");
            bool f2c = Convert.ToBoolean(0);
            //La primer diferencia entre Convert y bool.Parse, es que el segundo solo acepta 
            //argumentos de tipo string, en cambio Convert acepta muchos tipos 
            
            bool t1p = bool.Parse("true");
            bool f1p = bool.Parse("false");
            

            //La segunda diferencia entre Convert. y bool.Parse, es que Convert acepta valores nulos
            //y en esos casos devuelve false:
            bool boolNuloConvert = Convert.ToBoolean(null);
            Console.WriteLine("Valor de booleano nulo con Convert: {0}", boolNuloConvert);
            //Parse, en cambio, lanza una excepcion de tipo Argumento Nulo:
            try
            {
                bool boolNuloParse = bool.Parse(null);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("\nConvertir un null en bool con Parse, lanzó una excepción");
            }

            //Por su parte, TryParse intenta convertir al argumento, si logra convertirlos devuelve
            //True y guarda el resultado de la conversion en el segundo argumento.
            //Si no puede, devuelve False. 
            //Al igual que parse, el argumento a convertir debe ser tipo string.
            //Recomiendo su uso cuando el argumento a convertir proviene de una entrada de usuario.
            bool tryP;
            Console.Write("\nIngrese valor a convertir a boolean: ");
            string entrada = Console.ReadLine();
            if(bool.TryParse(entrada, out tryP))
            {
                Console.WriteLine("La conversion de {0} es un bool con valor  {1}", entrada, tryP);
            }
            else
            {
                Console.WriteLine("No pudo convertirse a boolean el valor " +entrada);
            }
            
            //2) Explique que sucede en los siguientes intentos de casteos de datos.

            int a = (int)344.4;
            //a.En este caso, el dato es casteado, eliminando sus decimales:
            Console.WriteLine(a);

            //b. En este caso, el dato se asigna sin problemas:
            decimal b = 10;
            Console.WriteLine(b.GetType());
            //c. El dato es casteado sin lanzar ninguna excepcion ni error. El problema, es
            //que el tipo de dato short solo acepta enteros de -32768 a 32767. 
            Console.WriteLine("Maximo valor de short: {0} \nMinimo valor de short: {1}", short.MinValue, short.MaxValue);
            int c = 443444;

            short c2 = (short)c;
            //Aca se muestra en problema: 
            Console.WriteLine("Int: {0} , Short: {1}", c, c2);
            Console.ReadKey();

        }
    }
}
