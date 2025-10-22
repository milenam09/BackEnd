// See https://aka.ms/new-console-template for more information

Console.WriteLine("Quantos numeros voce quer digitar?");
int x = int.Parse(Console.ReadLine());
int n1,n2;
int contador = 1;

while (contador <= x)
{
    Console.WriteLine($"Digite o primeiro numero:");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o segundo numero:");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O numero {n1} e maior que o {n1}");
    }
    else if (n1 > n1)
    {
        Console.WriteLine($"O numero {n2} e maior que o {n1}");
    }

    else
    {
        Console.WriteLine($"{n2} e {n1} sao iguais ");
    }
    contador++;
}
