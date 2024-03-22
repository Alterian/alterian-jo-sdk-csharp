# Alterian.JO.Api.TemplatesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadTemplateClientTemplatenameGet**](TemplatesApi.md#downloadtemplateclienttemplatenameget) | **GET** /download/template/{client}/{templatename} | Download the rule file for a specific version of a specific template for a specific client |
| [**DownloadTemplateClientTemplatenameVersionGet**](TemplatesApi.md#downloadtemplateclienttemplatenameversionget) | **GET** /download/template/{client}/{templatename}/{version} | Download the rule file for a specific version of a specific template for a specific client |
| [**TemplateClientDelete**](TemplatesApi.md#templateclientdelete) | **DELETE** /template/{client} | Delete all templates uploaded by this client. |
| [**TemplateClientGet**](TemplatesApi.md#templateclientget) | **GET** /template/{client} | Get details about all templates uploaded by a specific client |
| [**TemplateClientTemplatenameDelete**](TemplatesApi.md#templateclienttemplatenamedelete) | **DELETE** /template/{client}/{templatename} | Delete all versions of a specific template. |
| [**TemplateClientTemplatenameGet**](TemplatesApi.md#templateclienttemplatenameget) | **GET** /template/{client}/{templatename} | Get details about all versions of a specified template |
| [**TemplateClientTemplatenamePost**](TemplatesApi.md#templateclienttemplatenamepost) | **POST** /template/{client}/{templatename} | Upload a KTR file which defines the functionality of the template. This will generate and return a version   number. |
| [**TemplateClientTemplatenamePut**](TemplatesApi.md#templateclienttemplatenameput) | **PUT** /template/{client}/{templatename} | Alter the settings of the most recent version of an existing template. This will generate and return a new   version number. |
| [**TemplateClientTemplatenameVersionDelete**](TemplatesApi.md#templateclienttemplatenameversiondelete) | **DELETE** /template/{client}/{templatename}/{version} | Delete a specific version of a specific template on the server. |
| [**TemplateClientTemplatenameVersionGet**](TemplatesApi.md#templateclienttemplatenameversionget) | **GET** /template/{client}/{templatename}/{version} | Get details about a specific version of a specific template for a specific client |
| [**TemplateClientTemplatenameVersionPost**](TemplatesApi.md#templateclienttemplatenameversionpost) | **POST** /template/{client}/{templatename}/{version} | Get an upgraded version of template |
| [**TemplateGet**](TemplatesApi.md#templateget) | **GET** /template | Get details about all templates on the server |
| [**TemplateTargetClientTemplatenameVersionPost**](TemplatesApi.md#templatetargetclienttemplatenameversionpost) | **POST** /template/{target}/{client}/{templatename}/{version} | Take a specific version of a template and publish it as a rule. |
| [**TemplateTargetClientTemplatenameVersionPut**](TemplatesApi.md#templatetargetclienttemplatenameversionput) | **PUT** /template/{target}/{client}/{templatename}/{version} | Take a specific version of a template and publish it as a rule. and check if overwriting an existing rule   which has a different template |

<a id="downloadtemplateclienttemplatenameget"></a>
# **DownloadTemplateClientTemplatenameGet**
> System.IO.Stream DownloadTemplateClientTemplatenameGet (string varClient, string templatename)

Download the rule file for a specific version of a specific template for a specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class DownloadTemplateClientTemplatenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template

            try
            {
                // Download the rule file for a specific version of a specific template for a specific client
                System.IO.Stream result = apiInstance.DownloadTemplateClientTemplatenameGet(varClient, templatename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.DownloadTemplateClientTemplatenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadTemplateClientTemplatenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download the rule file for a specific version of a specific template for a specific client
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadTemplateClientTemplatenameGetWithHttpInfo(varClient, templatename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.DownloadTemplateClientTemplatenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |

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
| **200** | A uuencoded octet stream containing the template ktr file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="downloadtemplateclienttemplatenameversionget"></a>
# **DownloadTemplateClientTemplatenameVersionGet**
> System.IO.Stream DownloadTemplateClientTemplatenameVersionGet (string varClient, string templatename, int varVersion)

Download the rule file for a specific version of a specific template for a specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class DownloadTemplateClientTemplatenameVersionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var varVersion = 56;  // int | A uuencoded octet stream containing the template ktr file

            try
            {
                // Download the rule file for a specific version of a specific template for a specific client
                System.IO.Stream result = apiInstance.DownloadTemplateClientTemplatenameVersionGet(varClient, templatename, varVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.DownloadTemplateClientTemplatenameVersionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadTemplateClientTemplatenameVersionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download the rule file for a specific version of a specific template for a specific client
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadTemplateClientTemplatenameVersionGetWithHttpInfo(varClient, templatename, varVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.DownloadTemplateClientTemplatenameVersionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **varVersion** | **int** | A uuencoded octet stream containing the template ktr file |  |

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
| **200** | A uuencoded octet stream containing the template ktr file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="templateclientdelete"></a>
# **TemplateClientDelete**
> ApiResponse TemplateClientDelete (string varClient)

Delete all templates uploaded by this client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Delete all templates uploaded by this client.
                ApiResponse result = apiInstance.TemplateClientDelete(varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all templates uploaded by this client.
    ApiResponse<ApiResponse> response = apiInstance.TemplateClientDeleteWithHttpInfo(varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientDeleteWithHttpInfo: " + e.Message);
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

<a id="templateclientget"></a>
# **TemplateClientGet**
> TemplateList TemplateClientGet (string varClient, int? from = null, int? to = null, bool? allversions = null, bool? getAllDetails = null, bool? basicInfo = null, string? targetClient = null, string? searchText = null, bool? includePublic = null, List<string>? iClients = null)

Get details about all templates uploaded by a specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var allversions = true;  // bool? | Do we want all versions of the file listed? (optional) 
            var getAllDetails = true;  // bool? | Do we want to retrieve details of Data Grids present in this template. (optional) 
            var basicInfo = true;  // bool? | Only retrieve the basic information about this template, like name, client and url template. (optional) 
            var targetClient = "targetClient_example";  // string? | Request template's Data Grids' details with parameter information for this client. (optional) 
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 
            var includePublic = true;  // bool? | Flag to indicate whether rules from the public client should be included in the results, please use   iClients=public instead (optional) 
            var iClients = new List<string>?(); // List<string>? | Only include these client(s) (optional) 

            try
            {
                // Get details about all templates uploaded by a specific client
                TemplateList result = apiInstance.TemplateClientGet(varClient, from, to, allversions, getAllDetails, basicInfo, targetClient, searchText, includePublic, iClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all templates uploaded by a specific client
    ApiResponse<TemplateList> response = apiInstance.TemplateClientGetWithHttpInfo(varClient, from, to, allversions, getAllDetails, basicInfo, targetClient, searchText, includePublic, iClients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientGetWithHttpInfo: " + e.Message);
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
| **allversions** | **bool?** | Do we want all versions of the file listed? | [optional]  |
| **getAllDetails** | **bool?** | Do we want to retrieve details of Data Grids present in this template. | [optional]  |
| **basicInfo** | **bool?** | Only retrieve the basic information about this template, like name, client and url template. | [optional]  |
| **targetClient** | **string?** | Request template&#39;s Data Grids&#39; details with parameter information for this client. | [optional]  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |
| **includePublic** | **bool?** | Flag to indicate whether rules from the public client should be included in the results, please use   iClients&#x3D;public instead | [optional]  |
| **iClients** | [**List&lt;string&gt;?**](string.md) | Only include these client(s) | [optional]  |

### Return type

[**TemplateList**](TemplateList.md)

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

<a id="templateclienttemplatenamedelete"></a>
# **TemplateClientTemplatenameDelete**
> ApiResponse TemplateClientTemplatenameDelete (string varClient, string templatename)

Delete all versions of a specific template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientTemplatenameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template you want to delete

            try
            {
                // Delete all versions of a specific template.
                ApiResponse result = apiInstance.TemplateClientTemplatenameDelete(varClient, templatename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientTemplatenameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all versions of a specific template.
    ApiResponse<ApiResponse> response = apiInstance.TemplateClientTemplatenameDeleteWithHttpInfo(varClient, templatename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template you want to delete |  |

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

<a id="templateclienttemplatenameget"></a>
# **TemplateClientTemplatenameGet**
> TemplateList TemplateClientTemplatenameGet (string varClient, string templatename, int? from = null, int? to = null, bool? allversions = null, bool? getAllDetails = null, string? targetClient = null)

Get details about all versions of a specified template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientTemplatenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var allversions = true;  // bool? | Do we want all versions of the file listed? (optional) 
            var getAllDetails = true;  // bool? | Do we want to retrieve details of Data Grids present in this template. (optional) 
            var targetClient = "targetClient_example";  // string? | Request template's Data Grids' details with parameter information for this client. (optional) 

            try
            {
                // Get details about all versions of a specified template
                TemplateList result = apiInstance.TemplateClientTemplatenameGet(varClient, templatename, from, to, allversions, getAllDetails, targetClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientTemplatenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all versions of a specified template
    ApiResponse<TemplateList> response = apiInstance.TemplateClientTemplatenameGetWithHttpInfo(varClient, templatename, from, to, allversions, getAllDetails, targetClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **allversions** | **bool?** | Do we want all versions of the file listed? | [optional]  |
| **getAllDetails** | **bool?** | Do we want to retrieve details of Data Grids present in this template. | [optional]  |
| **targetClient** | **string?** | Request template&#39;s Data Grids&#39; details with parameter information for this client. | [optional]  |

### Return type

[**TemplateList**](TemplateList.md)

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

<a id="templateclienttemplatenamepost"></a>
# **TemplateClientTemplatenamePost**
> ResourceAndStatusResponse TemplateClientTemplatenamePost (string varClient, string templatename, bool? validate = null, System.IO.Stream? file = null, string? settings = null)

Upload a KTR file which defines the functionality of the template. This will generate and return a version   number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientTemplatenamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var validate = true;  // bool? | Set to 'True' to only validate the JSON (and not save it) (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 
            var settings = "settings_example";  // string? |  (optional) 

            try
            {
                // Upload a KTR file which defines the functionality of the template. This will generate and return a version   number.
                ResourceAndStatusResponse result = apiInstance.TemplateClientTemplatenamePost(varClient, templatename, validate, file, settings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientTemplatenamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a KTR file which defines the functionality of the template. This will generate and return a version   number.
    ApiResponse<ResourceAndStatusResponse> response = apiInstance.TemplateClientTemplatenamePostWithHttpInfo(varClient, templatename, validate, file, settings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **validate** | **bool?** | Set to &#39;True&#39; to only validate the JSON (and not save it) | [optional]  |
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |
| **settings** | **string?** |  | [optional]  |

### Return type

[**ResourceAndStatusResponse**](ResourceAndStatusResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="templateclienttemplatenameput"></a>
# **TemplateClientTemplatenamePut**
> ResourceAndStatusResponse TemplateClientTemplatenamePut (string varClient, string templatename, Object? body = null)

Alter the settings of the most recent version of an existing template. This will generate and return a new   version number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientTemplatenamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var body = null;  // Object? | The JSON containing additional settings for this template. (optional) 

            try
            {
                // Alter the settings of the most recent version of an existing template. This will generate and return a new   version number.
                ResourceAndStatusResponse result = apiInstance.TemplateClientTemplatenamePut(varClient, templatename, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientTemplatenamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Alter the settings of the most recent version of an existing template. This will generate and return a new   version number.
    ApiResponse<ResourceAndStatusResponse> response = apiInstance.TemplateClientTemplatenamePutWithHttpInfo(varClient, templatename, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **body** | **Object?** | The JSON containing additional settings for this template. | [optional]  |

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

<a id="templateclienttemplatenameversiondelete"></a>
# **TemplateClientTemplatenameVersionDelete**
> ApiResponse TemplateClientTemplatenameVersionDelete (string varClient, string templatename, int varVersion)

Delete a specific version of a specific template on the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientTemplatenameVersionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var varVersion = 56;  // int | The version of the template

            try
            {
                // Delete a specific version of a specific template on the server.
                ApiResponse result = apiInstance.TemplateClientTemplatenameVersionDelete(varClient, templatename, varVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameVersionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientTemplatenameVersionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific version of a specific template on the server.
    ApiResponse<ApiResponse> response = apiInstance.TemplateClientTemplatenameVersionDeleteWithHttpInfo(varClient, templatename, varVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameVersionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **varVersion** | **int** | The version of the template |  |

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

<a id="templateclienttemplatenameversionget"></a>
# **TemplateClientTemplatenameVersionGet**
> TemplateList TemplateClientTemplatenameVersionGet (string varClient, string templatename, int varVersion, bool? getAllDetails = null, string? targetClient = null)

Get details about a specific version of a specific template for a specific client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientTemplatenameVersionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var varVersion = 56;  // int | The version of the template
            var getAllDetails = true;  // bool? | Do we want to retrieve details of Data Grids present in this template. (optional) 
            var targetClient = "targetClient_example";  // string? | Request template's Data Grids' details with parameter information for this client. (optional) 

            try
            {
                // Get details about a specific version of a specific template for a specific client
                TemplateList result = apiInstance.TemplateClientTemplatenameVersionGet(varClient, templatename, varVersion, getAllDetails, targetClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameVersionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientTemplatenameVersionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about a specific version of a specific template for a specific client
    ApiResponse<TemplateList> response = apiInstance.TemplateClientTemplatenameVersionGetWithHttpInfo(varClient, templatename, varVersion, getAllDetails, targetClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameVersionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **varVersion** | **int** | The version of the template |  |
| **getAllDetails** | **bool?** | Do we want to retrieve details of Data Grids present in this template. | [optional]  |
| **targetClient** | **string?** | Request template&#39;s Data Grids&#39; details with parameter information for this client. | [optional]  |

### Return type

[**TemplateList**](TemplateList.md)

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

<a id="templateclienttemplatenameversionpost"></a>
# **TemplateClientTemplatenameVersionPost**
> TemplateUpgradeResponse TemplateClientTemplatenameVersionPost (string varClient, string templatename, int varVersion, string? targetClient = null, Object? body = null)

Get an upgraded version of template

Post a JSON representing a Rule Designer's tile to retrieve a JSON tile where the template version has   been upgraded

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateClientTemplatenameVersionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var varVersion = 56;  // int | The version of the template
            var targetClient = "targetClient_example";  // string? | Request template's Data Grids' details with parameter information for this client. (optional) 
            var body = null;  // Object? | JSON representing the current template to upgrade (optional) 

            try
            {
                // Get an upgraded version of template
                TemplateUpgradeResponse result = apiInstance.TemplateClientTemplatenameVersionPost(varClient, templatename, varVersion, targetClient, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameVersionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateClientTemplatenameVersionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an upgraded version of template
    ApiResponse<TemplateUpgradeResponse> response = apiInstance.TemplateClientTemplatenameVersionPostWithHttpInfo(varClient, templatename, varVersion, targetClient, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateClientTemplatenameVersionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **varVersion** | **int** | The version of the template |  |
| **targetClient** | **string?** | Request template&#39;s Data Grids&#39; details with parameter information for this client. | [optional]  |
| **body** | **Object?** | JSON representing the current template to upgrade | [optional]  |

### Return type

[**TemplateUpgradeResponse**](TemplateUpgradeResponse.md)

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

<a id="templateget"></a>
# **TemplateGet**
> TemplateList TemplateGet (int? from = null, int? to = null, bool? allversions = null, bool? getAllDetails = null, bool? basicInfo = null, string? targetClient = null, string? searchText = null, bool? includePublic = null, List<string>? iClients = null)

Get details about all templates on the server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var allversions = true;  // bool? | Do we want all versions of the file listed? (optional) 
            var getAllDetails = true;  // bool? | Do we want to retrieve details of Data Grids present in this template. (optional) 
            var basicInfo = true;  // bool? | Only retrieve the basic information about this template, like name, client and url template. (optional) 
            var targetClient = "targetClient_example";  // string? | Request template's Data Grids' details with parameter information for this client. (optional) 
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 
            var includePublic = true;  // bool? | Flag to indicate whether rules from the public client should be included in the results, please use   iClients=public instead (optional) 
            var iClients = new List<string>?(); // List<string>? | Only include these client(s) (optional) 

            try
            {
                // Get details about all templates on the server
                TemplateList result = apiInstance.TemplateGet(from, to, allversions, getAllDetails, basicInfo, targetClient, searchText, includePublic, iClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all templates on the server
    ApiResponse<TemplateList> response = apiInstance.TemplateGetWithHttpInfo(from, to, allversions, getAllDetails, basicInfo, targetClient, searchText, includePublic, iClients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **allversions** | **bool?** | Do we want all versions of the file listed? | [optional]  |
| **getAllDetails** | **bool?** | Do we want to retrieve details of Data Grids present in this template. | [optional]  |
| **basicInfo** | **bool?** | Only retrieve the basic information about this template, like name, client and url template. | [optional]  |
| **targetClient** | **string?** | Request template&#39;s Data Grids&#39; details with parameter information for this client. | [optional]  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |
| **includePublic** | **bool?** | Flag to indicate whether rules from the public client should be included in the results, please use   iClients&#x3D;public instead | [optional]  |
| **iClients** | [**List&lt;string&gt;?**](string.md) | Only include these client(s) | [optional]  |

### Return type

[**TemplateList**](TemplateList.md)

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

<a id="templatetargetclienttemplatenameversionpost"></a>
# **TemplateTargetClientTemplatenameVersionPost**
> ResourceAndStatusResponse TemplateTargetClientTemplatenameVersionPost (TargetEnum target, string varClient, string templatename, int varVersion, string? paramSource = null, string? targetClient = null, TemplatePublishSettings? templatePublishSettings = null)

Take a specific version of a template and publish it as a rule.

If a rule is already published at this target then it will be 'hot-swapped' with this new version with no   interruption to service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateTargetClientTemplatenameVersionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var varVersion = 56;  // int | The version of the template
            var paramSource = "";  // string? | When overwriting an existing rule, this determines which value to use (optional) 
            var targetClient = "targetClient_example";  // string? | Request template's Data Grids' details with parameter information for this client. (optional) 
            var templatePublishSettings = new TemplatePublishSettings?(); // TemplatePublishSettings? | The JSON containing additional settings for this template. (optional) 

            try
            {
                // Take a specific version of a template and publish it as a rule.
                ResourceAndStatusResponse result = apiInstance.TemplateTargetClientTemplatenameVersionPost(target, varClient, templatename, varVersion, paramSource, targetClient, templatePublishSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateTargetClientTemplatenameVersionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateTargetClientTemplatenameVersionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Take a specific version of a template and publish it as a rule.
    ApiResponse<ResourceAndStatusResponse> response = apiInstance.TemplateTargetClientTemplatenameVersionPostWithHttpInfo(target, varClient, templatename, varVersion, paramSource, targetClient, templatePublishSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateTargetClientTemplatenameVersionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **varVersion** | **int** | The version of the template |  |
| **paramSource** | **string?** | When overwriting an existing rule, this determines which value to use | [optional]  |
| **targetClient** | **string?** | Request template&#39;s Data Grids&#39; details with parameter information for this client. | [optional]  |
| **templatePublishSettings** | [**TemplatePublishSettings?**](TemplatePublishSettings?.md) | The JSON containing additional settings for this template. | [optional]  |

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

<a id="templatetargetclienttemplatenameversionput"></a>
# **TemplateTargetClientTemplatenameVersionPut**
> ApiResponse TemplateTargetClientTemplatenameVersionPut (TargetEnum target, string varClient, string templatename, int varVersion, string? targetClient = null, ModelClient? modelClient = null)

Take a specific version of a template and publish it as a rule. and check if overwriting an existing rule   which has a different template

If a rule is already published at this target then it will be 'hot-swapped' with this new version with no   interruption to service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TemplateTargetClientTemplatenameVersionPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var templatename = "templatename_example";  // string | The name of the template
            var varVersion = 56;  // int | The version of the template
            var targetClient = "targetClient_example";  // string? | Request template's Data Grids' details with parameter information for this client. (optional) 
            var modelClient = new ModelClient?(); // ModelClient? |  (optional) 

            try
            {
                // Take a specific version of a template and publish it as a rule. and check if overwriting an existing rule   which has a different template
                ApiResponse result = apiInstance.TemplateTargetClientTemplatenameVersionPut(target, varClient, templatename, varVersion, targetClient, modelClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplateTargetClientTemplatenameVersionPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateTargetClientTemplatenameVersionPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Take a specific version of a template and publish it as a rule. and check if overwriting an existing rule   which has a different template
    ApiResponse<ApiResponse> response = apiInstance.TemplateTargetClientTemplatenameVersionPutWithHttpInfo(target, varClient, templatename, varVersion, targetClient, modelClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplateTargetClientTemplatenameVersionPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **templatename** | **string** | The name of the template |  |
| **varVersion** | **int** | The version of the template |  |
| **targetClient** | **string?** | Request template&#39;s Data Grids&#39; details with parameter information for this client. | [optional]  |
| **modelClient** | [**ModelClient?**](ModelClient?.md) |  | [optional]  |

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

