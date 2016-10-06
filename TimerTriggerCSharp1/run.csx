using System;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"C# Timer trigger function changed and executed at: {DateTime.Now}");
}
