using System;
namespace Calculadora
{
    public class Operacoes
    {
        public int valorA {get;set;}
        public char operador { get; set; }
        public int valorB { get; set; }
        public decimal resultado { get; set; }
        /*
         Outra forma de solucionar o problema 2 seria a troca do tipo de dado dos valores de int para long (conforme abaixo)
        Porém, antes de implementar essa solução, é interessante estudar a necessidade, tendo em vista que é um dado que ocupa mais espaço

        public long valorA {get;set;}
        public long valorB { get; set; }

         */
    }
}
