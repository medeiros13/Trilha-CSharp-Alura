using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
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

        public virtual void AumentarSalario()
        {
            Salario *= 1.1; //Aumenta 10%
        }

        //Cria-se um método ao invés de uma propriedade para retornar um valor, pois o uso de propriedades geralmente é utilizado quando se tem um acesso imediato ao valor, sem precisar executar algum cálculo, ou alguma ação que demande um custo de processamento
        //O uso da palavra "virtual" significa que esse método pode ser sobrescrito nas suas classes filhas
        //Ou seja, o método GetBonificacao do Funcionario pode ser sobrescrito pelo Diretor, Designer, Coordenador, e outros diversos tipos de Funcionarios
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
