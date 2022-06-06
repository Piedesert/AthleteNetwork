namespace AthleteNetwork.Models
{
    public class Nationalize
    {

        public class Person
        {
            public string name { get; set; }
            public Country[] country { get; set; }
        }

        public class Country
        {
            public string country_id { get; set; }
            public float probability { get; set; }
        }

    }
}
