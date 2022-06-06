/*
 * Represents a person returned from the API call
 * 
 */

using System.Collections.Generic;

namespace AthleteNetwork.Models
{
    public class Person
    {
        public string name { get; private set; }
        public List<Country> country { get; private set; }
        
    }
}