// See https://aka.ms/new-console-template for more information
using Encapsulamento;

// ContaBancaria contaGui = new ContaBancaria();
// ContaBancaria contaMi = new ContaBancaria(1500);

// contaGui.Saldo = -100;
// contaGui.Depositar(20);

// contaGui.Sacar(-200);

// Console.WriteLine($"Saldo Atual: {contaGui.Saldo}");


using Encapsulamento;


class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro();

        meuCarro.DefinirMarca("Lamborghini");
        meuCarro.DefinirModelo("Urus");

        meuCarro.Acelerar(77);
        meuCarro.Acelerar(77);
        meuCarro.Frear(33);
        meuCarro.Frear(21); 

        Console.WriteLine("Marca: " + meuCarro.ObterMarca());
        Console.WriteLine("Modelo: " + meuCarro.ObterModelo());
        Console.WriteLine("Velocidade Atual: " + meuCarro.ObterVelocidade() + " km/h");
        }
    }
