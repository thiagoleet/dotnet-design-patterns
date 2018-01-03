using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.Filtros
{
    public class FiltroMaiorQue500k : Filtro
    {
        public FiltroMaiorQue500k() : base() { }
        public FiltroMaiorQue500k(Filtro outro) : base(outro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return FiltraOutroFiltro(contas).Where(c => c.Saldo > 500000).ToList();
        }
    }
}
