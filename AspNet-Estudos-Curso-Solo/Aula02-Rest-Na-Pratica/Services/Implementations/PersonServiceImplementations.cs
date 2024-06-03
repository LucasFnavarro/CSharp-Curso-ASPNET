using Aula02_Rest_Na_Pratica.Models;

namespace Aula02_Rest_Na_Pratica.Services.Implementations
{
    public class PersonServiceImplementations : IPersonService
    {
        public volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            // Lógica de delete aqui
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        public Person FindById(long id)
        {

            return new Person
            {
                Id = IncrementAndGet(),
                firstName = "Lucas",
                lastName = "Scquiavon",
                Addres = "Londrina - Paraná - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                firstName = "Person Name" + i,
                lastName = "Person Last Name" + i,
                Addres = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

    }
}
