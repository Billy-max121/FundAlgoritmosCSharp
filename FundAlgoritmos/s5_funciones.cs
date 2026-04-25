// Declarar variables
double radio, resultado, _base, altura = 0;
// Obtener los valores de entrada del usuario
Console.WriteLine("Ingrese el radio del circulo: ");
radio = double.Parse(Console.ReadLine());
// Realizar el proceso (llamar a la funcion)
resultado = AreaCirculo(radio);
// Mostrar el valor de lo procesado
Console.WriteLine("El valor del area del circulo es: " + resultado);

// Calcular el area del triangulo
Console.WriteLine("Ingrese la base del triangulo: ");
_base = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo: ");
altura = double.Parse(Console.ReadLine());
// Invocar (llamar a la funcion)
resultado = AreaTriangulo(_base, altura);
// Mostrar el resultado al usuario
Console.WriteLine("El area del triangulo es: " + resultado);

// Declarar funcion AreaCirculo
// Tipo nombre_func(tipo dato parametro variable parametro)
double AreaCirculo(double radio)
{
    // Declarar variables
    double resultado = 0;
    // Proceso    
    resultado = Math.PI * Math.Pow(radio, 2);
    // retorna el resultado
    return resultado; // No olvidar
}

//Declarar la funcion AreaTriangulo
double AreaTriangulo(double _base, double altura)
{
    double resultado = 0;
    // Proceso
    resultado = (_base * altura) / 2;
    // retornar el valor
    return resultado;

}