using System;
using DesignPatterns.Behavioral.Strategy.Common;

namespace DesignPatterns.Behavioral.Strategy.WithDesignPattern.Payments;

public class CashPayment : IPayment
{
    public ePaymentType type => ePaymentType.CASH;

    public void Pay(double amount)
    {
        Console.Write($"Amount of {amount}$ payed with cash.");
    }
}