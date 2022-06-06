/*
 * Represents a person returned from the API call
 * 
 */

namespace AthleteNetwork.Models
{
    public class Person
    {
        private string name;
        private Country country;

        public Person(){ }

        public string Name { get => name; private set => name = value; }
        public Country Country { get => country; private set => country = value; }

        public Person(string name, Country country)
        {
            Name = name;
            Country = country;
        }
    }
}