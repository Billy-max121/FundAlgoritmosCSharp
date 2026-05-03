
public class s6_alcance_var_global
{
    public static int cont = 0; // Global
    public static void Main(String[] args)
    {


        Console.WriteLine("Valor de cont: " + cont);
        Contar();
        Contar();
        Contar();
        Console.WriteLine("Valor de cont: " + cont);
    }
    static void Contar()
    {
        cont++;
        Console.WriteLine("Valor de cont desde la funcion: " + cont);

    }   
}