# Alterian.JO.Api.CacheApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CacheClientGet**](CacheApi.md#cacheclientget) | **GET** /cache/{client} | Get information about cache tables, filtered by client. |
| [**CacheClientTargetExecutePost**](CacheApi.md#cacheclienttargetexecutepost) | **POST** /cache/{client}/{target}/execute | Execute a limited set of cql commands against the cache |
| [**CacheClientTargetGet**](CacheApi.md#cacheclienttargetget) | **GET** /cache/{client}/{target} | Get information about cache tables, filtered by client and target. |
| [**CacheClientTargetTableColumnDelete**](CacheApi.md#cacheclienttargettablecolumndelete) | **DELETE** /cache/{client}/{target}/{table}/{column} | Delete column from a cache table. |
| [**CacheClientTargetTableColumnsDelete**](CacheApi.md#cacheclienttargettablecolumnsdelete) | **DELETE** /cache/{client}/{target}/{table}/columns | Delete unused cache table and columns |
| [**CacheClientTargetTableDelete**](CacheApi.md#cacheclienttargettabledelete) | **DELETE** /cache/{client}/{target}/{table} | Delete data from a cache table. |
| [**CacheClientTargetTableGet**](CacheApi.md#cacheclienttargettableget) | **GET** /cache/{client}/{target}/{table} | Get information about a specific cache table. |
| [**CacheClientTargetTablePost**](CacheApi.md#cacheclienttargettablepost) | **POST** /cache/{client}/{target}/table | Alter a cache table |

<a id="cacheclientget"></a>
# **CacheClientGet**
> CacheDetailsResponse CacheClientGet (string varClient)

Get information about cache tables, filtered by client.

Get information about cache tables, filtered by client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class CacheClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CacheApi(config);
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Get information about cache tables, filtered by client.
                CacheDetailsResponse result = apiInstance.CacheClientGet(varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.CacheClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CacheClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about cache tables, filtered by client.
    ApiResponse<CacheDetailsResponse> response = apiInstance.CacheClientGetWithHttpInfo(varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheApi.CacheClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |

### Return type

[**CacheDetailsResponse**](CacheDetailsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cacheclienttargetexecutepost"></a>
# **CacheClientTargetExecutePost**
> CacheExecuteResponse CacheClientTargetExecutePost (string varClient, TargetEnum target, CacheCQL? cacheCQL = null)

Execute a limited set of cql commands against the cache

insert, select, update or delete a single row of data from a single table

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class CacheClientTargetExecutePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CacheApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var cacheCQL = new CacheCQL?(); // CacheCQL? |  (optional) 

            try
            {
                // Execute a limited set of cql commands against the cache
                CacheExecuteResponse result = apiInstance.CacheClientTargetExecutePost(varClient, target, cacheCQL);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.CacheClientTargetExecutePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CacheClientTargetExecutePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Execute a limited set of cql commands against the cache
    ApiResponse<CacheExecuteResponse> response = apiInstance.CacheClientTargetExecutePostWithHttpInfo(varClient, target, cacheCQL);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheApi.CacheClientTargetExecutePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **cacheCQL** | [**CacheCQL?**](CacheCQL?.md) |  | [optional]  |

### Return type

[**CacheExecuteResponse**](CacheExecuteResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cacheclienttargetget"></a>
# **CacheClientTargetGet**
> CacheDetailsResponse CacheClientTargetGet (string varClient, TargetEnum target, TableTypeEnum? tabletype = null)

Get information about cache tables, filtered by client and target.

Get information about cache tables, filtered by client and target.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class CacheClientTargetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CacheApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var tabletype = new TableTypeEnum?(); // TableTypeEnum? | If you only want a certain type of table, provide it here (optional) 

            try
            {
                // Get information about cache tables, filtered by client and target.
                CacheDetailsResponse result = apiInstance.CacheClientTargetGet(varClient, target, tabletype);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.CacheClientTargetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CacheClientTargetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about cache tables, filtered by client and target.
    ApiResponse<CacheDetailsResponse> response = apiInstance.CacheClientTargetGetWithHttpInfo(varClient, target, tabletype);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheApi.CacheClientTargetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **tabletype** | [**TableTypeEnum?**](TableTypeEnum?.md) | If you only want a certain type of table, provide it here | [optional]  |

### Return type

[**CacheDetailsResponse**](CacheDetailsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cacheclienttargettablecolumndelete"></a>
# **CacheClientTargetTableColumnDelete**
> CacheApiResponse CacheClientTargetTableColumnDelete (string varClient, TargetEnum target, string table, string column, string? key = null, List<string>? keys = null)

Delete column from a cache table.

Removes a column from a cache table.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class CacheClientTargetTableColumnDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CacheApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var table = "table_example";  // string | Table name
            var column = "column_example";  // string | Column name
            var key = "key_example";  // string? | Pass DESTROY_COLUMN if you would like to remove a column.  Note, there is no recovery for these   actions and removing a column which is used will cause your rules to cease functioning. (optional) 
            var keys = new List<string>?(); // List<string>? | Values for clustering keys. If the table has a composite key, provide the values in order. (optional) 

            try
            {
                // Delete column from a cache table.
                CacheApiResponse result = apiInstance.CacheClientTargetTableColumnDelete(varClient, target, table, column, key, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.CacheClientTargetTableColumnDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CacheClientTargetTableColumnDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete column from a cache table.
    ApiResponse<CacheApiResponse> response = apiInstance.CacheClientTargetTableColumnDeleteWithHttpInfo(varClient, target, table, column, key, keys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheApi.CacheClientTargetTableColumnDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **table** | **string** | Table name |  |
| **column** | **string** | Column name |  |
| **key** | **string?** | Pass DESTROY_COLUMN if you would like to remove a column.  Note, there is no recovery for these   actions and removing a column which is used will cause your rules to cease functioning. | [optional]  |
| **keys** | [**List&lt;string&gt;?**](string.md) | Values for clustering keys. If the table has a composite key, provide the values in order. | [optional]  |

### Return type

[**CacheApiResponse**](CacheApiResponse.md)

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

<a id="cacheclienttargettablecolumnsdelete"></a>
# **CacheClientTargetTableColumnsDelete**
> CacheApiDeleteResponse CacheClientTargetTableColumnsDelete (string varClient, TargetEnum target, string table, bool preview)

Delete unused cache table and columns

Removes the columns and tables that are no longer used by any of the rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class CacheClientTargetTableColumnsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CacheApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var table = "table_example";  // string | Table name
            var preview = true;  // bool | By default API works in preview mode and returns a list of cache columns and tables that would be   dropped. Only when preview set to false the columns are actually dropped

            try
            {
                // Delete unused cache table and columns
                CacheApiDeleteResponse result = apiInstance.CacheClientTargetTableColumnsDelete(varClient, target, table, preview);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.CacheClientTargetTableColumnsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CacheClientTargetTableColumnsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete unused cache table and columns
    ApiResponse<CacheApiDeleteResponse> response = apiInstance.CacheClientTargetTableColumnsDeleteWithHttpInfo(varClient, target, table, preview);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheApi.CacheClientTargetTableColumnsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **table** | **string** | Table name |  |
| **preview** | **bool** | By default API works in preview mode and returns a list of cache columns and tables that would be   dropped. Only when preview set to false the columns are actually dropped |  |

### Return type

[**CacheApiDeleteResponse**](CacheApiDeleteResponse.md)

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

<a id="cacheclienttargettabledelete"></a>
# **CacheClientTargetTableDelete**
> CacheApiResponse CacheClientTargetTableDelete (string varClient, TargetEnum target, string table, string? key = null, List<string>? keys = null)

Delete data from a cache table.

Removes data from a cache table.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class CacheClientTargetTableDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CacheApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var table = "table_example";  // string | Table name
            var key = "key_example";  // string? | Key to delete from cache tables; provide DELETE_ALL to clear the table and DESTROY_TABLE if you would   like to remove the table.  Note, there is no recovery for these actions and removing a table which is used will cause   your rules to cease functioning. (optional) 
            var keys = new List<string>?(); // List<string>? | Values for clustering keys. If the table has a composite key, provide the values in order. (optional) 

            try
            {
                // Delete data from a cache table.
                CacheApiResponse result = apiInstance.CacheClientTargetTableDelete(varClient, target, table, key, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.CacheClientTargetTableDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CacheClientTargetTableDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete data from a cache table.
    ApiResponse<CacheApiResponse> response = apiInstance.CacheClientTargetTableDeleteWithHttpInfo(varClient, target, table, key, keys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheApi.CacheClientTargetTableDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **table** | **string** | Table name |  |
| **key** | **string?** | Key to delete from cache tables; provide DELETE_ALL to clear the table and DESTROY_TABLE if you would   like to remove the table.  Note, there is no recovery for these actions and removing a table which is used will cause   your rules to cease functioning. | [optional]  |
| **keys** | [**List&lt;string&gt;?**](string.md) | Values for clustering keys. If the table has a composite key, provide the values in order. | [optional]  |

### Return type

[**CacheApiResponse**](CacheApiResponse.md)

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

<a id="cacheclienttargettableget"></a>
# **CacheClientTargetTableGet**
> CacheDetailsResponse CacheClientTargetTableGet (string varClient, TargetEnum target, string table, string? key = null, List<string>? keys = null, int? sample = null, bool? pivot = null, string? fieldvalue = null, int? limit = null)

Get information about a specific cache table.

Get information about a specific cache table.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class CacheClientTargetTableGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CacheApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var table = "table_example";  // string | Table name
            var key = "key_example";  // string? | If you want a row of data to be returned, provide the partition key (optional) 
            var keys = new List<string>?(); // List<string>? | Values for clustering keys. If the table has a composite key, provide the values in order. (optional) 
            var sample = 56;  // int? | return a sample of n rows from the table (optional) 
            var pivot = true;  // bool? | Would you like the data pivoted? (Only for CSV report) (optional) 
            var fieldvalue = "keyvalues";  // string? | If this is a fieldvalue type table, you can ask for a list of keys or values.  If you specify   fieldvalues, you must also provide a key (optional) 
            var limit = 56;  // int? | If you are asking for a list of values from a fieldvalue table, you can request to return only the   most recent, limited to this number.  If not provided, a system limit will be used. (optional) 

            try
            {
                // Get information about a specific cache table.
                CacheDetailsResponse result = apiInstance.CacheClientTargetTableGet(varClient, target, table, key, keys, sample, pivot, fieldvalue, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.CacheClientTargetTableGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CacheClientTargetTableGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about a specific cache table.
    ApiResponse<CacheDetailsResponse> response = apiInstance.CacheClientTargetTableGetWithHttpInfo(varClient, target, table, key, keys, sample, pivot, fieldvalue, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheApi.CacheClientTargetTableGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **table** | **string** | Table name |  |
| **key** | **string?** | If you want a row of data to be returned, provide the partition key | [optional]  |
| **keys** | [**List&lt;string&gt;?**](string.md) | Values for clustering keys. If the table has a composite key, provide the values in order. | [optional]  |
| **sample** | **int?** | return a sample of n rows from the table | [optional]  |
| **pivot** | **bool?** | Would you like the data pivoted? (Only for CSV report) | [optional]  |
| **fieldvalue** | **string?** | If this is a fieldvalue type table, you can ask for a list of keys or values.  If you specify   fieldvalues, you must also provide a key | [optional]  |
| **limit** | **int?** | If you are asking for a list of values from a fieldvalue table, you can request to return only the   most recent, limited to this number.  If not provided, a system limit will be used. | [optional]  |

### Return type

[**CacheDetailsResponse**](CacheDetailsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cacheclienttargettablepost"></a>
# **CacheClientTargetTablePost**
> CacheChangesResponse CacheClientTargetTablePost (string varClient, TargetEnum target, CacheTableDefinition? cacheTableDefinition = null)

Alter a cache table

Ensure that the cache table includes at least the set of columns requested

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class CacheClientTargetTablePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CacheApi(config);
            var varClient = "varClient_example";  // string | Client name
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var cacheTableDefinition = new CacheTableDefinition?(); // CacheTableDefinition? |  (optional) 

            try
            {
                // Alter a cache table
                CacheChangesResponse result = apiInstance.CacheClientTargetTablePost(varClient, target, cacheTableDefinition);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.CacheClientTargetTablePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CacheClientTargetTablePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Alter a cache table
    ApiResponse<CacheChangesResponse> response = apiInstance.CacheClientTargetTablePostWithHttpInfo(varClient, target, cacheTableDefinition);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CacheApi.CacheClientTargetTablePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varClient** | **string** | Client name |  |
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **cacheTableDefinition** | [**CacheTableDefinition?**](CacheTableDefinition?.md) |  | [optional]  |

### Return type

[**CacheChangesResponse**](CacheChangesResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

