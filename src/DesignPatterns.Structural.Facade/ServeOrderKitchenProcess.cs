namespace DesignPatterns.Structural.Facade
{
    internal class ServeOrderKitchenProcess
    {
        public async Task ServeOrder(Order order)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine($"Delivering order - customer: {order.Customer.Name} - ${order.OptionFromMenu}");
            });
        }
    }
}
