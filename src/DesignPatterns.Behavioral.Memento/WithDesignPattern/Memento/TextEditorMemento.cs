namespace DesignPatterns.Behavioral.Memento.WithDesignPattern.Memento
{
    public class TextEditorMemento : IMemento
    {
        public TextEditorMemento(string currentText, bool isUpperCase, bool isLowerCase)
        {
            CurrentText = currentText;
            IsLowerCase = isLowerCase;
            IsUpperCase = isUpperCase;
        }

        public readonly string CurrentText;

        public readonly bool IsUpperCase;

        public readonly bool IsLowerCase;

        public string createdAt => DateTime.UtcNow.ToString();

        public string createdBy => nameof(TextEditor);
    }
}
