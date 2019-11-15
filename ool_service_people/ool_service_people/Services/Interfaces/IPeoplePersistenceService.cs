using ool_service_people.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ool_service_people.Services.Interfaces
{
    public interface IPeoplePersistenceService
    {
        People NewPeople(People People);
        People UpdatePeople(People People);
    }
}
