// Registro en la vida real
// Juan perez 1er grado 16
// nombre[0] = "Juan perez"
// grado[0] = "1er Grado"
// nota[0] = 16.00

// Crear un mini sistema de registro de notas
// que nos permita registrar el nombre, grado
// y nota del alumno
int indice = 0; // va a ser compartido
int maximoNumeroRegistros = 5;
String nombresCompletos;
String grado;
double promedioFinal;
int numeroRegistros;

String [] registroNombres = new String [maximoNumeroRegistros];
String [] registroGrados = new String [maximoNumeroRegistros];
double [] registroPromedios = new double[maximoNumeroRegistros];

Console.WriteLine("Ingresa el numero de registros a registrar: ");
numeroRegistros = int.Parse(Console.ReadLine());
while(numeroRegistros > indice)
{
    Console.WriteLine("Registrando nota: " + (indice+1));
    // Capturar los datos del usuario
    Console.WriteLine("Ingrese sus nombres completos: ");
    nombresCompletos = Console.ReadLine();
    Console.WriteLine("Ingrese grado del alumno: ");
    grado = Console.ReadLine();
    Console.WriteLine("Ingrese el promedio del alumno: ");
    promedioFinal = double.Parse(Console.ReadLine());

    // Insertar informacion en registro
    registroNombres[indice] = nombresCompletos;
    registroGrados [indice] = grado;
    registroPromedios[indice] = promedioFinal;
    Console.WriteLine("Informacion registrada con exito");
    indice++;
}

for(int i = 0; i < numeroRegistros; i++)
{
    Console.WriteLine("Nombre: " + registroNombres[i] + "       Grado: " + registroGrados[i] + "        Nota: " + registroPromedios[i]);
}
