public class Atleta
{
    public string nome;
    public string lado;
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

    public bool Cobrar(double valor) 
    {
        if (this.saldo < valor) {
            return true;
        }
        else 
        {
            return false;
        }

    }
}