using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.NF.Acoes
{
    public class SalvarNoBanco : IAcaoPosGeraNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("salvando no db");
        }
    }
}
