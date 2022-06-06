using AthleteNetwork.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AthleteNetwork.Services
{
    public class NationalizeService
    {
        public NationalizeService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        //private string NationalizeJson => 

        public async IAsyncEnumerable<Person> GetPeopleAsync(string[] people)
        {
            string name;
            string api;
            string url;
            string responseJsonString;

            Person person = new Person();
            using var httpClient = new HttpClient();

            if (people.Length == 1)
            {
                name = people[0].ToString();

                api = "https://api.nationalize.io?name=";
                url = string.Format(api, name);

                var endpoint = new Uri(url);

                try
                {
                    Task<HttpResponseMessage> getResponse = httpClient.GetAsync(endpoint);

                    HttpResponseMessage response = await getResponse;
                    if (response.IsSuccessStatusCode)
                    {
                        responseJsonString = await response.Content.ReadAsStringAsync();
                    }

                    person = JsonSerializer.Deserialize<Person>(responseJsonString)!;


                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                foreach (var personName in people)
                {
                    name = personName.ToString();

                    api = "https://api.nationalize.io?name=";
                    url = string.Format(api, name);

                    var endpoint = new Uri(url);

                    try
                    {
                        Task<HttpResponseMessage> getResponse = httpClient.GetAsync(endpoint);

                        HttpResponseMessage response = await getResponse;
                        responseJsonString = await response.Content.ReadAsStringAsync();

                        person = JsonSerializer.Deserialize<Person>(responseJsonString)!;

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            yield return person;

        }

        static async Task<Uri> CreateProductAsync(Person person)
        {
            using var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.PostAsync(
                "api/products", );
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}
