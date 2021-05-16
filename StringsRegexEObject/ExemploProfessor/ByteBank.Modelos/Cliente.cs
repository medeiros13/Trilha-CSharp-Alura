using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        //O método Equals serve para mostrar se o objeto passado por parâmetro é igual ao objeto dessa classe, para isso, é necessário definir o que faz eles serem iguais
        //No caso desse Equals, os clientes vão ser iguais se tiverem o mesmo CPF, que é o identificador (ID) da classe
        public override bool Equals(object obj)
        {
            //Cliente outroCliente = (Cliente)obj; //Essa conversão tenta converter, se não conseguir lança uma InvalidCastException
            Cliente outroCliente = obj as Cliente; //Essa conversão tenta converter, mas diferente da conversão de cima, ela retorna null, fazendo assim que o if abaixo seja possível

            if (outroCliente == null)
            {
                return false;
            }

            return CPF == outroCliente.CPF;
        }
    }
}
