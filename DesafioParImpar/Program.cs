// See https://aka.ms/new-console-template for more information

int qtdNumeros = int.Parse(Console.ReadLine());
string pares = "Pares: ";
string impares = "Impares: ";

for (int i = 1; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i}ª numero: ?");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        pares += numeroDigitado.ToString() + ", ";
    }
    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}

Console.Clear();
Console.WriteLine("RESULTADO");
Console.WriteLine();
Console.WriteLine("pares");
Console.WriteLine("impares");


 