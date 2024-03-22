# Alterian.JO.Api.FileApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FileClientGet**](FileApi.md#fileclientget) | **GET** /file/{client} | Lists files |
| [**FileClientTargetFilenameDelete**](FileApi.md#fileclienttargetfilenamedelete) | **DELETE** /file/{client}/{target}/{filename} | Remove a file from the server |
| [**FileClientTargetFilenameGet**](FileApi.md#fileclienttargetfilenameget) | **GET** /file/{client}/{target}/{filename} | Download a file from the server |
| [**FileClientTargetFilenamePost**](FileApi.md#fileclienttargetfilenamepost) | **POST** /file/{client}/{target}/{filename} | Upload a file to the server |
| [**FileClientTargetGet**](FileApi.md#fileclienttargetget) | **GET** /file/{client}/{target} | Lists files |

<a id="fileclientget"></a>
# **FileClientGet**
> ApiResponse FileClientGet (string varClient, string? searchText = null)

Lists files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class FileClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new FileApi(config);
            var varClient = "varClient_example";  // string | Client name
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 

            try
            {
                // Lists files
                ApiResponse result = apiInstance.FileClientGet(varClient, searchText);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists files
    ApiResponse<ApiResponse> response = apiInstance.FileClientGetWithHttpInfo(varClient, searchText);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |

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

<a id="fileclienttargetfilenamedelete"></a>
# **FileClientTargetFilenameDelete**
> void FileClientTargetFilenameDelete (TargetEnum target, string varClient, string filename)

Remove a file from the server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class FileClientTargetFilenameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new FileApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var filename = "filename_example";  // string | file name

            try
            {
                // Remove a file from the server
                apiInstance.FileClientTargetFilenameDelete(target, varClient, filename);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileClientTargetFilenameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileClientTargetFilenameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a file from the server
    apiInstance.FileClientTargetFilenameDeleteWithHttpInfo(target, varClient, filename);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileClientTargetFilenameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **filename** | **string** | file name |  |

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
| **200** | A binary stream containing the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fileclienttargetfilenameget"></a>
# **FileClientTargetFilenameGet**
> void FileClientTargetFilenameGet (TargetEnum target, string varClient, string filename, string? searchText = null)

Download a file from the server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class FileClientTargetFilenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new FileApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var filename = "filename_example";  // string | file name
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 

            try
            {
                // Download a file from the server
                apiInstance.FileClientTargetFilenameGet(target, varClient, filename, searchText);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileClientTargetFilenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileClientTargetFilenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download a file from the server
    apiInstance.FileClientTargetFilenameGetWithHttpInfo(target, varClient, filename, searchText);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileClientTargetFilenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **filename** | **string** | file name |  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |

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
| **200** | A binary stream containing the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fileclienttargetfilenamepost"></a>
# **FileClientTargetFilenamePost**
> void FileClientTargetFilenamePost (TargetEnum target, string varClient, string filename, System.IO.Stream? file = null)

Upload a file to the server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class FileClientTargetFilenamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new FileApi(config);
            var target = new TargetEnum(); // TargetEnum | Target for the file
            var varClient = "varClient_example";  // string | client name
            var filename = "filename_example";  // string | file name
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                // Upload a file to the server
                apiInstance.FileClientTargetFilenamePost(target, varClient, filename, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileClientTargetFilenamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileClientTargetFilenamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a file to the server
    apiInstance.FileClientTargetFilenamePostWithHttpInfo(target, varClient, filename, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileClientTargetFilenamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target for the file |  |
| **varClient** | **string** | client name |  |
| **filename** | **string** | file name |  |
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A binary stream containing the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fileclienttargetget"></a>
# **FileClientTargetGet**
> ApiResponse FileClientTargetGet (TargetEnum target, string varClient, string? searchText = null)

Lists files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class FileClientTargetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new FileApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 

            try
            {
                // Lists files
                ApiResponse result = apiInstance.FileClientTargetGet(target, varClient, searchText);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileClientTargetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileClientTargetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists files
    ApiResponse<ApiResponse> response = apiInstance.FileClientTargetGetWithHttpInfo(target, varClient, searchText);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileClientTargetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |

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

