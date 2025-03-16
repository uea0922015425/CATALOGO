using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Crear una lista para almacenar los títulos de las revistas
        List<string> catalogoRevistas = new List<string>()
        {
            "Yambal", "Oriflame", "Viztazo", "Leonisa", "Estadio",
            "Lebel", "Esica", "Avon", "Nike", "Jordan"

        };

        int opcion;
        
        do
        {
            // 2. Mostrar el menú
            Console.WriteLine("\n--- MENÚ DEL CATÁLOGO DE REVISTAS ---");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            // 3. Opciones del menú
            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese el título de la revista a buscar: ");
                    string tituloBuscado = Console.ReadLine();

                    // 4. Buscar en la lista e informar si está o no
                    if (catalogoRevistas.Contains(tituloBuscado))
                    {
                        Console.WriteLine("Resultado: ENCONTRADO ✅");
                    }
                    else
                    {
                        Console.WriteLine("Resultado: NO ENCONTRADO ❌");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }

        } while (opcion != 0);
    }
}
