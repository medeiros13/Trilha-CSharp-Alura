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
            //idades[4] = 45;

            int idadeNoIndice4 = idades[4];
            Console.WriteLine(idadeNoIndice4); //Vai mostrar zero, pois zero é o valor padrão do int. O array, quando não especificado um valor para alguma posição, ele assume o valor padrão de seu tipo primitivo

            int[] outroArray = idades;
            Console.WriteLine(outroArray[3]);

            bool[] arrayDeBooleans = new bool[10];
            arrayDeBooleans[0] = true;
            arrayDeBooleans[1] = false;
            arrayDeBooleans[2] = true;
            arrayDeBooleans[3] = false;
            arrayDeBooleans[4] = false;
            arrayDeBooleans[5] = true;
            arrayDeBooleans[6] = false;
            arrayDeBooleans[7] = false;
            arrayDeBooleans[8] = true;
            arrayDeBooleans[9] = false;
            Console.ReadLine();
        }
    }
}
