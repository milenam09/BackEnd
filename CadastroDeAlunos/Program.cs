﻿// See https://aka.ms/new-console-template for more information
string[] nomes = new string[3];
int[] idades = new int[3];
int totalAlunos = 0;
int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine($"=== Aplicativo Sala de Aula ===");
    Console.WriteLine($" 1) Listar Alunos ");
    Console.WriteLine($" 2) Cadastrar Alunos");
    Console.WriteLine($" 0) Sair");
    Console.WriteLine($" Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
            break;
        case 1:
            ListarAluno();
            break;
        case 2:
            CadastrarAluno();
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);


void ListarAluno()
{
    Console.WriteLine($"=== Listagem de Alunos ===");
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]}");
    }
}
void CadastrarAluno()
{
    Console.WriteLine($"=== Cadastro de Aluno ===");   

     if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido");
        return;
    }
    
        Console.WriteLine($"Digite o nome de Aluno");
        nomes[totalAlunos] = Console.ReadLine();
        
        Console.WriteLine($"Digite a idade de {nomes[totalAlunos]}");
        idades[totalAlunos] = int.Parse(Console.ReadLine());
        totalAlunos++;
} 
