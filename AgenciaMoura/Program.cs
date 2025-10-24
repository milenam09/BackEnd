// See https://aka.ms/new-console-template for more information
string[] nomes = new string[10];
int opcao;
int totalClientes = 0;
float[] saldos = new float[10];

do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine($" 1. Cadastrar Clientes ");
    Console.WriteLine($" 2. Depositar");
    Console.WriteLine($" 3. Sacar");
    Console.WriteLine($" 4. Transferir");
    Console.WriteLine($" 5. Listar Clientes");
    Console.WriteLine($" 0. Sair");
    Console.WriteLine($" Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarClientes();
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
    Console.WriteLine($"=== Cadastro do Cliente ===");

    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de cadastros atingido");
        return;
    }

    Console.WriteLine($"Nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0.50f;
    totalClientes++;
    Console.WriteLine("Cliente Cadastrado com sucesso!");
}

void Depositar()
{
    Console.WriteLine($"Função Depositar em Desonvolvimento");
}
void Sacar()
{
    Console.WriteLine($"Função Sacar em Desonvolvimento");
}

void Transferir()
{
    Console.WriteLine($"Função Transferir em Desonvolvimento");
}

void ListarClientes()
{
    Console.WriteLine($"Função Listar Clientes em Desonvolvimento");
}
