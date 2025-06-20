using System;
namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            ICommand onCmd = new LightOnCommand(light);
            ICommand offCmd = new LightOffCommand(light);
            RemoteControl remote = new RemoteControl();
            remote.SetCommand(onCmd);
            remote.PressButton();
            remote.SetCommand(offCmd);
            remote.PressButton();
        }
    }
}
