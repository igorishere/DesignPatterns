using DesignPatterns.Common;

namespace DesignPatterns.Structural.Facade.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override string GetName() => "Facade";

        public override async void Execute()
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
