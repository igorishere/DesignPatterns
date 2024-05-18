namespace DesignPatterns.Behavioral.ChainOfResponsability.WithDesignPattern.Validations
{
    public class NameIsEmptyValidation : BaseValidation
    {
        public override bool IsValid(User user)
        {
            if (string.IsNullOrEmpty(user.Name))
                return false;

            if (_nextValidation is not null)
                return _nextValidation.IsValid(user);

            return true;
        }
    }
}


