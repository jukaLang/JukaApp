namespace JukaApp
{
    public class Entry
    {
        public string message { get; }

        public DateTime started { get; }
        public DateTime completed { get; }

        public Entry(string messageIn, DateTime startedIn)
        {
            message = messageIn;
            started = startedIn;
            completed = DateTime.Now;
        }
    }
}
