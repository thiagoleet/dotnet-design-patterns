using CursoDesignPatterns.Financeiro.StatusConta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro
{
    public class Conta
    {

        public string Titular { get; set; }
        public double Saldo { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public DateTime DataAbertura { get; set; }
        public IStatusConta StatusConta { get; set; }

        public void Deposita(double valor)
        {
            StatusConta.Deposita(this, valor);
        }

        public void Saque(double valor)
        {
            StatusConta.Saca(this, valor);
        }

        public void Depositar(double valor)
        {
            this.Saldo -= valor;
        }

        public void Sacar(double valor)
        {
            this.Saldo += valor;
        }

    }
}
