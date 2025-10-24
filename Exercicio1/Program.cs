// See https://aka.ms/new-console-template for more information

double salarioRecebido, totalGasto;

Console.WriteLine("Informe o Salario: ");
salarioRecebido = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o gasto do mes: ");
totalGasto = double.Parse(Console.ReadLine());

if (salarioRecebido < totalGasto)
{
    Console.WriteLine($"Orçamento estourado!");
}
else
{
    Console.WriteLine($"Gastos dentro do Orçamento!");
}