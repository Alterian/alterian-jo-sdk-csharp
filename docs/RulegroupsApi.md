# Alterian.JO.Api.RulegroupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadRulegroupClientTargetRulegroupnameGet**](RulegroupsApi.md#downloadrulegroupclienttargetrulegroupnameget) | **GET** /download/rulegroup/{client}/{target}/{rulegroupname} | Download the rulegroup file (JSON) |
| [**RulegroupClientDelete**](RulegroupsApi.md#rulegroupclientdelete) | **DELETE** /rulegroup/{client} | Delete all rule groups uploaded by this client. |
| [**RulegroupClientGet**](RulegroupsApi.md#rulegroupclientget) | **GET** /rulegroup/{client} | Get details about all rule groups uploaded by a specific client |
| [**RulegroupClientTargetDelete**](RulegroupsApi.md#rulegroupclienttargetdelete) | **DELETE** /rulegroup/{client}/{target} | Delete all rule groups uploaded by this client in this target. |
| [**RulegroupClientTargetGet**](RulegroupsApi.md#rulegroupclienttargetget) | **GET** /rulegroup/{client}/{target} | Get details about all rule groups uploaded by a specific client in a specific target |
| [**RulegroupClientTargetRulegroupnameCopytoPost**](RulegroupsApi.md#rulegroupclienttargetrulegroupnamecopytopost) | **POST** /rulegroup/{client}/{target}/{rulegroupname}/copyto | Copy this rule group to the given target.  Also replicates any missing rules |
| [**RulegroupClientTargetRulegroupnameDelete**](RulegroupsApi.md#rulegroupclienttargetrulegroupnamedelete) | **DELETE** /rulegroup/{client}/{target}/{rulegroupname} | Delete all versions of a specific rulegroup. |
| [**RulegroupClientTargetRulegroupnameGet**](RulegroupsApi.md#rulegroupclienttargetrulegroupnameget) | **GET** /rulegroup/{client}/{target}/{rulegroupname} | Get details about all versions of a specified rulegroup |
| [**RulegroupClientTargetRulegroupnamePost**](RulegroupsApi.md#rulegroupclienttargetrulegroupnamepost) | **POST** /rulegroup/{client}/{target}/{rulegroupname} | Upload a file which defines the rulegroup. This will generate and return a version number number. |
| [**RulegroupClientTargetRulegroupnamePut**](RulegroupsApi.md#rulegroupclienttargetrulegroupnameput) | **PUT** /rulegroup/{client}/{target}/{rulegroupname} | Update an existing rulegroup. This will generate and return a version number. |
| [**RulegroupClientTargetRulegroupnameVersionDelete**](RulegroupsApi.md#rulegroupclienttargetrulegroupnameversiondelete) | **DELETE** /rulegroup/{client}/{target}/{rulegroupname}/{version} | Delete a specific version of a specific rulegroup on the server. |
| [**RulegroupClientTargetRulegroupnameVersionGet**](RulegroupsApi.md#rulegroupclienttargetrulegroupnameversionget) | **GET** /rulegroup/{client}/{target}/{rulegroupname}/{version} | Get details about a specific version of a specific rulegroup for a specific client |
| [**RulegroupGet**](RulegroupsApi.md#rulegroupget) | **GET** /rulegroup | Get details about all rule groups on the server |
| [**RulegroupPost**](RulegroupsApi.md#rulegrouppost) | **POST** /rulegroup | upload a file which defines the rulegroup. This will generate and return a version number.  Please use the   /rulegroup/client/target/name post version now. |

<a id="downloadrulegroupclienttargetrulegroupnameget"></a>
# **DownloadRulegroupClientTargetRulegroupnameGet**
> System.IO.Stream DownloadRulegroupClientTargetRulegroupnameGet (string varClient, TargetEnum target, string rulegroupname)

Download the rulegroup file (JSON)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class DownloadRulegroupClientTargetRulegroupnameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group

            try
            {
                // Download the rulegroup file (JSON)
                System.IO.Stream result = apiInstance.DownloadRulegroupClientTargetRulegroupnameGet(varClient, target, rulegroupname);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.DownloadRulegroupClientTargetRulegroupnameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadRulegroupClientTargetRulegroupnameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download the rulegroup file (JSON)
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadRulegroupClientTargetRulegroupnameGetWithHttpInfo(varClient, target, rulegroupname);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.DownloadRulegroupClientTargetRulegroupnameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **rulegroupname** | **string** | The name of the rule group |  |

### Return type

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A uuencoded octet stream containing the JSON file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclientdelete"></a>
# **RulegroupClientDelete**
> ApiResponse RulegroupClientDelete (string varClient)

Delete all rule groups uploaded by this client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Delete all rule groups uploaded by this client.
                ApiResponse result = apiInstance.RulegroupClientDelete(varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all rule groups uploaded by this client.
    ApiResponse<ApiResponse> response = apiInstance.RulegroupClientDeleteWithHttpInfo(varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |

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

<a id="rulegroupclientget"></a>
# **RulegroupClientGet**
> RuleGroupListingResponse RulegroupClientGet (string varClient, int? from = null, int? to = null, bool? includeproperties = null, bool? allversions = null)

Get details about all rule groups uploaded by a specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var includeproperties = true;  // bool? | Do we want all details of each rule group? (default is true). (optional) 
            var allversions = true;  // bool? | Do we want all versions of the file listed? (optional) 

            try
            {
                // Get details about all rule groups uploaded by a specific client
                RuleGroupListingResponse result = apiInstance.RulegroupClientGet(varClient, from, to, includeproperties, allversions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all rule groups uploaded by a specific client
    ApiResponse<RuleGroupListingResponse> response = apiInstance.RulegroupClientGetWithHttpInfo(varClient, from, to, includeproperties, allversions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientGetWithHttpInfo: " + e.Message);
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
| **includeproperties** | **bool?** | Do we want all details of each rule group? (default is true). | [optional]  |
| **allversions** | **bool?** | Do we want all versions of the file listed? | [optional]  |

### Return type

[**RuleGroupListingResponse**](RuleGroupListingResponse.md)

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

<a id="rulegroupclienttargetdelete"></a>
# **RulegroupClientTargetDelete**
> ApiResponse RulegroupClientTargetDelete (string varClient, TargetEnum target)

Delete all rule groups uploaded by this client in this target.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Where rulegroup should be published.

            try
            {
                // Delete all rule groups uploaded by this client in this target.
                ApiResponse result = apiInstance.RulegroupClientTargetDelete(varClient, target);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all rule groups uploaded by this client in this target.
    ApiResponse<ApiResponse> response = apiInstance.RulegroupClientTargetDeleteWithHttpInfo(varClient, target);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Where rulegroup should be published. |  |

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

<a id="rulegroupclienttargetget"></a>
# **RulegroupClientTargetGet**
> RuleGroupListingResponse RulegroupClientTargetGet (string varClient, TargetEnum target, int? from = null, int? to = null, bool? includeproperties = null, bool? allversions = null)

Get details about all rule groups uploaded by a specific client in a specific target

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Where rule group should be published.
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var includeproperties = true;  // bool? | Do we want all details of each rule group? (default is true). (optional) 
            var allversions = true;  // bool? | Do we want all versions of the file listed? (optional) 

            try
            {
                // Get details about all rule groups uploaded by a specific client in a specific target
                RuleGroupListingResponse result = apiInstance.RulegroupClientTargetGet(varClient, target, from, to, includeproperties, allversions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all rule groups uploaded by a specific client in a specific target
    ApiResponse<RuleGroupListingResponse> response = apiInstance.RulegroupClientTargetGetWithHttpInfo(varClient, target, from, to, includeproperties, allversions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Where rule group should be published. |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **includeproperties** | **bool?** | Do we want all details of each rule group? (default is true). | [optional]  |
| **allversions** | **bool?** | Do we want all versions of the file listed? | [optional]  |

### Return type

[**RuleGroupListingResponse**](RuleGroupListingResponse.md)

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

<a id="rulegroupclienttargetrulegroupnamecopytopost"></a>
# **RulegroupClientTargetRulegroupnameCopytoPost**
> ResourceAndStatusResponse RulegroupClientTargetRulegroupnameCopytoPost (string varClient, TargetEnum target, string rulegroupname, RuleGroupDestinationTarget? ruleGroupDestinationTarget = null)

Copy this rule group to the given target.  Also replicates any missing rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetRulegroupnameCopytoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Possible values: dev | test | prod.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group
            var ruleGroupDestinationTarget = new RuleGroupDestinationTarget?(); // RuleGroupDestinationTarget? |  (optional) 

            try
            {
                // Copy this rule group to the given target.  Also replicates any missing rules
                ResourceAndStatusResponse result = apiInstance.RulegroupClientTargetRulegroupnameCopytoPost(varClient, target, rulegroupname, ruleGroupDestinationTarget);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameCopytoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetRulegroupnameCopytoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy this rule group to the given target.  Also replicates any missing rules
    ApiResponse<ResourceAndStatusResponse> response = apiInstance.RulegroupClientTargetRulegroupnameCopytoPostWithHttpInfo(varClient, target, rulegroupname, ruleGroupDestinationTarget);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameCopytoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Possible values: dev | test | prod. |  |
| **rulegroupname** | **string** | The name of the rule group |  |
| **ruleGroupDestinationTarget** | [**RuleGroupDestinationTarget?**](RuleGroupDestinationTarget?.md) |  | [optional]  |

### Return type

[**ResourceAndStatusResponse**](ResourceAndStatusResponse.md)

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

<a id="rulegroupclienttargetrulegroupnamedelete"></a>
# **RulegroupClientTargetRulegroupnameDelete**
> ApiResponse RulegroupClientTargetRulegroupnameDelete (string varClient, TargetEnum target, string rulegroupname)

Delete all versions of a specific rulegroup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetRulegroupnameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group

            try
            {
                // Delete all versions of a specific rulegroup.
                ApiResponse result = apiInstance.RulegroupClientTargetRulegroupnameDelete(varClient, target, rulegroupname);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetRulegroupnameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all versions of a specific rulegroup.
    ApiResponse<ApiResponse> response = apiInstance.RulegroupClientTargetRulegroupnameDeleteWithHttpInfo(varClient, target, rulegroupname);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **rulegroupname** | **string** | The name of the rule group |  |

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

<a id="rulegroupclienttargetrulegroupnameget"></a>
# **RulegroupClientTargetRulegroupnameGet**
> RuleGroupListingResponse RulegroupClientTargetRulegroupnameGet (string varClient, TargetEnum target, string rulegroupname, int? from = null, int? to = null, bool? includeproperties = null, bool? allversions = null)

Get details about all versions of a specified rulegroup

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetRulegroupnameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var includeproperties = true;  // bool? | Do we want all details of each rule group? (default is true). (optional) 
            var allversions = true;  // bool? | Do we want all versions of the file listed? (optional) 

            try
            {
                // Get details about all versions of a specified rulegroup
                RuleGroupListingResponse result = apiInstance.RulegroupClientTargetRulegroupnameGet(varClient, target, rulegroupname, from, to, includeproperties, allversions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetRulegroupnameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all versions of a specified rulegroup
    ApiResponse<RuleGroupListingResponse> response = apiInstance.RulegroupClientTargetRulegroupnameGetWithHttpInfo(varClient, target, rulegroupname, from, to, includeproperties, allversions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **rulegroupname** | **string** | The name of the rule group |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **includeproperties** | **bool?** | Do we want all details of each rule group? (default is true). | [optional]  |
| **allversions** | **bool?** | Do we want all versions of the file listed? | [optional]  |

### Return type

[**RuleGroupListingResponse**](RuleGroupListingResponse.md)

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

<a id="rulegroupclienttargetrulegroupnamepost"></a>
# **RulegroupClientTargetRulegroupnamePost**
> ResourceAndStatusResponse RulegroupClientTargetRulegroupnamePost (string varClient, TargetEnum target, string rulegroupname, RuleGroup ruleGroup)

Upload a file which defines the rulegroup. This will generate and return a version number number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetRulegroupnamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Possible values: dev | test | prod.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group
            var ruleGroup = new RuleGroup(); // RuleGroup | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example.

            try
            {
                // Upload a file which defines the rulegroup. This will generate and return a version number number.
                ResourceAndStatusResponse result = apiInstance.RulegroupClientTargetRulegroupnamePost(varClient, target, rulegroupname, ruleGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetRulegroupnamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a file which defines the rulegroup. This will generate and return a version number number.
    ApiResponse<ResourceAndStatusResponse> response = apiInstance.RulegroupClientTargetRulegroupnamePostWithHttpInfo(varClient, target, rulegroupname, ruleGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Possible values: dev | test | prod. |  |
| **rulegroupname** | **string** | The name of the rule group |  |
| **ruleGroup** | [**RuleGroup**](RuleGroup.md) | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example. |  |

### Return type

[**ResourceAndStatusResponse**](ResourceAndStatusResponse.md)

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

<a id="rulegroupclienttargetrulegroupnameput"></a>
# **RulegroupClientTargetRulegroupnamePut**
> ResourceAndStatusResponse RulegroupClientTargetRulegroupnamePut (string varClient, TargetEnum target, string rulegroupname, RuleGroup ruleGroup)

Update an existing rulegroup. This will generate and return a version number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetRulegroupnamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Possible values: dev | test | prod.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group
            var ruleGroup = new RuleGroup(); // RuleGroup | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example.

            try
            {
                // Update an existing rulegroup. This will generate and return a version number.
                ResourceAndStatusResponse result = apiInstance.RulegroupClientTargetRulegroupnamePut(varClient, target, rulegroupname, ruleGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetRulegroupnamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing rulegroup. This will generate and return a version number.
    ApiResponse<ResourceAndStatusResponse> response = apiInstance.RulegroupClientTargetRulegroupnamePutWithHttpInfo(varClient, target, rulegroupname, ruleGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Possible values: dev | test | prod. |  |
| **rulegroupname** | **string** | The name of the rule group |  |
| **ruleGroup** | [**RuleGroup**](RuleGroup.md) | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example. |  |

### Return type

[**ResourceAndStatusResponse**](ResourceAndStatusResponse.md)

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

<a id="rulegroupclienttargetrulegroupnameversiondelete"></a>
# **RulegroupClientTargetRulegroupnameVersionDelete**
> ApiResponse RulegroupClientTargetRulegroupnameVersionDelete (string varClient, TargetEnum target, string rulegroupname, int varVersion)

Delete a specific version of a specific rulegroup on the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetRulegroupnameVersionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group
            var varVersion = 56;  // int | The version of the rule group

            try
            {
                // Delete a specific version of a specific rulegroup on the server.
                ApiResponse result = apiInstance.RulegroupClientTargetRulegroupnameVersionDelete(varClient, target, rulegroupname, varVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameVersionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetRulegroupnameVersionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific version of a specific rulegroup on the server.
    ApiResponse<ApiResponse> response = apiInstance.RulegroupClientTargetRulegroupnameVersionDeleteWithHttpInfo(varClient, target, rulegroupname, varVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameVersionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **rulegroupname** | **string** | The name of the rule group |  |
| **varVersion** | **int** | The version of the rule group |  |

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

<a id="rulegroupclienttargetrulegroupnameversionget"></a>
# **RulegroupClientTargetRulegroupnameVersionGet**
> RuleGroupListingResponse RulegroupClientTargetRulegroupnameVersionGet (string varClient, TargetEnum target, string rulegroupname, int varVersion)

Get details about a specific version of a specific rulegroup for a specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupClientTargetRulegroupnameVersionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group
            var varVersion = 56;  // int | The version of the rule group

            try
            {
                // Get details about a specific version of a specific rulegroup for a specific client
                RuleGroupListingResponse result = apiInstance.RulegroupClientTargetRulegroupnameVersionGet(varClient, target, rulegroupname, varVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameVersionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupClientTargetRulegroupnameVersionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about a specific version of a specific rulegroup for a specific client
    ApiResponse<RuleGroupListingResponse> response = apiInstance.RulegroupClientTargetRulegroupnameVersionGetWithHttpInfo(varClient, target, rulegroupname, varVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupClientTargetRulegroupnameVersionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **rulegroupname** | **string** | The name of the rule group |  |
| **varVersion** | **int** | The version of the rule group |  |

### Return type

[**RuleGroupListingResponse**](RuleGroupListingResponse.md)

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

<a id="rulegroupget"></a>
# **RulegroupGet**
> RuleGroupListingResponse RulegroupGet (int? from = null, int? to = null, bool? includeproperties = null, bool? allversions = null, List<string>? iClients = null)

Get details about all rule groups on the server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var includeproperties = true;  // bool? | Do we want all details of each rule group? (default is true). (optional) 
            var allversions = true;  // bool? | Do we want all versions of the file listed? (optional) 
            var iClients = new List<string>?(); // List<string>? | Only include these client(s) (optional) 

            try
            {
                // Get details about all rule groups on the server
                RuleGroupListingResponse result = apiInstance.RulegroupGet(from, to, includeproperties, allversions, iClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all rule groups on the server
    ApiResponse<RuleGroupListingResponse> response = apiInstance.RulegroupGetWithHttpInfo(from, to, includeproperties, allversions, iClients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **includeproperties** | **bool?** | Do we want all details of each rule group? (default is true). | [optional]  |
| **allversions** | **bool?** | Do we want all versions of the file listed? | [optional]  |
| **iClients** | [**List&lt;string&gt;?**](string.md) | Only include these client(s) | [optional]  |

### Return type

[**RuleGroupListingResponse**](RuleGroupListingResponse.md)

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

<a id="rulegrouppost"></a>
# **RulegroupPost**
> ApiResponse RulegroupPost (RuleGroup ruleGroup)

upload a file which defines the rulegroup. This will generate and return a version number.  Please use the   /rulegroup/client/target/name post version now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RulegroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulegroupsApi(config);
            var ruleGroup = new RuleGroup(); // RuleGroup | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example.

            try
            {
                // upload a file which defines the rulegroup. This will generate and return a version number.  Please use the   /rulegroup/client/target/name post version now.
                ApiResponse result = apiInstance.RulegroupPost(ruleGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulegroupsApi.RulegroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulegroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // upload a file which defines the rulegroup. This will generate and return a version number.  Please use the   /rulegroup/client/target/name post version now.
    ApiResponse<ApiResponse> response = apiInstance.RulegroupPostWithHttpInfo(ruleGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulegroupsApi.RulegroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleGroup** | [**RuleGroup**](RuleGroup.md) | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example. |  |

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

