Console.Write("Ingresa la nota: ");
    double nota = double.Parse(Console.ReadLine());

    if (nota == 20) {
        Console.WriteLine("¡Excelente!");
    }
    else if (nota >= 11) {
        Console.WriteLine("Aprobado");
    }
    else {
        Console.WriteLine("Desaprobado");
    }