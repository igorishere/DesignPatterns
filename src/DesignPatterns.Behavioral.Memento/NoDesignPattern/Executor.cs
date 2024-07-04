using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Memento.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var editor = new TextEditor();
            var history = new Stack<string>();

            var input = "Lorem ipsum";

            editor.InputText(input);
            history.Push(editor.ToString());
            editor.Display();

            editor.ToUpperCase();
            history.Push(editor.ToString());
            editor.Display();

            editor.ToLowerCase();
            history.Push(editor.ToString());
            editor.Display();

            _ = history.Pop();
            var lastState = history.Peek();
            editor = new TextEditor();
            editor.InputText(lastState);
            editor.Display();
        }

        public override string GetName() => "Memento";
    }
}