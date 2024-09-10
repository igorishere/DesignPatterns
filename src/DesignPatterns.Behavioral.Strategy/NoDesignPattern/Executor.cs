using DesignPatterns.Behavioral.Strategy.Common;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Strategy.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var random = new Random();
            var choosed = random.Next(1, 3);
            var paymentType = (ePaymentType)choosed;
            var valueToPay = 200.00;

            if (paymentType == ePaymentType.CASH)
            {
                Console.Write($"Amount of {valueToPay}$ payed with cash.");
            }

            if (paymentType == ePaymentType.CREDIT_CARD)
            {
                Console.Write($"Amount of {valueToPay}$ payed with credit card.");
            }

            if (paymentType == ePaymentType.DEBIT_CARD)
            {
                Console.Write($"Amount of {valueToPay}$ payed with debit card.");
            }
        }

        public override string GetName() => "Strategy";
    }
};
