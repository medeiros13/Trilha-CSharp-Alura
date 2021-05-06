using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Catch no método main");
            }
            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
        private static void CarregarContas()
        {

            //Using é uma outra forma parecida com a ideia do bloco try/finally
            //Para se usar o using em classes criadas por você, essa classe obrigatóriamente precisa implementar a interface IDisposable
            //Ele não trata exceções
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("text.txt"))
            {
                leitor.LerProximaLinha();
            }

            // -----------------------------------------------------
            //LeitorDeArquivos leitor = null;
            ////O bloco try deve obrigatoriamente ou ter um try, ou ter um catch, ou ter os 2
            ////Usamos o catch quando precisamos tratar uma exceção;
            ////Usamos o finally quando precisamos executar algo independente se a aplicação der erro ou não
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                //Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
                //Console.WriteLine(ex.InnerException.Message);
                //Console.WriteLine(ex.InnerException.StackTrace);
            }
        }
    }
}
