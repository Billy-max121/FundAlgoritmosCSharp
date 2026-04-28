
int cont = 100;
cont++;
Contar ();
Contar ();
Contar ();
Console.WriteLine("Var Main: " + cont);

void Contar()
{
    int cont = 0;
    cont++;
    Console.WriteLine("Var Func: " + cont);
}