using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        //Aqui criamos um método de extensão para a classe List<int>
        //Para criarmos métodos de extensão, é necessário criar um método estático em uma classe estática
        //e o primeiro argumento do nosso método de extensão tem que ser do tipo que queremos extender
        //Além disso, é necessário colocar antes do argumento, a palavra "this"


        //Adicionamos o "<T>" após o nome do método, isso o tornou um método genérico, com isso, dizemos que ele pode ser extendido para todos os tipos
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        //public static void TesteGenerico<T2>(this string texto)
        //{

        //}

        static void Teste()
        {
            List<int> idades = new List<int>();
            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            //string guilherme = "Guilherme";
            //Aqui nesse teste somos obrigados a tipar o método na chamada dele, pois o argumento do método não é um argumento genérico, é um argumento string.
            //guilherme.TesteGenerico<int>();

            //Ao chamarmos o método de extensão genérico, o compilador olha primeiro se o argumento com o "this" é um argumento genérico (tipo = <T>),
            //Se for, o compilador já entende que o método vai ser do mesmo tipo que esse argumento que possui o this.
            //Com isso, não há necessidade de tipar o método na chamada dele.

            idades.AdicionarVarios(10, 12, 343, 12312);

            List<string> nomes = new List<string>();
            nomes.Add("Guilherme");
            nomes.Add("Gabriel");
            nomes.Add("Carlos");

            nomes.AdicionarVarios("Ana", "Júlia");
        }
    }
}
