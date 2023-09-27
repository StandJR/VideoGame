namespace VideoGame;

class ConsoleLogger : ILogger
{
    public void Log(LogLevel level, string message)
    {
        string strDate = null!;
        DateTime dateNow = DateTime.Now;

        if (dateNow.Day < 10)
        {
            strDate += "0";
        }

        strDate += dateNow.Day.ToString() + "/";

        if (dateNow.Month < 10)
        {
            strDate += "0";
        }

        strDate += dateNow.Month.ToString() + "/";
        strDate += dateNow.Year + " ";
        strDate += dateNow.TimeOfDay;

        Console.WriteLine($"[{strDate}] {level} : {message}");
    }
}
