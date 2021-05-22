using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //IO = Input e Output

namespace ByteBankImportacaoExportacao
{
    //Utilizamos o modificador "partial" quando desejamos que uma classe no mesmo namespace tenha métodos em arquivos separados, ao executar, o programa vai juntar todos essas "parciais" e montar a classe completa
    partial class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";
            //Quando temos um using logo após o outro, retiramos as chaves do primeiro using e deixamos os ambos no mesmo nível de identação
            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }
            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer, int numeroDeBytesLidos)
        {
            var utf8 = Encoding.Default; //o Default, vai pegar o UFT padrão utilizado no sistema operacional do computador
            var texto = utf8.GetString(buffer, 0, numeroDeBytesLidos);
            Console.WriteLine(texto);
        }

    }
}
