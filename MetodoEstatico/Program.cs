using System;

namespace MetodoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um primeiro número inteiro: ");
            var primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um segundo número inteiro: ");
            var segundoNumero = int.Parse(Console.ReadLine());

            var numeroMaior = Math.Max(primeiroNumero, segundoNumero);
            Console.WriteLine($"O número maior é: {numeroMaior}");
        }
    }
}
