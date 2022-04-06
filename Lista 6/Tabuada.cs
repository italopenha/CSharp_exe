using System;

namespace Lista_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;

            Console.Write("Tabuada do: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int x = 1; x <= 10; x++)
            {
                resultado = numero * x;
                Console.WriteLine($"{numero} x {x} = {resultado}");
            }

        }   
    }
}
