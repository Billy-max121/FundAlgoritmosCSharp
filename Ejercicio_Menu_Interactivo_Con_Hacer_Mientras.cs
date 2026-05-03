using System;

class Program {
    static void Main() {
        int opcion;
        do {
            Console.WriteLine("\n--- MENÚ --- 1.Suma 2.Resta 3.Mult 4.Div 5.Salir");
            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 4) {
                Console.Write("Num 1: "); double n1 = double.Parse(Console.ReadLine());
                Console.Write("Num 2: "); double n2 = double.Parse(Console.ReadLine());

                switch (opcion) {
                    case 1: Console.WriteLine($"Suma: {n1 + n2}"); break;
                    case 2: Console.WriteLine($"Resta: {n1 - n2}"); break;
                    case 3: Console.WriteLine($"Mult: {n1 * n2}"); break;
                    case 4: Console.WriteLine(n2 != 0 ? $"Div: {n1 / n2}" : "Error: Div por cero"); break;
                }
            } else if (opcion == 5) {
                Console.WriteLine("¡Adiós!");
            } else {
                Console.WriteLine("Error: Opción inválida.");
            }
        } while (opcion != 5);
    }
}