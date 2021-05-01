using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        //Perceba que temos o método com o mesmo nome, o que muda é o tipo de parâmetro recebido, isso é válido em C#, pode se ter vários métodos com o mesmo nome, porém os parâmetros passados precisam ser diferentes
        //Isso é chamado de sobrecarga, temos 2 sobrecargas do método registrar
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
