Console.WriteLine("Ingrese nota: ");
double nota = double.Parse(Console.ReadLine());
if (nota <= 20 && nota >= 0){
    if (nota >= 17){
        Console.WriteLine("Excelente");
    }else if (nota >= 11){
        Console.WriteLine("Aprobado");
    }else{
        Console.WriteLine("Desaprobado");
    }
}else{
    Console.WriteLine("Nota invalida");
}