
namespace EventMonitoringSystem_Lab7
{
    public class FileHandler : EventHandlerBase
    {
        private readonly string _filePath = "events.log";

        public FileHandler(IFormatStrategy strategy) : base(strategy) { }

        protected override void SendMessage(string message)
        {
            try
            {
                File.AppendAllText(_filePath, message + Environment.NewLine + new string('-', 60) + Environment.NewLine);
                Console.WriteLine($"[FILE] Written to {_filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FILE ERROR]: {ex.Message}");
            }
        }
    }
}
