# Alterian.JO.Api.LicenseApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LicenseClientActiveGet**](LicenseApi.md#licenseclientactiveget) | **GET** /license/{client}/active | Get the currently active license for a client |
| [**LicenseClientGet**](LicenseApi.md#licenseclientget) | **GET** /license/{client} | Get all licenses for the specified client |
| [**LicenseClientLicenseDelete**](LicenseApi.md#licenseclientlicensedelete) | **DELETE** /license/{client}/{license} | Delete specified license |
| [**LicenseClientLicenseGet**](LicenseApi.md#licenseclientlicenseget) | **GET** /license/{client}/{license} | Get a specific license |
| [**LicenseClientLicensePost**](LicenseApi.md#licenseclientlicensepost) | **POST** /license/{client}/{license} | Create a new license |
| [**LicenseClientLicensePut**](LicenseApi.md#licenseclientlicenseput) | **PUT** /license/{client}/{license} | Create or update a license |
| [**LicenseGet**](LicenseApi.md#licenseget) | **GET** /license | Get all licenses for all clients that your login can access |

<a id="licenseclientactiveget"></a>
# **LicenseClientActiveGet**
> LicenseList LicenseClientActiveGet (string varClient)

Get the currently active license for a client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LicenseClientActiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LicenseApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Get the currently active license for a client
                LicenseList result = apiInstance.LicenseClientActiveGet(varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseClientActiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LicenseClientActiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the currently active license for a client
    ApiResponse<LicenseList> response = apiInstance.LicenseClientActiveGetWithHttpInfo(varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.LicenseClientActiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |

### Return type

[**LicenseList**](LicenseList.md)

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

<a id="licenseclientget"></a>
# **LicenseClientGet**
> LicenseList LicenseClientGet (string varClient)

Get all licenses for the specified client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LicenseClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LicenseApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Get all licenses for the specified client
                LicenseList result = apiInstance.LicenseClientGet(varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LicenseClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all licenses for the specified client
    ApiResponse<LicenseList> response = apiInstance.LicenseClientGetWithHttpInfo(varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.LicenseClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |

### Return type

[**LicenseList**](LicenseList.md)

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

<a id="licenseclientlicensedelete"></a>
# **LicenseClientLicenseDelete**
> ApiResponse LicenseClientLicenseDelete (string varClient, string license)

Delete specified license

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LicenseClientLicenseDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LicenseApi(config);
            var varClient = "varClient_example";  // string | Client name
            var license = "license_example";  // string | License to delete

            try
            {
                // Delete specified license
                ApiResponse result = apiInstance.LicenseClientLicenseDelete(varClient, license);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseClientLicenseDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LicenseClientLicenseDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete specified license
    ApiResponse<ApiResponse> response = apiInstance.LicenseClientLicenseDeleteWithHttpInfo(varClient, license);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.LicenseClientLicenseDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **license** | **string** | License to delete |  |

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

<a id="licenseclientlicenseget"></a>
# **LicenseClientLicenseGet**
> LicenseList LicenseClientLicenseGet (string varClient, string? license = null)

Get a specific license

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LicenseClientLicenseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LicenseApi(config);
            var varClient = "varClient_example";  // string | Client name
            var license = "license_example";  // string? | License to get (optional) 

            try
            {
                // Get a specific license
                LicenseList result = apiInstance.LicenseClientLicenseGet(varClient, license);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseClientLicenseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LicenseClientLicenseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific license
    ApiResponse<LicenseList> response = apiInstance.LicenseClientLicenseGetWithHttpInfo(varClient, license);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.LicenseClientLicenseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **license** | **string?** | License to get | [optional]  |

### Return type

[**LicenseList**](LicenseList.md)

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

<a id="licenseclientlicensepost"></a>
# **LicenseClientLicensePost**
> ApiResponse LicenseClientLicensePost (string varClient, LicenseData licenseData, string? license = null)

Create a new license

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LicenseClientLicensePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LicenseApi(config);
            var varClient = "varClient_example";  // string | Client name
            var licenseData = new LicenseData(); // LicenseData | 
            var license = "license_example";  // string? | License name to post; has the same name requirements as the name of a rule; must not contain invalid   characters like \"..\", etc. (optional) 

            try
            {
                // Create a new license
                ApiResponse result = apiInstance.LicenseClientLicensePost(varClient, licenseData, license);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseClientLicensePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LicenseClientLicensePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new license
    ApiResponse<ApiResponse> response = apiInstance.LicenseClientLicensePostWithHttpInfo(varClient, licenseData, license);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.LicenseClientLicensePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **licenseData** | [**LicenseData**](LicenseData.md) |  |  |
| **license** | **string?** | License name to post; has the same name requirements as the name of a rule; must not contain invalid   characters like \&quot;..\&quot;, etc. | [optional]  |

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

<a id="licenseclientlicenseput"></a>
# **LicenseClientLicensePut**
> ApiResponse LicenseClientLicensePut (string varClient, string body, string? license = null)

Create or update a license

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LicenseClientLicensePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LicenseApi(config);
            var varClient = "varClient_example";  // string | Client name
            var body = {"blockOverage":"False","conversationQuota":100000,"endDate":"","startDate":"2021-01-01T12:00:00.000Z"};  // string | A block of JSON describing the license
            var license = "license_example";  // string? | License name to put; has the same name requirements as the name of a rule; must not contain invalid   characters like \"..\", etc. (optional) 

            try
            {
                // Create or update a license
                ApiResponse result = apiInstance.LicenseClientLicensePut(varClient, body, license);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseClientLicensePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LicenseClientLicensePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or update a license
    ApiResponse<ApiResponse> response = apiInstance.LicenseClientLicensePutWithHttpInfo(varClient, body, license);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.LicenseClientLicensePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **body** | **string** | A block of JSON describing the license |  |
| **license** | **string?** | License name to put; has the same name requirements as the name of a rule; must not contain invalid   characters like \&quot;..\&quot;, etc. | [optional]  |

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

<a id="licenseget"></a>
# **LicenseGet**
> LicenseList LicenseGet ()

Get all licenses for all clients that your login can access

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class LicenseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new LicenseApi(config);

            try
            {
                // Get all licenses for all clients that your login can access
                LicenseList result = apiInstance.LicenseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LicenseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all licenses for all clients that your login can access
    ApiResponse<LicenseList> response = apiInstance.LicenseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.LicenseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LicenseList**](LicenseList.md)

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

