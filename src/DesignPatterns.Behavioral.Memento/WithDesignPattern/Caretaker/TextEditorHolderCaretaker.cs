namespace DesignPatterns.Behavioral.Memento.WithDesignPattern.Caretaker
{
    public class TextEditorHolderCareTaker
    {
        private HistoryCareTaker _history;
        private TextEditor _textEditor;
        public TextEditorHolderCareTaker()
        {
            this._history = new HistoryCareTaker();
            this._textEditor = new TextEditor();
        }

        public void InputText(string text)
        {
            _textEditor.InputText(text);
            CreateSnapshot();
            Display();
        }

        public void ToUpperCase()
        {
            _textEditor.ToUpperCase();
            CreateSnapshot();
            Display();
        }
        
        public void ToLowerCase()
        {
            _textEditor.ToLowerCase();
            CreateSnapshot();
            Display();
        }

        private void CreateSnapshot()
        {
            var snapshot = _textEditor.CreateSnapshot();
            _history.Register(snapshot);
        }

        public void Undo()
        {
            this._history.Undo(_textEditor);
            Display();
        }

        public void Display() => _textEditor.Display();
    }
}