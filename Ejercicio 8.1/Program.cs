//Solicite al usuario el ingreso de una frase y presente un mensaje indicando si alguna contiene la palabra “fin”.
string frase = "";
Console.WriteLine("Por favor, ingrese una frase");
frase = Console.ReadLine();

string[] valores = frase.Split(" ");

for (int i = 0; i < valores.Length; i++)
    if (valores[i] == "fin")
    {
        Console.WriteLine("Existe fin");
    }

Console.ReadKey();