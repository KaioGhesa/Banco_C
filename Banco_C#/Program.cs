
using System;
using System.Globalization;

namespace Banco_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;
            // Se declrara a conta bancaria dentro do If, ela só existiria lá dentro, ela está sendo declarada encima

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's'||  resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, depositoInicial);
                //Aqui chamamos o construtor com os 3 argumentos

            } else
            {
                conta = new ContaBancaria (numero, titular);
                //Aqui chamamos o construtor com os 2 argumentos
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
