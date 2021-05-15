using System;
using System.Threading;

namespace CaraOuCoroa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogando moeda... Aguarde alguns segundos...");
            Thread.Sleep(2000);

            var random = new Random();
            var numeroAleatorio = random.Next(1, 3);

            Console.Write("Resultado da jogada: ");
            if (numeroAleatorio == 1)
                Console.WriteLine("Cara!");
            else
                Console.WriteLine("Coroa!");
        }
    }
}
