using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.Filtros
{
    public class FiltroContasAbertasEsteMes : Filtro
    {
        public FiltroContasAbertasEsteMes() : base() { }
        public FiltroContasAbertasEsteMes(Filtro outro) : base(outro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return FiltraOutroFiltro(contas).Where(c => c.DataAbertura.Month == DateTime.Now.Month).ToList();
        }
    }
}
