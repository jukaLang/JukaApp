namespace JukaApp
{
    public class Tab
    {
        private static int _counter;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; } //0 = unedited, 1 = edited
        public string Code {get; set;}
        public EntryList Output{ get; set; }

        public Tab(string name = "Untitled.juk", string code = "")
        {
            Id = _counter++;
            if (name == "Untitled.juk" && Id != 0)
            {
                Name = "Untitled (" + Id + ").juk";
            }
            else
            {
                Name = name;
            }

            Status = 0;
            Code = code;
            Output = new();
        }

    }
}
