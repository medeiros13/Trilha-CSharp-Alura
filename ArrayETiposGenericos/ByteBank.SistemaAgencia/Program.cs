using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //No caso, o programa vai olha lá no código da Lista, todos os lugares que estão como T, ele vai trocar por int
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(10,20,30,40,50);

            //todas as nossas classes que criamos podem receber null pois são tipos de referência,
            //Já o nosso T, o int, string, o double, char, bool e todos os outros, são tipo valor, e tipos valor não podem receber null
            //ContaCorrente conta = null;

            int idadeSoma = 0;
            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }

            Console.WriteLine(SomarVarios(1, 2, 3, 4, 123123, 12312));

            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice: {i}: {idade}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }


        static void TestaArrayDeContas()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(875, 5679787),
                new ContaCorrente(875, 56797989),
                new ContaCorrente(875, 5679745)
            };


            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"conta[{i}] = {contaAtual.Numero}");
            }
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            //lista.MeuMetodo(numero: 10); Exemplo de chamada onde se passa direto o argumento que queremos usar

            ContaCorrente contadoGui = new ContaCorrente(434, 3434343);
            lista.Adicionar(contadoGui);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(875, 5679787),
            };

            lista.AdicionarVarios(new ContaCorrente(875, 5679787),
                    new ContaCorrente(875, 56797989),
                    new ContaCorrente(875, 5679745),
                    new ContaCorrente(875, 5679745),
                    new ContaCorrente(875, 5679745),
                    new ContaCorrente(875, 5679745),
                    new ContaCorrente(875, 5679745),
                    new ContaCorrente(875, 5679745),
                    new ContaCorrente(875, 5679745));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i]; //Aqui usamos um indexador
                Console.WriteLine($"Item na posição: {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static void TestaArrayInt()
        {

            //Array de inteiros com 5 posições!
            int[] idades = new int[3];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);
            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Acessando o array Idades no índice: {i}");
                Console.WriteLine($"valor de idades[{i}] = {idade}");
                acumulador += idade;
            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
