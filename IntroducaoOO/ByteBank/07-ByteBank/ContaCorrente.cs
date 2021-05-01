using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private int _agencia;
        private double _saldo = 100; //Atributo privado, todo atributo privado tem seu nome inciado com _ por convenção
        public Cliente Titular { get; set; } //Usa-se o prop tab tab apenas quando o atributo não possui nenhuma lógica para ser atribuído
        public static int TotalDeContasCriadas { get; private set; } //Atributo é estático, ou seja, seu valor é compartilhado para todos os objetos que forem do tipo dessa classe.
        //Repare que esse atributo possui um get público e um set privado, logo, ele só pode ter seu valor alterado aqui nessa classe, fora dela, isso não é permitido


        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; set; }


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

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

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
