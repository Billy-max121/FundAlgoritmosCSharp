using System;

class Program
{
    // Función void que recibe un carácter y un número
    static void MostrarLinea(string caracter, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(caracter);
        }

        Console.WriteLine(); // Salto de línea al final
    }

    static void Main()
    {
        string caracter;
        int n;

        Console.Write("Ingrese un carácter o símbolo: ");
        caracter = Console.ReadLine();

        Console.Write("Ingrese la cantidad de veces: ");
        n = int.Parse(Console.ReadLine());

        MostrarLinea(caracter, n);
    }
}