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
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            var buffer = new byte[1024]; //1kb
            var numeroBytesLidos = -1;

            while (numeroBytesLidos != 0)
            {
                numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

            }
            EscreverBuffer(buffer);

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
    }
}
