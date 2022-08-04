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
            char ligar;
            char desligar;
        
            do
            {
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("-----------");
                Console.Write("Pressione L para ligar");
                ligar = char.Parse(Console.ReadLine());
            }
            
            while (ligar != 'L' && ligar != 'l');

            Console.Write("Digite o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o operador: ");
            operador = char.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
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

            Console.Write("Deseja realizar outra operação? (S/N)");
            desligar = char.Parse(Console.ReadLine());

            if (desligar == 'n' || desligar == 'N') {
                Console.Clear();
            }
            else {
                Main(args);
            }
        }

    }
}
