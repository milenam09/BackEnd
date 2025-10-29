// See https://aka.ms/new-console-template for more information
int opcao = -1;
int totalClientes = 0;
string[] nomes = new string[10];
DateOnly[] idades = new DateOnly[10];
double[] documento = new double[10];
float[] saldos = new float[10];

do
{
    Console.Clear();
    Console.WriteLine($"=========================================");
    Console.WriteLine($"         SISTEMA BANCARIO SIMPLES        ");
    Console.WriteLine($"=========================================");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opcao:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
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
            ListaClientes();
            break;

        default:
            Console.WriteLine($"Opcao Invalida");
            break;

    }

    Console.WriteLine($"Pessione <Enter> para continuar");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
    Console.Clear();
    Console.WriteLine($"==== Cadastrar Clientes ====");

    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de Vagas Atingido");
        return;
    }

    Console.WriteLine($"Digite o nome do cliente:");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;

    Console.WriteLine($"Digite a data de nascimento do cliente:");
    idades[totalClientes] = DateOnly.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o CPF do cliente:");
    documento[totalClientes] = double.Parse(Console.ReadLine());
    totalClientes++;
    Console.WriteLine($"Cliente Cadastrado Com Sucesso!!!");
}

void Depositar()
{
    Console.Clear();
    Console.WriteLine($"==== Depositar ====");

    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write($"Digite a quantidade que deseja depositar:");
    float qntdDeposito = float.Parse(Console.ReadLine());
    saldos[idCliente] += qntdDeposito;
    Console.WriteLine($"Deposito Feito Com Sucesso!!!");
}

void Sacar()
{
    Console.Clear();
    Console.WriteLine($"==== Sacar ====");
    Console.WriteLine($"");
    
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Digite a quantidade que deseja sacar:");
    float qntdSacar = float.Parse(Console.ReadLine());

    if (qntdSacar <= 0)
    {
        Console.WriteLine($"Valor Invalido");
    }
    else if (qntdSacar > saldos[idCliente])
    {
        Console.WriteLine($"Saldo Insuficiente para Saque!!!");
    }

    else
    {
        saldos[idCliente] -= qntdSacar;
        Console.WriteLine($"Saque Feito Com Sucesso!!!");
    }
}

void Transferir()
{
    Console.Clear();
    Console.WriteLine($"==== Transferir ====");
    Console.WriteLine($"");

    Console.WriteLine($"Conta de Origem:");
    int idOrigem = BuscarCliente();

    if (idOrigem == -1) return;

    Console.WriteLine($"Conta Destinataria:");
    int idDestino = BuscarCliente();

    if (idDestino == -1) return;

    Console.WriteLine($"Valor da Transferencia:");
    float qntdTransferir = float.Parse(Console.ReadLine());

    if (qntdTransferir <= 0)
    {
        Console.WriteLine($"Valor Invalido");
    }
    else if (qntdTransferir > saldos[idOrigem])
    {
        Console.WriteLine($"Saldo Insuficiente para Transferencia!!!");
    }

    else
    {
        saldos[idOrigem] -= qntdTransferir;
        saldos[idDestino] += qntdTransferir;
        Console.WriteLine($"Transferencia Feito Com Sucesso!!!");
    }
}

void ListaClientes()
{
    Console.Clear();
    Console.WriteLine($"==== Lista de Clientes ====");
 

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i + 1}ª Cliente");
        Console.WriteLine($"Nome: {nomes[i]}     Data de Nascimento: {idades[i]}     CPF: {documento[i]}     Saldo: R${saldos[i]}");
        Console.WriteLine();
    }
}

int BuscarCliente()
{
    ListaClientes();

    Console.WriteLine($"Digite o numero do cliente:");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente nao encontrado no nosso sistema");
        return -1;
    }
    return idCliente;
}