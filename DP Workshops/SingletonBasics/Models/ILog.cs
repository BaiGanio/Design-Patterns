namespace SingletonBasics.Models
{
    public interface ILog
    {
        void LogException(string message);
        void LogSomething(string message);
    }
}
