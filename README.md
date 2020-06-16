# CovidInfo.NET
Get Information about COVID-19 using C#

https://cryental.dev/services/covid-status/



It provides up-to-date data about Coronavirus outbreak using the online database service, includes numbers about confirmed cases, deaths and recovered.

Database provided by https://github.com/CSSEGISandData/COVID-19. 

Online service API by Cryental.

If too many requests are made your rate will be limited. This is to avoid DDoS attacks or loss of resources. (Current: 5 req / sec, IP based)
You can bypass it by registering an account and use your own access key.

Use access_key parameter to pass your own access key.

## Usages
```
// No Access Key
var info = new Covid.Information();

// With Access Key
var info = new Covid.Information("d71faf7c-2dc4-4405-9381-548b35871b2e");


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
