using System;

class Program
{
    static void Main()
    {
        // Ejemplo de uso para MaxDe3
        Console.WriteLine("--- Mayor de tres números ---");
        Console.Write("Ingrese el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el tercer número: ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"El mayor es: {MaxDe3(n1, n2, n3)}");

        // Ejemplo de uso para ConvertirTemp
        Console.WriteLine("\n--- Conversión de Temperatura ---");
        Console.Write("Ingrese grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{celsius}°C equivalen a {ConvertirTemp(celsius)}°F");

        // Ejemplo de uso para AreaRectangulo
        Console.WriteLine("\n--- Área de un Rectángulo ---");
        Console.Write("Ingrese la base: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura: ");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"El área es: {AreaRectangulo(b, h)}");
    }

    // 1. Devuelve el mayor de tres números
    static double MaxDe3(double a, double b, double c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    // 2. Convierte Celsius a Fahrenheit
    static double ConvertirTemp(double c)
    {
        return (c * 9 / 5) + 32;
    }

    // 3. Calcula el área de un rectángulo
    static double AreaRectangulo(double b, double h)
    {
        return b * h;
    }
}