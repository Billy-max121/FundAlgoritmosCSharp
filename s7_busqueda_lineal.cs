int [] valores = [84, 12, 57, 93, 2, 45, 68, 19, 71, 33, 5, 
                88, 14, 62, 27, 99, 41, 7, 50, 76, 18, 91, 
                24, 66, 3, 54, 82, 39, 11, 73, 48, 8, 95, 21, 
                60, 36, 1, 79, 44, 15, 87, 52, 6, 92, 30, 64, 
                23, 77, 49, 10];

// Mostrar el array al usuario
Console.WriteLine("Valores Almacenados1");
for(int i=0; i < valores.Length; i++)
{
    Console.Write(valores[i] + ", ");
}
Console.WriteLine("\nIngrese valor a buscar: ");
int valorBuscar = int.Parse(Console.ReadLine());

// Busqueda lineal
int pos = -1;
for(int i=0; i < valores.Length; i++)
{
    if(valores[i] == valorBuscar)
    {
        pos = i;
        break;
    }
}

if(pos == -1)
{
    Console.WriteLine("No hallado");
}
else
{
    Console.WriteLine("Valor encontrado en pos: " + pos);
}