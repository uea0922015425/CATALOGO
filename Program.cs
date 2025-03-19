using System;

class Nodo
{
    public string Titulo { get; set; }
    public Nodo? Izquierdo { get; set; } = null;
    public Nodo? Derecho { get; set; } = null;

    public Nodo(string titulo)
    {
        Titulo = titulo;
    }
}

class ArbolBinario
{
    public Nodo? Raiz { get; private set; } = null;

    public void Insertar(string titulo)
    {
        Raiz = InsertarRecursivo(Raiz, titulo);
    }

    private Nodo InsertarRecursivo(Nodo? nodo, string titulo)
    {
        if (nodo == null)
            return new Nodo(titulo);

        if (string.Compare(titulo, nodo.Titulo, StringComparison.OrdinalIgnoreCase) < 0)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, titulo);
        else if (string.Compare(titulo, nodo.Titulo, StringComparison.OrdinalIgnoreCase) > 0)
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, titulo);

        return nodo;
    }

    public bool Buscar(string titulo)
    {
        return BuscarRecursivo(Raiz, titulo);
    }

    private bool BuscarRecursivo(Nodo? nodo, string titulo)
    {
        if (nodo == null)
            return false;

        if (titulo == nodo.Titulo)
            return true;

        return string.Compare(titulo, nodo.Titulo, StringComparison.OrdinalIgnoreCase) < 0
            ? BuscarRecursivo(nodo.Izquierdo, titulo)
            : BuscarRecursivo(nodo.Derecho, titulo);
    }
}

class Program
{
    static void Main()
    {
        ArbolBinario catalogo = new ArbolBinario();

        string[] titulos = {
            "Viztazo", "Estadio", "La Posta", "Yambal",
            "Lebel", "Oriflame", "Leoniza", "La Nike",
            "El Extra", "El Super"
        };

        foreach (var titulo in titulos)
        {
            catalogo.Insertar(titulo);
        }

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Buscar una revista");
            Console.WriteLine("2. Salir");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine() ?? "";

            if (opcion == "2") break;

            if (opcion == "1")
            {
                Console.Write("Ingrese el título de la revista: ");
                string tituloBuscar = Console.ReadLine() ?? "";

                bool encontrado = catalogo.Buscar(tituloBuscar);
                Console.WriteLine(encontrado ? "Encontrado" : "No encontrado");
            }
        }
    }
}
