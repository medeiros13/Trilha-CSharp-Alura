using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 12, 13);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

            string mensagem = $"Vencimento em {GetIntervaloDeTempoLegivel(diferenca)}";

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 30)
            {
                int numeroMeses = timeSpan.Days / 30;
                if (numeroMeses == 1)
                {
                    return $"{numeroMeses} mês";
                }
                return $"{numeroMeses} meses";
            }
            else if (timeSpan.Days > 7)
            {
                int numeroSemanas = timeSpan.Days / 7;
                if (numeroSemanas == 1)
                {
                    return $"{numeroSemanas} semana";
                }
                return $"{numeroSemanas} semanas";
            }
            return $"{timeSpan.Days} dias";
        }
    }
}
