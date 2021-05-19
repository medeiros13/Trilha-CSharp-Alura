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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            //lista.MeuMetodo(numero: 10); Exemplo de chamada onde se passa direto o argumento que queremos usar

            ContaCorrente contadoGui = new ContaCorrente(434, 3434343);
            lista.Adicionar(contadoGui);

            lista.Adicionar(new ContaCorrente(875, 5679787));
            lista.Adicionar(new ContaCorrente(875, 56797989));
            lista.Adicionar(new ContaCorrente(875, 5679745));
            lista.Adicionar(new ContaCorrente(875, 5679745));
            lista.Adicionar(new ContaCorrente(875, 5679745));
            lista.Adicionar(new ContaCorrente(875, 5679745));
            lista.Adicionar(new ContaCorrente(875, 5679745));
            lista.Adicionar(new ContaCorrente(875, 5679745));
            lista.Adicionar(new ContaCorrente(875, 5679745));

            lista.Remover(contadoGui);
            Console.ReadLine();
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
