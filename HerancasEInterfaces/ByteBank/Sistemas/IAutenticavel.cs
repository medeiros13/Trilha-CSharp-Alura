using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    //Interfaces são contratos, é uma forma de dizer que, a classe que implementar essa interface, obrigatóriamente precisa ter um método bool chamado Autenticar que recebe como parâmetro uma string senha
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
