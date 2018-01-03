using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP() : base() { }
        public ICPP(Imposto outro) : base(outro) { }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor >= 500);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
