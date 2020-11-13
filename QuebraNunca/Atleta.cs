public class Atleta
{
    private double _saldo;
    public string Nome { get; set; }
    public string Lado { get; set; }
    public double Saldo {
        get {
            return _saldo;
        }
        set {
            //logica validacao
            _saldo = value;
        }
    }



}