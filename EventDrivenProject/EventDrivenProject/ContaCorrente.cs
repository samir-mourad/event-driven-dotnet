using System;
using System.Collections.Generic;
using System.Text;

namespace EventDrivenProject
{
    public class ContaCorrente
    {
        public Cliente Cliente { get; set; }
        public decimal Saldo { get; private set; }
        public event NotificarSaque Notificar;

        public ContaCorrente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Notificar(this, new NotificacaoEventArgs { Valor = valor });
            }
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0.00M)
                Saldo += valor;
        }
    }
}
