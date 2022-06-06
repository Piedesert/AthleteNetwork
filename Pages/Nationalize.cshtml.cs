using AthleteNetwork.Controllers;
using AthleteNetwork.Models;
using AthleteNetwork.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AthleteNetwork.Pages
{
    public class NationalizeModel : PageModel
    {
        private NationalizeController nationalizeController;
        public NationalizeService NationalizeService;
        public List<Nationalize> People { get; private set; }
        public NationalizeModel(NationalizeService nationalizeService, NationalizeController nationalizeController)
		{
			NationalizeService = nationalizeService;
			this.nationalizeController = nationalizeController;
			People = new List<Nationalize>();
		}

		public async Task OnGetAsync() => People.Add(await nationalizeController.GetAsync());

		//public async Task OnGetAsync() => await NationalizeService.GetPeopleAsync();

		//public async Task GetAsync() => await NationalizeService.TestAsync();

		//public async Task GetPeopleAsync() => await NationalizeService.GetPeopleAsync(input);

		//public async Task<ActionResult> SubmitAsync(string input) => await nationalizeController.SubmitNamesAsync(input);

	}
}
