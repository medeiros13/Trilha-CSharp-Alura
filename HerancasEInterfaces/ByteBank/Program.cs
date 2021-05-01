using ByteBank.Funcionarios;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "033.437.160-06";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Funcionario pedro = new Diretor(); //Isso é válido, pois o Diretor é um funcionário, isso é chamado de Polimorfismo

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-03";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta; //Polimorfismo aqui também

            Console.WriteLine($"Bonificação de uma referência de Diretor: {roberta.GetBonificacao()}");
            Console.WriteLine($"Bonificação de uma referência de Funcionario: {robertaTeste.GetBonificacao()}");

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine($"Total de Bonificações: {gerenciador.GetTotalBonificacao()}");

            Console.ReadLine();
        }
    }
}
