using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Indice = 13, Soma = 0, K = 0;
            while (K < Indice)
            {
                K = K + 1;
                Soma = Soma + K;
            }
            Console.WriteLine(Soma);
            Console.ReadKey();
        }
    }
}
