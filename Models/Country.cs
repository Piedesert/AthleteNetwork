/*
 * Represents the country that a person belongs to
 * 
 */

using System.Text.Json.Serialization;

namespace AthleteNetwork.Models
{
    public class Country
    {
        private string id;
        private double probability;

        [JsonPropertyName("country_id")]
        public string Id { get => id; private set => id = value; }
        public double Probability { get => probability; private set => probability = value; }
        public Country(string country_id, double probability)
        {
            Id = country_id;
            Probability = probability;
        }
    }
}