using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Trabalho_so2.Model;

namespace Trabalho_so2.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
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
                id = IncrementAndGet(),
                first_name = "leandro",
                last_name = "Costa",
                address = "Petropolis - Rio de janeiro",
                gender = "male"
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
                id = IncrementAndGet(),
                first_name = "Person Name" + i,
                last_name = "Person LastName" + i,
                address = "Some Addres" + i,
                gender = "male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

       
    }
}
