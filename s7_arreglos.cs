public class s7_arreglos
{
    public static void Main(String[] args)
    {
        int[] notas = new int [5]; // Creacion de un arreglo de 5 posiciones
        notas [0] = 15;
        notas [1] = 18;
        notas [2] = 12;
        notas [3] = 20;
        notas [4] = 11;

        Console.WriteLine("===== Reporte De Notas =====");
        Console.WriteLine("Las notas son: ");
        ImprimirArray(notas);
    }

    static void ImprimirArray(int [] arreglo)
    {
        if(arreglo.Length == 0)
        {
            Console.WriteLine("No hay valores en el arreglo");
        }
        else
        {
            //For Var Control; condicion: actualizacion
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Nota " + (i+1) + ": " + notas[i]);
            }
        }   
    }
}