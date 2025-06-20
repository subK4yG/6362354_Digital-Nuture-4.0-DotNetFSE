namespace CommandPatternExample
{
    public class LightOnCommand : ICommand
    {
        private Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
