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
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50,Gabriel Medeiros";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            //o FileMode.Create, se o arquivo já existe, ele limpa todo o conteúdo do arquivo e escreve o que precisa ser escrito
            //Já o FileMode.CreateNew verifica se o arquivo já existe, se já existir, lança uma exceção
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,78945,4785.50,Gabriel Medeiros");
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";
            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 1000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); //Despeja o buffer para o Stream, ou seja, ele já escreve imediatamente no arquivo, mesmo dentro do using, ignorando o buffer
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma:");
                    Console.ReadLine();

                }
            }
        }
    }
}