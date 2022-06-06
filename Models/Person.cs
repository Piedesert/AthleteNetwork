/*
 * Represents a person returned from the API call
 * 
 */

namespace AthleteNetwork.Models
{
    public class Person
    {
        public Person(){ }

        public string Name { get; private set; }
        public Country Country { get; private set; }

        public Person(string name, Country country)
        {
            Name = name;
            Country = country;
        }
    }
}