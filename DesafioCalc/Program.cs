// See https://aka.ms/new-console-template for more information

int numeroEscolhido1;
int numeroEscolhido2;
int total;

Console.WriteLine("Digite o primeiro numero");
numeroEscolhido1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numeroEscolhido2 = int.Parse(Console.ReadLine());

total = numeroEscolhido1 + numeroEscolhido2;

Console.WriteLine("Resultado:" + total);

