using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using AthleteNetwork.Models;

namespace AthleteNetwork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NationalizeController : ControllerBase
    {

    }

    static async Task<Uri> Nationalize(string input)
    {
        var api = "https://api.nationalize.io";
        var url = string.Format(api, input);

        using (var httpClient = new HttpClient())
        {
            try
            {
                Task<HttpResponseMessage> getResponse = httpClient.GetAsync(url);

                HttpResponseMessage response = await getResponse;
                var responseJsonString = await response.Content.ReadAsStringAsync();
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}