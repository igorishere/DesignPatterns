namespace DesignPatterns.Behavioral.ChainOfResponsability.WithDesignPattern.Validations
{
    public abstract class BaseValidation : IValidation
    {
        protected IValidation _nextValidation;

        public abstract bool IsValid(User user);

        public void SetNext(IValidation validation)
        {
            _nextValidation = validation;
        }
    }
}


