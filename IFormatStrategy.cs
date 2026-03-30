

namespace EventMonitoringSystem_Lab7
{
    public interface IFormatStrategy
    {
        string Format(string message, DateTime timestamp);
    }
}
