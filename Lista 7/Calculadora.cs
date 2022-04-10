using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char operador;
            int ligar;
        
            do
            {
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("Pressione 1 para ligar");
                ligar = int.Parse(Console.ReadLine());
            }
            
            while (ligar != 1);

            Console.WriteLine("Digite o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador: ");
            operador = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());
            
            switch (operador)
            {
                case '+':
                    Console.WriteLine("Resultado: " + Somar(num1, num2));
                    break;
                case '-':
                    Console.WriteLine("Resultado: " + Subtrair(num1, num2));
                    break;
                case '*':
                    Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                    break;
                case '/':
                    Console.WriteLine("Resultado: " + Dividir(num1, num2));
                    break;
                default:
                    break;
            }

            static int Somar(int num1, int num2)
            {
                return num1 + num2;
            }
            static int Subtrair(int num1, int num2)
            {
                return num1 - num2;
            }
            static int Multiplicar(int num1, int num2)
            {
                return num1 * num2;
            }
            static int Dividir(int num1, int num2)
            {
                return num1 / num2;
            }
        }

    }
}
