using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //A regra para usar herança e implementar interfaces segue uma ordem: primeiro se diz qual a classe que estamos herdando, depois, com uma "," tudo que vier após essa "," são interfaces implementadas (pode implementar mais de uma interface, mas só pode usar herança 1 vez)
    //O nome de interfaces por convenção sempre deve começar com um "I"
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
