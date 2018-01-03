using CursoDesignPatterns.NF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ItemNotaBuilder
    {
        public string Nome { get; private set; }
        public double Valor { get; set; }

        public ItemNotaBuilder comNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemNotaBuilder comValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public ItemNota Constroi()
        {
            return new ItemNota(Nome, Valor);
        }
    }
}
