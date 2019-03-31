using System;
using Conta2.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Conta2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> list = new List<Cliente>();

            Console.Write("Numero de contas a cadastra: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.Write("Entre o número da conta: ");
                int NumeroConta = int.Parse(Console.ReadLine());
                Console.Write("Entre o titular da conta: ");
                string NomeConta = Console.ReadLine();
                Console.Write("Haverar deposito inicial (s/n)? ");
                char Escolha = char.Parse(Console.ReadLine());

                if (Escolha == 'S' || Escolha == 's')
                {
                    Console.Write("Entre o valor de deposito inicial: ");
                    double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Cliente(NumeroConta, NomeConta, DepositoInicial));
                }
                else
                {
                    list.Add(new Cliente(NumeroConta, NomeConta));
                }
            }

            Console.WriteLine();

            Console.WriteLine("Dados das contas:");

            foreach (Cliente obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            char Escol;
            int NumeroDaConta;
            do
            {
                Console.Write("Digite o numero de uma conta para deposito: ");
                NumeroDaConta = int.Parse(Console.ReadLine());

                Cliente emp = list.Find(x => x.NumeroConta == NumeroDaConta);

                if (emp != null)
                {
                    Console.Write($"Entre um valor para conta {NumeroDaConta}: ");
                    double Montante = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Deposito(Montante);
                }
                else
                {
                    Console.WriteLine("Essa Conta não existe!!!");
                }

                Console.Write("Deseja fazer mais um deposito (s/n)? ");
                Escol = char.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (Escol == 's' || Escol == 'S');

            do
            {
                Console.Write("Digite o numero de uma conta para saque: ");
                NumeroDaConta = int.Parse(Console.ReadLine());

                Cliente emp = list.Find(x => x.NumeroConta == NumeroDaConta);

                if (emp != null)
                {
                    Console.Write($"Digite um valor para Saque na Conta {NumeroDaConta}: ");
                    double Montante = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Saque(Montante);
                }
                else
                {
                    Console.WriteLine("Essa Conta não existe!!!");
                }

                Console.Write("Deseja fazer mais um saque (s/n)? ");
                Escol = char.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (Escol == 's' || Escol == 'S');

            Console.WriteLine();

            Console.WriteLine("Dados das contas:");

            foreach (Cliente obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
