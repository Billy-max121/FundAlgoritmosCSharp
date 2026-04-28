public class s6_alcance_var
{
    static int x = 10;
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Valor inicial x: " + x);
        AgregarValorA();
        AgregarValorB();
        AgregarValorC();
        Console.WriteLine("Valor final x: " + x);
    }

    static void AgregarValorA()
    {
        x = x + 1;
    }

    static void AgregarValorB()
    {
        x = x + 1;
    }

    static void AgregarValorC()
    {
        x = x + 1;
    }
}