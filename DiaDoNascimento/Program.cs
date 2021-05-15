using System;

namespace DiaDoNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaDataNascimento = new DateTime(2000, 7, 30);
            Console.WriteLine($"O dia do meu nascimento é: {minhaDataNascimento:dddd}");
        }
    }
}
