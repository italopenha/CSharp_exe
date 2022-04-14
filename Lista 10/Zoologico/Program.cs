using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Gato("Tom é um gato", "marrom", "felino"),
                    new Lobo("Wolf é um lobo", "branco", "canídio"),
                    new Gato("Kimi é um gato", "amarelo", "felino")
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "felino")
                {
                    Console.WriteLine($"{animal.Nome} {animal.Cor}, então é um {animal.Classificacao}");
                    animal.Comunicar("Miau!");
                }
                else if (animal.Classificacao == "canídio")
                {
                    Console.WriteLine($"{animal.Nome} {animal.Cor}, então é um {animal.Classificacao}");
                    animal.Comunicar("Auuuu!");
                }
            }
        }
    }
}
