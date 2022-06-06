using AthleteNetwork.Models;
using AthleteNetwork.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AthleteNetwork.Controllers
{
	[Route("[controller]")]
	[ApiController]
    public class NationalizeController : ControllerBase
    {
        public NationalizeController(NationalizeService nationalizeService)
		{
            this.NationalizeService = nationalizeService;
		}

        public NationalizeService NationalizeService { get; }

		[HttpGet]
        public async Task<List<Nationalize>> GetAsync()
		{
            List<Nationalize> people = new List<Nationalize>();
            people = await NationalizeService.GetPeopleAsync();
            return people;
		}

        /*public async Task<ActionResult> SubmitNamesAsync(string input)
        {
            string[] inputs = input.Split(",");

            if (inputs.Length == 0 || inputs.Length > 10)
            {
                return Content("Can only submit up to 10 names separated by a comma(,).");
            }

            if (inputs.Length == 1)
            {
                try
                {
                    people.Add(await NationalizeService.TestAsync());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                List<string> names = new List<string>(inputs);

                return Content(input);
            }
            return Content(input);
        }*/

        /*[HttpGet]
        public List<Nationalize> Get()
        {
            return people;
        }*/

        /*public int[] RankProbability(List<Nationalize> people)
		{
            people.probability.Sort();
            int lowest = people.GetLast;
            //people.FindIndex(people.Count);
            int highest = people.GetFirst;

            return [highest, lowest];
		}*/
    }
}
