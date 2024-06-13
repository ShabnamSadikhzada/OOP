using System.Threading.Channels;

namespace Delegate_.Models;

public interface ILogger
{
    void SendLog(string mesdsage) { }
}

public class SmsLog : ILogger { public void SendLog(string message) => Console.WriteLine($"Sms Log: {message}"); }
public class XmlLog : ILogger { public void SendLog(string message) => Console.WriteLine($"Xml Log: {message}"); }
public class SqlLog : ILogger { public void SendLog(string message) => Console.WriteLine($"Sql Log: {message}"); }
public class MailLog : ILogger { public void SendLog(string message) => Console.WriteLine($"Mail Log: {message}"); }
public class PushNotiLog : ILogger { public void SendLog(string message) => Console.WriteLine($"PushNoti Log: {message}"); }
