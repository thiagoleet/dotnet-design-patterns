using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            Desconto cincoItens = new DescontoPorCincoItens();
            Desconto maisQueQuinhentosReais = new DescontoPorMaisQueQuinhentosReais();
            Desconto SemDesconto = new SemDesconto();
            Desconto vendaCasada = new DescontoPorVendaCasada();

            cincoItens.Proximo = maisQueQuinhentosReais;
            maisQueQuinhentosReais.Proximo = vendaCasada;
            vendaCasada.Proximo = SemDesconto;

            return cincoItens.Desconta(orcamento);
        }
    }
}
