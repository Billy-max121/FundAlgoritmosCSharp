double nota = 0;
do
{
    Console.WriteLine("Ingrese nota entre 0 y 20: ");
    nota = double.Parse(Console.ReadLine());
} while(nota > 20 || nota < 0);