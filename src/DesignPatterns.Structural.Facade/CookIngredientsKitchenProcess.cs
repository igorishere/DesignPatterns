namespace DesignPatterns.Structural.Facade
{
    internal class CookIngredientsKitchenProcess
    {
        public async Task CookIngredients(Order order)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine($"Cooking ingredients for recipe: {order.OptionFromMenu}");
            });
        }
    }
}
