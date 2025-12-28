using System;

namespace CalculadoraProjeto 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Bem-Vindo a calculadora!!!");

            Console.WriteLine("Digite seu primeiro número:");
            string? entrada1 = Console.ReadLine();
            double num1 = Convert.ToDouble(entrada1);

            Console.WriteLine("Digite seu segundo número:");
            string? entrada2 = Console.ReadLine();
            double num2 = Convert.ToDouble(entrada2);

            Console.WriteLine("Digite seu operador (+, -, *, /, %):");
            string? operador = Console.ReadLine();

            // AQUI ESTAVA O ERRO: Agora removemos o "resultado ="
            if (operador == "+")
            {
                Console.WriteLine("Resultado da soma: " + (num1 + num2));
            }
            else if (operador == "-")
            {
                Console.WriteLine("Resultado da subtração: " + (num1 - num2));
            }
            else if (operador == "*")
            {
                Console.WriteLine("Resultado da multiplicação: " + (num1 * num2));
            }
            else if (operador == "/")
            {
                if (num2 != 0)
                    Console.WriteLine("Resultado da divisão: " + (num1 / num2));
                else
                    Console.WriteLine("Erro: Divisão por zero!");
            }
            else if (operador == "%")
            {
                Console.WriteLine("Resultado do Módulo: " + (num1 % num2));
            }
            else
            {
                Console.WriteLine("Operador inválido!");
            }
        }
    }
}