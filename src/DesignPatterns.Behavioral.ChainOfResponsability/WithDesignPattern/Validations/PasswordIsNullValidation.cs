namespace DesignPatterns.Behavioral.ChainOfResponsability.WithDesignPattern.Validations
{
    public class PasswordIsNullValidation : BaseValidation
    { 
        public override bool IsValid(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Password))
                return false;

            if (_nextValidation is not null)
                return _nextValidation.IsValid(user);

            return true;
        }
    }
}


