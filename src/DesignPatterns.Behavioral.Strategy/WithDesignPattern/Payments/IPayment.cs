using DesignPatterns.Behavioral.Strategy.Common;

namespace DesignPatterns.Behavioral.Strategy.WithDesignPattern.Payments
{
    public interface IPayment
    {
        public ePaymentType type { get; }
        public void Pay(double amount);
    }
}