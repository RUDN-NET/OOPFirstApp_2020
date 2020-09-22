namespace OOPFirstApp.Students
{
    class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Course { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"[Id:{Id}] {Name} ({Course}) {Description}".TrimEnd(' ');
        }
    }
}