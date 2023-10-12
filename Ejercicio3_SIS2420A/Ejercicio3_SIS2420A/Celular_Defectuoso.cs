using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_SIS2420A
{
    public class Celular_Defectuoso : Celular
    {
        public string Motivo { get; set; }

        public Celular_Defectuoso(string marca, string modelo, string so, int ram, int almacenamiento, DateTime fechaIngreso, string motivo)
            : base(marca, modelo, so, ram, almacenamiento, fechaIngreso)
        {
            Motivo = motivo;
        }

        public override void MostrarCelular()
        {
            Console.WriteLine("Celular Defectuoso:");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Sistema Operativo: {SO}");
            Console.WriteLine($"RAM: {Ram} GB");
            Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
            Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Motivo del Defecto: {Motivo}");
        }
    }

    
    }

