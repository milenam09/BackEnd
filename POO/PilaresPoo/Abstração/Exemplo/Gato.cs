namespace Exemplo
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Miau miau miau");
            
        }
        public override void Mover()
        {
            Console.WriteLine($"Ploc Ploc Ploc");
            
        }

    }
}