using CursoDesignPatterns.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.StatusConta
{
    public class Positivo : IStatusConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Depositar(valor * 0.98);
        }

        public void Saca(Conta conta, double valor)
        {
            conta.Sacar(valor);

            if (conta.Saldo < 0)
            {
                conta.StatusConta = new Negativo();
            }
        }
    }
}
