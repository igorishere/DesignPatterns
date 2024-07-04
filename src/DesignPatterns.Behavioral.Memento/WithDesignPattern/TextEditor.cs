using DesignPatterns.Behavioral.Memento.WithDesignPattern.Memento;

namespace DesignPatterns.Behavioral.Memento.WithDesignPattern
{
    public class TextEditor
    {
        private string _text { get; set; }
        public TextEditor()
        {
        }

        public void LoadState(IMemento snapshopt)
        {
            if (snapshopt is TextEditorMemento textEditorMemento)
            {
                var text = textEditorMemento.CurrentText;

                if (textEditorMemento.IsLowerCase)
                    text.ToLower();

                if (textEditorMemento.IsUpperCase)
                    text.ToUpper();

                InputText(text);
            }
        }

        public void InputText(string text)
        {
            this._text = text;
        }

        public IMemento CreateSnapshot()
        {
            var isUpperCase = _text == _text.ToUpper();
            var isLowerCase = _text == _text.ToLower();

            return new TextEditorMemento(_text, isLowerCase, isUpperCase);
        }

        public void ToUpperCase() => this._text = this._text.ToUpper();

        public void ToLowerCase() => this._text = this._text.ToLower();

        public void Display() => Console.WriteLine(_text);
    }
}