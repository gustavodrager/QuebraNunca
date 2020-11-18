using System;
using System.Collections.Generic;
using System.Text;

namespace QuebraNunca
{
    public class Conta
    {
        public Atleta Nome { get; set;}

        private string _descricao;
        public string Descricao {
            get { 
                return _descricao; 
            }
            set { 
                if (value != "") {
                    return;
                }
                _descricao = value;
            } 
        }

        
        public Conta(string descricao) {
            Descricao = descricao;
        }

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
