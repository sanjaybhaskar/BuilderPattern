using BuilderDemo.Builders.Person.Interfaces;

namespace BuilderDemo.Builders.Person
{
    public class PersonBuilder :
        IFirstNameHolder, ILastNameHolder, IPersonBuilder
    {

        private string FirstName { get; set; }
        private string LastName { get; set; }

        public static IFirstNameHolder Person() => new PersonBuilder();

        public ILastNameHolder WithFirstName(string firstName) =>
            new PersonBuilder()
            {
                FirstName = firstName
            };

        public bool IsValidFirstName(string name) => !string.IsNullOrEmpty(name);

        public IPersonBuilder WithLastName(string lastName) =>
            new PersonBuilder()
            {
                FirstName = this.FirstName,
                LastName = lastName
            };

        public bool IsValidLastName(string surname) => !string.IsNullOrEmpty(surname);
       

        public Models.Person Build()
        {

             Models.Person person = new Models.Person();
            person.Name = this.FirstName;
            person.Surname = this.LastName;
            return person;
        }
    }
}
