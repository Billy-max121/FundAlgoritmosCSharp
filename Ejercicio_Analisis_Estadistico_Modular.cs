using System;

class ProgramaNotas
{
    static void Main()
    {
        // Variables para acumular resultados
        double sumaNotas = 0;
        double notaMayor = -1; // Inicializar muy bajo
        double notaMenor = 21; // Inicializar muy alto
        int contadorAprobados = 0;
        int totalNotas = 0;

        Console.WriteLine("=== SISTEMA DE ANÁLISIS DE NOTAS ===");
        Console.Write("¿Cuántas notas desea ingresar?: ");
        totalNotas = int.Parse(Console.ReadLine());

        for (int i = 1; i <= totalNotas; i++)
        {
            // 1. Llamar a LeerNota (Pide y valida)
            double notaActual = LeerNota($"Ingrese la nota del estudiante {i}");

            // 2. Acumular para el promedio
            sumaNotas += notaActual;

            // 3. Evaluar si es aprobado usando EsAprobado
            if (EsAprobado(notaActual))
            {
                contadorAprobados++;
            }

            // 4. Clasificar y mostrar inmediatamente
            string clasificacion = ClasificarNota(notaActual);
            Console.WriteLine($"   -> Clasificación: {clasificacion}");

            // 5. Determinar mayor y menor (Lógica en main para seguimiento de serie)
            if (notaActual > notaMayor) notaMayor = notaActual;
            if (notaActual < notaMenor) notaMenor = notaActual;
        }

        // 6. Calcular promedio mediante función
        double promedioFinal = CalcularPromedio(sumaNotas, totalNotas);

        // 7. Mostrar resultados finales mediante función
        MostrarEstadisticas(promedioFinal, notaMayor, notaMenor, contadorAprobados, totalNotas);
    }

    // --- MÓDULOS DEL PROGRAMA ---

    // Pide y valida una nota entre 0 y 20
    static double LeerNota(string mensaje)
    {
        double nota;
        while (true)
        {
            Console.Write($"{mensaje} (0-20): ");
            if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 20)
            {
                return nota;
            }
            Console.WriteLine(" [Error] Nota inválida. Intente de nuevo.");
        }
    }

    // Retorna True si la nota es aprobatoria
    static bool EsAprobado(double nota)
    {
        return nota >= 11;
    }

    // Clasifica la nota según rangos
    static string ClasificarNota(double nota)
    {
        if (nota >= 18) return "Excelente";
        if (nota >= 15) return "Bueno";
        if (nota >= 11) return "Aprobado";
        return "Desaprobado";
    }

    // Calcula y retorna el promedio
    static double CalcularPromedio(double suma, int n)
    {
        if (n == 0) return 0;
        return suma / n;
    }

    // Muestra el resumen de estadísticas
    static void MostrarEstadisticas(double prom, double mayor, double menor, int aprobados, int total)
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("        RESUMEN DE ESTADÍSTICAS         ");
        Console.WriteLine("========================================");
        Console.WriteLine($" Promedio General:  {prom:F2}");
        Console.WriteLine($" Nota más Alta:     {mayor}");
        Console.WriteLine($" Nota más Baja:     {menor}");
        Console.WriteLine($" Total Aprobados:   {aprobados}");
        Console.WriteLine($" Total Desaprobados: {total - aprobados}");
        Console.WriteLine($" Porcentaje Éxito:  {((double)aprobados / total) * 100:F1}%");
        Console.WriteLine("========================================\n");
    }
}