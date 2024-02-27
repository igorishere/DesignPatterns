namespace DesignPatterns.Structural.Facade
{
    internal class MountOrderKitchenProcess
    {
        public async Task MountOrder(Order order)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine($"Assembling dishes for customer: {order.Customer.Name} - {order.OptionFromMenu}");
            });
        }
    }
}
