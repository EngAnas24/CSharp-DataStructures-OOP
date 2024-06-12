namespace Abstract_interface
{
    abstract class person
    {
        protected int id;
        public string Name;
        protected int age;

        public abstract int Age { get; set ; }
        public abstract int Id { get ; set; }
        public person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public abstract void printInfo();

    }
}
