namespace JukaApp
{
    public class EntryList
    {
        Queue<Entry> entries = new();

        public EntryList()
        {
        }

        public void Add(string message, DateTime starttime)
        {
            entries.Enqueue(new Entry(message, starttime));
        }

        public IEnumerable<Entry> List()
        {
            return entries.Reverse();
        }

        public void Clean()
        {
            entries = new();
        }
    }
}
