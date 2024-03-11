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
| [**InfoResourceexistsreportPost**](InfoApi.md#inforesourceexistsreportpost) | **POST** /info/resourceexistsreport | Pass in an array of any size containing resource URL&#39;s (rules, templates, etc) to see if they exist and can   be accessed by this user. |
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
> ApiResponse InfoAuditlogClientGet (string varClient, int? from = null, int? to = null, TargetEnum? target = null, CsvEnum? format = null)

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
                ApiResponse result = apiInstance.InfoAuditlogClientGet(varClient, from, to, target, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoAuditlogClientGetWithHttpInfo(varClient, from, to, target, format);
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

<a id="infocachedataclientget"></a>
# **InfoCachedataClientGet**
> ApiResponse InfoCachedataClientGet (string? varClient = null, int? from = null, int? to = null, TargetEnum? target = null, string? rulename = null, string? cachedirection = null, CsvEnum? format = null)

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
            var cachedirection = "READ";  // string? | Get only cache read or writes (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get cache data report
                ApiResponse result = apiInstance.InfoCachedataClientGet(varClient, from, to, target, rulename, cachedirection, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoCachedataClientGetWithHttpInfo(varClient, from, to, target, rulename, cachedirection, format);
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
| **cachedirection** | **string?** | Get only cache read or writes | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infocacheunusedcolumnsclientget"></a>
# **InfoCacheunusedcolumnsClientGet**
> ApiResponse InfoCacheunusedcolumnsClientGet (string varClient, int? from = null, int? to = null, TargetEnum? target = null, CsvEnum? format = null)

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
                ApiResponse result = apiInstance.InfoCacheunusedcolumnsClientGet(varClient, from, to, target, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoCacheunusedcolumnsClientGetWithHttpInfo(varClient, from, to, target, format);
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

<a id="infoclientaccessreportclientget"></a>
# **InfoClientaccessreportClientGet**
> ApiResponse InfoClientaccessreportClientGet (string? varClient = null, bool? includeClientAll = null, bool? includePermissionAll = null, CsvEnum? format = null)

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
            var varClient = "varClient_example";  // string? | Which client would you like the access information for? You must be able to access this client to   report on it. (optional) 
            var includeClientAll = true;  // bool? | Should users with access to all clients be included (optional)  (default to true)
            var includePermissionAll = true;  // bool? | Should users with permission ALL be included (optional)  (default to true)
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on the users able to access given client
                ApiResponse result = apiInstance.InfoClientaccessreportClientGet(varClient, includeClientAll, includePermissionAll, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoClientaccessreportClientGetWithHttpInfo(varClient, includeClientAll, includePermissionAll, format);
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
| **varClient** | **string?** | Which client would you like the access information for? You must be able to access this client to   report on it. | [optional]  |
| **includeClientAll** | **bool?** | Should users with access to all clients be included | [optional] [default to true] |
| **includePermissionAll** | **bool?** | Should users with permission ALL be included | [optional] [default to true] |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infoconsistencyreportget"></a>
# **InfoConsistencyreportGet**
> ApiResponse InfoConsistencyreportGet (int? from = null, int? to = null, CsvEnum? format = null)

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
                ApiResponse result = apiInstance.InfoConsistencyreportGet(from, to, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoConsistencyreportGetWithHttpInfo(from, to, format);
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

<a id="infoconversationusagereportclienttimeseriesget"></a>
# **InfoConversationusagereportClientTimeseriesGet**
> ApiResponse InfoConversationusagereportClientTimeseriesGet (string timeseries, string? varClient = null, CsvEnum? format = null)

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
            var timeseries = "min";  // string | Report on either the last 60 minutes, the last 48 hours or the last 60 days (default to day)
            var varClient = "varClient_example";  // string? | Which client would you like the conversation statistics for? You must be able to access this client   to report on it. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on the conversation usage by a specific client
                ApiResponse result = apiInstance.InfoConversationusagereportClientTimeseriesGet(timeseries, varClient, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoConversationusagereportClientTimeseriesGetWithHttpInfo(timeseries, varClient, format);
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
| **timeseries** | **string** | Report on either the last 60 minutes, the last 48 hours or the last 60 days | [default to day] |
| **varClient** | **string?** | Which client would you like the conversation statistics for? You must be able to access this client   to report on it. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infofieldusagetargetclientrulenameget"></a>
# **InfoFieldusageTargetClientRulenameGet**
> ApiResponse InfoFieldusageTargetClientRulenameGet (TargetEnum target, string varClient, string rulename, int? from = null, int? to = null, CsvEnum? format = null, bool? mergefields = null)

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
                ApiResponse result = apiInstance.InfoFieldusageTargetClientRulenameGet(target, varClient, rulename, from, to, format, mergefields);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoFieldusageTargetClientRulenameGetWithHttpInfo(target, varClient, rulename, from, to, format, mergefields);
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

<a id="infoflowtargetclientrulenameget"></a>
# **InfoFlowTargetClientRulenameGet**
> ApiResponse InfoFlowTargetClientRulenameGet (TargetEnum target, string varClient, string rulename)

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
                ApiResponse result = apiInstance.InfoFlowTargetClientRulenameGet(target, varClient, rulename);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoFlowTargetClientRulenameGetWithHttpInfo(target, varClient, rulename);
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

<a id="infoglobalparamreportclientget"></a>
# **InfoGlobalparamreportClientGet**
> ApiResponse InfoGlobalparamreportClientGet (string? varClient = null, int? from = null, int? to = null, string? parameterName = null, string? parameterValue = null, bool? onlyGlobalParameters = null, CsvEnum? format = null)

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
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get report on global parameters
                ApiResponse result = apiInstance.InfoGlobalparamreportClientGet(varClient, from, to, parameterName, parameterValue, onlyGlobalParameters, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoGlobalparamreportClientGetWithHttpInfo(varClient, from, to, parameterName, parameterValue, onlyGlobalParameters, format);
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
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infointernalrulecallreportclienttargetrulenameget"></a>
# **InfoInternalrulecallreportClientTargetRulenameGet**
> ApiResponse InfoInternalrulecallreportClientTargetRulenameGet (string varClient, TargetEnum target, string rulename, CsvEnum? format = null)

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
            var varClient = "varClient_example";  // string | Rule client
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var rulename = "rulename_example";  // string | Rule name
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // For a given rule, find all the rules that call this rule internally
                ApiResponse result = apiInstance.InfoInternalrulecallreportClientTargetRulenameGet(varClient, target, rulename, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoInternalrulecallreportClientTargetRulenameGetWithHttpInfo(varClient, target, rulename, format);
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
| **varClient** | **string** | Rule client |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **rulename** | **string** | Rule name |  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infologged404sclientget"></a>
# **InfoLogged404sClientGet**
> ApiResponse InfoLogged404sClientGet (string? varClient = null, int? from = null, int? to = null, int? limit = null, CsvEnum? format = null)

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
                ApiResponse result = apiInstance.InfoLogged404sClientGet(varClient, from, to, limit, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoLogged404sClientGetWithHttpInfo(varClient, from, to, limit, format);
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

<a id="inforesourceexistsreportpost"></a>
# **InfoResourceexistsreportPost**
> ApiResponse InfoResourceexistsreportPost (string body)

Pass in an array of any size containing resource URL's (rules, templates, etc) to see if they exist and can   be accessed by this user.

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
            var body = ["rule/target/client/rulename","template/client/templatename","queue/client/target/queuename","globalparameter/client/globalparametername","rulegroup/client/target/rulegroupname"];  // string | A json array of any number of resource urls prefixed by type. Supports rule, template, queue,   globalparameter and rulegroup

            try
            {
                // Pass in an array of any size containing resource URL's (rules, templates, etc) to see if they exist and can   be accessed by this user.
                ApiResponse result = apiInstance.InfoResourceexistsreportPost(body);
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
    // Pass in an array of any size containing resource URL's (rules, templates, etc) to see if they exist and can   be accessed by this user.
    ApiResponse<ApiResponse> response = apiInstance.InfoResourceexistsreportPostWithHttpInfo(body);
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
| **body** | **string** | A json array of any number of resource urls prefixed by type. Supports rule, template, queue,   globalparameter and rulegroup |  |

### Return type

[**ApiResponse**](ApiResponse.md)

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
> ApiResponse InfoRulecomplexityreportClientGet (string varClient, CsvEnum? format = null, TargetEnum? target = null)

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
            var varClient = "varClient_example";  // string | Limit the report to only the rules used by this client. You must be able to access this client to   report on it.
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 

            try
            {
                // Report on the complexity of the various rules for a client
                ApiResponse result = apiInstance.InfoRulecomplexityreportClientGet(varClient, format, target);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoRulecomplexityreportClientGetWithHttpInfo(varClient, format, target);
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
| **varClient** | **string** | Limit the report to only the rules used by this client. You must be able to access this client to   report on it. |  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |

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

<a id="infosnoozeget"></a>
# **InfoSnoozeGet**
> ApiResponse InfoSnoozeGet (CsvEnum? format = null, TargetEnum? target = null)

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
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 

            try
            {
                // Report on whether rules can be snoozed
                ApiResponse result = apiInstance.InfoSnoozeGet(format, target);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoSnoozeGetWithHttpInfo(format, target);
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
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |

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
> ApiResponse InfoSteptypestatisticsGet (CsvEnum? format = null)

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
                ApiResponse result = apiInstance.InfoSteptypestatisticsGet(format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoSteptypestatisticsGetWithHttpInfo(format);
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

<a id="infosteptypeusagereportclientget"></a>
# **InfoSteptypeusagereportClientGet**
> ApiResponse InfoSteptypeusagereportClientGet (string varClient, CsvEnum? format = null, TargetEnum? target = null)

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
            var varClient = "varClient_example";  // string | Limit the report to only the steps used by this client. You must be able to access this client to   report on it.
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 

            try
            {
                // Report on the steps being used by this client
                ApiResponse result = apiInstance.InfoSteptypeusagereportClientGet(varClient, format, target);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoSteptypeusagereportClientGetWithHttpInfo(varClient, format, target);
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
| **varClient** | **string** | Limit the report to only the steps used by this client. You must be able to access this client to   report on it. |  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |

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

<a id="infostepusagereportclientstepnameget"></a>
# **InfoStepusagereportClientStepnameGet**
> ApiResponse InfoStepusagereportClientStepnameGet (string stepname, string? varClient = null, TargetEnum? target = null, int? from = null, int? to = null, CsvEnum? format = null)

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
            var varClient = "varClient_example";  // string? | Filter the rules returned to only the ones in this client. Use * to match all clients visible to your   user (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Find out which rules are using a specific step type
                ApiResponse result = apiInstance.InfoStepusagereportClientStepnameGet(stepname, varClient, target, from, to, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoStepusagereportClientStepnameGetWithHttpInfo(stepname, varClient, target, from, to, format);
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
| **varClient** | **string?** | Filter the rules returned to only the ones in this client. Use * to match all clients visible to your   user | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infotemplatecolumnreportclientget"></a>
# **InfoTemplatecolumnreportClientGet**
> ApiResponse InfoTemplatecolumnreportClientGet (string? varClient = null, CsvEnum? format = null)

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
            var varClient = "varClient_example";  // string? | Limit the report to only the templates used by this client. You must be able to access this client to   report on it. (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Report on the names of the columns in the cache used by templates
                ApiResponse result = apiInstance.InfoTemplatecolumnreportClientGet(varClient, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoTemplatecolumnreportClientGetWithHttpInfo(varClient, format);
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
| **varClient** | **string?** | Limit the report to only the templates used by this client. You must be able to access this client to   report on it. | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infotemplateinputreportclientget"></a>
# **InfoTemplateinputreportClientGet**
> ApiResponse InfoTemplateinputreportClientGet (string? varClient = null, int? from = null, int? to = null, List<string>? inputFields = null, bool? allversions = null, CsvEnum? format = null)

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
            var varClient = "varClient_example";  // string? | Limit the report to only the templates used by this client. You must be able to access this client to   report on it. (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var inputFields = new List<string>?(); // List<string>? | Name of input fields to search for (optional) 
            var allversions = true;  // bool? | Do we want to check all template versions or only latest? (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // List all templates that expect given input fields
                ApiResponse result = apiInstance.InfoTemplateinputreportClientGet(varClient, from, to, inputFields, allversions, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoTemplateinputreportClientGetWithHttpInfo(varClient, from, to, inputFields, allversions, format);
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
| **varClient** | **string?** | Limit the report to only the templates used by this client. You must be able to access this client to   report on it. | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **inputFields** | [**List&lt;string&gt;?**](string.md) | Name of input fields to search for | [optional]  |
| **allversions** | **bool?** | Do we want to check all template versions or only latest? | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infotemplateusagereportclienttemplatenameget"></a>
# **InfoTemplateusagereportClientTemplatenameGet**
> ApiResponse InfoTemplateusagereportClientTemplatenameGet (string templatename, string? varClient = null, string? templateClient = null, string? templateVersion = null, int? from = null, int? to = null, TargetEnum? target = null, CsvEnum? format = null)

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
            var templatename = "templatename_example";  // string | The name of the template that is used by the rule
            var varClient = "varClient_example";  // string? | Filter the rules returned to only this client. Use * to match all clients (optional) 
            var templateClient = "templateClient_example";  // string? | Filter to only templates with this client (optional) 
            var templateVersion = "templateVersion_example";  // string? | Filter to only templates with this version (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var target = new TargetEnum?(); // TargetEnum? | Filters on target (optional) 
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Find a list of rules which use a specific template
                ApiResponse result = apiInstance.InfoTemplateusagereportClientTemplatenameGet(templatename, varClient, templateClient, templateVersion, from, to, target, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoTemplateusagereportClientTemplatenameGetWithHttpInfo(templatename, varClient, templateClient, templateVersion, from, to, target, format);
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
| **templatename** | **string** | The name of the template that is used by the rule |  |
| **varClient** | **string?** | Filter the rules returned to only this client. Use * to match all clients | [optional]  |
| **templateClient** | **string?** | Filter to only templates with this client | [optional]  |
| **templateVersion** | **string?** | Filter to only templates with this version | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **target** | [**TargetEnum?**](TargetEnum?.md) | Filters on target | [optional]  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

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

<a id="infotemplatevalidityreportclientget"></a>
# **InfoTemplatevalidityreportClientGet**
> ApiResponse InfoTemplatevalidityreportClientGet (string? varClient = null, int? from = null, int? to = null, CsvEnum? format = null)

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
                ApiResponse result = apiInstance.InfoTemplatevalidityreportClientGet(varClient, from, to, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoTemplatevalidityreportClientGetWithHttpInfo(varClient, from, to, format);
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

<a id="infotokenusereportget"></a>
# **InfoTokenusereportGet**
> ApiResponse InfoTokenusereportGet (int? from = null, int? to = null, string? user = null, CsvEnum? format = null, string? token = null)

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
                ApiResponse result = apiInstance.InfoTokenusereportGet(from, to, user, format, token);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoTokenusereportGetWithHttpInfo(from, to, user, format, token);
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

<a id="infoworkerthreadusageget"></a>
# **InfoWorkerthreadusageGet**
> ApiResponse InfoWorkerthreadusageGet (int? from = null, int? to = null, CsvEnum? format = null)

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
                ApiResponse result = apiInstance.InfoWorkerthreadusageGet(from, to, format);
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
    ApiResponse<ApiResponse> response = apiInstance.InfoWorkerthreadusageGetWithHttpInfo(from, to, format);
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

