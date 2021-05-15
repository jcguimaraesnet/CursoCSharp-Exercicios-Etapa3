using System;
using System.Threading;

namespace Jogo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogando dados... Aguarde alguns segundos...");
            Thread.Sleep(2000);

            var random = new Random();
            var jogada1 = random.Next(1, 7);
            var jogada2 = random.Next(1, 7);
            var jogada3 = random.Next(1, 7);

            Console.WriteLine($"Resultado da primeira jogada: {jogada1}");
            Console.WriteLine($"Resultado da segunda jogada: {jogada2}");
            Console.WriteLine($"Resultado da terceira jogada: {jogada3}");

            var somaJogadas = jogada1 + jogada2 + jogada3;
            Console.WriteLine($"Soma das jogadas: {somaJogadas}");

            Console.Write("Resultado final: ");
            if (somaJogadas > 12)
                Console.WriteLine("Vitória!");
            else
                Console.WriteLine("Derrota!");
        }
    }
}
