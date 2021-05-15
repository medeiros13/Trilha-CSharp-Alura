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
            //Com esse padrão, o sistema busca na tabela ASCII os códigos dos caracteres "0" até o "9", e o código do caractere "-"
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"; //Expressão regular de um número de telefone
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"; //Expressão regular de cima, porém um pouco simplificada
            //string padrao = "[0-9]{4}[-][0-9]{4}"; //Expressão regular de cima, só que simplificada, aqui ele busca fixo um número que tenha 4 dígitos númericos no começo
            //string padrao = "[0-9]{4,5}[-][0-9]{4}"; //Expressão regular de cima, só que simplificada, aqui ele busca números que comecem com 4 ou 5 dígitos numéricos no primeiro bloco
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}"; //Expressão regular de cima, só que simplificada, aqui ele busca número que tenham 0 ou 1 dígito no meio dos blocos de números
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}"; //Expressão regular de cima, só que simplificada, retirando os colchetes do "-", pois ele é apenas 1 caractere
            string padrao = "[0-9]{4,5}-?[0-9]{4}"; //Expressão regular de cima, só que simplificada, utilizando o "?" para representar um padrão que pode existir ou não (pega o número mesmo que ele tenha o hífen ou não)
            //o que fica entre "{}" é o numero que o padrão se repete


            string textoDeTeste = "Meu nome é Gabriel, me ligue em 98544-0898";

            Match resultado = Regex.Match(textoDeTeste, padrao); //Busca na string o padrão da expressão regular
            Console.WriteLine(resultado.Value); //Mostra o número de telefone que respeita a expressão do número de telefone
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); //Retorna true se a string respeitar o padrão da expressão regular

            Console.ReadLine();


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
