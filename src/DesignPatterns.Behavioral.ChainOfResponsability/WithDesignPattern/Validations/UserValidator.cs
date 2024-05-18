namespace DesignPatterns.Behavioral.ChainOfResponsability.WithDesignPattern.Validations
{
    public class UserValidator
    {
        private IValidation _validations {get;set;} 

        public bool IsValid(User user)
        {
            if(_validations is null)
            {
                _validations = new NameIsEmptyValidation();
                var b = new PasswordIsNullValidation();
                var c = new PasswordLenghtValidation();

                _validations.SetNext(b);
                b.SetNext(c);
            }
            
            return _validations.IsValid(user);
        }
    }
}
