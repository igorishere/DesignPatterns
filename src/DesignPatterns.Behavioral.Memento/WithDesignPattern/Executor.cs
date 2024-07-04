using DesignPatterns.Behavioral.Memento.WithDesignPattern.Caretaker;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Memento.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
             var editor = new TextEditorHolderCareTaker(); 
            var input = "Lorem ipsum";
            editor.InputText(input);
            editor.ToUpperCase();
            editor.ToLowerCase();
            editor.Undo();
        }

        public override string GetName() => "Memento";
    }
}