namespace EventMonitoringSystem_Lab7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Система мониторинга и оповещения запущена ===\n");

            var monitor = new EventMonitor();

            var textStrat = new TextFormatStrategy();
            var jsonStrat = new JsonFormatStrategy();
            var htmlStrat = new HtmlFormatStrategy();

            var consoleText = new ConsoleHandler(textStrat);
            var consoleJson = new ConsoleHandler(jsonStrat);
            var fileHtml = new FileHandler(htmlStrat);
            var emailText = new EmailHandler(textStrat);

            monitor.OnMetricExceeded += consoleText.ProcessEvent;
            monitor.OnMetricExceeded += consoleJson.ProcessEvent;
            monitor.OnMetricExceeded += fileHtml.ProcessEvent;
            monitor.OnMetricExceeded += emailText.ProcessEvent;

            Console.WriteLine("--- Симуляция метрик ---");
            monitor.CheckMetric("CPU Load", 92.5, 80.0);
            monitor.CheckMetric("Memory Usage", 65.0, 90.0);
            monitor.CheckMetric("Network Traffic", 150.0, 100.0);

            Console.WriteLine("\n--- Смена стратегии (Strategy) ---");
            consoleText.SetStrategy(htmlStrat);
            monitor.CheckMetric("CPU Load", 95.0, 80.0);

            Console.WriteLine("\n=== Демонстрация завершена ===");
            Console.ReadLine();
        }
    }
}
