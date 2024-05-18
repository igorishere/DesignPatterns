namespace DesignPatterns.Behavioral.ChainOfResponsability.WithDesignPattern.Validations
{
    public class PasswordLenghtValidation : BaseValidation
    {
        public override bool IsValid(User user)
        {
            if (user.Password.Length > 8)
                return false;

            if (_nextValidation is not null)
                return _nextValidation.IsValid(user);

            return true;
        }
    }
}
