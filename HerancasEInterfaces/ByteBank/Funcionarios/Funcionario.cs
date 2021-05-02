using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario //A classe é abstrata, isso significa que a mesma não deve ser instanciada diretamente. Pois todo Designer, Diretor, Auxiliar e GerenteDeConta são Funcionários, logo devem ser instanciados diretamente pelo seu tipo
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            Console.WriteLine("Criando FUNCIONARIO");
            TotalDeFuncionarios++;
        }

        //Os métodos foram alterados para abstratos, para que quando formos criar uma nova classe que herde de Funcionário,
        //seja obrigatório sobrescrever esses 2 métodos.
        //métodos abstratos só podem fazer parte classes abstratas. Classes concretas só implementam métodos concretos.
        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
