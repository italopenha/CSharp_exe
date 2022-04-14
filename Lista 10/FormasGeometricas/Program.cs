//2. Na matemática existem diferentes formas geométricas, mas todas elas possuem
//fórmula para encontrar suas áreas. Represente uma aplicação utilizando
//polimorfismo. E demostre como encontrar área de um retângulo, quadrado e um
//triangulo.

using System;
using System.Collections.Generic;
using FormasGeometricas.src;

namespace FormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fórmas Geométricas");

            List<Formas> formas = new List<Formas>
            (
                new Formas[]
                {
                    new Retangulo("retângulo", "A = b.h", "quadrilátero"),
                    new Quadrado("quadrado", "A = L²", "quadrilátero"),
                    new Triangulo("triângulo", "A = b.h / 2", "polígono")
                }
            );

            foreach (Formas forma in formas)
            {
                if(forma.Classificacao == "quadrilátero")
                {
                    Console.WriteLine($"A fórmula da área de um {forma.Nome} é {forma.Formula}, ele é um {forma.Classificacao}");
                    forma.Lados("4 lados");
                }
                else if(forma.Classificacao == "polígono")
                {
                    Console.WriteLine($"A fórmula da área de um {forma.Nome} é {forma.Formula}, ele é um {forma.Classificacao}");
                    forma.Lados("3 lados");
                }
            }
        }
    }
}
