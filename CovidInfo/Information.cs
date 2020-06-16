using System.Collections.Generic;
using System.Net;
using Covid.Models;
using Newtonsoft.Json;

namespace Covid
{
    public class Information
    {
        private readonly string _accessKey;

        public Information()
        {
        }

        public Information(string accessKey)
        {
            _accessKey = accessKey;
        }

        public Latest GetCounters()
        {
            var url = "https://cryental.dev/api/covid-status/latest";

            if (string.IsNullOrEmpty(_accessKey))
            {
                url += $"?access_key={_accessKey}";
            }

            var webClient = new WebClient();
            var result = webClient.DownloadString(url);

            try
            {
                var parsedObject = JsonConvert.DeserializeObject<LatestModel>(result);

                return parsedObject.Latest;
            }
            catch
            {
                throw new WebException("The access key is invalid.");
            }
        }

        public List<Location> GetAllLocations()
        {
            var url = "https://cryental.dev/api/covid-status/locations";

            if (string.IsNullOrEmpty(_accessKey))
            {
                url += $"?access_key={_accessKey}";
            }

            var webClient = new WebClient();
            var result = webClient.DownloadString(url);

            try
            {
                var parsedObject = JsonConvert.DeserializeObject<LocationsModel>(result);

                return parsedObject.Locations;
            }
            catch
            {
                throw new WebException("The access key is invalid.");
            }
        }

        public List<Location> GetByLocation(Countries country)
        {
            var url = "https://cryental.dev/api/covid-status/locations?country=" + country;

            if (string.IsNullOrEmpty(_accessKey))
            {
                url += $"&access_key={_accessKey}";
            }

            var webClient = new WebClient();
            var result = webClient.DownloadString(url);

            try
            {
                var parsedObject = JsonConvert.DeserializeObject<LocationsModel>(result);

                return parsedObject.Locations;
            }
            catch
            {
                throw new WebException("The access key is invalid.");
            }
        }
    }
}
