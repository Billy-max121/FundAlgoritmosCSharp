
int cont = 100; // variable local del main
cont++;
Contar ();
Contar ();
Contar ();
Console.WriteLine("Var Main: " + cont);

void Contar()
{
    int cont = 0; // variable local de la funcion
    cont++; // suma 1 a la variable local
    Console.WriteLine("Var Func: " + cont);
}