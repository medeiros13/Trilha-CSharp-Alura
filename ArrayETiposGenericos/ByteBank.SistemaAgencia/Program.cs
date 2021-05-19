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

            //Array de inteiros com 5 posições!
            int[] idades = new int[5];
            idades[0] = 15;
            idades[1] = 25;
            idades[2] = 30;
            idades[3] = 40;
            idades[4] = 45;

            Console.WriteLine(idades[4]);
            Console.ReadLine();
        }
    }
}
