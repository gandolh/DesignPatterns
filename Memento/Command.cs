namespace DesignPatterns.Memento
{
    internal abstract class Command
    {
        private Stack<IMemento> _history;
        protected Editor _editor;

        public Command(Editor editor)
        {
            _editor = editor;
            _history = new Stack<IMemento>();
        }

        protected void MakeBackup()
        {
            _history.Push(_editor.CreateSnapshot());
        }

        public void Undo()
        {
            IMemento memento = _history.Pop();
            memento.Restore();
        }

        public virtual void Execute()
        {
            MakeBackup();
        }
    }
}
