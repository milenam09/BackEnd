namespace Heranca
{
    public class Carro : Veiculos
    {
        public int QtdPortas;

        public void ExibirInfo()
        {
            Console.Writine($"Marca: {Marca}");
            Console.Writine($"Modelo: {Modelo}");
            Console.Writine($"Ano: {Ano}");
            Console.Writine($"Quantas portas: {QtdPortas}");
        }
    }
}