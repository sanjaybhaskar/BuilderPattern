namespace BuilderDemo.Models
{
    public class Person
    {
        public string Name { get; internal set; }
        public string Surname { get; internal set; }

        internal Person() { }
    }
}
