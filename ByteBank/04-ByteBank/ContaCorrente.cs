using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    public class ContaCorrente
    {
        public string titular { get; set; }
        public int agencia { get; set; }
        public int numero { get; set; }
        public double saldo { get; set; } = 100;

        public bool Sacar (double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
    }
}
