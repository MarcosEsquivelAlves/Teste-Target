using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_2
{
            internal class Program
        {
            static void Main(string[] args)
            {
                int a = 0;
                int b = 1;
                int c = 0;

                Console.Write("Quantos valores da sequência Fibonacci você quer ver? ");
                int valores = int.Parse(Console.ReadLine());

                Console.WriteLine("A sequência Fibonacci com " + valores + " valores:");

                for (int i = 0; i < valores; i++)
                {
                    if (i < valores - 1)
                    {
                        Console.Write(a + " , ");
                    }
                    else
                    {
                        Console.Write(a);
                    }

                    c = a + b;
                    a = b;
                    b = c;
                }

                Console.WriteLine(); // Nova linha após a sequência de Fibonacci

                // Solicita o número para verificação após exibir a sequência
                Console.WriteLine("Digite um número para verificar se ele pertence à sequência de Fibonacci: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int numeroEscolhido))
                {
                    bool pertenceAFibonacci = false;

                    // Reseta os valores de a e b para fazer a verificação corretamente
                    a = 0;
                    b = 1;

                    // Verifica se o número pertence à sequência de Fibonacci
                    if (numeroEscolhido == a || numeroEscolhido == b)
                    {
                        pertenceAFibonacci = true;
                    }
                    else
                    {
                        while (b <= numeroEscolhido)
                        {
                            c = a + b;
                            a = b;
                            b = c;

                            if (b == numeroEscolhido)
                            {
                                pertenceAFibonacci = true;
                                break;
                            }
                        }
                    }

                    if (pertenceAFibonacci)
                    {
                        Console.WriteLine($"O número escolhido {numeroEscolhido} faz parte da sequência de Fibonacci.");
                    }
                    else
                    {
                        Console.WriteLine("O número não faz parte da sequência de Fibonacci.");
                    }

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
                Console.ReadKey();
            }
        }

    }


