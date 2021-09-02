using System;

namespace MyBank
{
    public class Account
    {
        public Account(string nome, AccountType tipoConta, double saldo, double credito) 
        {
            this.Nome = nome;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
        }
        

        private string Nome { get; set; }
        
        private AccountType TipoConta { get; set; }

        private double Saldo { get; set; }
        
        private double Credito { get; set; }


        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("O saldo é insuficiente para o saque.");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine("Você sacou R$ {0:00} de sua conta.", valorSaque.ToString("C"));
            Console.WriteLine($"Saldo atual da conta: R$ {this.Saldo.ToString("C")}");

            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Você depositou R$ {0:00} em sua conta.", valorDeposito.ToString("C"));
            Console.WriteLine($"Saldo atual da conta: R$ {this.Saldo.ToString("C")}");
        }


        public void Transferir(double valorTransferencia, Account contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);       
            }   
        }
       
        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + " | ";        
            retorno += "Tipo de Conta: " + this.TipoConta + " | ";        
            retorno += "Crédito: " + this.Credito.ToString("C") + " | ";        
            retorno += "Saldo: " + this.Saldo.ToString("C");    
            return retorno;    
        }
    }
        
}