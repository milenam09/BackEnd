// See https://aka.ms/new-console-template for more information

int n1, n2, n3, n4;
int media;

Console.WriteLine("Digite a primeira nota do aluno");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota do aluno");
n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota do aluno");
n4 = int.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

if (media >= 7.00)
    Console.WriteLine("Aprovado: " + media);

else if (media >= 5.00 && media < 7.00)
{
    Console.WriteLine("Recuperação: " + media);
}

else
{
    Console.WriteLine("Reprovado: " + media);
}


