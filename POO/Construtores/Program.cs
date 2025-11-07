// See https://aka.ms/new-console-template for more information

using Construtores;

Console.Clear();

// Pessoa Guilherme = new Pessoa("Guilherme", 16, "Gosto da minha namorada");
// Pessoa Milena = new Pessoa("Milena Mares", 17);

// Milena.Nome = "Milena Mares";
// Milena.Idade = 17;

// Guilherme.ExibirDados();
// Milena.ExibirDados();

// Carro HondaFit = new Carro("Hondafit", "Ret", 2012);

// HondaFit.ExibirDados();


// Aluno Guilherme = new Aluno("Guilherme", 10);
// Aluno Milena = new Aluno("Milena", 10);

//  Guilherme.ExibirDados();
//  Milena.ExibirDados();

Console.WriteLine($"===================");
Console.WriteLine($"|     Produtos    |");
Console.WriteLine($"===================");
Console.WriteLine();

Produto Base = new Produto("Ruby Rose", 39.99f, 190);
Produto Blush = new Produto("Ruby Rose", 20.99f, 200);
Produto Serum = new Produto("Creamy", 78.99f, 300);

Base.ExibirDados();
Blush.ExibirDados();
Serum.ExibirDados();