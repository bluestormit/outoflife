using ool_service_people.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ool_service_people.Repositories.Interfaces
{
    public interface IPeopleRepository
    {
        People InsertPeople(People people);
        People UpdatePeolple(People people);
    }
}
