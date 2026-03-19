


//2) programa que busque en la cadena "esto es una cadena de prueba porque estoy empezando a programar en Csharp" las palbras prueba y programar
// si lo encuentra que emprima por pantalla "encontrado"

string texto = "esto es una cadena de prueba porque estoy empezando a programar en Csharp";

if (texto.Contains("prueba") && texto.Contains("programar"))
{
    Console.WriteLine("encontrado");
}
