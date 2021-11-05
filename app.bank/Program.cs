using System;
using System.Collections.Generic;

namespace app.bank
{
    class Program
    {
        static List<Conta> listContas= new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //ListarContas();
                        break;
                    case "2":
                        CadastrarConta();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.WriteLine("Volte Sempre!");
            Console.WriteLine();
        }

        private static void CadastrarConta()
        {
            Console.WriteLine("Cadastrar Nova Conta");
            Console.WriteLine();

            Console.WriteLine("Digite sua opção do tipo de conta:");
            Console.WriteLine("1 - Pessoa Física");
            Console.WriteLine("2 - Pessoa Jurídica");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite o crédito inicial do cliente: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(    tipoConta: (TipoConta)entradaTipoConta,
                                            nome: entradaNome,
                                            saldo: 0, //a conta inicia com saldo zerado
                                            credito: entradaCredito
                                        );

            listContas.Add(novaConta);            
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Olá!");
            Console.WriteLine("Bem vindo a aplicação de operações bancárias!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Cadastrar nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
