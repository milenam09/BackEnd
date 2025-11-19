// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;
using Exercicios02;


List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.Write($@"Menu de Opcoes
    1) Cadastrar Fatura
    2) Cadastrar Relatorio
    3) Cadastrar Contrato
    4) Listar Fatura
    5) Listar Relatorio
    6) Listar Contrato
    0) Sair
    Escolha uma opcao:
    ");
    opcao = int.Parse(Console.ReadLine());

   switch (opcao)
   {
        case 1:
        Console.WriteLine($"Cadastrar Fatura em desenvolvimento");
            break;
        case 2:
        Console.WriteLine($"Cadastrar Relatorio em desenvolvimento");
            break;
        case 3:
        Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
            break;
        case 4:
        Console.WriteLine($"Listar Faturas em desenvolvimento");
            break;
        case 5:
        Console.WriteLine($"Listar Relatorio em desenvolvimento");
            break;
        case 6:
        Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;
        case 0:
        Console.WriteLine($"Sair");
            break;
    default:
    Console.WriteLine($"Opcao Invalida!");
        break;
   }

    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();
    
    
} while (opcao != 0);

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente Devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da Empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o Valor");
    float valor = float.Parse (Console.ReadLine());
    
    Console.WriteLine($"Dias de atraso da fatura?");
    int qtdDiasAtraso = int.Parse(Console.ReadLine());

    Console.WriteLine($"Fatura calculada com sucesso!");
    

    Fatura fat = new Fatura(dev, empresa, valor, qtdDiasAtraso);
    documentos.Add(fat);
    
}
void CadastrarRelatorios()
{
    
}
void CadastrarContratos()
{
    
}
void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in documentos)
    {
       if (item is Fatura)
       {
            item.Imprimir();
       } 
    }
    
}
void ListarRelatorios()
{
    
}
void ListarContrato()
{
    
}



































// //FATUTRA
// Fatura fatGui = new Fatura();
// documentos.Add(fatGui);

// //RELATORIO

// Relatorio relGui= new Relatorio();
// documentos.Add(relGui);

// //CONTRATO
// Contrato contGui = new Contrato();
// documentos.Add(contGui);

// // LISTAR OS DADOS DA FATURA

// foreach (var item in documentos)
// { 
//     if (item is Contrato)
//     {
//         item.Imprimir();
//     }
// }


// // LISTAR OS DADOS DA RELATORIO
// foreach (var item  in documentos)
// {
//     if (item is Relatorio)
//     {
//         item.Imprimir();
//     }
// }


// // LISTAR OS DADOS DO CONTRATO 

// Console.WriteLine($"CONTRATOS");

// foreach (var item in documentos)
// {   
//     if (item is Contrato)
//     {
//         item.Imprimir(); 
//     }
// }
