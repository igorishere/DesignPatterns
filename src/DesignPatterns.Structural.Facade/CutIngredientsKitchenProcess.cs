namespace DesignPatterns.Structural.Facade
{
    public class CutIngredientsKitchenProcess
    {
        public async Task CutIngredients(Order order)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine($"Cutting ingredients for recipe: {order.OptionFromMenu}");
            });
        }
    }
}
