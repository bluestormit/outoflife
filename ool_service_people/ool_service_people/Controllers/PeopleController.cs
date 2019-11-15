using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ool_service_people.Models;
using ool_service_people.Services;
using ool_service_people.Services.Interfaces;

namespace ool_service_people.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeoplePersistenceService _peoplePersistenceService;

        public PeopleController(IPeoplePersistenceService peoplePersistenceService) =>
            this._peoplePersistenceService = peoplePersistenceService;

        [HttpPost]
        public People NewPeople([FromBody] People people) =>
            this._peoplePersistenceService.NewPeople(people);

        [HttpPut]
        public People UpdatePeople([FromBody] People people) =>
            this._peoplePersistenceService.UpdatePeople(people);

    }
}