using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
                Cadastro c;
                Console.Write("Entre com o número da conta: ");
                int conta = int.Parse(Console.ReadLine());

                Console.Write("Entre com o titular da conta: ");
                string titular =Console.ReadLine();

                Console.Write("Hávera deposito inicial (s/n)? ");
                char depini = char.Parse( Console.ReadLine());

                if (depini == 's') {
                  Console.Write("Entre com valor de depósito inicial: ");
                  double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                  c = new Cadastro(conta, titular, depositoInicial);
                 }
                else {
                  c = new Cadastro(conta, titular);
                }
               
                Console.WriteLine();
                Console.WriteLine("Dados da conta: " + c);
                
                Console.WriteLine();
                Console.Write("Entre com um valor para déposito: ");
                double qte = double.Parse(Console.ReadLine());
                c.Deposito(qte);
                
                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados: " + c);
                
                Console.WriteLine();
                Console.Write("Entre com um valor para saque: ");
                qte = double.Parse(Console.ReadLine());
                c.Saque(qte);
                
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + c);
               
            
        }
    }
}
