using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;

namespace AposentatoriaPorSexo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int idadeAposentadoriaMasculino = 65;
            const int idadeAposentariaFeminino = 62;
            const string sexoMasculino = "M";
            const string sexoFeminino = "F";

            Console.WriteLine("Informe a sua idade: ");
            var idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo (formato M/F): ");
            var sexo = Console.ReadLine().ToUpper();
            if (sexo != sexoFeminino && sexo != sexoMasculino)
            {
                Console.WriteLine("O sexo informado está em um formato (M/F) inválido.");
                return;
            }

            var idadeEmFaseDeAposentadoriaFeminino = sexo == sexoFeminino && idade >= idadeAposentariaFeminino;
            var idadeEmFaseDeAposentadoriaMasculino = sexo == sexoMasculino && idade >= idadeAposentadoriaMasculino;
            if (idadeEmFaseDeAposentadoriaFeminino || idadeEmFaseDeAposentadoriaMasculino)
            {
                Console.WriteLine("Usuário está em idade de aposentadoria!");
            }
            else
            {
                Console.WriteLine("Lamento! Usuário não está em idade de aposentadoria.");
            }
        }
    }
}
