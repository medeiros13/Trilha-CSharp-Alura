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

            Funcionario carlos = new Funcionario("033.437.160-06", 2000);

            carlos.Nome = "Carlos";

            carlos.AumentarSalario();

            Console.WriteLine($"Novo salário do Carlos: {carlos.Salario}");

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            //Funcionario pedro = new Diretor(); //Isso é válido, pois o Diretor é um funcionário, isso é chamado de Polimorfismo

            Diretor roberta = new Diretor("454.658.148-03");
            roberta.Nome = "Roberta";

            //Aqui ele vai printar 2 funcionários, pois quando se cria um objeto de uma classe derivada (diretor é derivado de funcionário), o compilador chama o construtor da classe base, para depois chamar o construtor da classe derivada
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta; //Polimorfismo aqui também

            roberta.AumentarSalario();
            Console.WriteLine($"Novo salário de Roberta: {roberta.Salario}");

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
