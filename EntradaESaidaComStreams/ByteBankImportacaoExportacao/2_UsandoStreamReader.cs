using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //IO = Input e Output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsandoStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";
            //Quando temos um using logo após o outro, retiramos as chaves do primeiro using e deixamos os ambos no mesmo nível de identação
            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"{contaCorrente.Titular.Nome}: Conta: {contaCorrente.Numero}, Agência: {contaCorrente.Agencia}, Saldo: {contaCorrente.Saldo}";

                    Console.WriteLine(msg);
                }
            }
        }
    }
}