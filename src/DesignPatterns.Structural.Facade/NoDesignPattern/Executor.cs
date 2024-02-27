using DesignPatterns.Common;

namespace DesignPatterns.Structural.Facade.NoDesignPattern
{
    public class Executor : IExecutor
    {
        public string Description => "Facade - no design pattern";

        public async void Execute()
        {
            var customer = new Customer("Cus tomer");
            var someOptionFromMenu = "Some option from menu";

            var order = new Order(customer, someOptionFromMenu);

            await new CutIngredientsKitchenProcess().CutIngredients(order);
            await new CookIngredientsKitchenProcess().CookIngredients(order);
            await new MountOrderKitchenProcess().MountOrder(order);
            await new ServeOrderKitchenProcess().ServeOrder(order);
        }
    }
}
