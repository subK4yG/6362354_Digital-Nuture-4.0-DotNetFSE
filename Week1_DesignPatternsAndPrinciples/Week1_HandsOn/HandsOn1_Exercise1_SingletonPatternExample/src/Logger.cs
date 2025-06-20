namespace SingletonPatternExample.src
{
    public class Logger
    {
        private static Logger instance;
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }
}
