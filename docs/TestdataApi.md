# Alterian.JO.Api.TestdataApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadTestdataTargetClientRulenameGet**](TestdataApi.md#downloadtestdatatargetclientrulenameget) | **GET** /download/testdata/{target}/{client}/{rulename} | Download user defined test data for a specific rule as JSON |
| [**TestdataGet**](TestdataApi.md#testdataget) | **GET** /testdata | List all user defined test data across all rules. |

<a id="downloadtestdatatargetclientrulenameget"></a>
# **DownloadTestdataTargetClientRulenameGet**
> void DownloadTestdataTargetClientRulenameGet (TargetEnum target, string varClient, string rulename)

Download user defined test data for a specific rule as JSON

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class DownloadTestdataTargetClientRulenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TestdataApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Download user defined test data for a specific rule as JSON
                apiInstance.DownloadTestdataTargetClientRulenameGet(target, varClient, rulename);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestdataApi.DownloadTestdataTargetClientRulenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadTestdataTargetClientRulenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download user defined test data for a specific rule as JSON
    apiInstance.DownloadTestdataTargetClientRulenameGetWithHttpInfo(target, varClient, rulename);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestdataApi.DownloadTestdataTargetClientRulenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **rulename** | **string** | Rule name |  |

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
| **200** | A uuencoded octet stream containing the .json file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="testdataget"></a>
# **TestdataGet**
> void TestdataGet (int? from = null, int? to = null)

List all user defined test data across all rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class TestdataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TestdataApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 

            try
            {
                // List all user defined test data across all rules.
                apiInstance.TestdataGet(from, to);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestdataApi.TestdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all user defined test data across all rules.
    apiInstance.TestdataGetWithHttpInfo(from, to);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestdataApi.TestdataGetWithHttpInfo: " + e.Message);
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

