using CursoDesignPatterns.NF;
using CursoDesignPatterns.NF.Acoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();
            //Imposto iccc = new ICCC();

            //Orcamento orcamento = new Orcamento(3000);
            //CalculadorImpostos calculador = new CalculadorImpostos();

            //calculador.RealizaCalculo(orcamento, icms);
            //calculador.RealizaCalculo(orcamento, iss);
            //calculador.RealizaCalculo(orcamento, iccc);



            //Investimento conservador = new Convervador();
            //Investimento moderado = new Moderado();
            //Investimento arrojado = new Arrojado();

            //Conta conta = new Conta();

            //conta.Deposita(100);

            //RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();
            //realizador.Realiza(conta, conservador);
            //realizador.Realiza(conta, moderado);
            //realizador.Realiza(conta, arrojado);

            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            //Orcamento orcamento = new Orcamento(500);
            //orcamento.AdicionaItem(new Item("CANETA", 250));
            //orcamento.AdicionaItem(new Item("LAPIS", 250));


            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto);

            //Imposto iss = new ISS(new ICMS(new IKCV())); // impostos compostos
            //Orcamento orcamento = new Orcamento(500);
            //double valor = iss.Calcula(orcamento);

            //Imposto muitoAlto = new ImpostoMuitoAlto(new ICMS());
            //Orcamento orcamento = new Orcamento(1000);
            //double valor = muitoAlto.Calcula(orcamento);

            //Console.WriteLine(valor);

            //Orcamento reforma = new Orcamento(500);

            //Console.WriteLine(reforma.Valor);


            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Aprova();
            //reforma.AplicaDescontoExtra();
            //reforma.AplicaDescontoExtra();

            //Console.WriteLine(reforma.Valor);

            //reforma.Finaliza();
            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            var builder = new NotaFiscalBuilder()
                .ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("23.456.789/0001-12")
                .Com(new ItemNota("item 1", 100))
                .Com(new ItemNota("item 2", 200))
                .NaData()
                .ComObservacoes("observações...");


            // Ações
            builder.AdicionaAcao(new SalvarNoBanco());
            builder.AdicionaAcao(new EnviaPorEmail());
            builder.AdicionaAcao(new Multiplicador(12));

            NotaFiscal nf = builder.Constroi();

            Console.ReadLine();
        }
    }
}
