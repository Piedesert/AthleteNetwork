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
        public PeopleController(PeopleService peopleService)
        {
            this.PeopleService = peopleService;
        }

        public async Task<ActionResult> SubmitNames(string input)
        {
            string[] inputs = input.Split(",");
            
            if(inputs.Length == 0 || inputs.Length > 10)
            {
                return Content("Can only submit up to 10 names separated by a comma(,).");
            }

            if(inputs.Length == 1)
            {
                try
                {
                    await PeopleService.Test();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                List<string> names = new List<string>();
                /*this.GetPeople(names);*/

                return Content(input);
            }
            return Content(input);
        }

        public PeopleService PeopleService { get; }

       /* [HttpGet]
        public IEnumerable<Person> GetPeople(List<string> names)
        {
            return (IEnumerable<Person>)PeopleService.GetPeopleAsync(names);
        }
*/

    }
}
