namespace JukaApp
{
    public class Entry(string messageIn, DateTime startedIn)
    {
        public string Message { get; } = messageIn;

        public DateTime Started { get; } = startedIn;
        public DateTime Completed { get; } = DateTime.Now;
    }
}
