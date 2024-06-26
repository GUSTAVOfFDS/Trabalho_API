using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Trabalho_so2.Model;
using Trabalho_so2.Model.Context;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Trabalho_so2.Repository.Implementations
{
    public class PersonRepositoryImplementations : IPersonRepository
    {
        private MySQLContext _context;
        public PersonRepositoryImplementations(MySQLContext context)
        {

            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();

            }
            catch (Exception ex) { throw ex; }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }



        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }
        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return person;

        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}