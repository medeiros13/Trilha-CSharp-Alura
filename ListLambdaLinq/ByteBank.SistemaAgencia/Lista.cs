using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    //Lista Genérica, o que indica que ela é genérica é o <T>
    //É possível criarmos classes genéricas, assim reaproveitamos todos os métodos e as lógicas dela para qualquer tipo valor
    public class Lista<T>
    {
        private T[] _itens;
        private int _proximaPosicao;
        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }
        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texto padrão", int numero = 5)
        {

        }
        public T GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }
        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(T item)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];

                //Busca pela conta que desejamos remover, se achar, sai do for
                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            //percorre a partir do item que desejamos remover e vai movendo as posições superiores uma posição para baixo
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            //Decrementa a última posição, pois agora temos uma posição livre
            _proximaPosicao--;

            //Seta a última casa como null pois o valor dela já foi movido para a casa anterior
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            //Console.WriteLine("Aumentando capacidade da lista");
            T[] novoArray = new T[novoTamanho];
            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
                //Console.WriteLine(".");
            }
            _itens = novoArray;
        }

        //O params permite que sejam adicionados n parâmetros.
        public void AdicionarVarios(params T[] itens)
        {
            foreach (T item in itens)
            {
                Adicionar(item);
            }
        }

        //esse seria um indexador por chave, nós buscaríamos por alguma chave string no array
        //public Object this[string texto]
        //{
        //    get
        //    {
        //        return null;
        //    }
        //}

        //isso é um indexador, na hora de usarmos, iremos dar um ListaDeObject[index], como se fosse um array de tipo primitivo, aí ele vai retornar uma Object nesse index
        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
