using System;

class Program {
    static void Main() {
        Console.Write("Ingrese tipo de cliente (1=VIP, 2=Regular): ");
        int tipo = int.Parse(Console.ReadLine());
        Console.Write("Ingrese monto de compra: ");
        double monto = double.Parse(Console.ReadLine());

        double descuento = 0;

        if (tipo == 1) { // Proceso del VIP
            descuento = (monto > 100) ? 0.20 : 0.10;
        } else if (tipo == 2) { // Proceso del Regular
            descuento = (monto > 200) ? 0.10 : 0.05;
        }

        double montoDescuento = monto * descuento;
        double total = monto - montoDescuento;

        Console.WriteLine($"Descuento aplicado: S/{montoDescuento:F2}");
        Console.WriteLine($"Monto final a pagar: S/{total:F2}");
    }
}