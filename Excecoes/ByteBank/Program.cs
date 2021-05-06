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

                conta2.Transferir(-10, conta);

                conta.Depositar(50);

                Console.WriteLine(conta.Saldo);

                conta.Sacar(500);

                //Metodo();
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Argumento com o problema: {e.ParamName}.");
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo DivideByZeroException.");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Aconteceu um erro.");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
