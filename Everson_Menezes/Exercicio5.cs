using System;
using System.Collections.Generic;
using System.Text;

namespace Everson_Menezes
{
    class Exercicio5
    {
        public int Entrada { get; private set; }
        public int[] Sequencia { get; private set; }

        public Exercicio5()
        {
        }
        //a(1)=1;
        //a(n+1) = 1+a(n+1-a(-a(n)))

        //45         
        private int a(int n)
        {            
            if (n == 1)
            {
                //a(1)=1
                return 1;
            }
            else
            {
                return 1 + a(n - a(a(n - 1)));
            }
        }
        public void GerarSequencia(int n)
        {
            Entrada = n;
            Sequencia = new int[Entrada];
            for (int i = 1; i < Sequencia.Length; i++)
            {
                Sequencia[i] = a(i);
            }
        }
        public string ExibirSequencia()
        {
            string saida = null;
            //1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 11, 11, 11, 11, 11, 12, 12, 12, 12, 12, 12,
            for (int i = 1; i < Sequencia.Length; i++)
            {
                saida += Sequencia[i] + ", ";
            }
            return saida;
        }
    }
}
