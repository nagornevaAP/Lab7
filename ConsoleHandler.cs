

namespace EventMonitoringSystem_Lab7
{
    public class ConsoleHandler : EventHandlerBase
    {
        public ConsoleHandler(IFormatStrategy strategy) : base(strategy) { }

        protected override void SendMessage(string message)
        {
            Console.WriteLine($"[CONSOLE] {message}");
        }
    }
}
