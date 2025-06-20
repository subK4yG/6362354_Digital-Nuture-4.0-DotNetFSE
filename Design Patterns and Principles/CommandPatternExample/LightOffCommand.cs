namespace CommandPatternExample
{
    public class LightOffCommand : ICommand
    {
        private Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Off();
        }
    }
}
