using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("¿Cuantos números deseas añadir?");
        int n = int.Parse(Console.ReadLine());

        List<int> numeros = new List<int>();

        Console.WriteLine("Añada " + n + " números:");
        for (int i = 0; i < n; i++)
        {
            int numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        var multiplosDeDos = numeros.Where(n => n % 2 == 0).ToList();
        var numerosPrimos = numeros.Where(EsPrimo).ToList();
        var multiplosDeCinco = numeros.Where(n => n % 5 == 0).ToList();
        var numerosPerfectos = numeros.Where(EsNumeroPerfecto).ToList();

        Console.WriteLine("Salida:");
        Console.WriteLine("Lista 1 : " + string.Join(", ", multiplosDeDos) );
        Console.WriteLine("Lista 2 : " + string.Join(", ", numerosPrimos) );
        Console.WriteLine("Lista 3 : " + string.Join(", ", multiplosDeCinco) );
        Console.WriteLine("Lista 4 : " + string.Join(", ", numerosPerfectos) );
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool EsNumeroPerfecto(int numero)
    {
        int sumaDivisores = numerosDivisores(numero).Sum();
        return sumaDivisores == numero;
    }

    static IEnumerable<int> numerosDivisores(int numero)
    {
        for (int i = 1; i <= numero / 2; i++)
        {
            if (numero % i == 0)
            {
                yield return i;
            }
        }
    }
}