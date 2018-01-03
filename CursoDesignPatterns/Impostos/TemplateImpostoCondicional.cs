using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public abstract class TemplateImpostoCondicional : Imposto
    {

        public TemplateImpostoCondicional() : base() { }
        public TemplateImpostoCondicional(Imposto outro) : base(outro) { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculoOutroImposto(orcamento);
            }
            else return MinimaTaxacao(orcamento) + CalculoOutroImposto(orcamento);
        }

        public abstract double MinimaTaxacao(Orcamento orcamento);

        public abstract double MaximaTaxacao(Orcamento orcamento);

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }

}
