# sparkiy.WindowsStore.Analytics.Client

[![nuget][nuget-badge]][nuget-url]
[![Build status](https://ci.appveyor.com/api/projects/status/6s85kfxda5uyb0td/branch/master?svg=true)](https://ci.appveyor.com/project/AleksandarDev/sparkiy-windowsstore-analytics-client/branch/master)

Sparkiy Windows Store Analytics API client.

Sample usage:

```

using (var client = new AnalyticsClient())
{
  await client.AuthorizeAsync("<YOUR CLIENT ID>", "<YOUR CLIENT SECRET>");

  // Query fields
  var appID = "<YOUR APP ID>";
  var startDate = DateTime.Parse("01-01-2016");
  var endDate = DateTime.Parse("31-12-2016");
  var pageSize = 100;
  var startPageIndex = 0;

  var result = await client.GetAppAcquisitionsAsync(
    appID, startDate, endDate, pageSize, startPageIndex);

  Console.WriteLine("Got {0} acquisitions.", result.Count());
}

```

#### Get your Client Id and Client Secret

Take a look at this article for more details: [Windows Store analytics API now available](https://blogs.windows.com/buildingapps/2016/03/01/windows-store-analytics-api-now-available/)

[nuget-badge]: https://img.shields.io/badge/nuget-v1.0.0-blue.svg
[nuget-url]: https://www.nuget.org/packages/Sparkiy.WindowsStore.Analytics.Client/
