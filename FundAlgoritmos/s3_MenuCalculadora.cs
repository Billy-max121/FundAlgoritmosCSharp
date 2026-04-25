Console.WriteLine("#### Menu Calculadora ####");
Console.WriteLine("Menu Operaciones");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicacion");
Console.WriteLine("4. Division");
Console.WriteLine("");
double resultado = 0.0;
Console.WriteLine("Ingresa primer numero: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa segundo numero: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa opcion: ");
int opc = int.Parse(Console.ReadLine());
switch(opc)
{
    case 1:
        resultado = a + b;
        break;
    case 2:
        resultado = a - b;
        break;
    case 3:
        resultado = a * b;
        break;
    case 4:
        resultado = a / b;
        break;
    default:
        Console.Write("Opcion no existe");
        break;
}
Console.WriteLine("Resultado: " + resultado);