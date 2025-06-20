using System;
namespace ProxyPatternExample
{
    public class RealImage : Image
    {
        private string filename;
        public RealImage(string filename)
        {
            this.filename = filename;
            LoadFromServer();
        }
        private void LoadFromServer()
        {
            Console.WriteLine("Loading " + filename + " from server...");
        }
        public void Display()
        {
            Console.WriteLine("Displaying " + filename);
        }
    }
}
