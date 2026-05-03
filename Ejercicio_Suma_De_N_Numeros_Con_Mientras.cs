using System;

class Program {
    static void Main() {
        Console.Write("¿Cuántos números desea sumar? ");
        int n = int.Parse(Console.ReadLine());
        
        int suma = 0, mayor = int.MinValue, menor = int.MaxValue;
        int i = 0;
        
        while (i < n) {
            Console.Write($"Ingrese número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            
            suma += num;
            if (num > mayor) mayor = num;
            if (num < menor) menor = num;
            i++;
        }
        
        double promedio = (double)suma / n;
        Console.WriteLine($"Cantidad: {n} | Suma: {suma} | Promedio: {promedio:F2}");
        Console.WriteLine($"Mayor: {mayor} | Menor: {menor}");
    }
}