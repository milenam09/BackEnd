// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

int qtdUsuario = 0;
int contador = 1;

Console.WriteLine("Quantos numeros voce quer digitar?");
qtdUsuario = int.Parse(Console.ReadLine());

while(contador <= qtdUsuario)
{
    Console.WriteLine($"Digite um Numero:");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"Numero digitado eh par: {batata}");
    }
    contador++;
}
