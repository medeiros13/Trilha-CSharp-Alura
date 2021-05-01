using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        //0 = funcionário
        //1 = diretor
        //2 = designer
        //3 = gerente de conta corrente
        //4 = coordenador
        //n = ...
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //Cria-se um método ao invés de uma propriedade para retornar um valor, pois o uso de propriedades geralmente é utilizado quando se tem um acesso imediato ao valor, sem precisar executar algum cálculo, ou alguma ação que demande um custo de processamento
        public double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
