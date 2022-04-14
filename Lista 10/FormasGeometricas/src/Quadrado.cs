using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormasGeometricas.src
{
    public class Quadrado : Formas
    {
       public Quadrado(string nome, string formula, string classificacao) : base( nome, formula, classificacao) {}

        public override void Lados(string lados)
        {
            Console.WriteLine($"Um {Nome} tem {lados}");
        } 
    }
}