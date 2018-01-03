using CursoDesignPatterns.NF;
using CursoDesignPatterns.NF.Acoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        private double valorTotal;
        private double Impostos;
        private IList<ItemNota> todosItens = new List<ItemNota>();
        public DateTime DataEmissao { get; private set; }
        private IList<IAcaoPosGeraNota> Acoes = new List<IAcaoPosGeraNota>();

        public NotaFiscalBuilder()
        {
            DataEmissao = DateTime.Now;
        }

        public NotaFiscalBuilder(IList<IAcaoPosGeraNota> acoes)
        {
            this.Acoes = acoes;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder Com(ItemNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string obs)
        {
            Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilder NaData()
        {
            DataEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            DataEmissao = data;
            return this;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, valorTotal, Impostos, todosItens, Observacoes);

            foreach (var acao in Acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public NotaFiscalBuilder AdicionaAcao(IAcaoPosGeraNota acao)
        {
            Acoes.Add(acao);
            return this;
        }
    }
}
