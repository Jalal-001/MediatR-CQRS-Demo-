using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        List<PersonModel> people = new();
        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, Name = "Jalal", Surname = "Khaligov" });
            people.Add(new PersonModel { Id = 1, Name = "Khayal", Surname = "Mammedov" });
        }
        public List<PersonModel> getPeople()
        {
            return people;
        }
        public PersonModel AddPerson(string name, string surname)
        {
            var person = new PersonModel { Name = name, Surname = surname };
            person.Id = people.Max(x => x.Id + 1);
            people.Add(person);
            return person;
        }
    }
}
