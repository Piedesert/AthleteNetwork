using AthleteNetwork.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace AthleteNetwork.Services
{
    public class PeopleService
    {
        /*List<Person> People { get; }

        PeopleService()
        {
            People = new List<Person>
            {
                new Person CreateProductAsync
            }
        }*/
        /*public IWebHostEnvironment WebHostEnvironment { get; }

        //private string NationalizeJson => 

        public async IAsyncEnumerable<Person> GetPeopleAsync(string[] names)
        {
            string name;
            string api;
            string url;

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
                    
                    var responseJsonString = await response.Content.ReadAsStringAsync();

                    person = JsonSerializer.Deserialize<Person>(responseJsonString)!;


                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                string[] names;
                api = "https://api.nationalize.io?";

                foreach (var personName in people)
                {
                    name = personName.ToString();
                    names = string.Concat("name[]=" + personName + "&");
                }
                url = string.Format(api, names);
                var endpoint = new Uri(url);

                try
                {
                    Task<HttpResponseMessage> getResponse = httpClient.GetAsync(endpoint);

                    HttpResponseMessage response = await getResponse;
                    var responseJsonString = await response.Content.ReadAsStringAsync();

                    person = JsonSerializer.Deserialize<Person>(responseJsonString)!;

                }
                catch (Exception)
                {
                    throw;
                }
            }

            yield return person;

        }*/

        public async Task Test()
        {
            string errorString;
            Nationalize nick;
            string url = "https://api.nationalize.io?name=Nick";
            using var httpClient = new HttpClient();

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    nick = await response.Content.ReadFromJsonAsync<Nationalize>();
                    errorString = null;
                }
                else
                {
                    errorString = $"There was an error submitting: { response.ReasonPhrase}";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
