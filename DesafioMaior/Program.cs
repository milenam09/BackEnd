// See https://aka.ms/new-console-template for more information

int numeroEscolhido1;
int numeroEscolhido2;

Console.WriteLine("Digite seu primeiro numero");
numeroEscolhido1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu segundo numero");
numeroEscolhido2 = int.Parse(Console.ReadLine());

if (numeroEscolhido1 > numeroEscolhido2)
    Console.WriteLine("O maior numero é:" + numeroEscolhido1);
else
{
    Console.WriteLine("O maior numero é:" + numeroEscolhido2);
}
