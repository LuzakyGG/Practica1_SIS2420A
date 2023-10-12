using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_SIS2420A
{
    class Program
    {
        static void Main()
        {
            Console.Write("Numero: ");

            int numero = int.Parse(Console.ReadLine());
            string numeroEnLetras = NumeroEnLetras.ConvertirNumeroEnLetras(numero);
            Console.WriteLine(numeroEnLetras);
            Console.ReadKey();
            
            
        }
    }
}


