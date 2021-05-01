using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    public class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string profissao { get; set; }

        public Cliente() { }
        public Cliente(string nome, string cpf, string profissao)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.profissao = profissao;
        }
    }
}
