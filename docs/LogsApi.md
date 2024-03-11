# Alterian.JO.Api.LogsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LogsTypeTargetClientGet**](LogsApi.md#logstypetargetclientget) | **GET** /logs/{type}/{target}/{client} | Search across logs for this client and target |
| [**LogsTypeTargetClientRulenameGet**](LogsApi.md#logstypetargetclientrulenameget) | **GET** /logs/{type}/{target}/{client}/{rulename} | Get logs that have been recorded for this rule |

<a id="logstypetargetclientget"></a>
# **LogsTypeTargetClientGet**
> LogsApiResponse LogsTypeTargetClientGet (LogType type, TargetEnum target, string varClient, string searchPhrase, string? sequenceNumber = null, string? templateUrl = null, int? limit = null, LogSource? source = null, bool? csv = null, DateTime? startdate = null, DateTime? enddate = null)

Search across logs for this client and target

Provide a search string to search for

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LogsTypeTargetClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LogsApi(config);
            var type = new LogType(); // LogType | What kind of logging do you want to see?
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var searchPhrase = "searchPhrase_example";  // string | The phrase to search for in the logs
            var sequenceNumber = "sequenceNumber_example";  // string? | Sequence Number to identify rule invoke logs (optional) 
            var templateUrl = "templateUrl_example";  // string? | Template url, if you want to filter your request by template url (optional) 
            var limit = 56;  // int? | The maximum number of items to return. (optional) 
            var source = new LogSource?(); // LogSource? | Pick the source of the logs. Currently only elastic search is supported (optional) 
            var csv = true;  // bool? | if true then returns csv file (optional) 
            var startdate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | If you want to filter your request by date range, this is the starting date for the time period,   please provide in ISO-8601 (YYYY-MM-DDThh:mm:ssZ)  All times are UTC. (optional) 
            var enddate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | If you want to filter your request by date range, this is the ending date for the time period, please   provide in ISO-8601 (YYYY-MM-DDThh:mm:ssZ)  All times are UTC. (optional) 

            try
            {
                // Search across logs for this client and target
                LogsApiResponse result = apiInstance.LogsTypeTargetClientGet(type, target, varClient, searchPhrase, sequenceNumber, templateUrl, limit, source, csv, startdate, enddate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogsApi.LogsTypeTargetClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogsTypeTargetClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search across logs for this client and target
    ApiResponse<LogsApiResponse> response = apiInstance.LogsTypeTargetClientGetWithHttpInfo(type, target, varClient, searchPhrase, sequenceNumber, templateUrl, limit, source, csv, startdate, enddate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogsApi.LogsTypeTargetClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | [**LogType**](LogType.md) | What kind of logging do you want to see? |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **searchPhrase** | **string** | The phrase to search for in the logs |  |
| **sequenceNumber** | **string?** | Sequence Number to identify rule invoke logs | [optional]  |
| **templateUrl** | **string?** | Template url, if you want to filter your request by template url | [optional]  |
| **limit** | **int?** | The maximum number of items to return. | [optional]  |
| **source** | [**LogSource?**](LogSource?.md) | Pick the source of the logs. Currently only elastic search is supported | [optional]  |
| **csv** | **bool?** | if true then returns csv file | [optional]  |
| **startdate** | **DateTime?** | If you want to filter your request by date range, this is the starting date for the time period,   please provide in ISO-8601 (YYYY-MM-DDThh:mm:ssZ)  All times are UTC. | [optional]  |
| **enddate** | **DateTime?** | If you want to filter your request by date range, this is the ending date for the time period, please   provide in ISO-8601 (YYYY-MM-DDThh:mm:ssZ)  All times are UTC. | [optional]  |

### Return type

[**LogsApiResponse**](LogsApiResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="logstypetargetclientrulenameget"></a>
# **LogsTypeTargetClientRulenameGet**
> LogsApiResponse LogsTypeTargetClientRulenameGet (LogTypeOrTimeseries type, TargetEnum target, string varClient, string rulename, string? searchPhrase = null, string? searchQuery = null, string? sequenceNumber = null, string? tileName = null, string? tileId = null, string? templateUrl = null, int? limit = null, LogSource? source = null, bool? csv = null, DateTime? startdate = null, DateTime? enddate = null)

Get logs that have been recorded for this rule

If you haven't invoked the rule since you started logging then the writetolog list will always be empty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LogsTypeTargetClientRulenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LogsApi(config);
            var type = new LogTypeOrTimeseries(); // LogTypeOrTimeseries | What kind of logging do you want to see?
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var searchPhrase = "searchPhrase_example";  // string? | The phrase to search for in the logs (optional) 
            var searchQuery = "searchQuery_example";  // string? | Lucene query string to apply (optional) 
            var sequenceNumber = "sequenceNumber_example";  // string? | Sequence Number to identify rule invoke logs (optional) 
            var tileName = "tileName_example";  // string? | The name of the tile, if you want to filter your request by tile name (optional) 
            var tileId = "tileId_example";  // string? | The id of the tile, if you want to filter your request by tile id (optional) 
            var templateUrl = "templateUrl_example";  // string? | Template url, if you want to filter your request by template url (optional) 
            var limit = 56;  // int? | The maximum number of items to return. (optional) 
            var source = new LogSource?(); // LogSource? | Pick the source of the logs. Currently only elastic search is supported (optional) 
            var csv = true;  // bool? | if true then returns csv file (optional) 
            var startdate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | If you want to filter your request by date range, this is the starting date for the time period,   please provide in ISO-8601 (YYYY-MM-DDThh:mm:ssZ)  All times are UTC. (optional) 
            var enddate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | If you want to filter your request by date range, this is the ending date for the time period, please   provide in ISO-8601 (YYYY-MM-DDThh:mm:ssZ)  All times are UTC. (optional) 

            try
            {
                // Get logs that have been recorded for this rule
                LogsApiResponse result = apiInstance.LogsTypeTargetClientRulenameGet(type, target, varClient, rulename, searchPhrase, searchQuery, sequenceNumber, tileName, tileId, templateUrl, limit, source, csv, startdate, enddate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogsApi.LogsTypeTargetClientRulenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogsTypeTargetClientRulenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get logs that have been recorded for this rule
    ApiResponse<LogsApiResponse> response = apiInstance.LogsTypeTargetClientRulenameGetWithHttpInfo(type, target, varClient, rulename, searchPhrase, searchQuery, sequenceNumber, tileName, tileId, templateUrl, limit, source, csv, startdate, enddate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogsApi.LogsTypeTargetClientRulenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | [**LogTypeOrTimeseries**](LogTypeOrTimeseries.md) | What kind of logging do you want to see? |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **rulename** | **string** | Rule name |  |
| **searchPhrase** | **string?** | The phrase to search for in the logs | [optional]  |
| **searchQuery** | **string?** | Lucene query string to apply | [optional]  |
| **sequenceNumber** | **string?** | Sequence Number to identify rule invoke logs | [optional]  |
| **tileName** | **string?** | The name of the tile, if you want to filter your request by tile name | [optional]  |
| **tileId** | **string?** | The id of the tile, if you want to filter your request by tile id | [optional]  |
| **templateUrl** | **string?** | Template url, if you want to filter your request by template url | [optional]  |
| **limit** | **int?** | The maximum number of items to return. | [optional]  |
| **source** | [**LogSource?**](LogSource?.md) | Pick the source of the logs. Currently only elastic search is supported | [optional]  |
| **csv** | **bool?** | if true then returns csv file | [optional]  |
| **startdate** | **DateTime?** | If you want to filter your request by date range, this is the starting date for the time period,   please provide in ISO-8601 (YYYY-MM-DDThh:mm:ssZ)  All times are UTC. | [optional]  |
| **enddate** | **DateTime?** | If you want to filter your request by date range, this is the ending date for the time period, please   provide in ISO-8601 (YYYY-MM-DDThh:mm:ssZ)  All times are UTC. | [optional]  |

### Return type

[**LogsApiResponse**](LogsApiResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

