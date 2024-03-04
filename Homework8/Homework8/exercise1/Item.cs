   public class Item
    {
        private string Name = "unknown";

        public Item() { }

        public Item(string name) 
        {
            Name = name;
        }

        public void SetName(string name)
        { this.Name = name; }

        public string GetName() 
        { return this.Name; }
    }
