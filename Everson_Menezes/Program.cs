using System;

namespace Everson_Menezes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 1
             * 
            Exercicio1 exercicio1 = new Exercicio1();
            Console.WriteLine("Por favor entre com a quantidade em dolares:");
            double Dolar = Double.Parse(Console.ReadLine());
            exercicio1.CalcularReal(Dolar);
            Console.WriteLine(exercicio1.ExibirValorReal());

            */

            //Exercício 2
            Exercicio2 exercicio2 = new Exercicio2();
            Console.WriteLine("Por favor entre com uma sequência numérica: ");
            long sequencia = long.Parse(Console.ReadLine());
            exercicio2.Verificar(sequencia);

        }
    }
}
