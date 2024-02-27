namespace DesignPatterns.Structural.Facade
{
    public class Order
    {

        public readonly Customer Customer;
        public readonly string OptionFromMenu;
        public Order(Customer customer, string optionFromMenu)
        {
            Customer = customer;
            OptionFromMenu = optionFromMenu;
        }
    }
}
