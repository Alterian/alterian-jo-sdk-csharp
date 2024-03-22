# Alterian.JO.Api.InfoApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InfoAuditlogClientGet**](InfoApi.md#infoauditlogclientget) | **GET** /info/auditlog/{client} | Get audit log report |
| [**InfoCachedataClientGet**](InfoApi.md#infocachedataclientget) | **GET** /info/cachedata/{client} | Get cache data report |
| [**InfoCacheunusedcolumnsClientGet**](InfoApi.md#infocacheunusedcolumnsclientget) | **GET** /info/cacheunusedcolumns/{client} | Get a report on all the cache columns that are no longer used by any rules |
| [**InfoClientaccessreportClientGet**](InfoApi.md#infoclientaccessreportclientget) | **GET** /info/clientaccessreport/{client} | Report on the users able to access given client |
| [**InfoConsistencyreportGet**](InfoApi.md#infoconsistencyreportget) | **GET** /info/consistencyreport | Get the consistency report |
| [**InfoConversationusagereportClientTimeseriesGet**](InfoApi.md#infoconversationusagereportclienttimeseriesget) | **GET** /info/conversationusagereport/{client}/{timeseries} | Report on the conversation usage by a specific client |
| [**InfoFieldusageTargetClientRulenameGet**](InfoApi.md#infofieldusagetargetclientrulenameget) | **GET** /info/fieldusage/{target}/{client}/{rulename} | Report on how fields are created, read and written within a rule |
| [**InfoFlowTargetClientRulenameGet**](InfoApi.md#infoflowtargetclientrulenameget) | **GET** /info/flow/{target}/{client}/{rulename} | Get the JSON representation of the steps within a rule, suitable for displaying as a flowchart |
| [**InfoGlobalparamreportClientGet**](InfoApi.md#infoglobalparamreportclientget) | **GET** /info/globalparamreport/{client} | Get report on global parameters |
| [**InfoInternalrulecallreportClientTargetRulenameGet**](InfoApi.md#infointernalrulecallreportclienttargetrulenameget) | **GET** /info/internalrulecallreport/{client}/{target}/{rulename} | For a given rule, find all the rules that call this rule internally |
| [**InfoLogged404sClientGet**](InfoApi.md#infologged404sclientget) | **GET** /info/logged404s/{client} | Get report on logged 404 errors |
| [**InfoResourceexistsreportPost**](InfoApi.md#inforesourceexistsreportpost) | **POST** /info/resourceexistsreport | Pass in an array of any size containing resource URL&#39;s (rules, templates, etc) to see if they exist and can be accessed by this user. |
| [**InfoRulecomplexityreportClientGet**](InfoApi.md#inforulecomplexityreportclientget) | **GET** /info/rulecomplexityreport/{client} | Report on the complexity of the various rules for a client |
| [**InfoSnoozeGet**](InfoApi.md#infosnoozeget) | **GET** /info/snooze | Report on whether rules can be snoozed |
| [**InfoSteptypestatisticsDelete**](InfoApi.md#infosteptypestatisticsdelete) | **DELETE** /info/steptypestatistics | Clear the execution statistics histogram for all step types |
| [**InfoSteptypestatisticsGet**](InfoApi.md#infosteptypestatisticsget) | **GET** /info/steptypestatistics | Find out the execution statistics histogram for each step type |
| [**InfoSteptypeusagereportClientGet**](InfoApi.md#infosteptypeusagereportclientget) | **GET** /info/steptypeusagereport/{client} | Report on the steps being used by this client |
| [**InfoStepusagereportClientStepnameGet**](InfoApi.md#infostepusagereportclientstepnameget) | **GET** /info/stepusagereport/{client}/{stepname} | Find out which rules are using a specific step type |
| [**InfoTemplatecolumnreportClientGet**](InfoApi.md#infotemplatecolumnreportclientget) | **GET** /info/templatecolumnreport/{client} | Report on the names of the columns in the cache used by templates |
| [**InfoTemplateinputreportClientGet**](InfoApi.md#infotemplateinputreportclientget) | **GET** /info/templateinputreport/{client} | List all templates that expect given input fields |
| [**InfoTemplateusagereportClientTemplatenameGet**](InfoApi.md#infotemplateusagereportclienttemplatenameget) | **GET** /info/templateusagereport/{client}/{templatename} | Find a list of rules which use a specific template |
| [**InfoTemplatevalidityreportClientGet**](InfoApi.md#infotemplatevalidityreportclientget) | **GET** /info/templatevalidityreport/{client} | Reports on validity of uploaded templates |
| [**InfoTokenusereportGet**](InfoApi.md#infotokenusereportget) | **GET** /info/tokenusereport | Reports on token access and last used date. |
| [**InfoWorkerthreadusageGet**](InfoApi.md#infoworkerthreadusageget) | **GET** /info/workerthreadusage | Worker thread usage |

<a id="infoauditlogclientget"></a>
# **InfoAuditlogClientGet**
> AuditLogReportResponse InfoAuditlogClientGet (string varClient, int? from = null, int? to = null, TargetEnum? target = null, CsvEnum? format = null)

Get audit log report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoAuditlogClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Client name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get audit log report
                AuditLogReportResponse result = apiInstance.InfoAuditlogClientGet(varClient, from, to, target, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoAuditlogClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoAuditlogClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get audit log report
    ApiResponse<AuditLogReportResponse> response = apiInstance.InfoAuditlogClientGetWithHttpInfo(varClient, from, to, target, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoAuditlogClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**AuditLogReportResponse**](AuditLogReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infocachedataclientget"></a>
# **InfoCachedataClientGet**
> CacheDataReportResponse InfoCachedataClientGet (string? varClient = null, int? from = null, int? to = null, TargetEnum? target = null, string? rulename = null, CacheDirectionEnum? cachedirection = null, CsvEnum? format = null)

Get cache data report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoCachedataClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string? | Client name (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var rulename = "rulename_example";  // string? | Filter for specific rule name (optional) 
            var cachedirection = new CacheDirectionEnum?(); // CacheDirectionEnum? | Get only cache read or writes (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get cache data report
                CacheDataReportResponse result = apiInstance.InfoCachedataClientGet(varClient, from, to, target, rulename, cachedirection, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoCachedataClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoCachedataClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get cache data report
    ApiResponse<CacheDataReportResponse> response = apiInstance.InfoCachedataClientGetWithHttpInfo(varClient, from, to, target, rulename, cachedirection, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoCachedataClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string?** | Client name | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **rulename** | **string?** | Filter for specific rule name | [optional]  |
| **cachedirection** | [**CacheDirectionEnum?**](CacheDirectionEnum?.md) | Get only cache read or writes | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**CacheDataReportResponse**](CacheDataReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infocacheunusedcolumnsclientget"></a>
# **InfoCacheunusedcolumnsClientGet**
> CacheUnusedColumnsReportResponse InfoCacheunusedcolumnsClientGet (string varClient, int? from = null, int? to = null, TargetEnum? target = null, CsvEnum? format = null)

Get a report on all the cache columns that are no longer used by any rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoCacheunusedcolumnsClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Client name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get a report on all the cache columns that are no longer used by any rules
                CacheUnusedColumnsReportResponse result = apiInstance.InfoCacheunusedcolumnsClientGet(varClient, from, to, target, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoCacheunusedcolumnsClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoCacheunusedcolumnsClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a report on all the cache columns that are no longer used by any rules
    ApiResponse<CacheUnusedColumnsReportResponse> response = apiInstance.InfoCacheunusedcolumnsClientGetWithHttpInfo(varClient, from, to, target, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoCacheunusedcolumnsClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**CacheUnusedColumnsReportResponse**](CacheUnusedColumnsReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infoclientaccessreportclientget"></a>
# **InfoClientaccessreportClientGet**
> ClientAccessReportResponse InfoClientaccessreportClientGet (string varClient, bool? includeClientAll = null, bool? includePermissionAll = null, CsvEnum? format = null)

Report on the users able to access given client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoClientaccessreportClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Which client would you like the report for? You must be able to access this client   to report on it.
            var includeClientAll = true;  // bool? | Should users with access to all clients be included (optional)  (default to true)
            var includePermissionAll = true;  // bool? | Should users with permission ALL be included (optional)  (default to true)
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on the users able to access given client
                ClientAccessReportResponse result = apiInstance.InfoClientaccessreportClientGet(varClient, includeClientAll, includePermissionAll, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoClientaccessreportClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoClientaccessreportClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report on the users able to access given client
    ApiResponse<ClientAccessReportResponse> response = apiInstance.InfoClientaccessreportClientGetWithHttpInfo(varClient, includeClientAll, includePermissionAll, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoClientaccessreportClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Which client would you like the report for? You must be able to access this client   to report on it. |  |
| **includeClientAll** | **bool?** | Should users with access to all clients be included | [optional] [default to true] |
| **includePermissionAll** | **bool?** | Should users with permission ALL be included | [optional] [default to true] |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**ClientAccessReportResponse**](ClientAccessReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infoconsistencyreportget"></a>
# **InfoConsistencyreportGet**
> ConsistencyReportResponse InfoConsistencyreportGet (int? from = null, int? to = null, CsvEnum? format = null)

Get the consistency report

Compares this nodes resources with other nodes to see if node has latest information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoConsistencyreportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get the consistency report
                ConsistencyReportResponse result = apiInstance.InfoConsistencyreportGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoConsistencyreportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoConsistencyreportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the consistency report
    ApiResponse<ConsistencyReportResponse> response = apiInstance.InfoConsistencyreportGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoConsistencyreportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**ConsistencyReportResponse**](ConsistencyReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infoconversationusagereportclienttimeseriesget"></a>
# **InfoConversationusagereportClientTimeseriesGet**
> ConversationUsageReportResponse InfoConversationusagereportClientTimeseriesGet (string varClient, Timeseries timeseries, CsvEnum? format = null)

Report on the conversation usage by a specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoConversationusagereportClientTimeseriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Which client would you like the report for? You must be able to access this client   to report on it.
            var timeseries = new Timeseries(); // Timeseries | Report on either the last 60 minutes, the last 48 hours or the last 60 days
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on the conversation usage by a specific client
                ConversationUsageReportResponse result = apiInstance.InfoConversationusagereportClientTimeseriesGet(varClient, timeseries, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoConversationusagereportClientTimeseriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoConversationusagereportClientTimeseriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report on the conversation usage by a specific client
    ApiResponse<ConversationUsageReportResponse> response = apiInstance.InfoConversationusagereportClientTimeseriesGetWithHttpInfo(varClient, timeseries, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoConversationusagereportClientTimeseriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Which client would you like the report for? You must be able to access this client   to report on it. |  |
| **timeseries** | [**Timeseries**](Timeseries.md) | Report on either the last 60 minutes, the last 48 hours or the last 60 days |  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**ConversationUsageReportResponse**](ConversationUsageReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infofieldusagetargetclientrulenameget"></a>
# **InfoFieldusageTargetClientRulenameGet**
> FieldUsageReportResponse InfoFieldusageTargetClientRulenameGet (TargetEnum target, string varClient, string rulename, int? from = null, int? to = null, CsvEnum? format = null, bool? mergefields = null)

Report on how fields are created, read and written within a rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoFieldusageTargetClientRulenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 
            var mergefields = false;  // bool? | Should fields that have been renamed be merged together? (optional)  (default to false)

            try
            {
                // Report on how fields are created, read and written within a rule
                FieldUsageReportResponse result = apiInstance.InfoFieldusageTargetClientRulenameGet(target, varClient, rulename, from, to, format, mergefields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoFieldusageTargetClientRulenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoFieldusageTargetClientRulenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report on how fields are created, read and written within a rule
    ApiResponse<FieldUsageReportResponse> response = apiInstance.InfoFieldusageTargetClientRulenameGetWithHttpInfo(target, varClient, rulename, from, to, format, mergefields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoFieldusageTargetClientRulenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **rulename** | **string** | Rule name |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |
| **mergefields** | **bool?** | Should fields that have been renamed be merged together? | [optional] [default to false] |

### Return type

[**FieldUsageReportResponse**](FieldUsageReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infoflowtargetclientrulenameget"></a>
# **InfoFlowTargetClientRulenameGet**
> FlowReportResponse InfoFlowTargetClientRulenameGet (TargetEnum target, string varClient, string rulename)

Get the JSON representation of the steps within a rule, suitable for displaying as a flowchart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoFlowTargetClientRulenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Get the JSON representation of the steps within a rule, suitable for displaying as a flowchart
                FlowReportResponse result = apiInstance.InfoFlowTargetClientRulenameGet(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoFlowTargetClientRulenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoFlowTargetClientRulenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the JSON representation of the steps within a rule, suitable for displaying as a flowchart
    ApiResponse<FlowReportResponse> response = apiInstance.InfoFlowTargetClientRulenameGetWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoFlowTargetClientRulenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **rulename** | **string** | Rule name |  |

### Return type

[**FlowReportResponse**](FlowReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infoglobalparamreportclientget"></a>
# **InfoGlobalparamreportClientGet**
> GlobalParameterReportResponse InfoGlobalparamreportClientGet (string? varClient = null, int? from = null, int? to = null, string? parameterName = null, string? parameterValue = null, bool? onlyGlobalParameters = null, bool? includeParameterDetails = null, CsvEnum? format = null)

Get report on global parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoGlobalparamreportClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string? | Client name (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var parameterName = "parameterName_example";  // string? | Get the report for a specific parameter (optional) 
            var parameterValue = "parameterValue_example";  // string? | Get the report for a specific parameter's value (optional) 
            var onlyGlobalParameters = true;  // bool? | Only include global parameters. When false will also list rules that would use global parameter if   one with given name was created (optional) 
            var includeParameterDetails = true;  // bool? | When listing rules using global parameters, should we also list all the parameters used in the rule. If not provided then true (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get report on global parameters
                GlobalParameterReportResponse result = apiInstance.InfoGlobalparamreportClientGet(varClient, from, to, parameterName, parameterValue, onlyGlobalParameters, includeParameterDetails, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoGlobalparamreportClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoGlobalparamreportClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get report on global parameters
    ApiResponse<GlobalParameterReportResponse> response = apiInstance.InfoGlobalparamreportClientGetWithHttpInfo(varClient, from, to, parameterName, parameterValue, onlyGlobalParameters, includeParameterDetails, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoGlobalparamreportClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string?** | Client name | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **parameterName** | **string?** | Get the report for a specific parameter | [optional]  |
| **parameterValue** | **string?** | Get the report for a specific parameter&#39;s value | [optional]  |
| **onlyGlobalParameters** | **bool?** | Only include global parameters. When false will also list rules that would use global parameter if   one with given name was created | [optional]  |
| **includeParameterDetails** | **bool?** | When listing rules using global parameters, should we also list all the parameters used in the rule. If not provided then true | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**GlobalParameterReportResponse**](GlobalParameterReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infointernalrulecallreportclienttargetrulenameget"></a>
# **InfoInternalrulecallreportClientTargetRulenameGet**
> InternalRuleCallReportResponse InfoInternalrulecallreportClientTargetRulenameGet (string varClient, TargetEnum target, string rulename, CsvEnum? format = null)

For a given rule, find all the rules that call this rule internally

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoInternalrulecallreportClientTargetRulenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var rulename = "rulename_example";  // string | Rule name
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // For a given rule, find all the rules that call this rule internally
                InternalRuleCallReportResponse result = apiInstance.InfoInternalrulecallreportClientTargetRulenameGet(varClient, target, rulename, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoInternalrulecallreportClientTargetRulenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoInternalrulecallreportClientTargetRulenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // For a given rule, find all the rules that call this rule internally
    ApiResponse<InternalRuleCallReportResponse> response = apiInstance.InfoInternalrulecallreportClientTargetRulenameGetWithHttpInfo(varClient, target, rulename, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoInternalrulecallreportClientTargetRulenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **rulename** | **string** | Rule name |  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**InternalRuleCallReportResponse**](InternalRuleCallReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infologged404sclientget"></a>
# **InfoLogged404sClientGet**
> Logged404sReportResponse InfoLogged404sClientGet (string? varClient = null, int? from = null, int? to = null, int? limit = null, CsvEnum? format = null)

Get report on logged 404 errors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoLogged404sClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string? | Client name (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var limit = 56;  // int? | Limit the number of results returned. By default set to 100 when not provided. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get report on logged 404 errors
                Logged404sReportResponse result = apiInstance.InfoLogged404sClientGet(varClient, from, to, limit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoLogged404sClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoLogged404sClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get report on logged 404 errors
    ApiResponse<Logged404sReportResponse> response = apiInstance.InfoLogged404sClientGetWithHttpInfo(varClient, from, to, limit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoLogged404sClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string?** | Client name | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **limit** | **int?** | Limit the number of results returned. By default set to 100 when not provided. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**Logged404sReportResponse**](Logged404sReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inforesourceexistsreportpost"></a>
# **InfoResourceexistsreportPost**
> ResourceExistsReportResponse InfoResourceexistsreportPost (List<string> requestBody)

Pass in an array of any size containing resource URL's (rules, templates, etc) to see if they exist and can be accessed by this user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoResourceexistsreportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var requestBody = new List<string>(); // List<string> | A JSON array of any number of resource URLs prefixed by type. Supports rule, template, queue, globalparameter, and rulegroup.

            try
            {
                // Pass in an array of any size containing resource URL's (rules, templates, etc) to see if they exist and can be accessed by this user.
                ResourceExistsReportResponse result = apiInstance.InfoResourceexistsreportPost(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoResourceexistsreportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoResourceexistsreportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pass in an array of any size containing resource URL's (rules, templates, etc) to see if they exist and can be accessed by this user.
    ApiResponse<ResourceExistsReportResponse> response = apiInstance.InfoResourceexistsreportPostWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoResourceexistsreportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) | A JSON array of any number of resource URLs prefixed by type. Supports rule, template, queue, globalparameter, and rulegroup. |  |

### Return type

[**ResourceExistsReportResponse**](ResourceExistsReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inforulecomplexityreportclientget"></a>
# **InfoRulecomplexityreportClientGet**
> RuleComplexityReportResponse InfoRulecomplexityreportClientGet (string varClient, TargetEnum? target = null, CsvEnum? format = null)

Report on the complexity of the various rules for a client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoRulecomplexityreportClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Which client would you like the report for? You must be able to access this client   to report on it.
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on the complexity of the various rules for a client
                RuleComplexityReportResponse result = apiInstance.InfoRulecomplexityreportClientGet(varClient, target, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoRulecomplexityreportClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoRulecomplexityreportClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report on the complexity of the various rules for a client
    ApiResponse<RuleComplexityReportResponse> response = apiInstance.InfoRulecomplexityreportClientGetWithHttpInfo(varClient, target, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoRulecomplexityreportClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Which client would you like the report for? You must be able to access this client   to report on it. |  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**RuleComplexityReportResponse**](RuleComplexityReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infosnoozeget"></a>
# **InfoSnoozeGet**
> SnoozeReportResponse InfoSnoozeGet (TargetEnum? target = null, CsvEnum? format = null)

Report on whether rules can be snoozed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoSnoozeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on whether rules can be snoozed
                SnoozeReportResponse result = apiInstance.InfoSnoozeGet(target, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoSnoozeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoSnoozeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report on whether rules can be snoozed
    ApiResponse<SnoozeReportResponse> response = apiInstance.InfoSnoozeGetWithHttpInfo(target, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoSnoozeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**SnoozeReportResponse**](SnoozeReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infosteptypestatisticsdelete"></a>
# **InfoSteptypestatisticsDelete**
> ApiResponse InfoSteptypestatisticsDelete ()

Clear the execution statistics histogram for all step types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoSteptypestatisticsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);

            try
            {
                // Clear the execution statistics histogram for all step types
                ApiResponse result = apiInstance.InfoSteptypestatisticsDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoSteptypestatisticsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoSteptypestatisticsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear the execution statistics histogram for all step types
    ApiResponse<ApiResponse> response = apiInstance.InfoSteptypestatisticsDeleteWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoSteptypestatisticsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infosteptypestatisticsget"></a>
# **InfoSteptypestatisticsGet**
> StepTypeStatisticsReportResponse InfoSteptypestatisticsGet (CsvEnum? format = null)

Find out the execution statistics histogram for each step type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoSteptypestatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Find out the execution statistics histogram for each step type
                StepTypeStatisticsReportResponse result = apiInstance.InfoSteptypestatisticsGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoSteptypestatisticsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoSteptypestatisticsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find out the execution statistics histogram for each step type
    ApiResponse<StepTypeStatisticsReportResponse> response = apiInstance.InfoSteptypestatisticsGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoSteptypestatisticsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**StepTypeStatisticsReportResponse**](StepTypeStatisticsReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infosteptypeusagereportclientget"></a>
# **InfoSteptypeusagereportClientGet**
> StepTypeUsageReportResponse InfoSteptypeusagereportClientGet (string varClient, TargetEnum? target = null, CsvEnum? format = null)

Report on the steps being used by this client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoSteptypeusagereportClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Which client would you like the report for? You must be able to access this client   to report on it.
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on the steps being used by this client
                StepTypeUsageReportResponse result = apiInstance.InfoSteptypeusagereportClientGet(varClient, target, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoSteptypeusagereportClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoSteptypeusagereportClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report on the steps being used by this client
    ApiResponse<StepTypeUsageReportResponse> response = apiInstance.InfoSteptypeusagereportClientGetWithHttpInfo(varClient, target, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoSteptypeusagereportClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Which client would you like the report for? You must be able to access this client   to report on it. |  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**StepTypeUsageReportResponse**](StepTypeUsageReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infostepusagereportclientstepnameget"></a>
# **InfoStepusagereportClientStepnameGet**
> StepUsageReportResponse InfoStepusagereportClientStepnameGet (string stepname, string varClient, TargetEnum? target = null, int? from = null, int? to = null, CsvEnum? format = null)

Find out which rules are using a specific step type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoStepusagereportClientStepnameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var stepname = "stepname_example";  // string | type of step that must exist in the rules returned
            var varClient = "varClient_example";  // string | Which client would you like the report for? You must be able to access this client   to report on it.
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Find out which rules are using a specific step type
                StepUsageReportResponse result = apiInstance.InfoStepusagereportClientStepnameGet(stepname, varClient, target, from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoStepusagereportClientStepnameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoStepusagereportClientStepnameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find out which rules are using a specific step type
    ApiResponse<StepUsageReportResponse> response = apiInstance.InfoStepusagereportClientStepnameGetWithHttpInfo(stepname, varClient, target, from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoStepusagereportClientStepnameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stepname** | **string** | type of step that must exist in the rules returned |  |
| **varClient** | **string** | Which client would you like the report for? You must be able to access this client   to report on it. |  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**StepUsageReportResponse**](StepUsageReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infotemplatecolumnreportclientget"></a>
# **InfoTemplatecolumnreportClientGet**
> TemplateColumnReportResponse InfoTemplatecolumnreportClientGet (string varClient, CsvEnum? format = null)

Report on the names of the columns in the cache used by templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoTemplatecolumnreportClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Which client would you like the report for? You must be able to access this client   to report on it.
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on the names of the columns in the cache used by templates
                TemplateColumnReportResponse result = apiInstance.InfoTemplatecolumnreportClientGet(varClient, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoTemplatecolumnreportClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoTemplatecolumnreportClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report on the names of the columns in the cache used by templates
    ApiResponse<TemplateColumnReportResponse> response = apiInstance.InfoTemplatecolumnreportClientGetWithHttpInfo(varClient, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoTemplatecolumnreportClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Which client would you like the report for? You must be able to access this client   to report on it. |  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**TemplateColumnReportResponse**](TemplateColumnReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infotemplateinputreportclientget"></a>
# **InfoTemplateinputreportClientGet**
> TemplateInputReportResponse InfoTemplateinputreportClientGet (string varClient, int? from = null, int? to = null, List<string>? inputFields = null, bool? allversions = null, CsvEnum? format = null)

List all templates that expect given input fields

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoTemplateinputreportClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Which client would you like the report for? You must be able to access this client   to report on it.
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var inputFields = new List<string>?(); // List<string>? | Name of input fields to search for (optional) 
            var allversions = true;  // bool? | Do we want to check all template versions or only latest? (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // List all templates that expect given input fields
                TemplateInputReportResponse result = apiInstance.InfoTemplateinputreportClientGet(varClient, from, to, inputFields, allversions, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoTemplateinputreportClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoTemplateinputreportClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all templates that expect given input fields
    ApiResponse<TemplateInputReportResponse> response = apiInstance.InfoTemplateinputreportClientGetWithHttpInfo(varClient, from, to, inputFields, allversions, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoTemplateinputreportClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Which client would you like the report for? You must be able to access this client   to report on it. |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **inputFields** | [**List&lt;string&gt;?**](string.md) | Name of input fields to search for | [optional]  |
| **allversions** | **bool?** | Do we want to check all template versions or only latest? | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**TemplateInputReportResponse**](TemplateInputReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infotemplateusagereportclienttemplatenameget"></a>
# **InfoTemplateusagereportClientTemplatenameGet**
> TemplateUsageReportResponse InfoTemplateusagereportClientTemplatenameGet (string varClient, string templatename, string? templateClient = null, string? templateVersion = null, int? from = null, int? to = null, TargetEnum? target = null, CsvEnum? format = null)

Find a list of rules which use a specific template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoTemplateusagereportClientTemplatenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string | Filter the rules returned to only this client. Use * to match all clients
            var templatename = "templatename_example";  // string | The name of the template that is used by the rule
            var templateClient = "templateClient_example";  // string? | Filter to only templates with this client (optional) 
            var templateVersion = "templateVersion_example";  // string? | Filter to only templates with this version (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Find a list of rules which use a specific template
                TemplateUsageReportResponse result = apiInstance.InfoTemplateusagereportClientTemplatenameGet(varClient, templatename, templateClient, templateVersion, from, to, target, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoTemplateusagereportClientTemplatenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoTemplateusagereportClientTemplatenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find a list of rules which use a specific template
    ApiResponse<TemplateUsageReportResponse> response = apiInstance.InfoTemplateusagereportClientTemplatenameGetWithHttpInfo(varClient, templatename, templateClient, templateVersion, from, to, target, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoTemplateusagereportClientTemplatenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Filter the rules returned to only this client. Use * to match all clients |  |
| **templatename** | **string** | The name of the template that is used by the rule |  |
| **templateClient** | **string?** | Filter to only templates with this client | [optional]  |
| **templateVersion** | **string?** | Filter to only templates with this version | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**TemplateUsageReportResponse**](TemplateUsageReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infotemplatevalidityreportclientget"></a>
# **InfoTemplatevalidityreportClientGet**
> TemplateValidityReportResponse InfoTemplatevalidityreportClientGet (string? varClient = null, int? from = null, int? to = null, CsvEnum? format = null)

Reports on validity of uploaded templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoTemplatevalidityreportClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var varClient = "varClient_example";  // string? | Client name (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Reports on validity of uploaded templates
                TemplateValidityReportResponse result = apiInstance.InfoTemplatevalidityreportClientGet(varClient, from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoTemplatevalidityreportClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoTemplatevalidityreportClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reports on validity of uploaded templates
    ApiResponse<TemplateValidityReportResponse> response = apiInstance.InfoTemplatevalidityreportClientGetWithHttpInfo(varClient, from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoTemplatevalidityreportClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string?** | Client name | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**TemplateValidityReportResponse**](TemplateValidityReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infotokenusereportget"></a>
# **InfoTokenusereportGet**
> TokenUseReportResponse InfoTokenusereportGet (int? from = null, int? to = null, string? user = null, CsvEnum? format = null, string? token = null)

Reports on token access and last used date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoTokenusereportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var user = "user_example";  // string? | Optional query parameter to specify the user (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 
            var token = "token_example";  // string? | Optional token for which to obtain the last used report (optional) 

            try
            {
                // Reports on token access and last used date.
                TokenUseReportResponse result = apiInstance.InfoTokenusereportGet(from, to, user, format, token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoTokenusereportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoTokenusereportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reports on token access and last used date.
    ApiResponse<TokenUseReportResponse> response = apiInstance.InfoTokenusereportGetWithHttpInfo(from, to, user, format, token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoTokenusereportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **user** | **string?** | Optional query parameter to specify the user | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |
| **token** | **string?** | Optional token for which to obtain the last used report | [optional]  |

### Return type

[**TokenUseReportResponse**](TokenUseReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="infoworkerthreadusageget"></a>
# **InfoWorkerthreadusageGet**
> WorkerThreadUsageReportResponse InfoWorkerthreadusageGet (int? from = null, int? to = null, CsvEnum? format = null)

Worker thread usage

Worker threads execute steps within rules. This report shows what they are doing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class InfoWorkerthreadusageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InfoApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Worker thread usage
                WorkerThreadUsageReportResponse result = apiInstance.InfoWorkerthreadusageGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoWorkerthreadusageGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoWorkerthreadusageGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Worker thread usage
    ApiResponse<WorkerThreadUsageReportResponse> response = apiInstance.InfoWorkerthreadusageGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoWorkerthreadusageGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**WorkerThreadUsageReportResponse**](WorkerThreadUsageReportResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

