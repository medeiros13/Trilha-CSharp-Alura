using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //IO = Input e Output

namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";

            //Só podemos usar o using quando estamos trabalhando com classes que implementam a interfacee IDisposable
            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; //1kb
                var numeroBytesLidos = -1;

                while (numeroBytesLidos != 0)
                {
                    numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                }
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = Encoding.Default; //o Default, vai pegar o UFT padrão utilizado no sistema operacional do computador
            var texto = utf8.GetString(buffer);
            Console.WriteLine(texto);
        }
    }
}
