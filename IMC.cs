using System;

namespace Lista_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float peso;
            float altura;
            float imc;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Insira sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira seu peso: ");
            peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira sua altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc  );
        }
    }
}
