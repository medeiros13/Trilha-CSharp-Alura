using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; } //Usa-se o prop tab tab apenas quando o atributo não possui nenhuma lógica para ser atribuído
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100; //Atributo privado, todo atributo privado tem seu nome inciado com _ por convenção

        public double Saldo //Propriedade pública com getter e setter inclusos, seu nome sempre inicia com a primeira letra em maiúsculo
        {
            //Maneira nova de um Getter e Setter
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value; //Palavra reservada "value" representa o valor passado para o setter (o valor que o saldo irá receber)
            }
        }

        //Maneira antiga de Getter e Setter
        //public void SetSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }

        //    saldo = saldo;
        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
