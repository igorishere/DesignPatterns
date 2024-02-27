namespace DesignPatterns.Structural.Facade.WithDesignPattern
{
    public class BartenderFacade
    {
        public async Task DeliverOrder(Customer customer, string choosedOptionFromMenu)
        {
            var order = new Order(customer, choosedOptionFromMenu);
            var cut = new CutIngredientsKitchenProcess();
            var cook = new CookIngredientsKitchenProcess();
            var mount = new MountOrderKitchenProcess();
            var serve = new ServeOrderKitchenProcess();

            await cut.CutIngredients(order);
            await cook.CookIngredients(order);
            await mount.MountOrder(order);
            await serve.ServeOrder(order);
        }
    }
}
