namespace Construtores
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro(string n, int i)
        {
            Marca = n;
            Modelo = n;
            Ano = i;
        }

         public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo} e Ano: {Ano}");
        }
    }
}