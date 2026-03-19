//estructuras

string[] frutas = { "Manzana", "Banana", "Cereza" };

/*
Console.WriteLine(frutas[0]);
Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[2]);
*/

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(frutas[i]);
}


int[] edades = { 25, 5, 10, 2 };

int edadAcumulada = 0;
for (int i = 0; i < edades.Length; i++)
{
    edadAcumulada = edadAcumulada + edades[i];
}

edades[2] = 125;

Console.WriteLine(edades[2]);

for (int i = 0; i < edades.Length; i++)
{
    Console.WriteLine(edades[i]);
}

List<string> nombres = new List<string>();
nombres.Add("Ana");
nombres.Add("Luis");
nombres.Add("Carlos");

Console.WriteLine(nombres[2]);

if (nombres.Contains("Carlos"))
{
    nombres.Remove("Carlos");
}



//nombres.Clear();

List<string> cantantes = new List<string>();
cantantes.Add("Maddona");
cantantes.Add("Cerati");

List<string> personas = new List<string>();
personas.AddRange(cantantes);
personas.AddRange(nombres);


Console.WriteLine("FIn listas");


foreach(string nombre in personas)
{
    Console.WriteLine($"persona: {nombre}");
}

int elementosEnLista = personas.Capacity;
Console.WriteLine(elementosEnLista);
personas.Clear();

Dictionary<string, int> edadesPersonas = new Dictionary<string, int>();

edadesPersonas["Ana"] = 30;
edadesPersonas["Luis"] = 25;
edadesPersonas["Carlos"] = 28;
edadesPersonas["Ana"] = 31;

edadesPersonas.Add("Ana Cabera", 58);
//edadesPersonas.Add("Ana Cabera", 58);

Dictionary<string, List<double>> notasEstudiantes = new Dictionary<string, List<double>>();
notasEstudiantes["Ana"] = new List<double> { 8.5, 9.0, 6.5 };
notasEstudiantes["Luis"] = new List<double> { 4.7, 6.0, 9.5 };

List<double> notasCarlos = new List<double>();
notasCarlos.Add(5);
notasCarlos.Add(5.2);
notasCarlos.Add(7.2);

double promedioCarlos = notasCarlos.Average();

notasEstudiantes["Carlos"] = notasCarlos;

foreach (var estudiante in notasEstudiantes)
{
    double promedio = estudiante.Value.Average();
    Console.WriteLine($"persona: {estudiante.Key}, promedio: {promedio}");
}



// ejercicios
// Arrays
 // Escribe código para sumar todos los elementos e imprimir el resultado
 // Encuentra y muestra el mayor elemento de un array de enteros
 // programa que pida 3 numeros por consola, guardarlos en un array de enteros y finalmente recorrer el array y sumarlos mostrando el resultado por pantalla

int[] numeros = { 5, 10, 15, 20 };

int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

Console.WriteLine($"La suma es: {suma}");


int[] numeros = { 5, 10, 15, 20 };

int mayor = numeros[0];

for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
}

Console.WriteLine($"El mayor es: {mayor}");

int[] numeros = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Ingrese número {i + 1}:");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

Console.WriteLine($"La suma total es: {suma}");

//listas
// Crea una lista con los números del 1 al 10.
// Elimina los números pares de la lista.
// Imprime la lista resultante.

List<int> lista = new List<int>();

for (int i = 1; i <= 10; i++)
{
    lista.Add(i);
}

// eliminar pares
lista.RemoveAll(x => x % 2 == 0);

// imprimir
foreach (int num in lista)
{
    Console.WriteLine(num);
}

// Crea un diccionario donde la clave sea el nombre de la persona
// y el valor sea su número de teléfono (como string).
// Agrega 3 contactos y muestra la agenda completa.

Dictionary<string, string> agenda = new Dictionary<string, string>();

agenda["Ana"] = "999111222";
agenda["Luis"] = "988777666";
agenda["Carlos"] = "977555444";

foreach (var contacto in agenda)
{
    Console.WriteLine($"{contacto.Key}: {contacto.Value}");
}

// Usa el diccionario anterior.
// Pide al usuario que escriba un nombre.
// Si el nombre existe, muestra el teléfono.
// Si no, indica que no está en la agenda.

Console.WriteLine("Ingrese nombre:");
string nombreBuscar = Console.ReadLine();

if (agenda.ContainsKey(nombreBuscar))
{
    Console.WriteLine($"Teléfono: {agenda[nombreBuscar]}");
}
else
{
    Console.WriteLine("No está en la agenda");
}
