namespace CommandPatternExample
{
    public class RemoteControl
    {
        private ICommand command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void PressButton()
        {
            command.Execute();
        }
    }
}
