using System;

namespace app.bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Arthur Delmas");
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
