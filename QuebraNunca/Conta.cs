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
            if (this.saldo < valor) {
                return false;
            }
            else {
                this.saldo -= valor;

                return true;
            }
        }

        public void Creditar(double valor) {
            this.saldo += valor;
        }
    }
}
