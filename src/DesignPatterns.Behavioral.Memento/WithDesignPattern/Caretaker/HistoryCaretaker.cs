using DesignPatterns.Behavioral.Memento.WithDesignPattern.Memento;

namespace DesignPatterns.Behavioral.Memento.WithDesignPattern.Caretaker
{
        public class HistoryCareTaker
        {
                private Stack<IMemento> _mementos { get; set; }
                public HistoryCareTaker()
                {
                        _mementos = new Stack<IMemento>();
                }

                public void Register(IMemento memento) => _mementos.Push(memento);

                public void Undo(TextEditor textEditor)
                {
                        _ = _mementos.Pop();
                        var lastState = _mementos.Peek();

                        textEditor.LoadState(lastState);
                }
        }
}
