// See https://aka.ms/new-console-template for more information

//e=MC^2

using System.Reflection.Metadata;
/*
Console.WriteLine(Math.Pow(3, 2));

int m = 5;
int c = 300000;
double resultado = m * Math.Pow(c, 2);

Console.WriteLine($"energia necesaria: {resultado} jules");

m = 8;
resultado = m * Math.Pow(c, 2);
Console.WriteLine($"energia necesaria: {resultado} jules");
*/

double resultado = CalcularEnergia(5);
Console.WriteLine(resultado);
/*
Console.WriteLine(CalcularEnergia(1));
Console.WriteLine(CalcularEnergia(8));
Console.WriteLine(CalcularEnergia(6));


CalcularEnergiaYMostrar(6);
CalcularEnergiaYMostrar(60);
CalcularEnergiaYMostrar(16);
*/

int masa = IngresarMasa();
double energia = CalcularEnergia(masa);
Console.WriteLine(energia);

List<string> nombres = IniciaNombre();

static double CalcularEnergia(int m)
{
    int c = 300000;
    double resultado = m * Math.Pow(c, 2) + 12;
    return resultado;
} 

static void CalcularEnergiaYMostrar(int m)
{
    int c = 300000;
    double resultado = m * Math.Pow(c, 2) + 12;
    Console.WriteLine($"energia necesaria: {resultado} jules");
}

static int IngresarMasa()
{
    Console.WriteLine("Ingrese la masa dle objeto");
    string masaString = Console.ReadLine()!;
    int masa = 0;
    if (!int.TryParse(masaString, out masa))
    {
        Console.WriteLine("La masa no es correcta");
    }
    return masa;
}

static List<string> IniciaNombre()
{
    List<string> nombres = new List<string>();
    nombres.Add("Juan");
    nombres.Add("Mario");
    nombres.Add("Pepe");

    return nombres;
}



// ejercicios
// funcion que calcule los impuestos de un importe y que retorne el importe + el impuesto

static double CalcularTotalConImpuesto(double importe)
{
    double impuesto = importe * 0.18;
    return importe + impuesto;
}

double total = CalcularTotalConImpuesto(100);
Console.WriteLine($"Total con impuesto: {total}");

// un progema que pida por teclado en un bucle nombres y no acabe ahsta que se ingrese "fin" como nombre
// el programa debera almacenar en una lista de string los nombres que se han ido ingresadno
// luego debera buscar en esa lista y mostrar si existe o no el nombre "Mario". Utilza funciones

static List<string> IngresarNombres()
{
    List<string> nombres = new List<string>();

    while (true)
    {
        Console.WriteLine("Ingrese un nombre (o 'fin' para terminar):");
        string nombre = Console.ReadLine()!;

        if (nombre.ToLower() == "fin")
        {
            break;
        }

        nombres.Add(nombre);
    }

    return nombres;
}

static void BuscarNombre(List<string> nombres, string nombreBuscar)
{
    if (nombres.Contains(nombreBuscar))
    {
        Console.WriteLine($"{nombreBuscar} SÍ está en la lista");
    }
    else
    {
        Console.WriteLine($"{nombreBuscar} NO está en la lista");
    }
}

List<string> listaNombres = IngresarNombres();

BuscarNombre(listaNombres, "Mario");