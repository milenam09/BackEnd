namespace Exemplo
{
    public class Cachorro : Animal
    {
         public override void FazerSom()
        {
            Console.WriteLine($"Au Au Au");
            
        }
        public override void Mover()
        {
            Console.WriteLine($"Tec Tec Tec");
            
        }


    }
}