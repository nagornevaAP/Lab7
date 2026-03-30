

namespace EventMonitoringSystem_Lab7
{
    public class JsonFormatStrategy : IFormatStrategy
    {
        public string Format(string message, DateTime timestamp)
        {
            //кавычки, чтобы JSON был валидным
            string safeMessage = message.Replace("\"", "\\\"");

            return $"{{\"timestamp\":\"{timestamp:O}\",\"message\":\"{safeMessage}\"}}";
        }
    }
}