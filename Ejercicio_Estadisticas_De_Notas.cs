using System;

class Program {
    static void Main() {
        int nota, total = 0, suma = 0, mayor = -1, menor = 21;
        int exc = 0, bno = 0, apr = 0, des = 0;
        do {
            Console.Write("Ingrese nota (0-20 o -1 para salir): ");
            nota = int.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 20) {
                total++; suma += nota;
                if (nota > mayor) mayor = nota;
                if (nota < menor) menor = nota;
                // Clasificación anidada
                if (nota >= 17) exc++;
                else if (nota >= 14) bno++;
                else if (nota >= 11) apr++;
                else des++;
            } else if (nota != -1) Console.WriteLine("Nota inválida.");
        } while (nota != -1);
        
        if (total > 0) {
            Console.WriteLine($"Total: {total} | Prom: {(double)suma/total:F2}");
            Console.WriteLine($"Mayor: {mayor} | Menor: {menor}");
            Console.WriteLine($"Exc: {exc} | Bno: {bno} | Apr: {apr} | Des: {des}");
        }
    }
}