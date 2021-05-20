using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes<T>
    {
        //Aqui criamos um método de extensão para a classe List<int>
        //Para criarmos métodos de extensão, é necessário criar um método estático em uma classe estática
        //e o primeiro argumento do nosso método de extensão tem que ser do tipo que queremos extender
        //Além disso, é necessário colocar antes do argumento, a palavra "this"
        public static void AdicionarVarios( List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();
            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            ListExtensoes<int>.AdicionarVarios(idades, 14, 12, 324, 45, 456, 234);

            List<string> nomes = new List<string>();
            nomes.Add("Guilherme");
            nomes.Add("Gabriel");
            nomes.Add("Carlos");

            ListExtensoes<string>.AdicionarVarios(nomes, "Ana", "Júlia");
        }
    }
}
