using System;

namespace app.bank
{
    public class Conta
    {
        private TipoConta TipoConta {get; set;}
        private double Saldo {get; set;}
        private double Credito {get; set;}
        private string Nome {get; set;}

        //Construtor
        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
        }

        //Metodos

        public bool Sacar(double valorSaque)
        {
            if(this.Saldo - valorSaque < (this.Credito *-1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é de R${1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é de R${1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo Conta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo R$" + this.Saldo + " | ";
            retorno += "Crédito R$" + this.Credito + " | ";
            return retorno;
        }

    }
}