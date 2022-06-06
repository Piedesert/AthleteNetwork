using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AthleteNetwork.Controllers;
using AthleteNetwork.Models;
using AthleteNetwork.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AthleteNetwork.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public NationalizeService NationalizeService;
        public IEnumerable<Person> People { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            NationalizeService nationalizeService)
        {
            _logger = logger;
            NationalizeService = nationalizeService;
        }

        public void Submit()
        {
            foreach (var person in people.Split(','))
            {
                int num;
                if (int.TryParse(person, out num))
                    yield return num;
            }
            People = PeopleController.GetPeople(people);
        }
    }
}
