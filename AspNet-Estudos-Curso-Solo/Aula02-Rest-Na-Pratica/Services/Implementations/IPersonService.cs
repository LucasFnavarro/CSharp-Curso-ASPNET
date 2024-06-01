using Aula02_Rest_Na_Pratica.Models;

namespace Aula02_Rest_Na_Pratica.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
