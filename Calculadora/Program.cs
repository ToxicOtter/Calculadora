using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue(); //Soluciona o problema de loop infinito no primeiro item da fila
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);

                if (filaOperacoes.Count > 0) //Implementa a funcionalidade de imprimir a fila no fim de cada operação
                {
                    Console.Write(filaOperacoes.Count + " operações na fila: ");
                    foreach (Operacoes opNaFila in filaOperacoes)
                    {
                        //Console.Write(opNaFila.valorA);
                        Console.Write("'{0} {1} {2}'; ", opNaFila.valorA, opNaFila.operador, opNaFila.valorB);
                    }
                } else
                {
                    Console.WriteLine("Fila de operações vazia");
                }
                Console.WriteLine("\n");
                
            }

          
           
        }
    }
}
