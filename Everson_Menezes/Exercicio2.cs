using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            string conteudo;
            List<string> listaUnicos = new List<string>();
            List<string> listaRepetidos = new List<string>();
            List<string> listaAux = new List<string>();


            for (int i = 0; i < comprimento; i++)
            {
                Vetor[i] = obj.Substring(i, 1);
            }

            for (int j = 0; j < comprimento; j++)
            {
                conteudo = Vetor[j];

                if (Vetor.Where(x => x.Equals(conteudo)).Count().Equals(1))
                {
                    listaUnicos.Add(conteudo);
                }
                else if (!listaRepetidos.Contains(conteudo))
                {
                    listaRepetidos.Add(conteudo);
                }
                else
                {
                    listaAux.Add(conteudo);
                }
            }
            //245431234

            //[2, 4, 3] ->  3 valores que repetem //
            string[] numerosQueRepetem = listaRepetidos.ToArray();

            //[2, 4, 4, 3, 2, 3, 4] -> 7 valores repetidos//
            string[] repetidos = Vetor.Where(x => listaAux.Contains(x)).ToArray();
            int[,] vetorAux = new int[numerosQueRepetem.Length, repetidos.Length];

            for (int x = 0; x < numerosQueRepetem.Length; x++)
            {
                int contador = 0;
                for(int y = 0; y < repetidos.Length; y++)
                {
                    if(numerosQueRepetem[x] == repetidos[y])
                    {
                        contador++;
                        int valor = int.Parse(numerosQueRepetem[x]);
                        vetorAux[x,y] = vetorAux[valor, contador];                        
                    }
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine(vetorAux);
        }
    }
}
