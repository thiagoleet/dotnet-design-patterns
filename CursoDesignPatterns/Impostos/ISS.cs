using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class ISS : Imposto
    {
        public ISS(Imposto outro) : base(outro){ }
        public ISS() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoOutroImposto(orcamento);
        }

       
    }
}
