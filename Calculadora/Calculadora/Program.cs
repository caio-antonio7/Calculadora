using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao >= 1 && opcao <= 4)
                {
                    Console.Write("Digite o primeiro número: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int resultado = 0;

                    if (opcao == 1)
                    {
                        resultado = num1 + num2;
                    }
                    else if (opcao == 2)
                    {
                        resultado = num1 - num2;
                    }
                    else if (opcao == 3)
                    {
                        resultado = num1 * num2;
                    }
                    else if (opcao == 4)
                    {
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                            continue;
                        }
                    }

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (opcao == 5)
                {
                    sair = true;
                    Console.WriteLine("Obrigado por usar esta calculadora.");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Escolha uma opção de 1 a 5.");
                }

                Console.WriteLine();
            }
        }
    }
}