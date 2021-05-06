using System;
using System.Collections.Generic;
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

                ContaCorrente conta = new ContaCorrente(514, 5435);

                ContaCorrente conta2 = new ContaCorrente(485, 456478);

                conta2.Transferir(10000, conta);

                conta.Depositar(50);

                Console.WriteLine(conta.Saldo);

                conta.Sacar(500);

                //Metodo();
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.ValorSaque);

                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argumento com o problema: {ex.ParamName}.");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo DivideByZeroException.");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Aconteceu um erro.");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
