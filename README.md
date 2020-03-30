# CovidInfo.NET
Get Information about COVID-19 using C#

It provides up-to-date data about Coronavirus outbreak using the online database service, includes numbers about confirmed cases, deaths and recovered.

Database provided by https://github.com/CSSEGISandData/COVID-19. 

Online service API by Cryental.

## Usages
```
var info = new Covid.Information();

// Get Latest Counters
var result = info.GetCounters();

// Get All Countries' Counters
var result = info.GetAllLocations();

// Get Specific Country's Counter
var result = info.GetByLocation(Countries.US);
```

If you want to use this with web service, you can query:

```
// Get Latest Counters
https://cryental.dev/api/covid-status/latest

// Get All Countries' Counters
https://cryental.dev/api/covid-status/locations

// Get Specific Country's Counter
https://cryental.dev/api/covid-status/locations?country=us
```


You can use this service without any limitation. 

In case, if your requests are too many and it's blocking other users' requests, your IP can be blocked for 1 hour.
