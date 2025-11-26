// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using ClassesEstaticas;

// Console.WriteLine($"Numero de PI: {CalculosMatematicos.PI}");

// Console.WriteLine($"Soma de 5 e 10: {CalculosMatematicos.Somar(5,10)}");

// Console.WriteLine($"Soma de 50,2 e 10,7: {CalculosMatematicos.Somar(50.2f , 10.7f)}");

// Console.WriteLine($"Divisao de 5 e 0 é : {CalculosMatematicos.Dividir(5,0)}");

// Console.WriteLine($"Bem Vindo a Calculadora ");
// Console.ReadLine();


// Console.WriteLine($"Digite o primeiro numero:");
// float n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo numero:");
// float n2 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Resultados:");
// Console.WriteLine($"Soma: {CalculosMatematicos.Somar(n1,n2)}");
// Console.WriteLine($"Subtrair: {CalculosMatematicos.Subtrair(n1,n2)}");
// Console.WriteLine($"Multiplicar: {CalculosMatematicos.Multiplicar(n1,n2)}");
// Console.WriteLine($"Dividir: {CalculosMatematicos.Dividir(n1,n2)}");

Console.Clear();

Console.WriteLine($"Digite o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero:");
float n2 = float.Parse(Console.ReadLine());

float maior = Math.Max(n1 , n2);
float menor = Math.Min(n1, n2);

Console.WriteLine($"=======RESULTADOS=======");
Console.WriteLine($"Numero maior eh{maior}");
Console.WriteLine($"Numero menor eh{menor}");






