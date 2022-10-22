# Pochta SDK

[![Build status](https://github.com/restub/PochtaSdk/actions/workflows/dotnet.yml/badge.svg)](https://github.com/restub/PochtaSdk/actions/workflows/dotnet.yml)
[![.NET Framework 4.6.2](https://img.shields.io/badge/.net-v4.62-yellow)](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net462)
[![.NET 6.0](https://img.shields.io/badge/.net-v6.0-orange)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
[![NuGet](https://img.shields.io/nuget/v/PochtaSdk.svg)](https://www.nuget.org/packages/PochtaSdk)
[![DotNetFiddle](https://img.shields.io/badge/try-online-blue)](https://dotnetfiddle.net/HsS50y)

Pochta.ru REST API client with tracing support.

# Welcome

This is a beta version that covers basic API features.

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
    ObjectType = ObjectType.LetterRegistered,
    FromPostCode = 344038,
    ToPostCode = 115162,
    Weight = 100,
    Date = DateTime.Today,
    Time = DateTime.Now.TimeOfDay,
});

// display server's response
Console.WriteLine(text);
```

## Tariff API support

Documentation: https://tariff.pochta.ru/post-calculator-api.pdf

* CalculateTariff, CalculateDelivery, Calculate (chapter 1)
* GetCategories (chapter 2.3.1)
* GetCategoryDescription (chapter 2.3.2)
* GetObjectTypes, GetObjectType (chapter 2.4)
* GetServices (chapter 2.6)
* GetCountries (chapter 2.7)
* GetPostOffices (chapter 2.8)

## Otpravka API support

Documentation: https://otpravka.pochta.ru/specification

* Authorization: [authorization-token](https://otpravka.pochta.ru/specification#/authorization-token)
* RequestLimits: [nogroup-count_request_api](https://otpravka.pochta.ru/specification#/nogroup-count_request_api)
* Data normalization
  * CleanAddress: [nogroup-normalization_adress](https://otpravka.pochta.ru/specification#/nogroup-normalization_adress)
  * CleanFullName: [nogroup-normalization_fio](https://otpravka.pochta.ru/specification#/nogroup-normalization_fio)
  * CleanPhone: [nogroup-normalization_phone](https://otpravka.pochta.ru/specification#/nogroup-normalization_phone)
* Delivery orders
  * CreateOrders: [orders-creating_order](https://otpravka.pochta.ru/specification#/orders-creating_order)
  * GetOrder: [orders-search_order_byid](https://otpravka.pochta.ru/specification#/orders-search_order_byid)
  * SearchOrders: [orders-search_order](https://otpravka.pochta.ru/specification#/orders-search_order)
  * SearchOrdersByGroupName: [orders-search_orders_by_group_name](https://otpravka.pochta.ru/specification#/orders-search_orders_by_group_name)
  * UpdateOrder: [orders-editing_order](https://otpravka.pochta.ru/specification#/orders-editing_order)
  * DeleteOrders: [orders-delete_new_order](https://otpravka.pochta.ru/specification#/orders-delete_new_order)
* Shipping batches
  * CreateBatch: [batches-create_batch_from_N_orders](https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders)
  * GetBatch: [batches-find_batch](https://otpravka.pochta.ru/specification#/batches-find_batch)
  * ChangeBatchDate: [batches-sending_date](https://otpravka.pochta.ru/specification#/batches-sending_date)
  * RemoveFromBatch: [orders-shipment_to_backlog](https://otpravka.pochta.ru/specification#/orders-shipment_to_backlog)
* Archive
  * GetArchivedBatches: [archive-search_batches](https://otpravka.pochta.ru/specification#/archive-search_batches)
  * ArchiveBatches: [archive-batch_to_archive](https://otpravka.pochta.ru/specification#/archive-batch_to_archive)
  * UnarchiveBatches: [archive-revert_batch](https://otpravka.pochta.ru/specification#/archive-revert_batch)

## Trace log

A typical trace log looks like this:

```c
// Calculate
-> GET https://tariff.pochta.ru/v2/calculate/tariff/delivery?json=json&object=3000&from=344038&to=115162&weight=100&service=&errorcode=1&date=20221006&time=0230
headers: {
  X-ApiClientName = PochtaSdk.TariffClient v0.4.9.1922, restub v0.6.6.4920
  X-ApiMethodName = Calculate
  Accept = application/json, text/json, text/x-json, text/javascript, application/xml, text/xml
}

<- OK 200 (OK) https://tariff.pochta.ru/v2/calculate/tariff/delivery?json=json&object=3000&from=344038&to=115162&weight=100&service=&errorcode=1&date=20221006&time=0230
timings: {
  started: 2022-10-06 02:22:25
  elapsed: 0:00:00.578
}
headers: {
  Connection = keep-alive
  Access-Control-Allow-Origin = *
  Content-Length = 1927
  Content-Type = application/json;charset=utf-8
  Date = Wed, 05 Oct 2022 23:22:27 GMT
  Server = nginx
}
body: {
  "version_api": 2,
  "version": "2.14.1.676",
  "caption": "Расчет тарифов, контрольных сроков доставки",
  "id": 3000,
  "name": "Бандероль простая",
  "mailtype": 3,
  "mailctg": 0,
  "directctg": 1,
  "weight": 100,
  "from": 344038,
  "to": 115162,
  "date": 20221006,
  "time": 23000,
  "date-first": 20220101,
  "delivery-date-first": 20181217,
  "postoffice": [
    {
      "index": 115162,
      "tp": 2,
      "type": 3,
      "typei": 1,
      "name": "МОСКВА 162",
      "regionid": 77,
      "regiono": 45000000,
      "region-main": 1,
      "areao": 45000000,
      "area-main": 1,
      "placeid": 30302,
      "placeo": 45000000,
      "parent": 117950,
      "root": 101700,
      "courier": 130206,
      "pvz": 1,
      "item-check-view": 1,
      "move": 1,
      "weight-max": 20000,
      "pack-max": 99,
      "cutoff": 235900,
      "box": 117997
    },
    {
      "index": 344038,
      "tp": 1,
      "type": 3,
      "typei": 1,
      "name": "РОСТОВ-НА-ДОНУ 38",
      "regionid": 61,
      "regiono": 60701000001,
      "region-main": 1,
      "areao": 60701000001,
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
      "cutoff": 235900,
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
    },
    {
      "id": "5203",
      "name": "Нормативный срок внутренней доставки, группа: Бандероль",
      "serviceon": [
        130,
        111
      ],
      "from": 344038,
      "to": 115162,
      "delivery": {
        "min": 4,
        "max": 4
      }
    },
    {
      "id": "5303",
      "name": "Срок внутренней доставки с учетом расписания работы и обмена, группа: Бандероль",
      "serviceon": [
        132,
        111
      ],
      "to": 115162,
      "delivery": {
        "deadline": "20221010T235900"
      }
    }
  ],
  "delivery-variant": 61,
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
  "delivery": {
    "min": 4,
    "max": 4,
    "deadline": "20221010T235900"
  },
  "place": "C5-d01-8"
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
