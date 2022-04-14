using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormasGeometricas.src
{
    public class Formas
    {
        public string Nome { get; set;}

        public string Formula { get; set;}

        public string Classificacao { get; set;}

        public Formas(string nome, string formula, string classificacao)
        {
            Nome = nome;
            Formula = formula;
            Classificacao = classificacao;
        }

        public virtual void Lados(string lados)
        {
            Console.WriteLine($"Um {Nome} tem {lados}");
        }
    }
}