using System;

namespace QuebraNunca
{
    class Program
    {
        static void Main(string[] args) {

            Conta conta = new Conta();
            Atleta atleta = new Atleta();

            atleta.nome = "gustavo";
            atleta.lado = "esquerdo";
            atleta.saldo = 100;

            conta.Saldo = -20;
            conta.Nome = atleta;
            conta.descricao = "churrasco";

            Console.WriteLine(conta.Nome.nome);
            Console.WriteLine(conta.Saldo);
            
            Console.ReadLine();
        }
    }
}
