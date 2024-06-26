using Trabalho_so2.Model;
using System.Collections.Generic;

namespace Trabalho_so2.Repository

{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);

    }
}