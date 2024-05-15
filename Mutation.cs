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
    public class Mutation
    {
        public async Task<Person> AddPerson(Person person, [Service] PersonRepository personRepository)
        {
            personRepository.AddPerson(person);
            return person;
        }
    }
}
