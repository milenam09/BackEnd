// See https://aka.ms/new-console-template for more information

string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
double investimentos;

Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é sua idade?");
idade = int.Parse(Console.ReadLine());//converte o texto em int antes de jogar navariavel

Console.WriteLine("Qual é o saldo bancario?");
saldoBancario = float.Parse(Console.ReadLine());//converte o texto digitando no console

Console.WriteLine("Qual é o valor do seu investimento?");
investimentos = double.Parse(Console.ReadLine());//converte o texto digitando no console



Console.Clear();
Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"saldo Bancario: {saldoBancario}" );
Console.WriteLine($"investimentos esse ano: {investimentos}");

