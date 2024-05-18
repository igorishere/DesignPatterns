namespace DesignPatterns.Behavioral.ChainOfResponsability.WithDesignPattern.Validations
{
    public interface IValidation
    {
        void SetNext(IValidation validation);

        bool IsValid(User user);
    }
}
