using DesignPatterns.Behavioral.Strategy.Common;

namespace DesignPatterns.Behavioral.Strategy.WithDesignPattern.Payments
{
    public class DebitCard : IPayment
    {
        public ePaymentType type => ePaymentType.DEBIT_CARD;

        public void Pay(double amount)
        {
            Console.Write($"Amount of {amount}$ payed with debit card.");
        }
    }
}