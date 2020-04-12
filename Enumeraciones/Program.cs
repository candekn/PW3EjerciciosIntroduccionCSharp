using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    class Program
    {
        public enum DiasDeLaSemana
        {
            Domingo = 1, Lunes = 2, Martes = 3, Miercoles = 4, Jueves = 5, Viernes = 6, Sabado = 7
        }
        static void Main(string[] args)
        {
            //1) Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1.
            //2)Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana
            bool estado = true;
            int num;
            do
            {
                Console.Write("Ingrese un numero y se mostrará el día de la semana (Ingrese '0' para salir): ");
                string n = Console.ReadLine();
                if(int.TryParse(n,out num))
                {
                    if (num == 0)
                    {
                        Console.WriteLine("Adios!");
                        estado = false;
                    }else if (num > 7 || num <0)
                    {
                        Console.WriteLine("Numero invalido, debe estar entre 1 y 7 (0 para salir)");
                    }
                    else
                    {
                        Console.WriteLine("El dia numero {0} es: {1}", num, Enum.GetName(typeof(DiasDeLaSemana), num));
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un numero entero (0-7)");
                }
            }while(estado);

            Console.ReadKey();
        }
    }
}
