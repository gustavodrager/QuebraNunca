using System;

namespace QuebraNunca
{
    class Program
    {
        static void Main(string[] args) {

            Atleta atleta = new Atleta();

            atleta.nome = "Gustavo";
            atleta.lado = "esquerdo";
            atleta.saldo = 100;

            Atleta atleta = new Atleta();

            atleta.nome = "Tiago";
            atleta.lado = "direito";
            atleta.saldo = 700;



            Console.WriteLine(atleta.nome);
            Console.WriteLine(atleta.lado);
            Console.WriteLine(atleta.saldo);

            Console.WriteLine(atleta.nome == atleta.lado);

            atleta.Debitar(50);

            Console.WriteLine(atleta.saldo);

            atleta.Creditar(100);

            Console.WriteLine(atleta.saldo);

            Console.ReadLine();
        }
    }
}
