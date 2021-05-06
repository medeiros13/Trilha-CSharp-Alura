using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }
        //Aqui eu chamo o construtor lá da Exception que é o pai dessa exception aqui
        public SaldoInsuficienteException(string message)
            : base(message)
        {

        }
        public SaldoInsuficienteException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
        //Aqui eu chamo o construtor que recebe apenas uma string a partir desse construtor aqui
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this($"Tentativa de saque no valor de: {valorSaque} em uma conta com o saldo de: {saldo}")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

    }
}
