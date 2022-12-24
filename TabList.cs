namespace JukaApp
{
    public class TabList
    {
        Queue<Tab> tabs = new();

        public int CurrentTab = 0;

        public TabList()
        {
            tabs.Enqueue(new Tab());
            CurrentTab = 0;
        }

        public Queue<Tab> List()
        {
            return tabs;
        }

        public void Add(string name = "Untitled.juk",string code="")
        {
            tabs.Enqueue(new Tab(name,code));
            CurrentTab = tabs.Count-1;
        }
        
        public void Delete(int id)
        {
            Console.WriteLine(id);
            tabs = new Queue<Tab>(tabs.Where(x => x.Id != id));
            if (CurrentTab > 0)
            {
                CurrentTab--;
            } else if(tabs.Any())
            {
                CurrentTab = 0;
            }
            else
            {
                CurrentTab = -1;
            }
        }

        public void SetCurrentTab(int id)
        {
            CurrentTab = tabs.ToList().FindIndex(x => x.Id == id);
        }

        public Tab GetCurrentTab()
        {
            return tabs.ElementAt(CurrentTab);
        }
    }
}
