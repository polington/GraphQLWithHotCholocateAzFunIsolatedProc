using HotChocolate;
using IsolatedProcessAzFun.Models;
using IsolatedProcessAzFun.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedProcessAzFun
{
    public class QueryRename
    {
        public Person GetPerson(int id, [Service] PersonRepository personRepository) => personRepository.GetPerson(id);

        public List<Person> GetPersons([Service] PersonRepository personRepository) { return personRepository.GetPersons(); }
    }
}
