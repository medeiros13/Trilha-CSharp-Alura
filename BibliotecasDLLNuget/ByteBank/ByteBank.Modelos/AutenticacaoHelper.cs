using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    //O modificador "internal" diz pro compilador que essa classe só é acessível aqui dentro dessa biblioteca,
    //e projetos externos que utilizam essa biblioteca, não possuírão acesso a classe AutenticacaoHelper
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
