using System;
using System.Collections.Generic;

namespace MyBank
{
    class Program
    {
        static List<Account> lista = new List<Account>();

        static void Main(string[] args)
        {
            string userInput = "";

            
            while (userInput.ToUpper() != "X")
            {
                Menu();
                userInput = Console.ReadLine();

                switch (userInput.ToUpper())
                {
                    case "1":
                        // Listar contas
                        Listar();
                        Console.ReadKey();
                        break;

                    case "2": 
                        // Criar conta
                        CriarConta();
                        break;

                    case "3":
                        Transferir();
                        break;
                    case "4": 
                        // Sacar
                        SacarConta();
                        break;
                    case "5":
                        // Depositar
                        DepositarConta();
                        break;
                    case "X":
                        // Sair
                        Console.WriteLine("Obrigado por utilizar os serviços do MyBank. Volte sempre!");
                        break;
                    default:
                        break;

                }
            }            

        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao MyBank!");
            Console.WriteLine("[1] - Listar contas");
            Console.WriteLine("[2] - Criar nova conta");
            Console.WriteLine("[3] - Transferir");
            Console.WriteLine("[4] - Sacar");
            Console.WriteLine("[5] - Depositar");
            Console.WriteLine("[X] - Sair");
            Console.WriteLine("Digite uma opção: ");
            Console.Write("> ");
        }

        private static void Listar()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada no banco.");
            }

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("# {0} ", i);
                Console.WriteLine(lista[i]);
            }
        }

        private static void CriarConta()
        {
            Console.WriteLine("Digite o seu nome: ");
            Console.Write("> ");
            string inputNome = Console.ReadLine();

            Console.WriteLine("Digite o tipo de conta (1 - PF, 2 - PJ): ");
            Console.Write("> ");
            int inputTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o saldo inicial: ");
            Console.Write("> ");
            double inputSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito inicial: ");
            Console.Write("> ");
            double inputCredito = double.Parse(Console.ReadLine());

            Account conta = new Account(inputNome, 
                                (AccountType)inputTipoConta,
                                inputSaldo,
                                inputCredito);

            Console.WriteLine(conta);
            lista.Add(conta);
            Console.ReadKey();
        }

        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta de origem: "); // numero que corresponde ao indice da lista de contas
            Console.Write("> ");
            int numContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino: "); // numero que corresponde ao indice da lista de contas
            Console.Write("> ");
            int numContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que deseja transferir: ");
            Console.Write("> ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            lista[numContaOrigem].Transferir(valorTransferencia, lista[numContaDestino]);
            Console.ReadKey();
        }

        private static void SacarConta()
        {
            Console.WriteLine("Digite o número da conta: "); // numero que corresponde ao indice da lista de contas
            Console.Write("> ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que deseja sacar: ");
            Console.Write("> ");
            double valorSaque = double.Parse(Console.ReadLine());

            lista[indiceConta].Sacar(valorSaque);
            Console.ReadKey();
        }

        private static void DepositarConta()
        {
            Console.WriteLine("Digite o número da conta: ");
            Console.Write("> ");
            int numConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que deseja sacar: ");
            Console.Write("> ");
            double valorDeposito = double.Parse(Console.ReadLine());

            lista[numConta].Depositar(valorDeposito);
            Console.ReadKey();
        }  
    
    }
}


