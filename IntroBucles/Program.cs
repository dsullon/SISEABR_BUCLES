using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroBucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SENTENCIAS REPETITIVAS");
            Console.WriteLine("========================");
            sentenciaFOR();
            Console.ReadKey();
        }

        private static void sentenciaFOR()
        {
            Console.WriteLine("SENTENCIA FOR");
            Console.WriteLine("--------------");
            // for(valor_inicio; valor_final; incremento)
            Console.WriteLine("Ingrese el límite superior (valor_final): ");
            int limiteSuperior = int.Parse(Console.ReadLine());
            int limiteInferior; // CONTADOR
            int contadorVueltas = 0; // CONTADOR
            int sumaTotal = 0; // ACUMULADOR

            for (limiteInferior=1; limiteInferior <= limiteSuperior; limiteInferior+=2)
            {
                Console.WriteLine($"Valor del límite inferior: {limiteInferior}");
                contadorVueltas++;
                sumaTotal = sumaTotal + limiteInferior;
            }

            var promedio = decimal.Parse(sumaTotal.ToString()) / decimal.Parse(contadorVueltas.ToString());

            Console.WriteLine($"La suma total de los números es: {sumaTotal}");
            Console.WriteLine($"El promedio de los números es: {promedio}");
        }
    }
}
