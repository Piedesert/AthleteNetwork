using AthleteNetwork.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        private string NationalizeJson => Path.Combine(IWebHostEnvironment.WebRootPath, "data", "people.json");

        public IEnumerable<Person> GetPeople()
        {
            //string responseJsonString = ;//json return from user input
            Person person = JsonSerializer.Deserialize<Person[]>(responseJsonString)!;
            yield return person;
        }
    }
}
