using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class IHIT : TemplateImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (TemDoisItensComMesmoNome(orcamento, item.Nome))
                {
                    return true;
                }
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.01) * orcamento.Itens.Count;
        }

        private bool TemDoisItensComMesmoNome(Orcamento orcamento, string nome)
        {
            if (orcamento.Itens.Where(i => i.Nome.Equals(nome)).Count() >= 2)
            {
                return true;
            }
            else return false;
        }
    }
}
