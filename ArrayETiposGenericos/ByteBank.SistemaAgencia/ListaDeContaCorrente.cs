using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    //[conta][conta][conta][conta][conta]
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }
        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texto padrão", int numero = 5)
        {

        }
        public ContaCorrente GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }
        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];

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
            _itens[_proximaPosicao] = null;
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
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
                //Console.WriteLine(".");
            }
            _itens = novoArray;
        }

        //O params permite que sejam adicionados n parâmetros.
        public void AdicionarVarios(params ContaCorrente[] contas)
        {
            foreach (ContaCorrente conta in contas)
            {
                Adicionar(conta);
            }
        }

        //esse seria um indexador por chave, nós buscaríamos por alguma chave string no array
        //public ContaCorrente this[string texto]
        //{
        //    get
        //    {
        //        return null;
        //    }
        //}

        //isso é um indexador, na hora de usarmos, iremos dar um ListaDeContaCorrente[index], como se fosse um array de tipo primitivo, aí ele vai retornar uma ContaCorrente nesse index
        public ContaCorrente this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
