using DesignPatterns.Common;

namespace DesignPatterns.Structural.Facade.WithDesignPattern
{
    public class Executor : IExecutor
    {
        public string Description => "Facade - with design pattern";

        public async void Execute()
        {
            var customer = new Customer("Cus tomer");
            var someOptionFromMenu = "Some option from menu";

            var barteder = new BartenderFacade();

            await barteder.DeliverOrder(customer, someOptionFromMenu);
        }
    }
}
