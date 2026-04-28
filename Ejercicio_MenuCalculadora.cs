Console.WriteLine("Calculadora");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicacion");
Console.WriteLine("4. Division");
Console.Write("Escribir primer numero: ");
    double n1 = double.Parse(Console.ReadLine());
    Console.Write("Escribir segundo numero: ");
    double n2 = double.Parse(Console.ReadLine());
    Console.Write("Que operación realizará: ");
    int op = int.Parse(Console.ReadLine());

    switch (op) {
        case 1: Console.WriteLine(n1 + n2); break;
        case 2: Console.WriteLine(n1 - n2); break;
        case 3: Console.WriteLine(n1 * n2); break;
        case 4:
            if (n2 != 0) Console.WriteLine(n1 / n2);
            else Console.WriteLine("Error: Divisor es cero.");
            break;
        default: Console.WriteLine("Operación inválida."); break;
        }