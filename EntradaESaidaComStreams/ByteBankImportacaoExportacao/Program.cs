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
    //O partial é útil em exemplos como: Temos uma classe cliente, criamos uma partial contendo só os atributos dela, e outra partial contendo só os métodos. Para assim, quando for necessário modificarmos algum método irmos direto no arquivo dos métodos, ou quando for necessário modificarmos algum atributo, irmos direto no arquivo dos atributos
    partial class Program
    {
        static void Main(string[] args)
        {

            //Utilizamos a classe File quando sabemos que os arquivos que iremos manipular não são grandes
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            
            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var bytes = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytes.Length} bytes");



            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);
            
            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine("Aplicação Finalizada!");
            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);
            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
        static void EscreverBuffer(byte[] buffer, int numeroDeBytesLidos)
        {
            var utf8 = Encoding.Default; //o Default, vai pegar o UFT padrão utilizado no sistema operacional do computador
            var texto = utf8.GetString(buffer, 0, numeroDeBytesLidos);
            Console.WriteLine(texto);
        }

    }
}
