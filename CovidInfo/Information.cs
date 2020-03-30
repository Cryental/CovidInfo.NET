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
            var url = "https://cryental.dev/api/covid-status/latest";

            var webclient = new WebClient();
            var result = webclient.DownloadString(url);

            var parsedObject = JsonConvert.DeserializeObject<LatestModel>(result);

            return parsedObject.Latest;
        }

        public List<Location> GetAllLocations()
        {
            var url = "https://cryental.dev/api/covid-status/locations";

            var webclient = new WebClient();
            var result = webclient.DownloadString(url);

            var parsedObject = JsonConvert.DeserializeObject<LocationsModel>(result);

            return parsedObject.Locations;
        }

        public List<Location> GetByLocation(Countries country)
        {
            var url = "https://cryental.dev/api/covid-status/locations?country=" + country;

            var webclient = new WebClient();
            var result = webclient.DownloadString(url);

            var parsedObject = JsonConvert.DeserializeObject<LocationsModel>(result);

            return parsedObject.Locations;
        }
    }
}
