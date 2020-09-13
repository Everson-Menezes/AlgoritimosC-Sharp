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
            try
            {
                double Dolar = Double.Parse(Console.ReadLine());
                exercicio1.CalcularReal(Dolar);
                Console.WriteLine(exercicio1.ExibirValorReal());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Por favor insira apenas números", ex.Message);
            } 
            */

            /*Exercício 2
             * 
            Exercicio2 exercicio2 = new Exercicio2();
            Console.WriteLine("Por favor entre com uma sequência numérica: ");
            try
            {
                string sequencia = Console.ReadLine();
                exercicio2.Verificar(sequencia);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Por favor insira apenas números", ex.Message);
                throw;
            }
            */

            /*Exercício 3
             * 
                Produto produto = new Produto();
                Pedido pedido = new Pedido();
                bool continuar = false;
                string resposta;
                int menu = 0;
                Console.WriteLine("Bem vindo a Lanchonete Comilão");
                while (menu != 3)
                {
                    try
                    {
                        Console.WriteLine("Digite: \n1 para fazer o pedido. \n2 para finalizar pedido \n3 para sair");
                        menu = int.Parse(Console.ReadLine());
                        switch (menu)
                        {
                            case 1:
                                {
                                    foreach (var obj in Produto.ExibirProdutos())
                                    {
                                        Console.WriteLine("Código: " + obj.Id + "\nProduto: " + obj.Nome + " Preço: R$" + obj.Preco + "\n");
                                    }

                                    do
                                    {
                                        Console.WriteLine("\nDigite o código do produto que deseja: ");

                                        int escolha = int.Parse(Console.ReadLine());
                                        produto = Produto.ExibirProdutos().Find(x => x.Id == escolha);
                                        pedido.Produtos.Add(produto);

                                        Console.WriteLine("Deseja adicionar algo mais no pedido? S/N");

                                        resposta = Console.ReadLine();
                                        if (resposta.ToUpper() != "S")
                                        {
                                            if (resposta.ToUpper() != "N")
                                                Console.WriteLine("Por favor digite (S ou N)");
                                        }
                                        if (resposta.ToUpper() == "S")
                                        {
                                            continuar = true;
                                        }
                                        else if (resposta.ToUpper() == "N")
                                        {
                                            continuar = false;
                                        }
                                    } while (continuar == true);
                                }
                                break;

                            case 2:
                                {
                                    pedido.Valor = pedido.FazerPedido(pedido);
                                    foreach (var obj in pedido.Produtos)
                                    {
                                        Console.WriteLine("Código: " + obj.Id + "\nProduto: " + obj.Nome + " Preço: R$" + obj.Preco + "\n");
                                    }
                                    Console.WriteLine("Total: R$" + pedido.Valor);
                                    Console.WriteLine("Muito obrigado!");
                                    Environment.Exit(0);
                                }
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine("Por favor insira apenas números", ex.Message);
                        throw;

                    }
                }
                */

            /*Exercício 4
            Boolean c = false;
            while (!c)
            {
                Console.WriteLine("Digite o palindrome inicial(fim para terminar): ");
                String s = Console.ReadLine();
                if (s.Length < 100)
                {
                    if (s.Equals("fim"))
                        c = true;
                    else
                        Console.WriteLine("Maior palíndrome é: " + a(s));
                }
                else
                    Console.WriteLine("A cadeia de caracteres precisa ter no máximo 100 elementos");

            }
            */
            //Exercicio 5
            Exercicio5 exercicio5 = new Exercicio5();
            Console.WriteLine("Programa para mostrar a sequência de Golomb! \nPor favor digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            exercicio5.GerarSequencia(numero);
            Console.WriteLine(exercicio5.ExibirSequencia());

        }
    }
}
