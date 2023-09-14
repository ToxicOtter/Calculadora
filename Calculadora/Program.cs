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
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();

            Stack resultados = new Stack();
            
            while (filaOperacoes.Count > 0)
            {
                //Soluciona o problema de loop infinito no primeiro item da fila
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                resultados.Push(operacao.resultado);

                //Implementa a funcionalidade de imprimir a fila no fim de cada operação
                if (filaOperacoes.Count > 0)
                {
                    Console.Write(filaOperacoes.Count + " operações na fila: ");
                    foreach (Operacoes opNaFila in filaOperacoes)
                    {
                        Console.Write("'{0} {1} {2}'; ", opNaFila.valorA, opNaFila.operador, opNaFila.valorB);
                    }
                } else
                {
                    Console.WriteLine("Fila de operações vazia");
                }
                Console.WriteLine("\n");
                
            }

            //Implementa a impressão da pilha de resultados ao final
            Console.WriteLine("Histórico de resultados das operações: "); 
            foreach(Object res in resultados)
            {
                Console.WriteLine(res);
            }

          
           
        }
    }
}
