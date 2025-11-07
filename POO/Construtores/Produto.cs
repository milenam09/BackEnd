namespace Construtores
{
    public class Produto
    {
        public string Nome;

        public float Preço;

        public int Estoque;

        public Produto(string N, float P, int i)
        {
            Nome = N;
            Preço = P;
            Estoque = i;

        }
        
          public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Preço: {Preço} e Estoque: {Estoque}");
        }  
    }
}