using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        //Aqui criamos um método de extensão para a classe List<int>
        //Para criarmos métodos de extensão, é necessário criar um método estático em uma classe estática
        //e o primeiro argumento do nosso método de extensão tem que ser do tipo que queremos extender
        //Além disso, é necessário colocar antes do argumento, a palavra "this"
        public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {
            foreach (int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}
