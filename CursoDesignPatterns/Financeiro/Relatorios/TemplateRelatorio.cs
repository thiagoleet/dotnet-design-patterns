using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.Relatorios
{
    public abstract class TemplateRelatorio
    {
        public string CabecalhoSimples(Banco banco)
        {
            StringBuilder cabecalho = new StringBuilder();
            cabecalho.Append(banco.Nome);
            cabecalho.Append(" - ");
            cabecalho.Append(banco.Telefone);

            return cabecalho.ToString();
        }
        public string CabecalhoComplexo(Banco banco)
        {
            StringBuilder cabecalho = new StringBuilder();
            cabecalho.Append(banco.Nome);
            cabecalho.Append(" - ");
            cabecalho.Append(banco.Endereco);
            cabecalho.Append(" - ");
            cabecalho.Append(banco.Telefone);

            return cabecalho.ToString();
        }

        public string RodapeSimples(Banco banco)
        {
            StringBuilder rodape = new StringBuilder();
            rodape.Append(banco.Nome);
            rodape.Append(" - ");
            rodape.Append(banco.Telefone);

            return rodape.ToString();
        }
        public string RodapeComplexo(Banco banco)
        {
            StringBuilder rodape = new StringBuilder();
            rodape.Append(banco.Nome);
            rodape.Append(" - ");
            rodape.Append(banco.Endereco);
            rodape.Append(" - ");
            rodape.Append(banco.Telefone);
            rodape.Append(" - ");
            rodape.Append(banco.Email);
            rodape.Append(" - ");
            rodape.Append(DateTime.Now);

            return rodape.ToString();
        }

        public string RelatorioSimples(IEnumerable<Conta> contas)
        {
            StringBuilder relatorio = new StringBuilder();

            foreach (Conta conta in contas)
            {
                relatorio.Append("Titular: ");
                relatorio.Append(conta.Titular);
                relatorio.Append("Saldo: ");
                relatorio.Append(conta.Saldo);

            }

            return relatorio.ToString();
        }
        public string RelatorioComplexo(IEnumerable<Conta> contas)
        {
            StringBuilder relatorio = new StringBuilder();

            foreach (Conta conta in contas)
            {
                relatorio.Append("Titular: ");
                relatorio.Append(conta.Titular);
                relatorio.Append("Agência: ");
                relatorio.Append(conta.Agencia);
                relatorio.Append("CC: ");
                relatorio.Append(conta.NumeroConta);
                relatorio.Append("Saldo: ");
                relatorio.Append(conta.Saldo);

            }

            return relatorio.ToString();
        }


    }
}
