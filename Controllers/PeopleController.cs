using AthleteNetwork.Models;
using AthleteNetwork.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthleteNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public PeopleController(NationalizeService nationalizeService)
        {
            this.NationalizeService = nationalizeService;
        }

        public NationalizeService NationalizeService { get; }

        [HttpGet]
        public IEnumerable<Person> GetPeople(string[] people)
        {
            return (IEnumerable<Person>)NationalizeService.GetPeopleAsync(people);
        }

    }
}
