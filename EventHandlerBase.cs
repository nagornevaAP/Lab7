
namespace EventMonitoringSystem_Lab7
{
    public abstract class EventHandlerBase
    {
        protected IFormatStrategy _formatStrategy;

        protected EventHandlerBase(IFormatStrategy strategy)
        {
            _formatStrategy = strategy;
        }

        public void SetStrategy(IFormatStrategy strategy)
        {
            _formatStrategy = strategy;
        }

        public void ProcessEvent(MetricEventArgs e)
        {
            var message = FormatMessage(e.EventType, e.Data);
            SendMessage(message);
            LogResult();
        }

        protected virtual string FormatMessage(string type, object data)
        {
            if (data is MetricData md)
            {
                string rawMessage = $"Event: {type}. {md}";
                return _formatStrategy.Format(rawMessage, md.Timestamp);
            }
            return $"Event: {type}";
        }

        protected abstract void SendMessage(string message);

        protected virtual void LogResult()
        {
            Console.WriteLine("[Handler]: Notification processed successfully.");
        }
    }
}
