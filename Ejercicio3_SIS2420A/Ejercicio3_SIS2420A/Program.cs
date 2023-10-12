using Ejercicio3_SIS2420A;
using System;

public abstract class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string SO { get; set; }
    public int Ram { get; set; }
    public int Almacenamiento { get; set; }
    public DateTime FechaIngreso { get; set; }

    
    public Celular(string marca, string modelo, string so, int ram, int almacenamiento, DateTime fechaIngreso)
    {
        Marca = marca;
        Modelo = modelo;
        SO = so;
        Ram = ram;
        Almacenamiento = almacenamiento;
        FechaIngreso = fechaIngreso;
    }

    
    public abstract void MostrarCelular();
}
class Program
{
    static void Main(string[] args)
    {
        List<Celular> celulares = new List<Celular>
        {
            new Celular_Nuevo("Samsung", "Galaxy S21", "Android", 8, 128, new DateTime(2023, 1, 15), 899.99m),
            new Celular_Nuevo("Apple", "iPhone 13", "iOS", 4, 64, new DateTime(2023, 2, 5), 999.99m),
            new Celular_Nuevo("Google", "Pixel 6", "Android", 6, 256, new DateTime(2023, 3, 10), 799.99m),
            new Celular_Nuevo("Sony", "Xperia 5", "Android", 6, 128, new DateTime(2023, 4, 20), 699.99m),
            new Celular_Nuevo("OnePlus", "9 Pro", "Android", 12, 256, new DateTime(2023, 5, 1), 899.99m),
            new Celular_Nuevo("LG", "G9", "Android", 8, 128, new DateTime(2023, 6, 15), 699.99m),
            new Celular_Defectuoso("Motorola", "Moto G7", "Android", 4, 64, new DateTime(2023, 9, 20), "Pantalla rota"),
            new Celular_Defectuoso("Nokia", "8.3", "Android", 6, 128, new DateTime(2023, 10, 1), "Batería defectuosa"),
        };

       
        double Prom_Celular(List<Celular_Nuevo> celularesNuevos)
        {
            return celularesNuevos.Average(celular => (double)celular.Precio);
        }

        
        List<Celular_Nuevo> Cel_MarcaS(List<Celular_Nuevo> celularesNuevos)
        {
            return celularesNuevos.Where(celular => celular.Marca == "Samsung").ToList();
        }

        
        List<Celular_Nuevo> Celular_RSA(List<Celular_Nuevo> celularesNuevos)
        {
            return celularesNuevos.Where(celular => celular.Ram == 8 && celular.SO == "Android" && celular.Almacenamiento == 128).ToList();
        }

        
        List<Celular_Nuevo> Celular_Ingreso(List<Celular_Nuevo> celularesNuevos, int año)
        {
            return celularesNuevos.Where(celular => celular.FechaIngreso.Year == año).ToList();
        }

        
        var celularesApple = from celular in celulares.OfType<Celular_Nuevo>()
                             where celular.Marca == "Apple"
                             select new { celular.Modelo, celular.Precio };

        Console.WriteLine($"Promedio de precios de los celulares nuevos: ${Prom_Celular(celulares.OfType<Celular_Nuevo>().ToList()):0.00}");
        Console.WriteLine("Celulares de Marca Samsung:");
        List<Celular_Nuevo> samsungCelulares = Cel_MarcaS(celulares.OfType<Celular_Nuevo>().ToList());
        foreach (var celular in samsungCelulares)
        {
            celular.MostrarCelular();
        }

        Console.WriteLine("Celulares con RAM = 8GB, SO = Android y Almacenamiento de 128GB:");
        List<Celular_Nuevo> rsaCelulares = Celular_RSA(celulares.OfType<Celular_Nuevo>().ToList());
        foreach (var celular in rsaCelulares)
        {
            celular.MostrarCelular();
        }

        Console.WriteLine("Celulares ingresados en el año 2023:");
        List<Celular_Nuevo> ingreso2023Celulares = Celular_Ingreso(celulares.OfType<Celular_Nuevo>().ToList(), 2023);
        foreach (var celular in ingreso2023Celulares)
        {
            celular.MostrarCelular();
        }

        Console.WriteLine("Modelos y precios de celulares Apple:");
        foreach (var celular in celularesApple)
        {
            Console.WriteLine($"{celular.Modelo}: ${celular.Precio}");
        }
    }
}
