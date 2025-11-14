// See https://aka.ms/new-console-template for more information

using Exemplo;

Console.Clear();

// Gato birobinha = new Gato();

// Cachorro Amora = new Cachorro();

// Console.Clear();
// Pessoa Guilherme = new Pessoa();
// Guilherme.nome = "Guilherme Vieira";
// Guilherme.idade = 16;
// Guilherme.Exibir();
// Guilherme.Dormir();
// Guilherme.FazerSom();
// Guilherme.Mover();

Console.WriteLine($"Conta Corrente:");
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: {cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R$ {cc.Saldo}");

Console.WriteLine();

Console.WriteLine($"Conta Poupança:");
ContaCorrente cp = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: {cp.Saldo}");
cp.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cp.Saldo}");
cp.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R$ {cp.Saldo}");