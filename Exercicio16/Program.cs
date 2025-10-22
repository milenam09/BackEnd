// See https://aka.ms/new-console-template for more information
string cargo;
double salario, salarioNovo;


Console.WriteLine($"Bem Vindo a DevConnect, digite o cargo do funcionario producao,administrativo ou diretoria");
cargo = (Console.ReadLine());


Console.WriteLine("Digite o salario do funcionario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065);
}

else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075);
}

else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12);
}

else
{
    Console.WriteLine($"cargo invalido");
    return;
}

Console.WriteLine($"o novo salario reajustado e {salarioNovo} ");