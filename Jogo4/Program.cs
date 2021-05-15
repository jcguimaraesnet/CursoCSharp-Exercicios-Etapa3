using System;
using System.Threading;

namespace Jogo4
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte pontuacaoPremioViagem = 15;
            const byte pontuacaoPremioCarro = 10;
            const byte pontuacaoPremioLaptop = 5;

            const byte bonusDuasJogadasIguais = 2;
            const byte bonusTresJogadasIguais = 4;
            Console.WriteLine("Jogando dados... Aguarde alguns segundos...");
            Thread.Sleep(2000);

            var random = new Random();
            var jogada1 = random.Next(1, 7);
            var jogada2 = random.Next(1, 7);
            var jogada3 = random.Next(1, 7);
            var temBonusDuasJogadasIguais = (jogada1 == jogada2) || (jogada2 == jogada3) || (jogada1 == jogada3);
            var temBonusTresJogadasIguais = (jogada1 == jogada2) && (jogada2 == jogada3);

            Console.WriteLine($"Resultado da primeira jogada: {jogada1}");
            Console.WriteLine($"Resultado da segunda jogada: {jogada2}");
            Console.WriteLine($"Resultado da terceira jogada: {jogada3}");

            var somaJogadas = jogada1 + jogada2 + jogada3;
            if (temBonusDuasJogadasIguais)
            {
                Console.WriteLine($"Duas jogadas tiveram resultados iguais. Você ganhou um bônus de 2 pontos.");
                somaJogadas += bonusDuasJogadasIguais;
            }
            if (temBonusTresJogadasIguais)
            {
                Console.WriteLine($"Três jogadas tiveram resultados iguais. Você ganhou um bônus de 4 pontos.");
                somaJogadas += bonusTresJogadasIguais;
            }
            Console.WriteLine($"Soma das jogadas: {somaJogadas}");

            if (somaJogadas > pontuacaoPremioViagem)
                Console.Write("Você ganhou uma viagem!");
            else if (somaJogadas > pontuacaoPremioCarro)
                Console.Write("Você ganhou um carro!");
            else if (somaJogadas > pontuacaoPremioLaptop)
                Console.Write("Você ganhou um laptop!");
            else
                Console.Write("Você ganhou um bombom!");
        }
    }
}
