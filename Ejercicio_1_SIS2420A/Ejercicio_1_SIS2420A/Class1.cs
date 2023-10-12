using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_SIS2420A
{
    public static class NumeroEnLetras
    {
        private static string[] unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        private static string[] decenas = { "", "", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        private static string[] especiales = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
        private static string[] centenas = { "", "cien", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

        public static string ConvertirNumeroEnLetras(int numero)
        {
            if (numero >= 0 && numero < 10)
            {
                return unidades[numero];
            }
            else if (numero >= 10 && numero < 20)
            {
                return especiales[numero - 10];
            }
            else if (numero >= 20 && numero <= 99)
            {
                int decena = numero / 10;
                int unidad = numero % 10;
                if (unidad == 0)
                {
                    return decenas[decena];
                }
                else
                {
                    return decenas[decena] + " y " + unidades[unidad];
                }
            }
            else if (numero >= 100 && numero <= 999)
            {
                int centena = numero / 100;
                int decena = numero % 100;
                if (decena == 0)
                {
                    return centenas[centena];
                }
                else
                {
                    return centenas[centena] + " " + ConvertirNumeroEnLetras(decena);
                }
            }
            else if (numero >= 1000 && numero <= 9999)
            {
                int unidadDeMil = numero / 1000;
                int resto = numero % 1000;
                if (resto == 0)
                {
                    return unidades[unidadDeMil] + " mil";
                }
                else
                {
                    return unidades[unidadDeMil] + " mil " + ConvertirNumeroEnLetras(resto);
                }
            }
            else
            {
                return "Número fuera de rango";
            }
        }
    }
}
