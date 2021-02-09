using System;
using System.Globalization;

namespace Banco
{
    class Cadastro
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Cadastro(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
            Saldo = 0.0;
        }

        public Cadastro(int conta, string titular, double saldo) : this(conta,titular)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta : " 
            + Conta
            + ", Titular : "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
        public void Saque(double saldo)
        {
            
            Saldo -= saldo + 5;
        }
        
    }
}

