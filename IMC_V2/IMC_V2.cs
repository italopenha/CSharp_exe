using System;

namespace Lista_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float altura;
            float peso;
            float imc;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Insira sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira sua altura: ");
            altura = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira seu peso: ");
            peso = Convert.ToInt32(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc  );

            if (imc < 18.5) 
            {Console.WriteLine("Abaixo do peso");}

            else if (imc < 25)
            {Console.WriteLine("Peso normal");}

            else if (imc < 30)
            {Console.WriteLine("Sobrepeso");}

            else if (imc >= 30)
            {Console.WriteLine("Obesidade");}


        }
    }
}
