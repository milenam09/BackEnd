// See https://aka.ms/new-console-template for more information
string[] nomes = new string[4];

nomes[0] = "Milena";
nomes [1] = "Guilherme";
nomes[2] = "Adriana";

Console.WriteLine($"Tamanho do Array: {nomes.Length}");


for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"   {i + 1}o Nome: {nomes[i]}");
}