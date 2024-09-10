using DesignPatterns.Behavioral.Strategy.Common;
using DesignPatterns.Behavioral.Strategy.WithDesignPattern.Payments;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Strategy.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            var random = new Random();
            var choosed = random.Next(1, 3);
            var valueToPay = 200.00;
            var payment = GetPayment((ePaymentType)choosed);
            Pay(payment, valueToPay);
        }

        IPayment GetPayment(ePaymentType paymentType)
        {
            IPayment payment = null;

            if (paymentType == ePaymentType.CASH)
                payment = new CashPayment();

            if (paymentType == ePaymentType.CREDIT_CARD)
                payment = new CreditCard();

            if (paymentType == ePaymentType.DEBIT_CARD)
                payment = new DebitCard();

            return payment;
        }

        void Pay(IPayment payment, double amount)
        {
            payment.Pay(amount);
        }

        public override string GetName() => "Strategy";
    }
}