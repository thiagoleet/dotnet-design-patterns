using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro
{
    public interface Investimento
    {
        double Calcula(Conta conta);
    }
}
