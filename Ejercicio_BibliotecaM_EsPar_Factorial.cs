using System;

class Program
{
    // ① Función que verifica si el número es par
    static bool EsPar(int n)
    {
        return n % 2 == 0;
    }

    // ② Función que calcula el factorial - posible erropr
    static int Factorial(int n)
    {
        int resultado = 1;

        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }

    static void Main()
    {
        // Prueba de EsPar
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (EsPar(numero))
        {
            Console.WriteLine("El número es par");
        }
        else
        {
            Console.WriteLine("El número es impar");
        }

        // Prueba de Factorial
        Console.Write("Ingrese un número para calcular su factorial: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Factorial: " + Factorial(n));
    }
}