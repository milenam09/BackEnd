// See https://aka.ms/new-console-template for more information
int opcao = -1;

do
{

    Console.WriteLine($"------------------------------");
    Console.WriteLine($"|         Bem Vindo          |");
    Console.WriteLine($"|            ao              |");
    Console.WriteLine($"|      Jãopones Food         |");
    Console.WriteLine($"------------------------------");
    Console.WriteLine($"");
    Console.WriteLine($"Escolha uma opção no menu abaixo:");
    Console.WriteLine($"");
    Console.WriteLine($" 1)HotHoll-------------------R$30,00 (10 Unidades)");
    Console.WriteLine($" 2)Temaki---------------------R$25,00");
    Console.WriteLine($" 3)Sashimi--------------------R$20,00");
    Console.WriteLine($" 4)Guioza---------------------R$35,00 (10 Unidades)");
    Console.WriteLine($" 5)Shimeji--------------------R$15,00");
    Console.WriteLine($" 0)Sair");
    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <Enter> para continuar...");
            Console.ReadLine();
            break;
        case 1:
            HotHoll();
            break;
        case 2:
            Temaki();
            break;
        case 3:
            Sashimi();
            break;
        case 4:
            Guioza();
            break;
        case 5:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

} while (opcao != 0);


void HotHoll()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Hot Holl com carinho!");
}

void Temaki()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Temaki com carinho!");
}

void Sashimi()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Sashimi com carinho!");
}

void Guioza()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Guioza com carinho!");
}

void Shimeji()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Shimeji com carinho!");
}