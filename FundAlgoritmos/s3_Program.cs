// Programa que permite calcular el IMC
// Declarar las variables
double peso = 0;
double altura = 0;
double IMC = 0;
//Obtener datos del usuario
Console.WriteLine("Ingrese su peso (KG): ");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su altura (M): ");
altura = double.Parse(Console.ReadLine());
//Calcular el IMC
//Opcion 1 - IMC = peso / (altura*altura);
IMC = peso / Math.Pow(altura, 2);
//Mostrar la informacion al usuario
Console.WriteLine("Su IMC es: " + IMC);