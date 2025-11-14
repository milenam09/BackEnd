// See https://aka.ms/new-console-template for more information

using Heranca;

Console.Clear();
// Carro fusca = new Carro();
// Veiculo generic = new Veiculo();

// Aviao AirBus = new Aviao();
// Moto HarleyDavison = new Moto();
// HarleyDavison.Marca = "HarleyDavison";
// HarleyDavison.Modelo = "Fat Boy";
// HarleyDavison.Ano = 2028;
// HarleyDavison.SomDaMoto();

// AirBus.Marca = "LATAM AirLines";
// AirBus.Modelo = "AirBus 320";
// AirBus.Ano = 2022;
// AirBus.qtdAsas = 2;
// AirBus.Voar();

Gato Persa = new Gato();
Cachorro ViraLata = new Cachorro();

Persa.Nome = "Perola";
Persa.Raca = "Persa";
Persa.Idade = 4;
Persa.ExibirInfo();
Persa.FazerSom();

ViraLata.Nome = "Amora";
ViraLata.Raca = "ViraLata";
ViraLata.Idade = 1;
ViraLata.ExibirInfo();
ViraLata.FazerSom();



//Funcionario

Console.Clear();  
Gerente gerente = new Gerente();
Funcionario GerenteGeneric = new Funcionario();
Console.Clear();
gerente.nome = "Gustavo";
gerente.salarioBase = 2000;
gerente.ExibirSalario();


//Aluno

Console.Clear();
Aluno aluno = new Aluno();
Pessoa AlunoGeneric = new Pessoa();
aluno.nome = "Gustavo";
aluno.idade = 17;
aluno.curso = "Desenvolvimento de Sistemas";
aluno.ExibirInfo();

Console.Clear();
Professor professor = new Professor();
Pessoa ProfessorGeneric = new Pessoa();
professor.nome = "Eduardo";
professor.idade = 43;
professor.disciplina = "Area de TI";
professor.ExibirInfo();

// Banco

Console.Clear();
ContaPoupanca conta = new ContaPoupanca();
Conta contaGeneric = new Conta();
conta.numero = 11915021323f;
conta.saldoaBase = 0;
conta.ExibirInfo();
conta.Exibir();
conta.QntdDeposito = 100;
conta.Depositar();
conta.ExibirInfo2();
conta.Exibir2();
conta.QntdSacar = 50;
conta.Sacar();
conta.ExibirInfo2();
