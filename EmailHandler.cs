

namespace EventMonitoringSystem_Lab7
{
    public class EmailHandler : EventHandlerBase
    {
        public EmailHandler(IFormatStrategy strategy) : base(strategy) { }

        protected override void SendMessage(string message)
        {
            Console.WriteLine($"[EMAIL IMITATION → admin@example.com] {message}");
        }
    }
}
