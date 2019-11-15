using ool_service_people.Models;
using ool_service_people.Repositories.Interfaces;
using ool_service_people.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ool_service_people.Services
{
    public class PeoplePersistenceService : IPeoplePersistenceService
    {
        private IPeopleRepository _peopleRepository;

        public PeoplePersistenceService(IPeopleRepository peopleRepository) =>
            this._peopleRepository = peopleRepository;

        public People NewPeople(People People)
        {
            return this._peopleRepository.InsertPeople(People);
        }

        public People UpdatePeople(People People)
        {
            return this._peopleRepository.UpdatePeolple(People);
        }
    }
}
