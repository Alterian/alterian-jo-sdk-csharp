# Alterian.JO.Api.RecordingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RecordingClientDelete**](RecordingApi.md#recordingclientdelete) | **DELETE** /recording/{client} | Delete all recordings created by this client. |
| [**RecordingClientGet**](RecordingApi.md#recordingclientget) | **GET** /recording/{client} | Get details about all recordings created by a specific client |
| [**RecordingClientTargetDelete**](RecordingApi.md#recordingclienttargetdelete) | **DELETE** /recording/{client}/{target} | Delete all recordings created by this client in this target. |
| [**RecordingClientTargetGet**](RecordingApi.md#recordingclienttargetget) | **GET** /recording/{client}/{target} | Get details about all recordings created by a specific client in a specific target |
| [**RecordingClientTargetNameDelete**](RecordingApi.md#recordingclienttargetnamedelete) | **DELETE** /recording/{client}/{target}/{name} | Delete a specific recording. |
| [**RecordingClientTargetNameEventsGet**](RecordingApi.md#recordingclienttargetnameeventsget) | **GET** /recording/{client}/{target}/{name}/events | Get raw event traffic associated with this specific recording |
| [**RecordingClientTargetNameGet**](RecordingApi.md#recordingclienttargetnameget) | **GET** /recording/{client}/{target}/{name} | Get details about a specific recording |
| [**RecordingClientTargetNamePut**](RecordingApi.md#recordingclienttargetnameput) | **PUT** /recording/{client}/{target}/{name} | Edit the details of a specific recording. |
| [**RecordingClientTargetPost**](RecordingApi.md#recordingclienttargetpost) | **POST** /recording/{client}/{target} | Start or stop recording traffic for this client and target |
| [**RecordingGet**](RecordingApi.md#recordingget) | **GET** /recording | Get details about all recordings in the cluster |

<a id="recordingclientdelete"></a>
# **RecordingClientDelete**
> void RecordingClientDelete (string varClient)

Delete all recordings created by this client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Delete all recordings created by this client.
                apiInstance.RecordingClientDelete(varClient);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all recordings created by this client.
    apiInstance.RecordingClientDeleteWithHttpInfo(varClient);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientDeleteWithHttpInfo: " + e.Message);
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

<a id="recordingclientget"></a>
# **RecordingClientGet**
> void RecordingClientGet (string varClient, int? from = null, int? to = null)

Get details about all recordings created by a specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | Client name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 

            try
            {
                // Get details about all recordings created by a specific client
                apiInstance.RecordingClientGet(varClient, from, to);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all recordings created by a specific client
    apiInstance.RecordingClientGetWithHttpInfo(varClient, from, to);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientGetWithHttpInfo: " + e.Message);
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

<a id="recordingclienttargetdelete"></a>
# **RecordingClientTargetDelete**
> void RecordingClientTargetDelete (string varClient, TargetEnum target)

Delete all recordings created by this client in this target.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientTargetDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | Filter recordings to this client
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.

            try
            {
                // Delete all recordings created by this client in this target.
                apiInstance.RecordingClientTargetDelete(varClient, target);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientTargetDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientTargetDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all recordings created by this client in this target.
    apiInstance.RecordingClientTargetDeleteWithHttpInfo(varClient, target);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientTargetDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Filter recordings to this client |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |

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

<a id="recordingclienttargetget"></a>
# **RecordingClientTargetGet**
> void RecordingClientTargetGet (string varClient, TargetEnum target, int? from = null, int? to = null)

Get details about all recordings created by a specific client in a specific target

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientTargetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Which target should we filter to?
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 

            try
            {
                // Get details about all recordings created by a specific client in a specific target
                apiInstance.RecordingClientTargetGet(varClient, target, from, to);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientTargetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientTargetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all recordings created by a specific client in a specific target
    apiInstance.RecordingClientTargetGetWithHttpInfo(varClient, target, from, to);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientTargetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Which target should we filter to? |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |

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

<a id="recordingclienttargetnamedelete"></a>
# **RecordingClientTargetNameDelete**
> void RecordingClientTargetNameDelete (string varClient, TargetEnum target, string name)

Delete a specific recording.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientTargetNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | Filter recordings to this client
            var target = new TargetEnum(); // TargetEnum | Filter recordings to this target
            var name = "name_example";  // string | The name of the recording

            try
            {
                // Delete a specific recording.
                apiInstance.RecordingClientTargetNameDelete(varClient, target, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientTargetNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientTargetNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific recording.
    apiInstance.RecordingClientTargetNameDeleteWithHttpInfo(varClient, target, name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientTargetNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Filter recordings to this client |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Filter recordings to this target |  |
| **name** | **string** | The name of the recording |  |

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

<a id="recordingclienttargetnameeventsget"></a>
# **RecordingClientTargetNameEventsGet**
> void RecordingClientTargetNameEventsGet (string varClient, TargetEnum target, string name, string? since = null, int? from = null, int? to = null)

Get raw event traffic associated with this specific recording

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientTargetNameEventsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Which target should we filter to?
            var name = "name_example";  // string | The name of the recording
            var since = "since_example";  // string? | Optional 'since' values for paging large data - pass in the value from the last row returned. Use instead of 'From' (optional) 
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 

            try
            {
                // Get raw event traffic associated with this specific recording
                apiInstance.RecordingClientTargetNameEventsGet(varClient, target, name, since, from, to);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientTargetNameEventsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientTargetNameEventsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get raw event traffic associated with this specific recording
    apiInstance.RecordingClientTargetNameEventsGetWithHttpInfo(varClient, target, name, since, from, to);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientTargetNameEventsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Which target should we filter to? |  |
| **name** | **string** | The name of the recording |  |
| **since** | **string?** | Optional &#39;since&#39; values for paging large data - pass in the value from the last row returned. Use instead of &#39;From&#39; | [optional]  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |

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

<a id="recordingclienttargetnameget"></a>
# **RecordingClientTargetNameGet**
> void RecordingClientTargetNameGet (string varClient, TargetEnum target, string name, bool? analysis = null, bool? force = null)

Get details about a specific recording

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientTargetNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Which target should we filter to?
            var name = "name_example";  // string | The name of the recording
            var analysis = true;  // bool? | Should the server also perform analysis of the recorded data so that common items can be identified? (optional) 
            var force = true;  // bool? | Analysis data is cached. Should the cached data be cleared and the analysis be re-performed on the   raw data? (optional) 

            try
            {
                // Get details about a specific recording
                apiInstance.RecordingClientTargetNameGet(varClient, target, name, analysis, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientTargetNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientTargetNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about a specific recording
    apiInstance.RecordingClientTargetNameGetWithHttpInfo(varClient, target, name, analysis, force);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientTargetNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Which target should we filter to? |  |
| **name** | **string** | The name of the recording |  |
| **analysis** | **bool?** | Should the server also perform analysis of the recorded data so that common items can be identified? | [optional]  |
| **force** | **bool?** | Analysis data is cached. Should the cached data be cleared and the analysis be re-performed on the   raw data? | [optional]  |

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

<a id="recordingclienttargetnameput"></a>
# **RecordingClientTargetNamePut**
> ApiResponse RecordingClientTargetNamePut (string varClient, TargetEnum target, string name, string? body = null)

Edit the details of a specific recording.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientTargetNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | The client that this recording belongs to
            var target = new TargetEnum(); // TargetEnum | The target that this recording belongs to
            var name = "name_example";  // string | The name of the existing recording
            var body = {"name":"my recording"};  // string? | JSON containing optional additional settings for this recording. (optional) 

            try
            {
                // Edit the details of a specific recording.
                ApiResponse result = apiInstance.RecordingClientTargetNamePut(varClient, target, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientTargetNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientTargetNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit the details of a specific recording.
    ApiResponse<ApiResponse> response = apiInstance.RecordingClientTargetNamePutWithHttpInfo(varClient, target, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientTargetNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | The client that this recording belongs to |  |
| **target** | [**TargetEnum**](TargetEnum.md) | The target that this recording belongs to |  |
| **name** | **string** | The name of the existing recording |  |
| **body** | **string?** | JSON containing optional additional settings for this recording. | [optional]  |

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

<a id="recordingclienttargetpost"></a>
# **RecordingClientTargetPost**
> void RecordingClientTargetPost (string varClient, TargetEnum target, string? action = null, string? body = null)

Start or stop recording traffic for this client and target

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingClientTargetPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var varClient = "varClient_example";  // string | The client to start recording traffic for
            var target = new TargetEnum(); // TargetEnum | The target to start recording traffic for
            var action = "start";  // string? | Start or stop recording. Will toggle the current recording state (i.e. start->stop or stop->start) if   not specified. (optional) 
            var body = {"name":"my recording"};  // string? | JSON containing optional additional settings for this recording. (optional) 

            try
            {
                // Start or stop recording traffic for this client and target
                apiInstance.RecordingClientTargetPost(varClient, target, action, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingClientTargetPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingClientTargetPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start or stop recording traffic for this client and target
    apiInstance.RecordingClientTargetPostWithHttpInfo(varClient, target, action, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingClientTargetPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | The client to start recording traffic for |  |
| **target** | [**TargetEnum**](TargetEnum.md) | The target to start recording traffic for |  |
| **action** | **string?** | Start or stop recording. Will toggle the current recording state (i.e. start-&gt;stop or stop-&gt;start) if   not specified. | [optional]  |
| **body** | **string?** | JSON containing optional additional settings for this recording. | [optional]  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="recordingget"></a>
# **RecordingGet**
> void RecordingGet (int? from = null, int? to = null)

Get details about all recordings in the cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RecordingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RecordingApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 

            try
            {
                // Get details about all recordings in the cluster
                apiInstance.RecordingGet(from, to);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingApi.RecordingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all recordings in the cluster
    apiInstance.RecordingGetWithHttpInfo(from, to);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingApi.RecordingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |

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

