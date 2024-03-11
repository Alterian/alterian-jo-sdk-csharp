# Alterian.JO.Api.GlobalparameterApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadGlobalparameterClientParamnameGet**](GlobalparameterApi.md#downloadglobalparameterclientparamnameget) | **GET** /download/globalparameter/{client}/{paramname} | Download global parameter |
| [**GlobalparameterClientGet**](GlobalparameterApi.md#globalparameterclientget) | **GET** /globalparameter/{client} | Get target parameter for for specific client |
| [**GlobalparameterClientParamnameCopyPost**](GlobalparameterApi.md#globalparameterclientparamnamecopypost) | **POST** /globalparameter/{client}/{paramname}/copy | Create a copy of a Global Parameter and, optionally, delete the original |
| [**GlobalparameterClientParamnameCopyPut**](GlobalparameterApi.md#globalparameterclientparamnamecopyput) | **PUT** /globalparameter/{client}/{paramname}/copy | Create a copy of a Global Parameter overwriting the target if it exists and, optionally, delete the original |
| [**GlobalparameterClientParamnameDelete**](GlobalparameterApi.md#globalparameterclientparamnamedelete) | **DELETE** /globalparameter/{client}/{paramname} | Delete a global parameter |
| [**GlobalparameterClientParamnameGet**](GlobalparameterApi.md#globalparameterclientparamnameget) | **GET** /globalparameter/{client}/{paramname} | Get individual Global Parameter |
| [**GlobalparameterClientParamnamePut**](GlobalparameterApi.md#globalparameterclientparamnameput) | **PUT** /globalparameter/{client}/{paramname} | Update Global Parameter |
| [**GlobalparameterGet**](GlobalparameterApi.md#globalparameterget) | **GET** /globalparameter | Get global parameters for all clients |
| [**GlobalparameterPost**](GlobalparameterApi.md#globalparameterpost) | **POST** /globalparameter | Create Global Parameter (will fail if already exists) |

<a id="downloadglobalparameterclientparamnameget"></a>
# **DownloadGlobalparameterClientParamnameGet**
> void DownloadGlobalparameterClientParamnameGet (string varClient, string paramname)

Download global parameter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class DownloadGlobalparameterClientParamnameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var varClient = "varClient_example";  // string | Client name
            var paramname = "paramname_example";  // string | parameter name

            try
            {
                // Download global parameter
                apiInstance.DownloadGlobalparameterClientParamnameGet(varClient, paramname);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.DownloadGlobalparameterClientParamnameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadGlobalparameterClientParamnameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download global parameter
    apiInstance.DownloadGlobalparameterClientParamnameGetWithHttpInfo(varClient, paramname);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.DownloadGlobalparameterClientParamnameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **paramname** | **string** | parameter name |  |

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

<a id="globalparameterclientget"></a>
# **GlobalparameterClientGet**
> ParameterList GlobalparameterClientGet (string varClient, int? from = null, int? to = null, string? sortProperty = null, string? sortDescending = null, string? searchText = null, List<string>? iClients = null)

Get target parameter for for specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class GlobalparameterClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var varClient = "varClient_example";  // string | Client name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var sortProperty = "sortProperty_example";  // string? | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. (optional) 
            var sortDescending = "sortDescending_example";  // string? | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty (optional) 
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 
            var iClients = new List<string>?(); // List<string>? | Only include these client(s) (optional) 

            try
            {
                // Get target parameter for for specific client
                ParameterList result = apiInstance.GlobalparameterClientGet(varClient, from, to, sortProperty, sortDescending, searchText, iClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalparameterClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get target parameter for for specific client
    ApiResponse<ParameterList> response = apiInstance.GlobalparameterClientGetWithHttpInfo(varClient, from, to, sortProperty, sortDescending, searchText, iClients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientGetWithHttpInfo: " + e.Message);
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
| **sortProperty** | **string?** | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. | [optional]  |
| **sortDescending** | **string?** | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty | [optional]  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |
| **iClients** | [**List&lt;string&gt;?**](string.md) | Only include these client(s) | [optional]  |

### Return type

[**ParameterList**](ParameterList.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Roles that the system knows about |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="globalparameterclientparamnamecopypost"></a>
# **GlobalparameterClientParamnameCopyPost**
> ParameterApiResponse GlobalparameterClientParamnameCopyPost (string varClient, string paramname, ParameterCopyDetails parameterCopyDetails)

Create a copy of a Global Parameter and, optionally, delete the original

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class GlobalparameterClientParamnameCopyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var varClient = "varClient_example";  // string | Client name
            var paramname = "paramname_example";  // string | parameter name
            var parameterCopyDetails = new ParameterCopyDetails(); // ParameterCopyDetails | 

            try
            {
                // Create a copy of a Global Parameter and, optionally, delete the original
                ParameterApiResponse result = apiInstance.GlobalparameterClientParamnameCopyPost(varClient, paramname, parameterCopyDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnameCopyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalparameterClientParamnameCopyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a copy of a Global Parameter and, optionally, delete the original
    ApiResponse<ParameterApiResponse> response = apiInstance.GlobalparameterClientParamnameCopyPostWithHttpInfo(varClient, paramname, parameterCopyDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnameCopyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **paramname** | **string** | parameter name |  |
| **parameterCopyDetails** | [**ParameterCopyDetails**](ParameterCopyDetails.md) |  |  |

### Return type

[**ParameterApiResponse**](ParameterApiResponse.md)

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

<a id="globalparameterclientparamnamecopyput"></a>
# **GlobalparameterClientParamnameCopyPut**
> ParameterApiResponse GlobalparameterClientParamnameCopyPut (string varClient, string paramname, ParameterCopyDetails parameterCopyDetails)

Create a copy of a Global Parameter overwriting the target if it exists and, optionally, delete the original

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class GlobalparameterClientParamnameCopyPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var varClient = "varClient_example";  // string | Client name
            var paramname = "paramname_example";  // string | parameter name
            var parameterCopyDetails = new ParameterCopyDetails(); // ParameterCopyDetails | 

            try
            {
                // Create a copy of a Global Parameter overwriting the target if it exists and, optionally, delete the original
                ParameterApiResponse result = apiInstance.GlobalparameterClientParamnameCopyPut(varClient, paramname, parameterCopyDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnameCopyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalparameterClientParamnameCopyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a copy of a Global Parameter overwriting the target if it exists and, optionally, delete the original
    ApiResponse<ParameterApiResponse> response = apiInstance.GlobalparameterClientParamnameCopyPutWithHttpInfo(varClient, paramname, parameterCopyDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnameCopyPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **paramname** | **string** | parameter name |  |
| **parameterCopyDetails** | [**ParameterCopyDetails**](ParameterCopyDetails.md) |  |  |

### Return type

[**ParameterApiResponse**](ParameterApiResponse.md)

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

<a id="globalparameterclientparamnamedelete"></a>
# **GlobalparameterClientParamnameDelete**
> ApiResponse GlobalparameterClientParamnameDelete (string varClient, string paramname)

Delete a global parameter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class GlobalparameterClientParamnameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var varClient = "varClient_example";  // string | Client name
            var paramname = "paramname_example";  // string | parameter name

            try
            {
                // Delete a global parameter
                ApiResponse result = apiInstance.GlobalparameterClientParamnameDelete(varClient, paramname);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalparameterClientParamnameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a global parameter
    ApiResponse<ApiResponse> response = apiInstance.GlobalparameterClientParamnameDeleteWithHttpInfo(varClient, paramname);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **paramname** | **string** | parameter name |  |

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
| **200** | A list of Roles that the system knows about |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="globalparameterclientparamnameget"></a>
# **GlobalparameterClientParamnameGet**
> ParameterList GlobalparameterClientParamnameGet (string varClient, string paramname)

Get individual Global Parameter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class GlobalparameterClientParamnameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var varClient = "varClient_example";  // string | Client name
            var paramname = "paramname_example";  // string | parameter name

            try
            {
                // Get individual Global Parameter
                ParameterList result = apiInstance.GlobalparameterClientParamnameGet(varClient, paramname);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalparameterClientParamnameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get individual Global Parameter
    ApiResponse<ParameterList> response = apiInstance.GlobalparameterClientParamnameGetWithHttpInfo(varClient, paramname);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **paramname** | **string** | parameter name |  |

### Return type

[**ParameterList**](ParameterList.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Roles that the system knows about |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="globalparameterclientparamnameput"></a>
# **GlobalparameterClientParamnamePut**
> ParameterApiResponse GlobalparameterClientParamnamePut (string varClient, string paramname, Parameter varParameter)

Update Global Parameter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class GlobalparameterClientParamnamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var varClient = "varClient_example";  // string | Client name
            var paramname = "paramname_example";  // string | parameter name
            var varParameter = new Parameter(); // Parameter | 

            try
            {
                // Update Global Parameter
                ParameterApiResponse result = apiInstance.GlobalparameterClientParamnamePut(varClient, paramname, varParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalparameterClientParamnamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Global Parameter
    ApiResponse<ParameterApiResponse> response = apiInstance.GlobalparameterClientParamnamePutWithHttpInfo(varClient, paramname, varParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterClientParamnamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **paramname** | **string** | parameter name |  |
| **varParameter** | [**Parameter**](Parameter.md) |  |  |

### Return type

[**ParameterApiResponse**](ParameterApiResponse.md)

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

<a id="globalparameterget"></a>
# **GlobalparameterGet**
> ParameterList GlobalparameterGet (int? from = null, int? to = null, string? sortProperty = null, string? sortDescending = null, string? searchText = null, List<string>? iClients = null)

Get global parameters for all clients

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class GlobalparameterGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var sortProperty = "sortProperty_example";  // string? | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. (optional) 
            var sortDescending = "sortDescending_example";  // string? | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty (optional) 
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 
            var iClients = new List<string>?(); // List<string>? | Only include these client(s) (optional) 

            try
            {
                // Get global parameters for all clients
                ParameterList result = apiInstance.GlobalparameterGet(from, to, sortProperty, sortDescending, searchText, iClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalparameterGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get global parameters for all clients
    ApiResponse<ParameterList> response = apiInstance.GlobalparameterGetWithHttpInfo(from, to, sortProperty, sortDescending, searchText, iClients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **sortProperty** | **string?** | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. | [optional]  |
| **sortDescending** | **string?** | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty | [optional]  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |
| **iClients** | [**List&lt;string&gt;?**](string.md) | Only include these client(s) | [optional]  |

### Return type

[**ParameterList**](ParameterList.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Roles that the system knows about |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="globalparameterpost"></a>
# **GlobalparameterPost**
> ParameterApiResponse GlobalparameterPost (Parameter? varParameter = null)

Create Global Parameter (will fail if already exists)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class GlobalparameterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new GlobalparameterApi(config);
            var varParameter = new Parameter?(); // Parameter? |  (optional) 

            try
            {
                // Create Global Parameter (will fail if already exists)
                ParameterApiResponse result = apiInstance.GlobalparameterPost(varParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlobalparameterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Global Parameter (will fail if already exists)
    ApiResponse<ParameterApiResponse> response = apiInstance.GlobalparameterPostWithHttpInfo(varParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalparameterApi.GlobalparameterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varParameter** | [**Parameter?**](Parameter?.md) |  | [optional]  |

### Return type

[**ParameterApiResponse**](ParameterApiResponse.md)

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

