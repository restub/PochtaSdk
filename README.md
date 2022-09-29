# Pochta SDK

[![Build status](https://github.com/restub/PochtaSdk/actions/workflows/dotnet.yml/badge.svg)](https://github.com/restub/PochtaSdk/actions/workflows/dotnet.yml)
[![.NET Framework 4.6.2](https://img.shields.io/badge/.net-v4.62-yellow)](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net462)
[![.NET 6.0](https://img.shields.io/badge/.net-v6.0-orange)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
[![NuGet](https://img.shields.io/nuget/v/PochtaSdk.svg)](https://www.nuget.org/packages/PochtaSdk)
[![DotNetFiddle](https://img.shields.io/badge/try-online-blue)](https://dotnetfiddle.net/HsS50y)

Pochta.ru REST API client with tracing support.

# Welcome

This is an early beta version that covers only very basic API features.

## Getting started

* Add the Nuget package: https://www.nuget.org/packages/PochtaSdk
* Use `TariffClient` class to calculate delivery tariffs and terms
* Use `OtpravkaClient` class to register packages (requires authentication)

## Sample usage

Try online: https://dotnetfiddle.net/HsS50y

```c#
var client = new TariffClient();

// optional: trace API calls to the console
// client.Tracer = Console.WriteLine;

// calculate tariff and display as plain text
var text = client.CalculateTariff(ResponseFormat.Text, new TariffRequest
{
	Object = ObjectType.WrapperRegular,
	FromPostCode = 344038,
	ToPostCode = 115162,
	Weight = 100,
	Date = DateTime.Today,
	Time = DateTime.Now.TimeOfDay,
});

// display server's response
Console.WriteLine(text);
```

## Trace log

A typical trace log looks like this:
    
```c
// Calculate
-> GET https://tariff.pochta.ru/v2/calculate/tariff?json=&object=3000&from=344038&to=115162&weight=100&closed=1&date=2022-09-26T10:37:58%2b03:00&time=0223
headers: {
  X-ApiClientName = restub v0.3.6.25927
  X-ApiMethodName = Calculate
  Accept = application/json, text/json, text/x-json, text/javascript, application/xml, text/xml
}

<- OK 200 (OK) https://tariff.pochta.ru/v2/calculate/tariff?json=&object=3000&from=344038&to=115162&weight=100&closed=1&date=2022-09-26T10:37:58%2b03:00&time=0223
timings: {
  started: 2022-09-26 10:37:58
  elapsed: 0:00:00.703
}
headers: {
  Connection = keep-alive
  Access-Control-Allow-Origin = *
  Content-Length = 921
  Content-Type = application/json;charset=utf-8
  Date = Mon, 26 Sep 2022 07:37:58 GMT
  Server = nginx
}
body: {
  "version_api": 2,
  "version": "2.14.1.675",
  "caption": "Расчет тарифов",
  "id": 3000,
  "name": "Бандероль простая",
  "mailtype": 3,
  "mailctg": 0,
  "directctg": 1,
  "weight": 100,
  "date": 20220926,
  "time": 22300,
  "date-first": 20220101,
  "postoffice": [
    {
      "index": 344038,
      "tp": 1,
      "type": 3,
      "typei": 1,
      "name": "РОСТОВ-НА-ДОНУ 38",
      "regionid": 61,
      "regiono": 60701000001,
      "region-main": 1,
      "area-main": 1,
      "placeid": 39771,
      "placeo": 60701000001,
      "parent": 344999,
      "root": 344700,
      "courier": 344880,
      "pvz": 1,
      "item-check-view": 1,
      "move": 1,
      "weight-max": 20000,
      "pack-max": 99,
      "box": 344038
    }
  ],
  "transtype": 1,
  "transname": "наземно",
  "items": [
    {
      "id": "3173",
      "name": "Пересылка простой бандероли",
      "serviceon": [
        110,
        11
      ],
      "serviceoff": [
        53,
        57
      ],
      "tariff": {
        "val": 4200,
        "valnds": 5040,
        "valmark": 4200
      }
    }
  ],
  "ground": {
    "val": 4200,
    "valnds": 5040,
    "valmark": 4200
  },
  "paymark": 4200,
  "pay": 4200,
  "paynds": 5040,
  "ndsrate": 20,
  "nds": 840,
  "place": "C5-r00-7"
}
```

# PochtaSdk versioning

The project uses [Nerdbank.GitVersioning](https://github.com/dotnet/Nerdbank.GitVersioning) tool to manage versions.  
Each library build can be traced back to the original git commit.

## Preparing and publishing a new release

1. Make sure that `nbgv` dotnet CLI tool is installed and is up to date
2. Run `nbgv prepare-release` to create a stable branch for the upcoming release, i.e. release/v1.0
3. Switch to the release branch: `git checkout release/v1.0`
4. Execute unit tests, update the README, release notes in csproj file, etc. Commit and push your changes.
5. Run `dotnet pack -c Release` and check that it builds Nuget packages with the right version number.
6. Run `nbgv tag release/v1.0` to tag the last commit on the release branch with your current version number, i.e. v1.0.7.
7. Push tags as suggested by nbgv tool: `git push origin v1.0.7`
8. Go to github project page and create a release out of the last tag v1.0.7.
9. Verify that github workflow for publishing the nuget package has completed.
10. Switch back to master and merge the release branch.
