using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.NF.Acoes
{
    public class Multiplicador : IAcaoPosGeraNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double f)
        {
            Fator = f;
        }

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto * Fator);
        }
    }
}
