using System;
using System.Globalization;

namespace TotalDiasDeVida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua data de aniversário (formato: dd/mm/yyyy): ");
            var dataAniversario = Convert.ToDateTime(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));

            var totalDiasDeVida = DateTime.Now - dataAniversario;
            Console.WriteLine($"Total de dias de vida até o hoje: {totalDiasDeVida.TotalDays:N2}");
        }
    }
}
