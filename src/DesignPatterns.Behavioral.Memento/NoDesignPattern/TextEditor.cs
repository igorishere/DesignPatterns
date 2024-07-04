using System.Text;

namespace DesignPatterns.Behavioral.Memento.NoDesignPattern
{
    public class TextEditor
    {
        private StringBuilder _stringBuilder;
        public TextEditor()
        {
            _stringBuilder = new StringBuilder();
        }

        public void InputText(string text) => _stringBuilder.Append(text);

        public void ToUpperCase()
        {
            var text = _stringBuilder.ToString().ToUpper();
            _stringBuilder = new StringBuilder();
            _stringBuilder.Append(text);
        }

        public void ToLowerCase()
        {
            var text = _stringBuilder.ToString().ToLower();
            _stringBuilder = new StringBuilder();
            _stringBuilder.Append(text);
        }

        public override string ToString() => _stringBuilder.ToString();

        public void Display() => Console.WriteLine(_stringBuilder.ToString());
    }
}
