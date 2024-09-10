using DesignPatterns.Behavioral.Strategy.Common;

namespace DesignPatterns.Behavioral.Strategy.WithDesignPattern.Payments
{
    public class CreditCard : IPayment
    {
        public ePaymentType type => ePaymentType.CREDIT_CARD;

        public void Pay(double amount)
        {
            Console.Write($"Amount of {amount}$ payed with credit card.");
        }
    }
}