using Trabalho_so2.Model;
using Trabalho_so2.Repository;

namespace Trabalho_so2.Business.Implementations
{
    public class PersonBusinessImplementations : IPersonBusiness
    {
        private readonly IPersonRepository _repository;
        public PersonBusinessImplementations(IPersonRepository repository) { 

            _repository = repository;
        }

        public Person Create(Person person)
        {
            
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
             _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
          return _repository.FindAll();  
        }



        public Person FindById(long id)
        {
            return _repository.FindById(id);
           }
        public Person Update(Person person)
        {
            return _repository.Update(person);

        }

       
    }
}
