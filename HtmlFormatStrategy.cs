

namespace EventMonitoringSystem_Lab7
{
    public class HtmlFormatStrategy : IFormatStrategy
    {
        public string Format(string message, DateTime timestamp) =>
        $"<div style=\"color:red;font-weight:bold\">{timestamp:yyyy-MM-dd HH:mm:ss}: {message}</div>";
    }
}
