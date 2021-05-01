using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "033.437.160-06";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.titular = gabriela;
            conta.titular.nome = "gabriel costa";
            conta.titular.profissao = "desenvolvedora c#";
            conta.titular.cpf = "033.437.160-06";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            if (conta.titular == null)
            {
                Console.WriteLine("Ops! A referência do campo titular é NULL");
            }

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);
            Console.ReadLine();
        }
    }
}