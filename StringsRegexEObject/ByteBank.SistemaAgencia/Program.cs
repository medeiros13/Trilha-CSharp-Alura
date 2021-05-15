using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Olá meu nome é Gabriel e você pode entrar em contato comigo
            //através do número 8457-4456!

            //Meu nome é Gabriel, me ligue em 8544-8098

            //Teste expressões regulares
            string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"; //Expressão regular de um número de telefone
            string textoDeTeste = "Meu nome é Gabriel, me ligue em 8544-8098";

            Match resultado = Regex.Match(textoDeTeste, padrao); //Busca na string o padrão da expressão regular
            Console.WriteLine(resultado.Value); //Mostra o número de telefone que respeita a expressão do número de telefone

            Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); //Retorna true se a string respeitar o padrão da expressão regular



            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");


            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("ByteBank"));
            Console.ReadLine();
            // pagina?argumentos
            // 012345678


            // moedaOrigem=real&moedaDestino=dolar
            //                              |
            //             ----------------´

            //Programa principal
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine($"Valor de moeda destino: {valor}");

            string valorDaMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine($"Valor de moeda origem: {valorDaMoedaOrigem}");

            Console.WriteLine($"Valor: {extratorDeValores.GetValor("VALOR")}");

            Console.ReadLine();


            //Testando tolower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";
            Console.WriteLine(mensagemOrigem.ToLower());

            //Testando replace
            termoBusca = termoBusca.Replace('r','R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);


            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            //Testando o método Remove
            string testeRemocao = "primeiraParte&123456789";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();

            // <nome>=<valor>
            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine($"Tamanho da string {nameof(nomeArgumento)}: {nomeArgumento.Length}");

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();

            //Testando o IsnullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();






            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }


}
