/*
 * Represents the country that a person belongs to
 * 
 */

using System.Text.Json.Serialization;

namespace AthleteNetwork.Models
{
    public class Country
    {
        [JsonPropertyName("country_id")]
        public string Id { get; private set; }
        public double Probability { get; private set; }
        public Country(string country_id, double probability)
        {
            Id = country_id;
            Probability = probability;
        }
    }
}