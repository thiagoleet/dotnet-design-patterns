using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.Filtros
{
    public class FiltroSaldoMenorQue100 : Filtro
    {

        public FiltroSaldoMenorQue100() : base() { }
        public FiltroSaldoMenorQue100(Filtro outro) : base(outro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return FiltraOutroFiltro(contas).Where(c => c.Saldo < 100).ToList();
        }
    }
}
