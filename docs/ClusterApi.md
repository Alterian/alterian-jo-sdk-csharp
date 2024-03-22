# Alterian.JO.Api.ClusterApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClusterDecommissionDelete**](ClusterApi.md#clusterdecommissiondelete) | **DELETE** /cluster/decommission | Remove this node from the cluster |
| [**ClusterDelete**](ClusterApi.md#clusterdelete) | **DELETE** /cluster | Removes from the cluster a down node that has not been seen for the longest |
| [**ClusterDiscoverPost**](ClusterApi.md#clusterdiscoverpost) | **POST** /cluster/discover | Ask the cluster to rerun the discovery process. |
| [**ClusterFlushPost**](ClusterApi.md#clusterflushpost) | **POST** /cluster/flush | Make sure all data in internal caches across the entire cluster are written to disk |
| [**ClusterGet**](ClusterApi.md#clusterget) | **GET** /cluster | Find out what instances are in the cluster |
| [**ClusterPost**](ClusterApi.md#clusterpost) | **POST** /cluster | Register an instance with the cluster |
| [**ClusterPut**](ClusterApi.md#clusterput) | **PUT** /cluster | Update an advanced cluster setting |
| [**ClusterReregisterPost**](ClusterApi.md#clusterreregisterpost) | **POST** /cluster/reregister | Make this note reregister itself with all the other nodes in the cluster without requiring a restart |
| [**ClusterStreamGet**](ClusterApi.md#clusterstreamget) | **GET** /cluster/stream | Find out the streaming status of an instance in the cluster |
| [**ClusterStreamThroughputGet**](ClusterApi.md#clusterstreamthroughputget) | **GET** /cluster/stream/throughput | Find out the current stream throughput (Mb per sec) of an instance in the cluster |
| [**ClusterStreamThroughputPost**](ClusterApi.md#clusterstreamthroughputpost) | **POST** /cluster/stream/throughput | Set the current stream throughput (Mb per sec) of an instance in the cluster |

<a id="clusterdecommissiondelete"></a>
# **ClusterDecommissionDelete**
> ClusterResponse ClusterDecommissionDelete (string targetnode)

Remove this node from the cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterDecommissionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);
            var targetnode = "targetnode_example";  // string | Must match the private IP address of the node, so there is no ambiguity when decommissioning

            try
            {
                // Remove this node from the cluster
                ClusterResponse result = apiInstance.ClusterDecommissionDelete(targetnode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterDecommissionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterDecommissionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove this node from the cluster
    ApiResponse<ClusterResponse> response = apiInstance.ClusterDecommissionDeleteWithHttpInfo(targetnode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterDecommissionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **targetnode** | **string** | Must match the private IP address of the node, so there is no ambiguity when decommissioning |  |

### Return type

[**ClusterResponse**](ClusterResponse.md)

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

<a id="clusterdelete"></a>
# **ClusterDelete**
> ClusterResponse ClusterDelete ()

Removes from the cluster a down node that has not been seen for the longest

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);

            try
            {
                // Removes from the cluster a down node that has not been seen for the longest
                ClusterResponse result = apiInstance.ClusterDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes from the cluster a down node that has not been seen for the longest
    ApiResponse<ClusterResponse> response = apiInstance.ClusterDeleteWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ClusterResponse**](ClusterResponse.md)

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

<a id="clusterdiscoverpost"></a>
# **ClusterDiscoverPost**
> ClusterResponse ClusterDiscoverPost ()

Ask the cluster to rerun the discovery process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterDiscoverPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);

            try
            {
                // Ask the cluster to rerun the discovery process.
                ClusterResponse result = apiInstance.ClusterDiscoverPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterDiscoverPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterDiscoverPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ask the cluster to rerun the discovery process.
    ApiResponse<ClusterResponse> response = apiInstance.ClusterDiscoverPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterDiscoverPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ClusterResponse**](ClusterResponse.md)

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

<a id="clusterflushpost"></a>
# **ClusterFlushPost**
> ApiResponse ClusterFlushPost ()

Make sure all data in internal caches across the entire cluster are written to disk

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterFlushPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);

            try
            {
                // Make sure all data in internal caches across the entire cluster are written to disk
                ApiResponse result = apiInstance.ClusterFlushPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterFlushPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterFlushPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make sure all data in internal caches across the entire cluster are written to disk
    ApiResponse<ApiResponse> response = apiInstance.ClusterFlushPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterFlushPostWithHttpInfo: " + e.Message);
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

<a id="clusterget"></a>
# **ClusterGet**
> ClusterResponse ClusterGet (bool? update = null, bool? repair = null, bool? includeSettings = null)

Find out what instances are in the cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);
            var update = true;  // bool? | Also ping the other instances in the cluster to check that they are present. (optional) 
            var repair = true;  // bool? | Request an immediate repair so this instance will definitely contain the same rules, templates, etc   as the other instances in this cluster. Only works if all instances are up (optional) 
            var includeSettings = true;  // bool? | Include extended details (optional) 

            try
            {
                // Find out what instances are in the cluster
                ClusterResponse result = apiInstance.ClusterGet(update, repair, includeSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find out what instances are in the cluster
    ApiResponse<ClusterResponse> response = apiInstance.ClusterGetWithHttpInfo(update, repair, includeSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **update** | **bool?** | Also ping the other instances in the cluster to check that they are present. | [optional]  |
| **repair** | **bool?** | Request an immediate repair so this instance will definitely contain the same rules, templates, etc   as the other instances in this cluster. Only works if all instances are up | [optional]  |
| **includeSettings** | **bool?** | Include extended details | [optional]  |

### Return type

[**ClusterResponse**](ClusterResponse.md)

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

<a id="clusterpost"></a>
# **ClusterPost**
> ClusterResponse ClusterPost (Cluster? cluster = null)

Register an instance with the cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);
            var cluster = new Cluster?(); // Cluster? |  (optional) 

            try
            {
                // Register an instance with the cluster
                ClusterResponse result = apiInstance.ClusterPost(cluster);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register an instance with the cluster
    ApiResponse<ClusterResponse> response = apiInstance.ClusterPostWithHttpInfo(cluster);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cluster** | [**Cluster?**](Cluster?.md) |  | [optional]  |

### Return type

[**ClusterResponse**](ClusterResponse.md)

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

<a id="clusterput"></a>
# **ClusterPut**
> ApiResponse ClusterPut (ClusterSetting? clusterSetting = null)

Update an advanced cluster setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);
            var clusterSetting = new ClusterSetting?(); // ClusterSetting? |  (optional) 

            try
            {
                // Update an advanced cluster setting
                ApiResponse result = apiInstance.ClusterPut(clusterSetting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an advanced cluster setting
    ApiResponse<ApiResponse> response = apiInstance.ClusterPutWithHttpInfo(clusterSetting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterSetting** | [**ClusterSetting?**](ClusterSetting?.md) |  | [optional]  |

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

<a id="clusterreregisterpost"></a>
# **ClusterReregisterPost**
> ClusterResponse ClusterReregisterPost (string? body = null)

Make this note reregister itself with all the other nodes in the cluster without requiring a restart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterReregisterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);
            var body = "body_example";  // string? | Optional address of one seed node to register with. Same syntax as seed parameter in web.xml,   ipaddress:port (optional) 

            try
            {
                // Make this note reregister itself with all the other nodes in the cluster without requiring a restart
                ClusterResponse result = apiInstance.ClusterReregisterPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterReregisterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterReregisterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make this note reregister itself with all the other nodes in the cluster without requiring a restart
    ApiResponse<ClusterResponse> response = apiInstance.ClusterReregisterPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterReregisterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string?** | Optional address of one seed node to register with. Same syntax as seed parameter in web.xml,   ipaddress:port | [optional]  |

### Return type

[**ClusterResponse**](ClusterResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/text
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="clusterstreamget"></a>
# **ClusterStreamGet**
> ClusterStreamResponse ClusterStreamGet (string? targetnode = null)

Find out the streaming status of an instance in the cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);
            var targetnode = "targetnode_example";  // string? | Which instance (identified by host name) do you want to query? Leave blank to pick an instance   randomly (optional) 

            try
            {
                // Find out the streaming status of an instance in the cluster
                ClusterStreamResponse result = apiInstance.ClusterStreamGet(targetnode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find out the streaming status of an instance in the cluster
    ApiResponse<ClusterStreamResponse> response = apiInstance.ClusterStreamGetWithHttpInfo(targetnode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **targetnode** | **string?** | Which instance (identified by host name) do you want to query? Leave blank to pick an instance   randomly | [optional]  |

### Return type

[**ClusterStreamResponse**](ClusterStreamResponse.md)

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

<a id="clusterstreamthroughputget"></a>
# **ClusterStreamThroughputGet**
> ClusterThroughputResponse ClusterStreamThroughputGet (string? targetnode = null)

Find out the current stream throughput (Mb per sec) of an instance in the cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterStreamThroughputGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);
            var targetnode = "targetnode_example";  // string? | Which instance (identified by host name) do you want to query? Leave blank to pick an instance   randomly (optional) 

            try
            {
                // Find out the current stream throughput (Mb per sec) of an instance in the cluster
                ClusterThroughputResponse result = apiInstance.ClusterStreamThroughputGet(targetnode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterStreamThroughputGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterStreamThroughputGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find out the current stream throughput (Mb per sec) of an instance in the cluster
    ApiResponse<ClusterThroughputResponse> response = apiInstance.ClusterStreamThroughputGetWithHttpInfo(targetnode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterStreamThroughputGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **targetnode** | **string?** | Which instance (identified by host name) do you want to query? Leave blank to pick an instance   randomly | [optional]  |

### Return type

[**ClusterThroughputResponse**](ClusterThroughputResponse.md)

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

<a id="clusterstreamthroughputpost"></a>
# **ClusterStreamThroughputPost**
> ClusterThroughputResponse ClusterStreamThroughputPost (int throughput, string? targetnode = null)

Set the current stream throughput (Mb per sec) of an instance in the cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class ClusterStreamThroughputPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ClusterApi(config);
            var throughput = 50;  // int | The maximum data rate in Mb/s that this node can send across all streams. (default to 50)
            var targetnode = "targetnode_example";  // string? | Which instance (identified by host name) do you want to query? Leave blank to pick an instance   randomly (optional) 

            try
            {
                // Set the current stream throughput (Mb per sec) of an instance in the cluster
                ClusterThroughputResponse result = apiInstance.ClusterStreamThroughputPost(throughput, targetnode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterStreamThroughputPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterStreamThroughputPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the current stream throughput (Mb per sec) of an instance in the cluster
    ApiResponse<ClusterThroughputResponse> response = apiInstance.ClusterStreamThroughputPostWithHttpInfo(throughput, targetnode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.ClusterStreamThroughputPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **throughput** | **int** | The maximum data rate in Mb/s that this node can send across all streams. | [default to 50] |
| **targetnode** | **string?** | Which instance (identified by host name) do you want to query? Leave blank to pick an instance   randomly | [optional]  |

### Return type

[**ClusterThroughputResponse**](ClusterThroughputResponse.md)

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

