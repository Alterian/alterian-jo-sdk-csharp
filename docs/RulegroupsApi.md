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
> void DownloadRulegroupClientTargetRulegroupnameGet (string varClient, TargetEnum target, string rulegroupname)

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
            var rulegroupname = "rulegroupname_example";  // string | rulegroup name

            try
            {
                // Download the rulegroup file (JSON)
                apiInstance.DownloadRulegroupClientTargetRulegroupnameGet(varClient, target, rulegroupname);
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
    apiInstance.DownloadRulegroupClientTargetRulegroupnameGetWithHttpInfo(varClient, target, rulegroupname);
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
| **rulegroupname** | **string** | rulegroup name |  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A uuencoded octet stream containing the JSON file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclientdelete"></a>
# **RulegroupClientDelete**
> void RulegroupClientDelete (string varClient)

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
                apiInstance.RulegroupClientDelete(varClient);
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
    apiInstance.RulegroupClientDeleteWithHttpInfo(varClient);
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclientget"></a>
# **RulegroupClientGet**
> void RulegroupClientGet (string varClient, int? from = null, int? to = null, bool? includeproperties = null, bool? allversions = null)

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
                apiInstance.RulegroupClientGet(varClient, from, to, includeproperties, allversions);
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
    apiInstance.RulegroupClientGetWithHttpInfo(varClient, from, to, includeproperties, allversions);
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclienttargetdelete"></a>
# **RulegroupClientTargetDelete**
> void RulegroupClientTargetDelete (string varClient, TargetEnum target)

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
                apiInstance.RulegroupClientTargetDelete(varClient, target);
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
    apiInstance.RulegroupClientTargetDeleteWithHttpInfo(varClient, target);
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclienttargetget"></a>
# **RulegroupClientTargetGet**
> void RulegroupClientTargetGet (string varClient, TargetEnum target, int? from = null, int? to = null, bool? includeproperties = null, bool? allversions = null)

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
                apiInstance.RulegroupClientTargetGet(varClient, target, from, to, includeproperties, allversions);
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
    apiInstance.RulegroupClientTargetGetWithHttpInfo(varClient, target, from, to, includeproperties, allversions);
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclienttargetrulegroupnamecopytopost"></a>
# **RulegroupClientTargetRulegroupnameCopytoPost**
> ApiResponse RulegroupClientTargetRulegroupnameCopytoPost (string varClient, TargetEnum target, string rulegroupname, string? body = null)

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
            var varClient = "varClient_example";  // string | client name
            var target = new TargetEnum(); // TargetEnum | Possible values: dev | test | prod.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group that you want to copy
            var body = "body_example";  // string? |  (optional) 

            try
            {
                // Copy this rule group to the given target.  Also replicates any missing rules
                ApiResponse result = apiInstance.RulegroupClientTargetRulegroupnameCopytoPost(varClient, target, rulegroupname, body);
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
    ApiResponse<ApiResponse> response = apiInstance.RulegroupClientTargetRulegroupnameCopytoPostWithHttpInfo(varClient, target, rulegroupname, body);
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
| **varClient** | **string** | client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Possible values: dev | test | prod. |  |
| **rulegroupname** | **string** | The name of the rule group that you want to copy |  |
| **body** | **string?** |  | [optional]  |

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

<a id="rulegroupclienttargetrulegroupnamedelete"></a>
# **RulegroupClientTargetRulegroupnameDelete**
> void RulegroupClientTargetRulegroupnameDelete (string varClient, TargetEnum target, string rulegroupname)

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
            var rulegroupname = "rulegroupname_example";  // string | The name of the rulegroup you want to delete

            try
            {
                // Delete all versions of a specific rulegroup.
                apiInstance.RulegroupClientTargetRulegroupnameDelete(varClient, target, rulegroupname);
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
    apiInstance.RulegroupClientTargetRulegroupnameDeleteWithHttpInfo(varClient, target, rulegroupname);
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
| **rulegroupname** | **string** | The name of the rulegroup you want to delete |  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclienttargetrulegroupnameget"></a>
# **RulegroupClientTargetRulegroupnameGet**
> void RulegroupClientTargetRulegroupnameGet (string varClient, TargetEnum target, string rulegroupname, int? from = null, int? to = null, bool? includeproperties = null, bool? allversions = null)

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
            var rulegroupname = "rulegroupname_example";  // string | rulegroup name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var includeproperties = true;  // bool? | Do we want all details of each rule group? (default is true). (optional) 
            var allversions = true;  // bool? | Do we want all versions of the file listed? (optional) 

            try
            {
                // Get details about all versions of a specified rulegroup
                apiInstance.RulegroupClientTargetRulegroupnameGet(varClient, target, rulegroupname, from, to, includeproperties, allversions);
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
    apiInstance.RulegroupClientTargetRulegroupnameGetWithHttpInfo(varClient, target, rulegroupname, from, to, includeproperties, allversions);
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
| **rulegroupname** | **string** | rulegroup name |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **includeproperties** | **bool?** | Do we want all details of each rule group? (default is true). | [optional]  |
| **allversions** | **bool?** | Do we want all versions of the file listed? | [optional]  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclienttargetrulegroupnamepost"></a>
# **RulegroupClientTargetRulegroupnamePost**
> ApiResponse RulegroupClientTargetRulegroupnamePost (string varClient, TargetEnum target, string rulegroupname, RulegroupPostRequest rulegroupPostRequest)

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
            var varClient = "varClient_example";  // string | client name
            var target = new TargetEnum(); // TargetEnum | Possible values: dev | test | prod.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group that you want to upload
            var rulegroupPostRequest = new RulegroupPostRequest(); // RulegroupPostRequest | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example.

            try
            {
                // Upload a file which defines the rulegroup. This will generate and return a version number number.
                ApiResponse result = apiInstance.RulegroupClientTargetRulegroupnamePost(varClient, target, rulegroupname, rulegroupPostRequest);
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
    ApiResponse<ApiResponse> response = apiInstance.RulegroupClientTargetRulegroupnamePostWithHttpInfo(varClient, target, rulegroupname, rulegroupPostRequest);
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
| **varClient** | **string** | client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Possible values: dev | test | prod. |  |
| **rulegroupname** | **string** | The name of the rule group that you want to upload |  |
| **rulegroupPostRequest** | [**RulegroupPostRequest**](RulegroupPostRequest.md) | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example. |  |

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

<a id="rulegroupclienttargetrulegroupnameput"></a>
# **RulegroupClientTargetRulegroupnamePut**
> ApiResponse RulegroupClientTargetRulegroupnamePut (string varClient, TargetEnum target, string rulegroupname, RulegroupPostRequest rulegroupPostRequest)

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
            var varClient = "varClient_example";  // string | client name
            var target = new TargetEnum(); // TargetEnum | Possible values: dev | test | prod.
            var rulegroupname = "rulegroupname_example";  // string | The name of the rule group that you want to upload
            var rulegroupPostRequest = new RulegroupPostRequest(); // RulegroupPostRequest | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example.

            try
            {
                // Update an existing rulegroup. This will generate and return a version number.
                ApiResponse result = apiInstance.RulegroupClientTargetRulegroupnamePut(varClient, target, rulegroupname, rulegroupPostRequest);
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
    ApiResponse<ApiResponse> response = apiInstance.RulegroupClientTargetRulegroupnamePutWithHttpInfo(varClient, target, rulegroupname, rulegroupPostRequest);
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
| **varClient** | **string** | client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Possible values: dev | test | prod. |  |
| **rulegroupname** | **string** | The name of the rule group that you want to upload |  |
| **rulegroupPostRequest** | [**RulegroupPostRequest**](RulegroupPostRequest.md) | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example. |  |

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

<a id="rulegroupclienttargetrulegroupnameversiondelete"></a>
# **RulegroupClientTargetRulegroupnameVersionDelete**
> void RulegroupClientTargetRulegroupnameVersionDelete (string varClient, TargetEnum target, string rulegroupname, int varVersion)

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
            var rulegroupname = "rulegroupname_example";  // string | The name of the rulegroup you want to delete
            var varVersion = 56;  // int | The version of the rulegroup you want to delete

            try
            {
                // Delete a specific version of a specific rulegroup on the server.
                apiInstance.RulegroupClientTargetRulegroupnameVersionDelete(varClient, target, rulegroupname, varVersion);
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
    apiInstance.RulegroupClientTargetRulegroupnameVersionDeleteWithHttpInfo(varClient, target, rulegroupname, varVersion);
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
| **rulegroupname** | **string** | The name of the rulegroup you want to delete |  |
| **varVersion** | **int** | The version of the rulegroup you want to delete |  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupclienttargetrulegroupnameversionget"></a>
# **RulegroupClientTargetRulegroupnameVersionGet**
> void RulegroupClientTargetRulegroupnameVersionGet (string varClient, TargetEnum target, string rulegroupname, int varVersion)

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
            var rulegroupname = "rulegroupname_example";  // string | rulegroup name
            var varVersion = 56;  // int | The version of the file you want information for.

            try
            {
                // Get details about a specific version of a specific rulegroup for a specific client
                apiInstance.RulegroupClientTargetRulegroupnameVersionGet(varClient, target, rulegroupname, varVersion);
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
    apiInstance.RulegroupClientTargetRulegroupnameVersionGetWithHttpInfo(varClient, target, rulegroupname, varVersion);
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
| **rulegroupname** | **string** | rulegroup name |  |
| **varVersion** | **int** | The version of the file you want information for. |  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegroupget"></a>
# **RulegroupGet**
> void RulegroupGet (int? from = null, int? to = null, bool? includeproperties = null, bool? allversions = null, List<string>? iClients = null)

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
                apiInstance.RulegroupGet(from, to, includeproperties, allversions, iClients);
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
    apiInstance.RulegroupGetWithHttpInfo(from, to, includeproperties, allversions, iClients);
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rulegrouppost"></a>
# **RulegroupPost**
> ApiResponse RulegroupPost (RulegroupPostRequest rulegroupPostRequest)

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
            var rulegroupPostRequest = new RulegroupPostRequest(); // RulegroupPostRequest | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example.

            try
            {
                // upload a file which defines the rulegroup. This will generate and return a version number.  Please use the   /rulegroup/client/target/name post version now.
                ApiResponse result = apiInstance.RulegroupPost(rulegroupPostRequest);
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
    ApiResponse<ApiResponse> response = apiInstance.RulegroupPostWithHttpInfo(rulegroupPostRequest);
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
| **rulegroupPostRequest** | [**RulegroupPostRequest**](RulegroupPostRequest.md) | A block of JSON containing the rule group information you want to create.  Note there are many more   properties which you can set to allow you to override parameters of the rules, etc. but the simplest is provided as an   example. |  |

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

