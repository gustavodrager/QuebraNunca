using System;
using System.Collections.Generic;
using System.Text;

namespace QuebraNunca
{
    public class Conta
    {
        public Atleta atleta;
        public string descricao;
        public double saldo;

        public bool Debitar(double valor) {
            if (saldo < valor) {
                return false;
            }
            else {
                saldo -= valor;

                return true;
            }
        }

        public void Creditar(double valor) {
            saldo += valor;
        }

        public double ObterSaldo() {
            return saldo;
        }

        public void DefinirSaldo(double saldo) {
            if (saldo < 0) {
                return;
            }

            this.saldo = saldo;
        }
    }
}
