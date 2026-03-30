

namespace EventMonitoringSystem_Lab7
{
    public class TextFormatStrategy : IFormatStrategy
    {
        public string Format(string message, DateTime timestamp) =>
        $"[{timestamp:yyyy-MM-dd HH:mm:ss}] {message}";
    }
}
