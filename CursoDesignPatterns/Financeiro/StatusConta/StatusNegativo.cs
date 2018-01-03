using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Financeiro.StatusConta
{
    public class Negativo : IStatusConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Depositar(valor * 0.95);
            if (conta.Saldo > 0)
            {
                conta.StatusConta = new Positivo();
            }
        }

        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Sua conta está negativa, não é possível sacar");
        }
    }
}
