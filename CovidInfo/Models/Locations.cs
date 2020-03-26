using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Covid.Models
{
    public class Latest
    {
        [JsonProperty("confirmed")] public int Confirmed { get; set; }

        [JsonProperty("deaths")] public int Deaths { get; set; }

        [JsonProperty("recovered")] public int Recovered { get; set; }
    }

    public class Coordinates
    {
        [JsonProperty("latitude")] public string Latitude { get; set; }

        [JsonProperty("longitude")] public string Longitude { get; set; }
    }

    public class Location
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("country_code")] public string CountryCode { get; set; }

        [JsonProperty("country_population")] public int? CountryPopulation { get; set; }

        [JsonProperty("province")] public string Province { get; set; }

        [JsonProperty("last_updated")] public DateTime LastUpdated { get; set; }

        [JsonProperty("coordinates")] public Coordinates Coordinates { get; set; } = new Coordinates();

        [JsonProperty("latest")] public Latest Latest { get; set; } = new Latest();
    }

    public class LocationsModel
    {
        [JsonProperty("latest")] public Latest Latest { get; set; } = new Latest();

        [JsonProperty("locations")] public List<Location> Locations { get; set; } = new List<Location>();
    }
}