# Alterian.JO.Api.ClientApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClientClientAliasAliasNameDelete**](ClientApi.md#clientclientaliasaliasnamedelete) | **DELETE** /client/{client}/alias/{aliasName} | Deletes a specific alias from the client |
| [**ClientClientAliasAliasNameGet**](ClientApi.md#clientclientaliasaliasnameget) | **GET** /client/{client}/alias/{aliasName} | Returns back information about a specific alias |
| [**ClientClientAliasAliasNameTargetRuleorgroupPost**](ClientApi.md#clientclientaliasaliasnametargetruleorgrouppost) | **POST** /client/{client}/alias/{aliasName}/{target}/{ruleorgroup} | Creates or updates an alias |
| [**ClientClientAliasAliasNameTargetRuleorgroupPut**](ClientApi.md#clientclientaliasaliasnametargetruleorgroupput) | **PUT** /client/{client}/alias/{aliasName}/{target}/{ruleorgroup} | Create a new alias, must not exist. |
| [**ClientClientAliasGet**](ClientApi.md#clientclientaliasget) | **GET** /client/{client}/alias | Returns back all aliases which have been defined for a client |
| [**ClientClientCopyDestinationPut**](ClientApi.md#clientclientcopydestinationput) | **PUT** /client/{client}/copy/{destination} | Copy an existing client to a client with a new name |
| [**ClientClientDelete**](ClientApi.md#clientclientdelete) | **DELETE** /client/{client} | Delete all client files that have been uploaded to the server. |
| [**ClientClientGet**](ClientApi.md#clientclientget) | **GET** /client/{client} | Returns extended details about a client. |
| [**ClientClientPost**](ClientApi.md#clientclientpost) | **POST** /client/{client} | Updates a client&#39;s parameters |
| [**ClientClientPut**](ClientApi.md#clientclientput) | **PUT** /client/{client} | Create a new client. |
| [**ClientCopySourcePut**](ClientApi.md#clientcopysourceput) | **PUT** /client/copy/{source} | Copy an existing client to a client with a new name |
| [**ClientGet**](ClientApi.md#clientget) | **GET** /client | Get a list of all clients that your login can access, and all permissions that you have |

<a id="clientclientaliasaliasnamedelete"></a>
# **ClientClientAliasAliasNameDelete**
> ApiResponse ClientClientAliasAliasNameDelete (string varClient, string aliasName)

Deletes a specific alias from the client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientAliasAliasNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | Client name
            var aliasName = "aliasName_example";  // string | The name of the alias

            try
            {
                // Deletes a specific alias from the client
                ApiResponse result = apiInstance.ClientClientAliasAliasNameDelete(varClient, aliasName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientAliasAliasNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientAliasAliasNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific alias from the client
    ApiResponse<ApiResponse> response = apiInstance.ClientClientAliasAliasNameDeleteWithHttpInfo(varClient, aliasName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientAliasAliasNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **aliasName** | **string** | The name of the alias |  |

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

<a id="clientclientaliasaliasnameget"></a>
# **ClientClientAliasAliasNameGet**
> ApiResponse ClientClientAliasAliasNameGet (string varClient, string aliasName)

Returns back information about a specific alias

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientAliasAliasNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | Client name
            var aliasName = "aliasName_example";  // string | The name of the alias

            try
            {
                // Returns back information about a specific alias
                ApiResponse result = apiInstance.ClientClientAliasAliasNameGet(varClient, aliasName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientAliasAliasNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientAliasAliasNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back information about a specific alias
    ApiResponse<ApiResponse> response = apiInstance.ClientClientAliasAliasNameGetWithHttpInfo(varClient, aliasName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientAliasAliasNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **aliasName** | **string** | The name of the alias |  |

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

<a id="clientclientaliasaliasnametargetruleorgrouppost"></a>
# **ClientClientAliasAliasNameTargetRuleorgroupPost**
> ApiResponse ClientClientAliasAliasNameTargetRuleorgroupPost (string varClient, string aliasName, TargetEnum target, string ruleorgroup)

Creates or updates an alias

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientAliasAliasNameTargetRuleorgroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | Client name, must begin with a letter, can only contain alphanumerics and hyphens, and must be no   more than 40 characters long
            var aliasName = "aliasName_example";  // string | The name of the alias
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var ruleorgroup = "ruleorgroup_example";  // string | The name of the rule or rule group to which this alias should point

            try
            {
                // Creates or updates an alias
                ApiResponse result = apiInstance.ClientClientAliasAliasNameTargetRuleorgroupPost(varClient, aliasName, target, ruleorgroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientAliasAliasNameTargetRuleorgroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientAliasAliasNameTargetRuleorgroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates an alias
    ApiResponse<ApiResponse> response = apiInstance.ClientClientAliasAliasNameTargetRuleorgroupPostWithHttpInfo(varClient, aliasName, target, ruleorgroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientAliasAliasNameTargetRuleorgroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name, must begin with a letter, can only contain alphanumerics and hyphens, and must be no   more than 40 characters long |  |
| **aliasName** | **string** | The name of the alias |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **ruleorgroup** | **string** | The name of the rule or rule group to which this alias should point |  |

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

<a id="clientclientaliasaliasnametargetruleorgroupput"></a>
# **ClientClientAliasAliasNameTargetRuleorgroupPut**
> ResourceAndStatusResponse ClientClientAliasAliasNameTargetRuleorgroupPut (string varClient, string aliasName, TargetEnum target, string ruleorgroup)

Create a new alias, must not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientAliasAliasNameTargetRuleorgroupPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | Client name, must begin with a letter, can only contain alphanumerics and hyphens, and must be no   more than 40 characters long
            var aliasName = "aliasName_example";  // string | The name of the alias
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var ruleorgroup = "ruleorgroup_example";  // string | The name of the rule or rule group to which this alias should point

            try
            {
                // Create a new alias, must not exist.
                ResourceAndStatusResponse result = apiInstance.ClientClientAliasAliasNameTargetRuleorgroupPut(varClient, aliasName, target, ruleorgroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientAliasAliasNameTargetRuleorgroupPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientAliasAliasNameTargetRuleorgroupPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new alias, must not exist.
    ApiResponse<ResourceAndStatusResponse> response = apiInstance.ClientClientAliasAliasNameTargetRuleorgroupPutWithHttpInfo(varClient, aliasName, target, ruleorgroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientAliasAliasNameTargetRuleorgroupPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name, must begin with a letter, can only contain alphanumerics and hyphens, and must be no   more than 40 characters long |  |
| **aliasName** | **string** | The name of the alias |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **ruleorgroup** | **string** | The name of the rule or rule group to which this alias should point |  |

### Return type

[**ResourceAndStatusResponse**](ResourceAndStatusResponse.md)

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

<a id="clientclientaliasget"></a>
# **ClientClientAliasGet**
> ClientResponse ClientClientAliasGet (string varClient)

Returns back all aliases which have been defined for a client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientAliasGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Returns back all aliases which have been defined for a client
                ClientResponse result = apiInstance.ClientClientAliasGet(varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientAliasGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientAliasGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back all aliases which have been defined for a client
    ApiResponse<ClientResponse> response = apiInstance.ClientClientAliasGetWithHttpInfo(varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientAliasGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |

### Return type

[**ClientResponse**](ClientResponse.md)

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

<a id="clientclientcopydestinationput"></a>
# **ClientClientCopyDestinationPut**
> ApiResponse ClientClientCopyDestinationPut (string varClient, string? destination = null)

Copy an existing client to a client with a new name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientCopyDestinationPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | The source client
            var destination = "destination_example";  // string? | The new client name (optional) 

            try
            {
                // Copy an existing client to a client with a new name
                ApiResponse result = apiInstance.ClientClientCopyDestinationPut(varClient, destination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientCopyDestinationPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientCopyDestinationPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy an existing client to a client with a new name
    ApiResponse<ApiResponse> response = apiInstance.ClientClientCopyDestinationPutWithHttpInfo(varClient, destination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientCopyDestinationPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | The source client |  |
| **destination** | **string?** | The new client name | [optional]  |

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

<a id="clientclientdelete"></a>
# **ClientClientDelete**
> ApiResponse ClientClientDelete (string varClient)

Delete all client files that have been uploaded to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Delete all client files that have been uploaded to the server.
                ApiResponse result = apiInstance.ClientClientDelete(varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all client files that have been uploaded to the server.
    ApiResponse<ApiResponse> response = apiInstance.ClientClientDeleteWithHttpInfo(varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientDeleteWithHttpInfo: " + e.Message);
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

<a id="clientclientget"></a>
# **ClientClientGet**
> ClientResponse ClientClientGet (string varClient, bool? aszip = null, bool? asdata = null)

Returns extended details about a client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | client name, you can use * to return all clients to which your account has access
            var aszip = true;  // bool? | Return back the entire client in a zip (compresses everything except files).  Requires ALL   permissions.  Note, you cannot use a wildcard with this option. (optional) 
            var asdata = true;  // bool? | If this is true, it will return just the client list in the data property and exclude permissions,   etc. from the result.  Useful if you simply want a list of clients. (optional) 

            try
            {
                // Returns extended details about a client.
                ClientResponse result = apiInstance.ClientClientGet(varClient, aszip, asdata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns extended details about a client.
    ApiResponse<ClientResponse> response = apiInstance.ClientClientGetWithHttpInfo(varClient, aszip, asdata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | client name, you can use * to return all clients to which your account has access |  |
| **aszip** | **bool?** | Return back the entire client in a zip (compresses everything except files).  Requires ALL   permissions.  Note, you cannot use a wildcard with this option. | [optional]  |
| **asdata** | **bool?** | If this is true, it will return just the client list in the data property and exclude permissions,   etc. from the result.  Useful if you simply want a list of clients. | [optional]  |

### Return type

[**ClientResponse**](ClientResponse.md)

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

<a id="clientclientpost"></a>
# **ClientClientPost**
> ApiResponse ClientClientPost (string varClient, ModelClient? modelClient = null)

Updates a client's parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | Client name
            var modelClient = new ModelClient?(); // ModelClient? |  (optional) 

            try
            {
                // Updates a client's parameters
                ApiResponse result = apiInstance.ClientClientPost(varClient, modelClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a client's parameters
    ApiResponse<ApiResponse> response = apiInstance.ClientClientPostWithHttpInfo(varClient, modelClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
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

<a id="clientclientput"></a>
# **ClientClientPut**
> ApiResponse ClientClientPut (string varClient, ModelClient? modelClient = null)

Create a new client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientClientPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var varClient = "varClient_example";  // string | Client name, must begin with a letter, can only contain alphanumerics and hyphens, and must be no   more than 40 characters long
            var modelClient = new ModelClient?(); // ModelClient? |  (optional) 

            try
            {
                // Create a new client.
                ApiResponse result = apiInstance.ClientClientPut(varClient, modelClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientClientPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientClientPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new client.
    ApiResponse<ApiResponse> response = apiInstance.ClientClientPutWithHttpInfo(varClient, modelClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientClientPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name, must begin with a letter, can only contain alphanumerics and hyphens, and must be no   more than 40 characters long |  |
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

<a id="clientcopysourceput"></a>
# **ClientCopySourcePut**
> ApiResponse ClientCopySourcePut (string source, string? destination = null)

Copy an existing client to a client with a new name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientCopySourcePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);
            var source = "source_example";  // string | Source client name
            var destination = "destination_example";  // string? | The new client name (optional) 

            try
            {
                // Copy an existing client to a client with a new name
                ApiResponse result = apiInstance.ClientCopySourcePut(source, destination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientCopySourcePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientCopySourcePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy an existing client to a client with a new name
    ApiResponse<ApiResponse> response = apiInstance.ClientCopySourcePutWithHttpInfo(source, destination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientCopySourcePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | Source client name |  |
| **destination** | **string?** | The new client name | [optional]  |

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

<a id="clientget"></a>
# **ClientGet**
> ClientResponse ClientGet ()

Get a list of all clients that your login can access, and all permissions that you have

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClientApi(config);

            try
            {
                // Get a list of all clients that your login can access, and all permissions that you have
                ClientResponse result = apiInstance.ClientGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of all clients that your login can access, and all permissions that you have
    ApiResponse<ClientResponse> response = apiInstance.ClientGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.ClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ClientResponse**](ClientResponse.md)

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

