using System;

namespace QuebraNunca
{
    class Program
    {
        static void Main(string[] args) {

            Conta conta = new Conta();
            Atleta atleta = new Atleta();

            atleta.Nome = "gustavo";
            atleta.Lado = "esquerdo";
            atleta.Saldo = 100;

            conta.Saldo = -20;
            conta.Nome = atleta;
            conta.descricao = "churrasco";

            Console.WriteLine(conta.Nome.Nome);
            Console.WriteLine(conta.Saldo);
            
            Console.ReadLine();
        }
    }
}
