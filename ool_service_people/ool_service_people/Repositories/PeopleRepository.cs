using ool_service_people.Models;
using ool_service_people.Repositories.Interfaces;

namespace ool_service_people.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private IMongoAcess _mongoAcess;

        public PeopleRepository(IMongoAcess MongoAcess) =>
            this._mongoAcess = MongoAcess;

        public People InsertPeople(People people) => this._mongoAcess.Insert<People>(people);
        public People UpdatePeolple(People people) => this._mongoAcess.Update<People>(people, t => t.Id == people.Id);
    }
}
