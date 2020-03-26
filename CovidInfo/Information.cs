using System.Collections.Generic;
using System.Net;
using Covid.Models;
using Newtonsoft.Json;

namespace Covid
{
    public class Information
    {
        public Latest GetCounters()
        {
            var url = "https://covid19.cryental.dev/v1/latest";

            var webclient = new WebClient();
            var result = webclient.DownloadString(url);

            var parsedObject = JsonConvert.DeserializeObject<LatestModel>(result);

            return parsedObject.Latest;
        }

        public List<Location> GetAllLocations()
        {
            var url = "https://covid19.cryental.dev/v1/locations";

            var webclient = new WebClient();
            var result = webclient.DownloadString(url);

            var parsedObject = JsonConvert.DeserializeObject<LocationsModel>(result);

            return parsedObject.Locations;
        }

        public List<Location> GetByLocation(Countries country)
        {
            var url = "https://covid19.cryental.dev/v1/locations?country_code=" + country;

            var webclient = new WebClient();
            var result = webclient.DownloadString(url);

            var parsedObject = JsonConvert.DeserializeObject<LocationsModel>(result);

            return parsedObject.Locations;
        }
    }
}