using AthleteNetwork.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace AthleteNetwork.Services
{
    public class NationalizeService
    {
        static List<Nationalize> People { get; }

        public async Task<List<Nationalize>> GetPeopleAsync()
        {
            await TestAsync();
            return People;
        }

        public async Task<Nationalize> TestAsync()
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
                    errorString = $"There was an error submitting: {response.ReasonPhrase}";
                    return null;
                }
                People.Add(nick);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /*public async Task<List<Nationalize>> GetPeopleAsync(string[] names)
        {
            string url;
            string api;

            List<Nationalize> people = new List<Nationalize>();
            using var httpClient = new HttpClient();

            if (names.Length == 1)
            {
                url = "https://api.nationalize.io?name=" + names[0].ToString();

                var endpoint = new Uri(url);

                try
                {
                    Task<HttpResponseMessage> getResponse = httpClient.GetAsync(endpoint);

                    HttpResponseMessage response = await getResponse;

                    var responseJsonString = await response.Content.ReadAsStringAsync();

                    people = JsonSerializer.Deserialize<List<Nationalize>>(responseJsonString)!;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                yield return people;
            }
            else
            {
                api = "https://api.nationalize.io?";

                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(names[]));
                url = string.Format(api, names);
                var endpoint = new Uri(url);

                try
                {
                    Task<HttpResponseMessage> getResponse = httpClient.GetAsync(endpoint);

                    HttpResponseMessage response = await getResponse;
                    var responseJsonString = await response.Content.ReadAsStringAsync();

                    people = JsonSerializer.Deserialize<List<Nationalize>>(responseJsonString)!;

                }
                catch (Exception)
                {
                    throw;
                }
            }
            yield return people;

        }*/

    }
}
