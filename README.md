# Pochta SDK

[![.NET Framework 4.62](https://img.shields.io/badge/.net-v4.62-yellow)](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net462)
[![.NET 6.0](https://img.shields.io/badge/.net-v6.0-orange)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Pochta.ru REST API client with tracing support.

# Welcome

TODO

## Getting started

TODO

## Sample usage

```c#
// TODO
var client = new GithubClient();

// trace all API calls to the console
client.Tracer = Console.WriteLine;

// get user's organizations
var orgs = client.GetUserOrgs("yallie");
```

<details>
  <summary>A typical trace log looks like this:</summary>
    
```c
// GetAuthToken
-> POST https://api.edu.cdek.ru/v2/oauth/token?parameters
headers: {
  X-ApiClientName = restub v0.1.6.37278
  X-ApiMethodName = GetAuthToken
  Accept = application/json, text/json, text/x-json, text/javascript, application/xml, text/xml
  Content-type = application/json
}
body: null

<- OK 200 (OK) https://api.edu.cdek.ru/v2/oauth/token?parameters
timings: {
  started: 2022-09-23 19:51:16
  elapsed: 0:00:00.719
}
headers: {
  Transfer-Encoding = chunked
  Connection = keep-alive
  Keep-Alive = timeout=15
  Vary = Accept-Encoding
  Pragma = no-cache
  X-Content-Type-Options = nosniff
  X-XSS-Protection = 1; mode=block
  X-Frame-Options = DENY
  Content-Encoding = 
  Cache-Control = no-store
  Content-Type = application/json;charset=utf-8
  Date = Fri, 23 Sep 2022 16:51:18 GMT
  Server = QRATOR
}
body: {
  "access_token": "eyJhbGciOiJSUzI1Ni....eq62ZCji34UPjozvWCUXv16ZvTA",
  "token_type": "bearer",
  "expires_in": 3599,
  "scope": "order:all payment:all",
  "jti": "be19866f-0d95-4287-b1ff-cad84e113c3c"
}

// GetRegions
-> GET https://api.edu.cdek.ru/v2/location/regions?size=3&page=2
headers: {
  X-ApiClientName = restub v0.1.6.37278
  X-ApiMethodName = GetRegions
  Authorization = Bearer eyJhbGciOiJSUzI1Ni....eq62ZCji34UPjozvWCUXv16ZvTA
  Accept = application/json, text/json, text/x-json, text/javascript, application/xml, text/xml
}

<- OK 200 (OK) https://api.edu.cdek.ru/v2/location/regions?size=3&page=2
timings: {
  started: 2022-09-23 19:55:56
  elapsed: 0:00:00.859
}
headers: {
  Transfer-Encoding = chunked
  Connection = keep-alive
  Keep-Alive = timeout=15
  Vary = Accept-Encoding
  X-Content-Type-Options = nosniff
  X-XSS-Protection = 1; mode=block
  Pragma = no-cache
  X-Frame-Options = DENY
  Content-Encoding = 
  Cache-Control = no-cache, no-store, max-age=0, must-revalidate
  Content-Type = application/json
  Date = Fri, 23 Sep 2022 16:55:58 GMT
  Expires = 0
  Server = QRATOR
}
body: [
  {
    "country_code": "FR",
    "country": "Франция",
    "region": "Марна",
    "region_code": 590
  },
  {
    "country_code": "JP",
    "country": "Япония",
    "region": "Фукусима",
    "region_code": 855
  },
  {
    "country_code": "FR",
    "country": "Франция",
    "region": "Ло и Гаронна",
    "region_code": 560
  }
]

// GetRegions
-> GET https://api.edu.cdek.ru/v2/location/regions?page=3
headers: {
  X-ApiClientName = restub v0.1.6.37278
  X-ApiMethodName = GetRegions
  Authorization = Bearer eyJhbGciOiJSUzI1Ni....eq62ZCji34UPjozvWCUXv16ZvTA
  Accept = application/json, text/json, text/x-json, text/javascript, application/xml, text/xml
}

<- ERROR 400 (BadRequest) https://api.edu.cdek.ru/v2/location/regions?page=3
timings: {
  started: 2022-09-23 19:51:17
  elapsed: 0:00:00.078
}
headers: {
  Transfer-Encoding = chunked
  Connection = keep-alive
  Keep-Alive = timeout=15
  X-Content-Type-Options = nosniff
  X-XSS-Protection = 1; mode=block
  Pragma = no-cache
  X-Frame-Options = DENY
  Cache-Control = no-cache, no-store, max-age=0, must-revalidate
  Content-Type = application/json
  Date = Fri, 23 Sep 2022 16:51:19 GMT
  Expires = 0
  Server = QRATOR
}
body: {
  "errors": [
    {
      "code": "v2_field_is_empty",
      "message": "[size] is empty"
    }
  ]
}
```
</details>

# PochtaSdk versioning

The project uses [Nerdbank.GitVersioning](https://github.com/dotnet/Nerdbank.GitVersioning) tool to manage versions.  
Each library build can be traced back to the original git commit.

## Preparing and publishing a new release

1. Make sure that `nbgv` dotnet CLI tool is installed and is up to date
2. Run `nbgv prepare-release` to create a stable branch for the upcoming release, i.e. release/v1.0
3. Switch to the release branch: `git checkout release/v1.0`
4. Execute unit tests, update the README, etc. Commit and push your changes.
5. Run `dotnet pack -c Release` and check that it builds Nuget packages with the right version number.
6. Run `nbgv tag release/v1.0` to tag the last commit on the release branch with your current version number, i.e. v1.0.7.
7. Push tags as suggested by nbgv tool: `git push origin v1.0.7`
8. Go to github project page and create a release out of the last tag v1.0.7.
9. Verify that github workflow for publishing the nuget package has completed.
10. Switch back to master and merge the release branch.
