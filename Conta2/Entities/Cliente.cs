using System.Globalization;
namespace Conta2.Entities
{
    public class Cliente
    {
        public int NumeroConta { get; private set; }
        public string NomeConta { get; set; }
        public double SaldoConta { get; private set; }

        public Cliente()
        {
        }

        public Cliente(int numeroConta, string nomeConta)
        {
            NumeroConta = numeroConta;
            NomeConta = nomeConta;
        }

        public Cliente(int numeroConta, string nomeConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            NomeConta = nomeConta;
            SaldoConta = saldoConta;
        }

        public void Deposito(double Montante)
        {
            SaldoConta += Montante;
        }

        public void Saque(double Montante)
        {
            SaldoConta -= Montante + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + NomeConta
                + ", Saldo: $ "
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
