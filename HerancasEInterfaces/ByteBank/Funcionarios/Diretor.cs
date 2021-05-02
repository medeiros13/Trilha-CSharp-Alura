using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("criando DIRETOR");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15; //Aumenta 15%
        }
        //O uso da palavra "override" significa que o método está sobrescrevendo o método da sua classe pai
        //ou seja, o GetBonificacao do Diretor, está sobrescrevendo o GetBonificacao do Funcionario
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
