using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        PersonModel AddPerson(string name, string surname);
        List<PersonModel> GetPeople();
    }
}