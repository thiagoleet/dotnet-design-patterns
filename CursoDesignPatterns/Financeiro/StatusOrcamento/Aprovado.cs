using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.StatusOrcamento
{
    public class Aprovado : IEstadoOrcamento
    {
        private bool DescontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (DescontoAplicado)
            {
                throw new Exception("O desconto já foi aplicado!");
            }
            else
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
                DescontoAplicado = true;
            }
            
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento aprovado não poode ser reprovado");
        }
    }
}
