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

            //var cara = numeroAleatorio == 1;
            //var coroa = numeroAleatorio == 2;
            //if (cara)
            //    Console.WriteLine("Cara!");
            //else if (coroa)
            //    Console.WriteLine("Coroa!");

            var moeda = (numeroAleatorio == 1) ? "Cara" : "Coroa";
            Console.WriteLine($"{moeda}!");
        }
    }
}
