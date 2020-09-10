using System;
using System.Collections.Generic;
using System.Text;

namespace Everson_Menezes
{
    class Exercicio2
    {
        public long Entrada { get; set; }
        public int Contador { get; set; }
        public string[] Vetor { get; set; }

        public void Verificar(long entrada)
        {
            Entrada = entrada;
            string obj = Entrada.ToString();
            int comprimento = obj.Length;
            Vetor = new string[comprimento];
            for (int i = 0; i < comprimento; i++)
            {
                Vetor[i] = obj.Substring(i, 1);
                Console.WriteLine(Vetor[i]);
            }
        }
    }
}
