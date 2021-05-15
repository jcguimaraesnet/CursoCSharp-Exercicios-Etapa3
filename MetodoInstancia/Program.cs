using System;

namespace MetodoInstancia
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numeroAleatorio = random.Next(1, 7);
            Console.WriteLine($"Número aleatório: {numeroAleatorio}");
        }
    }
}
