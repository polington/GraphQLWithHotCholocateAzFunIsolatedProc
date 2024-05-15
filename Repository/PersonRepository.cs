using Google.Protobuf.WellKnownTypes;
using IsolatedProcessAzFun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedProcessAzFun.Repository
{
    public class PersonRepository
    {
        private List<Person> people = new List<Person>() {
        new Person() { Id = 1, Name = "Polington" },
        new Person() { Id = 2, Name = "Preethi" } };

        public Person GetPerson(int id) { return people.FirstOrDefault(p => p.Id == id) ?? new Person(); }

        public List<Person> GetPersons() { return people; }

        public Person AddPerson(Person person)
        {
            people.Add(person);
            return person;
        }

    }
}
