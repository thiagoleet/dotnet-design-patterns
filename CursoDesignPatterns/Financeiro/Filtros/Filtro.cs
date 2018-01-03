using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.Filtros
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; set; }

        public Filtro()
        {
            OutroFiltro = null;
        }

        public Filtro(Filtro outro)
        {
            OutroFiltro = outro;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        public IList<Conta> FiltraOutroFiltro(IList<Conta> contas)
        {
            if (OutroFiltro == null)
            {
                return contas;
            }
            else
            {
                return OutroFiltro.Filtra(contas);
            }
        }
        
    }
}
