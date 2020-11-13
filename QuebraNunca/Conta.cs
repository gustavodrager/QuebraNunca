using System;
using System.Collections.Generic;
using System.Text;

namespace QuebraNunca
{
    public class Conta
    {
        public Atleta Nome {
            get;
            set;
            
        }

        public string descricao;
        private double _saldo = 100;

        public double Saldo {
            get {
                return _saldo;
            }
            set {
              if (value < 0) {
                    return;
                }

                _saldo = value;
            }
        }

        public bool Debitar(double valor) {
            if (_saldo < valor) {
                return false;
            }
            else {
                _saldo -= valor;

                return true;
            }
        }

        public void Creditar(double valor) {
            _saldo += valor;
        }
    }
}
