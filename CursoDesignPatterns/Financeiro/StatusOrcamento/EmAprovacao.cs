using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.StatusOrcamento
{
    public class EmAprovacao : IEstadoOrcamento
    {
        private bool DescontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (DescontoAplicado)
            {
                throw new Exception("O desconto já foi aplicado");
            }
            else
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                DescontoAplicado = true;
            }
            
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ir pra finalizado direto");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
