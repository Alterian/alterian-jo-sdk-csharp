# Alterian.JO.Api.QueueApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**QueueClientDelete**](QueueApi.md#queueclientdelete) | **DELETE** /queue/{client}/ | Delete all queues that this client owns. |
| [**QueueClientGet**](QueueApi.md#queueclientget) | **GET** /queue/{client}/ | Get all of the queues for a specific client, across all targets. |
| [**QueueClientTargetDelete**](QueueApi.md#queueclienttargetdelete) | **DELETE** /queue/{client}/{target}/ | Delete all of the queues within a specific target for the given client |
| [**QueueClientTargetGet**](QueueApi.md#queueclienttargetget) | **GET** /queue/{client}/{target}/ | Get details about all of the queues within a specific target for this client. |
| [**QueueClientTargetQueueNameAckPost**](QueueApi.md#queueclienttargetqueuenameackpost) | **POST** /queue/{client}/{target}/{queueName}/ack | Remove a set of messages from a given queue. |
| [**QueueClientTargetQueueNameDelete**](QueueApi.md#queueclienttargetqueuenamedelete) | **DELETE** /queue/{client}/{target}/{queueName} | Delete a specific named queue |
| [**QueueClientTargetQueueNameGet**](QueueApi.md#queueclienttargetqueuenameget) | **GET** /queue/{client}/{target}/{queueName} | Gets information about a specific named queue. |
| [**QueueClientTargetQueueNameMessagesGet**](QueueApi.md#queueclienttargetqueuenamemessagesget) | **GET** /queue/{client}/{target}/{queueName}/messages | Gets one or more messages from the queue |
| [**QueueClientTargetQueueNameMessagesPost**](QueueApi.md#queueclienttargetqueuenamemessagespost) | **POST** /queue/{client}/{target}/{queueName}/messages | Add a message to the named queue |
| [**QueueClientTargetQueueNamePost**](QueueApi.md#queueclienttargetqueuenamepost) | **POST** /queue/{client}/{target}/{queueName} | Create a new queue, passing a block of JSON that is associated with the queue |
| [**QueueClientTargetQueueNamePurgePost**](QueueApi.md#queueclienttargetqueuenamepurgepost) | **POST** /queue/{client}/{target}/{queueName}/purge | Remove all messages from the named queue |
| [**QueueClientTargetQueueNamePut**](QueueApi.md#queueclienttargetqueuenameput) | **PUT** /queue/{client}/{target}/{queueName} | Edit an existing queue |
| [**QueueGet**](QueueApi.md#queueget) | **GET** /queue | Get information about all queues on the server. |

<a id="queueclientdelete"></a>
# **QueueClientDelete**
> ApiResponse QueueClientDelete (string varClient)

Delete all queues that this client owns.

Delete all queues that this client owns, across all targets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Delete all queues that this client owns.
                ApiResponse result = apiInstance.QueueClientDelete(varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all queues that this client owns.
    ApiResponse<ApiResponse> response = apiInstance.QueueClientDeleteWithHttpInfo(varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientDeleteWithHttpInfo: " + e.Message);
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

<a id="queueclientget"></a>
# **QueueClientGet**
> ApiResponse QueueClientGet (string varClient, int? from = null, int? to = null, bool? includeStatistics = null)

Get all of the queues for a specific client, across all targets.

Find the full details of all queues that this client owns, across all targets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | Client name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var includeStatistics = true;  // bool? | Should the results include the execution statistics for each rule? Default true (optional) 

            try
            {
                // Get all of the queues for a specific client, across all targets.
                ApiResponse result = apiInstance.QueueClientGet(varClient, from, to, includeStatistics);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all of the queues for a specific client, across all targets.
    ApiResponse<ApiResponse> response = apiInstance.QueueClientGetWithHttpInfo(varClient, from, to, includeStatistics);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientGetWithHttpInfo: " + e.Message);
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
| **includeStatistics** | **bool?** | Should the results include the execution statistics for each rule? Default true | [optional]  |

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

<a id="queueclienttargetdelete"></a>
# **QueueClientTargetDelete**
> ApiResponse QueueClientTargetDelete (string varClient, TargetEnum target)

Delete all of the queues within a specific target for the given client

Delete all of the queues within a specific target for the given client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.

            try
            {
                // Delete all of the queues within a specific target for the given client
                ApiResponse result = apiInstance.QueueClientTargetDelete(varClient, target);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all of the queues within a specific target for the given client
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetDeleteWithHttpInfo(varClient, target);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |

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

<a id="queueclienttargetget"></a>
# **QueueClientTargetGet**
> ApiResponse QueueClientTargetGet (string varClient, TargetEnum target, int? from = null, int? to = null, bool? includeStatistics = null)

Get details about all of the queues within a specific target for this client.

Get details about all of the queues within a specific target for this client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var includeStatistics = true;  // bool? | Should the results include the execution statistics for each rule? Default true (optional) 

            try
            {
                // Get details about all of the queues within a specific target for this client.
                ApiResponse result = apiInstance.QueueClientTargetGet(varClient, target, from, to, includeStatistics);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about all of the queues within a specific target for this client.
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetGetWithHttpInfo(varClient, target, from, to, includeStatistics);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **includeStatistics** | **bool?** | Should the results include the execution statistics for each rule? Default true | [optional]  |

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

<a id="queueclienttargetqueuenameackpost"></a>
# **QueueClientTargetQueueNameAckPost**
> ApiResponse QueueClientTargetQueueNameAckPost (string varClient, TargetEnum target, string queueName, List<AckMessage>? ackMessage = null)

Remove a set of messages from a given queue.

If the message was read with 'deleteAfterRead=false' then you must call this API to remove the message   from the queue after your code has successfully processed it

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetQueueNameAckPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | The client name for the queue
            var target = new TargetEnum(); // TargetEnum | The target in which the queue is located
            var queueName = "\"\"";  // string | The name of queue which contains the message you want to acknowledge (default to "")
            var ackMessage = new List<AckMessage>?(); // List<AckMessage>? |  (optional) 

            try
            {
                // Remove a set of messages from a given queue.
                ApiResponse result = apiInstance.QueueClientTargetQueueNameAckPost(varClient, target, queueName, ackMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameAckPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetQueueNameAckPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a set of messages from a given queue.
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetQueueNameAckPostWithHttpInfo(varClient, target, queueName, ackMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameAckPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | The client name for the queue |  |
| **target** | [**TargetEnum**](TargetEnum.md) | The target in which the queue is located |  |
| **queueName** | **string** | The name of queue which contains the message you want to acknowledge | [default to &quot;&quot;] |
| **ackMessage** | [**List&lt;AckMessage&gt;?**](AckMessage.md) |  | [optional]  |

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

<a id="queueclienttargetqueuenamedelete"></a>
# **QueueClientTargetQueueNameDelete**
> ApiResponse QueueClientTargetQueueNameDelete (string varClient, TargetEnum target, string queueName)

Delete a specific named queue

Delete a queue and all the messages within it

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetQueueNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var queueName = "queueName_example";  // string | The name of the queue that should be deleted.

            try
            {
                // Delete a specific named queue
                ApiResponse result = apiInstance.QueueClientTargetQueueNameDelete(varClient, target, queueName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetQueueNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific named queue
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetQueueNameDeleteWithHttpInfo(varClient, target, queueName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **queueName** | **string** | The name of the queue that should be deleted. |  |

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

<a id="queueclienttargetqueuenameget"></a>
# **QueueClientTargetQueueNameGet**
> ApiResponse QueueClientTargetQueueNameGet (string varClient, TargetEnum target, string queueName, bool? includeStatistics = null)

Gets information about a specific named queue.

Information returned is filtered by user permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetQueueNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var queueName = "\"\"";  // string | The name of queue that you want to get the information for. (default to "")
            var includeStatistics = true;  // bool? | Should the results include the execution statistics for each rule? Default true (optional) 

            try
            {
                // Gets information about a specific named queue.
                ApiResponse result = apiInstance.QueueClientTargetQueueNameGet(varClient, target, queueName, includeStatistics);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetQueueNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets information about a specific named queue.
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetQueueNameGetWithHttpInfo(varClient, target, queueName, includeStatistics);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **queueName** | **string** | The name of queue that you want to get the information for. | [default to &quot;&quot;] |
| **includeStatistics** | **bool?** | Should the results include the execution statistics for each rule? Default true | [optional]  |

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

<a id="queueclienttargetqueuenamemessagesget"></a>
# **QueueClientTargetQueueNameMessagesGet**
> ApiResponse QueueClientTargetQueueNameMessagesGet (string varClient, TargetEnum target, string queueName, int? numberOfMessages = null, int? maxWaitTimeInSeconds = null, bool? deleteAfterRead = null, string? varLock = null)

Gets one or more messages from the queue

Return a JSON array containing zero or more messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetQueueNameMessagesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - the target of where the queue is stored.
            var queueName = "queueName_example";  // string | The name of the queue to read messages from
            var numberOfMessages = 56;  // int? | The number of messages to read in this request. Default 1. If messages are bundled together then more   messages may be returned than requested. If deleteAfterRead is false then the maximum is 10, and you must call `POST   /queue/{client}/{target}/{queueName}/ack` on the current messages before any more will be available to read (optional) 
            var maxWaitTimeInSeconds = 56;  // int? | If the queue currently contains fewer than the numberOfMessages requested, how long (in seconds)   should we wait for new messages to arrive? Default 0 (optional) 
            var deleteAfterRead = true;  // bool? | Should the messages being read be automatically removed from the queue? Default true. If this is   false then the `POST /queue/{client}/{target}/{queueName}/ack` API must be called with the message details once the   data has been processed (optional) 
            var varLock = "varLock_example";  // string? | If the queue is locked, you must provide the key in this parameter (optional) 

            try
            {
                // Gets one or more messages from the queue
                ApiResponse result = apiInstance.QueueClientTargetQueueNameMessagesGet(varClient, target, queueName, numberOfMessages, maxWaitTimeInSeconds, deleteAfterRead, varLock);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameMessagesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetQueueNameMessagesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets one or more messages from the queue
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetQueueNameMessagesGetWithHttpInfo(varClient, target, queueName, numberOfMessages, maxWaitTimeInSeconds, deleteAfterRead, varLock);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameMessagesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - the target of where the queue is stored. |  |
| **queueName** | **string** | The name of the queue to read messages from |  |
| **numberOfMessages** | **int?** | The number of messages to read in this request. Default 1. If messages are bundled together then more   messages may be returned than requested. If deleteAfterRead is false then the maximum is 10, and you must call &#x60;POST   /queue/{client}/{target}/{queueName}/ack&#x60; on the current messages before any more will be available to read | [optional]  |
| **maxWaitTimeInSeconds** | **int?** | If the queue currently contains fewer than the numberOfMessages requested, how long (in seconds)   should we wait for new messages to arrive? Default 0 | [optional]  |
| **deleteAfterRead** | **bool?** | Should the messages being read be automatically removed from the queue? Default true. If this is   false then the &#x60;POST /queue/{client}/{target}/{queueName}/ack&#x60; API must be called with the message details once the   data has been processed | [optional]  |
| **varLock** | **string?** | If the queue is locked, you must provide the key in this parameter | [optional]  |

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

<a id="queueclienttargetqueuenamemessagespost"></a>
# **QueueClientTargetQueueNameMessagesPost**
> ApiResponse QueueClientTargetQueueNameMessagesPost (string varClient, TargetEnum target, string queueName, string body)

Add a message to the named queue

Used for posting messages to a queue. The data passed in the message is not validated in any way

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetQueueNameMessagesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | client name
            var target = new TargetEnum(); // TargetEnum | Target - the target of where the queue is stored.
            var queueName = "queueName_example";  // string | The name of the queue that the message will be posted to..
            var body = "body_example";  // string | The message that should be posted on to the queue.

            try
            {
                // Add a message to the named queue
                ApiResponse result = apiInstance.QueueClientTargetQueueNameMessagesPost(varClient, target, queueName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameMessagesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetQueueNameMessagesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a message to the named queue
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetQueueNameMessagesPostWithHttpInfo(varClient, target, queueName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNameMessagesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - the target of where the queue is stored. |  |
| **queueName** | **string** | The name of the queue that the message will be posted to.. |  |
| **body** | **string** | The message that should be posted on to the queue. |  |

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

<a id="queueclienttargetqueuenamepost"></a>
# **QueueClientTargetQueueNamePost**
> ApiResponse QueueClientTargetQueueNamePost (string varClient, TargetEnum target, string queueName, string body)

Create a new queue, passing a block of JSON that is associated with the queue

Used for creating a new queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetQueueNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | The name of the client.
            var target = new TargetEnum(); // TargetEnum | Target - is what the queue will be tagged with.
            var queueName = "queueName_example";  // string | The name of the queue that should be created.
            var body = {"fifo":true,"schema":[{"dataType":"integer","name":"custid"}]};  // string | A block of JSON that contains information about the contents of the messages in the queue

            try
            {
                // Create a new queue, passing a block of JSON that is associated with the queue
                ApiResponse result = apiInstance.QueueClientTargetQueueNamePost(varClient, target, queueName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetQueueNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new queue, passing a block of JSON that is associated with the queue
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetQueueNamePostWithHttpInfo(varClient, target, queueName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | The name of the client. |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is what the queue will be tagged with. |  |
| **queueName** | **string** | The name of the queue that should be created. |  |
| **body** | **string** | A block of JSON that contains information about the contents of the messages in the queue |  |

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

<a id="queueclienttargetqueuenamepurgepost"></a>
# **QueueClientTargetQueueNamePurgePost**
> ApiResponse QueueClientTargetQueueNamePurgePost (string varClient, TargetEnum target, string queueName)

Remove all messages from the named queue

Used to clear messages from a queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetQueueNamePurgePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - the target of where the queue is stored.
            var queueName = "queueName_example";  // string | The name of the queue that the message will be posted to..

            try
            {
                // Remove all messages from the named queue
                ApiResponse result = apiInstance.QueueClientTargetQueueNamePurgePost(varClient, target, queueName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNamePurgePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetQueueNamePurgePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove all messages from the named queue
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetQueueNamePurgePostWithHttpInfo(varClient, target, queueName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNamePurgePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - the target of where the queue is stored. |  |
| **queueName** | **string** | The name of the queue that the message will be posted to.. |  |

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

<a id="queueclienttargetqueuenameput"></a>
# **QueueClientTargetQueueNamePut**
> ApiResponse QueueClientTargetQueueNamePut (string varClient, TargetEnum target, string queueName, string body)

Edit an existing queue

Edit the block of JSON that is associated with the queue. This is only permitted if the queue is empty   (has zero messages)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueClientTargetQueueNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var varClient = "varClient_example";  // string | The name of the client.
            var target = new TargetEnum(); // TargetEnum | Target - is what the queue will be tagged with.
            var queueName = "queueName_example";  // string | The name of the queue that should be created.
            var body = {"fifo":true,"schema":[{"dataType":"integer","name":"custid"}]};  // string | A block of JSON that contains information about the contents of the messages in the queue

            try
            {
                // Edit an existing queue
                ApiResponse result = apiInstance.QueueClientTargetQueueNamePut(varClient, target, queueName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueClientTargetQueueNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an existing queue
    ApiResponse<ApiResponse> response = apiInstance.QueueClientTargetQueueNamePutWithHttpInfo(varClient, target, queueName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueClientTargetQueueNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | The name of the client. |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is what the queue will be tagged with. |  |
| **queueName** | **string** | The name of the queue that should be created. |  |
| **body** | **string** | A block of JSON that contains information about the contents of the messages in the queue |  |

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

<a id="queueget"></a>
# **QueueGet**
> ApiResponse QueueGet (int? from = null, int? to = null, bool? includeStatistics = null)

Get information about all queues on the server.

Get information about all queues that this user can access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class QueueGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new QueueApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var includeStatistics = true;  // bool? | Should the results include the execution statistics for each rule? Default true (optional) 

            try
            {
                // Get information about all queues on the server.
                ApiResponse result = apiInstance.QueueGet(from, to, includeStatistics);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueueGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about all queues on the server.
    ApiResponse<ApiResponse> response = apiInstance.QueueGetWithHttpInfo(from, to, includeStatistics);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueApi.QueueGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **includeStatistics** | **bool?** | Should the results include the execution statistics for each rule? Default true | [optional]  |

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

