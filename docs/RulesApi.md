# Alterian.JO.Api.RulesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadRuleTargetClientRulenameGet**](RulesApi.md#downloadruletargetclientrulenameget) | **GET** /download/rule/{target}/{client}/{rulename} | Download the rule file (KTR) for a running rule |
| [**RuleGet**](RulesApi.md#ruleget) | **GET** /rule | Get information about all published rules on the server |
| [**RuleTargetClientDelete**](RulesApi.md#ruletargetclientdelete) | **DELETE** /rule/{target}/{client} | Unpublish all rules that this client has published to the given target. |
| [**RuleTargetClientDesignerPut**](RulesApi.md#ruletargetclientdesignerput) | **PUT** /rule/{target}/{client}/designer | Validate a new Rule Designer JSON |
| [**RuleTargetClientGet**](RulesApi.md#ruletargetclientget) | **GET** /rule/{target}/{client} | Get information about all rules published by this client to the given target. |
| [**RuleTargetClientRulenameAutoloaderGet**](RulesApi.md#ruletargetclientrulenameautoloaderget) | **GET** /rule/{target}/{client}/{rulename}/autoloader | Get the autoloader JSON for a specific rule. This is normally used by the Rule plugin within Spoon |
| [**RuleTargetClientRulenameAutoloaderPost**](RulesApi.md#ruletargetclientrulenameautoloaderpost) | **POST** /rule/{target}/{client}/{rulename}/autoloader | Save the JSON for an autoloader rule |
| [**RuleTargetClientRulenameCopytoPost**](RulesApi.md#ruletargetclientrulenamecopytopost) | **POST** /rule/{target}/{client}/{rulename}/copyto | Copy this rule to the given target. |
| [**RuleTargetClientRulenameDatagridDataGridNameGet**](RulesApi.md#ruletargetclientrulenamedatagriddatagridnameget) | **GET** /rule/{target}/{client}/{rulename}/datagrid/{dataGridName} | Get information about the data grid for a specific, published rule. |
| [**RuleTargetClientRulenameDatagridDataGridNamePost**](RulesApi.md#ruletargetclientrulenamedatagriddatagridnamepost) | **POST** /rule/{target}/{client}/{rulename}/datagrid/{dataGridName} | Enter new data for an exisiting data grid and update |
| [**RuleTargetClientRulenameDatagridDataGridNameRowsPost**](RulesApi.md#ruletargetclientrulenamedatagriddatagridnamerowspost) | **POST** /rule/{target}/{client}/{rulename}/datagrid/{dataGridName}/rows | Add new data grid rows to a rule&#39;s Data Grid |
| [**RuleTargetClientRulenameDelete**](RulesApi.md#ruletargetclientrulenamedelete) | **DELETE** /rule/{target}/{client}/{rulename} | Unpublish a specific rule. |
| [**RuleTargetClientRulenameDesignerGet**](RulesApi.md#ruletargetclientrulenamedesignerget) | **GET** /rule/{target}/{client}/{rulename}/designer | Get the rule designer JSON for a specific rule. This is normally used by the Rule designer user interface |
| [**RuleTargetClientRulenameDesignerPost**](RulesApi.md#ruletargetclientrulenamedesignerpost) | **POST** /rule/{target}/{client}/{rulename}/designer | Save or validate the rule designer JSON for a rule |
| [**RuleTargetClientRulenameDesignerPut**](RulesApi.md#ruletargetclientrulenamedesignerput) | **PUT** /rule/{target}/{client}/{rulename}/designer | Add a new rule via the rule designer JSON. |
| [**RuleTargetClientRulenameGet**](RulesApi.md#ruletargetclientrulenameget) | **GET** /rule/{target}/{client}/{rulename} | Get information about one specific, published rule. |
| [**RuleTargetClientRulenameParameterPost**](RulesApi.md#ruletargetclientrulenameparameterpost) | **POST** /rule/{target}/{client}/{rulename}/parameter | update the default values for parameters. |
| [**RuleTargetClientRulenamePauseDelete**](RulesApi.md#ruletargetclientrulenamepausedelete) | **DELETE** /rule/{target}/{client}/{rulename}/pause | Pause this rule |
| [**RuleTargetClientRulenamePost**](RulesApi.md#ruletargetclientrulenamepost) | **POST** /rule/{target}/{client}/{rulename} | Start or restart one specific, published rule. |
| [**RuleTargetClientRulenamePriorityWeightingPost**](RulesApi.md#ruletargetclientrulenamepriorityweightingpost) | **POST** /rule/{target}/{client}/{rulename}/priorityWeighting | Update the rule&#39;s priority weighting |
| [**RuleTargetClientRulenameResetDelete**](RulesApi.md#ruletargetclientrulenameresetdelete) | **DELETE** /rule/{target}/{client}/{rulename}/reset | Perform extended actions to rules |
| [**RuleTargetClientRulenameSampleDataGet**](RulesApi.md#ruletargetclientrulenamesampledataget) | **GET** /rule/{target}/{client}/{rulename}/sampleData | Get JSON Schema representation of the data expected by the rule |
| [**RuleTargetClientRulenameSnoozePost**](RulesApi.md#ruletargetclientrulenamesnoozepost) | **POST** /rule/{target}/{client}/{rulename}/snooze | Make this rule start snoozing |
| [**RuleTargetClientRulenameTestDataDelete**](RulesApi.md#ruletargetclientrulenametestdatadelete) | **DELETE** /rule/{target}/{client}/{rulename}/testData | Delete all test data |
| [**RuleTargetClientRulenameTestDataGet**](RulesApi.md#ruletargetclientrulenametestdataget) | **GET** /rule/{target}/{client}/{rulename}/testData | Get the rule&#39;s test data and headers information |
| [**RuleTargetClientRulenameTestDataPost**](RulesApi.md#ruletargetclientrulenametestdatapost) | **POST** /rule/{target}/{client}/{rulename}/testData | Add test data to rule |
| [**RuleTargetGet**](RulesApi.md#ruletargetget) | **GET** /rule/{target} | Get information about all rules published by all clients to the given target |

<a id="downloadruletargetclientrulenameget"></a>
# **DownloadRuleTargetClientRulenameGet**
> System.IO.Stream DownloadRuleTargetClientRulenameGet (TargetEnum target, string varClient, string rulename)

Download the rule file (KTR) for a running rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class DownloadRuleTargetClientRulenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Download the rule file (KTR) for a running rule
                System.IO.Stream result = apiInstance.DownloadRuleTargetClientRulenameGet(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.DownloadRuleTargetClientRulenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadRuleTargetClientRulenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download the rule file (KTR) for a running rule
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadRuleTargetClientRulenameGetWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.DownloadRuleTargetClientRulenameGetWithHttpInfo: " + e.Message);
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

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A uuencoded octet stream containing the rule ktr file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ruleget"></a>
# **RuleGet**
> RuleList RuleGet (int? from = null, int? to = null, string? sortProperty = null, string? sortDescending = null, string? createdRuleUrl = null, HealthScoreTimeFrame? healthScore = null, bool? includeStatistics = null, string? searchText = null, string? parameterName = null, string? parameterValue = null, string? templateFilter = null, bool? includePublic = null, bool? checkTemplateLatestVersion = null, List<string>? iClients = null)

Get information about all published rules on the server

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
    public class RuleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var sortProperty = "sortProperty_example";  // string? | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. (optional) 
            var sortDescending = "sortDescending_example";  // string? | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty (optional) 
            var createdRuleUrl = "createdRuleUrl_example";  // string? | The url the rule was published to. Only rule with this url will be returned. In the format of:   target/client/rule_name (optional) 
            var healthScore = new HealthScoreTimeFrame?(); // HealthScoreTimeFrame? | Time Frame for calculating the health score of a rule. Allowed values are hour, day, min (optional) 
            var includeStatistics = true;  // bool? | Should the results include the execution statistics for each rule? Default true (optional) 
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 
            var parameterName = "parameterName_example";  // string? | Get the report for a specific parameter (optional) 
            var parameterValue = "parameterValue_example";  // string? | Get a list of rules which have a specific parameter value (optional) 
            var templateFilter = "templateFilter_example";  // string? | Filter to return only rules using specified template (optional) 
            var includePublic = true;  // bool? | Flag to indicate whether rules from the public client should be included in the results, please use   iClients=public instead (optional) 
            var checkTemplateLatestVersion = true;  // bool? | Should a check to verify rule has the latest templates version be performed? (optional) 
            var iClients = new List<string>?(); // List<string>? | Only include these client(s) (optional) 

            try
            {
                // Get information about all published rules on the server
                RuleList result = apiInstance.RuleGet(from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about all published rules on the server
    ApiResponse<RuleList> response = apiInstance.RuleGetWithHttpInfo(from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleGetWithHttpInfo: " + e.Message);
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
| **createdRuleUrl** | **string?** | The url the rule was published to. Only rule with this url will be returned. In the format of:   target/client/rule_name | [optional]  |
| **healthScore** | [**HealthScoreTimeFrame?**](HealthScoreTimeFrame?.md) | Time Frame for calculating the health score of a rule. Allowed values are hour, day, min | [optional]  |
| **includeStatistics** | **bool?** | Should the results include the execution statistics for each rule? Default true | [optional]  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |
| **parameterName** | **string?** | Get the report for a specific parameter | [optional]  |
| **parameterValue** | **string?** | Get a list of rules which have a specific parameter value | [optional]  |
| **templateFilter** | **string?** | Filter to return only rules using specified template | [optional]  |
| **includePublic** | **bool?** | Flag to indicate whether rules from the public client should be included in the results, please use   iClients&#x3D;public instead | [optional]  |
| **checkTemplateLatestVersion** | **bool?** | Should a check to verify rule has the latest templates version be performed? | [optional]  |
| **iClients** | [**List&lt;string&gt;?**](string.md) | Only include these client(s) | [optional]  |

### Return type

[**RuleList**](RuleList.md)

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

<a id="ruletargetclientdelete"></a>
# **RuleTargetClientDelete**
> RuleList RuleTargetClientDelete (TargetEnum target, string varClient)

Unpublish all rules that this client has published to the given target.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name

            try
            {
                // Unpublish all rules that this client has published to the given target.
                RuleList result = apiInstance.RuleTargetClientDelete(target, varClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unpublish all rules that this client has published to the given target.
    ApiResponse<RuleList> response = apiInstance.RuleTargetClientDeleteWithHttpInfo(target, varClient);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |

### Return type

[**RuleList**](RuleList.md)

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

<a id="ruletargetclientdesignerput"></a>
# **RuleTargetClientDesignerPut**
> RuleDesignerResponse RuleTargetClientDesignerPut (TargetEnum target, string varClient, RuleData? ruleData = null)

Validate a new Rule Designer JSON

This will validate a new Rule Designer JSON and return validations if problems detected without saving the rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientDesignerPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var ruleData = new RuleData?(); // RuleData? | Specify the rule designer JSON for the updated rule. Ensure wrapped in {} (optional) 

            try
            {
                // Validate a new Rule Designer JSON
                RuleDesignerResponse result = apiInstance.RuleTargetClientDesignerPut(target, varClient, ruleData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientDesignerPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientDesignerPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate a new Rule Designer JSON
    ApiResponse<RuleDesignerResponse> response = apiInstance.RuleTargetClientDesignerPutWithHttpInfo(target, varClient, ruleData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientDesignerPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **ruleData** | [**RuleData?**](RuleData?.md) | Specify the rule designer JSON for the updated rule. Ensure wrapped in {} | [optional]  |

### Return type

[**RuleDesignerResponse**](RuleDesignerResponse.md)

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

<a id="ruletargetclientget"></a>
# **RuleTargetClientGet**
> RuleList RuleTargetClientGet (TargetEnum target, string varClient, int? from = null, int? to = null, string? sortProperty = null, string? sortDescending = null, string? createdRuleUrl = null, HealthScoreTimeFrame? healthScore = null, bool? includeStatistics = null, string? searchText = null, string? parameterName = null, string? parameterValue = null, string? templateFilter = null, bool? includePublic = null, bool? checkTemplateLatestVersion = null, List<string>? iClients = null)

Get information about all rules published by this client to the given target.

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
    public class RuleTargetClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var sortProperty = "sortProperty_example";  // string? | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. (optional) 
            var sortDescending = "sortDescending_example";  // string? | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty (optional) 
            var createdRuleUrl = "createdRuleUrl_example";  // string? | The url the rule was published to. Only rule with this url will be returned. In the format of:   target/client/rule_name (optional) 
            var healthScore = new HealthScoreTimeFrame?(); // HealthScoreTimeFrame? | Time Frame for calculating the health score of a rule. Allowed values are hour, day, min (optional) 
            var includeStatistics = true;  // bool? | Should the results include the execution statistics for each rule? Default true (optional) 
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 
            var parameterName = "parameterName_example";  // string? | Get the report for a specific parameter (optional) 
            var parameterValue = "parameterValue_example";  // string? | Get a list of rules which have a specific parameter value (optional) 
            var templateFilter = "templateFilter_example";  // string? | Filter to return only rules using specified template (optional) 
            var includePublic = true;  // bool? | Flag to indicate whether rules from the public client should be included in the results, please use   iClients=public instead (optional) 
            var checkTemplateLatestVersion = true;  // bool? | Should a check to verify rule has the latest templates version be performed? (optional) 
            var iClients = new List<string>?(); // List<string>? | Only include these client(s) (optional) 

            try
            {
                // Get information about all rules published by this client to the given target.
                RuleList result = apiInstance.RuleTargetClientGet(target, varClient, from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about all rules published by this client to the given target.
    ApiResponse<RuleList> response = apiInstance.RuleTargetClientGetWithHttpInfo(target, varClient, from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **varClient** | **string** | Client name |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **sortProperty** | **string?** | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. | [optional]  |
| **sortDescending** | **string?** | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty | [optional]  |
| **createdRuleUrl** | **string?** | The url the rule was published to. Only rule with this url will be returned. In the format of:   target/client/rule_name | [optional]  |
| **healthScore** | [**HealthScoreTimeFrame?**](HealthScoreTimeFrame?.md) | Time Frame for calculating the health score of a rule. Allowed values are hour, day, min | [optional]  |
| **includeStatistics** | **bool?** | Should the results include the execution statistics for each rule? Default true | [optional]  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |
| **parameterName** | **string?** | Get the report for a specific parameter | [optional]  |
| **parameterValue** | **string?** | Get a list of rules which have a specific parameter value | [optional]  |
| **templateFilter** | **string?** | Filter to return only rules using specified template | [optional]  |
| **includePublic** | **bool?** | Flag to indicate whether rules from the public client should be included in the results, please use   iClients&#x3D;public instead | [optional]  |
| **checkTemplateLatestVersion** | **bool?** | Should a check to verify rule has the latest templates version be performed? | [optional]  |
| **iClients** | [**List&lt;string&gt;?**](string.md) | Only include these client(s) | [optional]  |

### Return type

[**RuleList**](RuleList.md)

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

<a id="ruletargetclientrulenameautoloaderget"></a>
# **RuleTargetClientRulenameAutoloaderGet**
> RuleList RuleTargetClientRulenameAutoloaderGet (TargetEnum target, string varClient, string rulename)

Get the autoloader JSON for a specific rule. This is normally used by the Rule plugin within Spoon

This will be parsed by the Spoon plugin so that a rule created as an autoloader can be edited

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameAutoloaderGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Get the autoloader JSON for a specific rule. This is normally used by the Rule plugin within Spoon
                RuleList result = apiInstance.RuleTargetClientRulenameAutoloaderGet(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameAutoloaderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameAutoloaderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the autoloader JSON for a specific rule. This is normally used by the Rule plugin within Spoon
    ApiResponse<RuleList> response = apiInstance.RuleTargetClientRulenameAutoloaderGetWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameAutoloaderGetWithHttpInfo: " + e.Message);
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

[**RuleList**](RuleList.md)

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

<a id="ruletargetclientrulenameautoloaderpost"></a>
# **RuleTargetClientRulenameAutoloaderPost**
> RuleAndStateResponse RuleTargetClientRulenameAutoloaderPost (TargetEnum target, string varClient, string rulename, Object? body = null)

Save the JSON for an autoloader rule

This will automatically change the structure and the values within the rule so that it can load the data   required. Tis is normally called by the Rule plugin from within Spoon. Only rules that were created as an autoloader can   be altered.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameAutoloaderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var body = null;  // Object? | Specify the autoloader JSON for the updated rule. Ensure wrapped in {} (optional) 

            try
            {
                // Save the JSON for an autoloader rule
                RuleAndStateResponse result = apiInstance.RuleTargetClientRulenameAutoloaderPost(target, varClient, rulename, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameAutoloaderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameAutoloaderPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save the JSON for an autoloader rule
    ApiResponse<RuleAndStateResponse> response = apiInstance.RuleTargetClientRulenameAutoloaderPostWithHttpInfo(target, varClient, rulename, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameAutoloaderPostWithHttpInfo: " + e.Message);
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
| **body** | **Object?** | Specify the autoloader JSON for the updated rule. Ensure wrapped in {} | [optional]  |

### Return type

[**RuleAndStateResponse**](RuleAndStateResponse.md)

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

<a id="ruletargetclientrulenamecopytopost"></a>
# **RuleTargetClientRulenameCopytoPost**
> RuleAndStateResponse RuleTargetClientRulenameCopytoPost (TargetEnum target, string varClient, string rulename, TargetEnum? destinationtarget = null, DestinationTarget? destinationTarget = null)

Copy this rule to the given target.

A copy of this rule will be started in the given target.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameCopytoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var destinationtarget = new TargetEnum?(); // TargetEnum? | The target to copy the rule to - must be different from the current target.  Can optionally be   provided in the requestBody as JSON instead if preferred (optional) 
            var destinationTarget = new DestinationTarget?(); // DestinationTarget? | Where the copy will run. (optional) 

            try
            {
                // Copy this rule to the given target.
                RuleAndStateResponse result = apiInstance.RuleTargetClientRulenameCopytoPost(target, varClient, rulename, destinationtarget, destinationTarget);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameCopytoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameCopytoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy this rule to the given target.
    ApiResponse<RuleAndStateResponse> response = apiInstance.RuleTargetClientRulenameCopytoPostWithHttpInfo(target, varClient, rulename, destinationtarget, destinationTarget);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameCopytoPostWithHttpInfo: " + e.Message);
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
| **destinationtarget** | [**TargetEnum?**](TargetEnum?.md) | The target to copy the rule to - must be different from the current target.  Can optionally be   provided in the requestBody as JSON instead if preferred | [optional]  |
| **destinationTarget** | [**DestinationTarget?**](DestinationTarget?.md) | Where the copy will run. | [optional]  |

### Return type

[**RuleAndStateResponse**](RuleAndStateResponse.md)

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

<a id="ruletargetclientrulenamedatagriddatagridnameget"></a>
# **RuleTargetClientRulenameDatagridDataGridNameGet**
> DataGridApiResponse RuleTargetClientRulenameDatagridDataGridNameGet (TargetEnum target, string varClient, string rulename, string dataGridName, CsvEnum? format = null)

Get information about the data grid for a specific, published rule.

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
    public class RuleTargetClientRulenameDatagridDataGridNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var dataGridName = "dataGridName_example";  // string | Name of the Data Grid that will be updated
            var format = new CsvEnum?(); // CsvEnum? | If you want CSV, enter csv here (optional) 

            try
            {
                // Get information about the data grid for a specific, published rule.
                DataGridApiResponse result = apiInstance.RuleTargetClientRulenameDatagridDataGridNameGet(target, varClient, rulename, dataGridName, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDatagridDataGridNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameDatagridDataGridNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about the data grid for a specific, published rule.
    ApiResponse<DataGridApiResponse> response = apiInstance.RuleTargetClientRulenameDatagridDataGridNameGetWithHttpInfo(target, varClient, rulename, dataGridName, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDatagridDataGridNameGetWithHttpInfo: " + e.Message);
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
| **dataGridName** | **string** | Name of the Data Grid that will be updated |  |
| **format** | [**CsvEnum?**](CsvEnum?.md) | If you want CSV, enter csv here | [optional]  |

### Return type

[**DataGridApiResponse**](DataGridApiResponse.md)

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

<a id="ruletargetclientrulenamedatagriddatagridnamepost"></a>
# **RuleTargetClientRulenameDatagridDataGridNamePost**
> RuleAndStateResponse RuleTargetClientRulenameDatagridDataGridNamePost (TargetEnum target, string varClient, string rulename, string dataGridName, List<DataGridDetails>? dataGridDetails = null)

Enter new data for an exisiting data grid and update

If a rule already has an associated data grid, here it is possible to enter new data and change the grid   contents.  Note, you cannot add or remove columns but you can change their format.  Do a get on the data grid to get the   existing structure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameDatagridDataGridNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var dataGridName = "dataGridName_example";  // string | Name of the Data Grid that will be updated
            var dataGridDetails = new List<DataGridDetails>?(); // List<DataGridDetails>? | Specify the data for the updated data grid. Ensure wrapped in {} (optional) 

            try
            {
                // Enter new data for an exisiting data grid and update
                RuleAndStateResponse result = apiInstance.RuleTargetClientRulenameDatagridDataGridNamePost(target, varClient, rulename, dataGridName, dataGridDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDatagridDataGridNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameDatagridDataGridNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enter new data for an exisiting data grid and update
    ApiResponse<RuleAndStateResponse> response = apiInstance.RuleTargetClientRulenameDatagridDataGridNamePostWithHttpInfo(target, varClient, rulename, dataGridName, dataGridDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDatagridDataGridNamePostWithHttpInfo: " + e.Message);
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
| **dataGridName** | **string** | Name of the Data Grid that will be updated |  |
| **dataGridDetails** | [**List&lt;DataGridDetails&gt;?**](DataGridDetails.md) | Specify the data for the updated data grid. Ensure wrapped in {} | [optional]  |

### Return type

[**RuleAndStateResponse**](RuleAndStateResponse.md)

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

<a id="ruletargetclientrulenamedatagriddatagridnamerowspost"></a>
# **RuleTargetClientRulenameDatagridDataGridNameRowsPost**
> RuleAndStateResponse RuleTargetClientRulenameDatagridDataGridNameRowsPost (TargetEnum target, string varClient, string rulename, string dataGridName, DataGridRow? dataGridRow = null)

Add new data grid rows to a rule's Data Grid

This is to append new data only. Existing data remains unchanged

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameDatagridDataGridNameRowsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var dataGridName = "dataGridName_example";  // string | Name of the Data Grid that will be updated
            var dataGridRow = new DataGridRow?(); // DataGridRow? | Data grid rows (optional) 

            try
            {
                // Add new data grid rows to a rule's Data Grid
                RuleAndStateResponse result = apiInstance.RuleTargetClientRulenameDatagridDataGridNameRowsPost(target, varClient, rulename, dataGridName, dataGridRow);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDatagridDataGridNameRowsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameDatagridDataGridNameRowsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add new data grid rows to a rule's Data Grid
    ApiResponse<RuleAndStateResponse> response = apiInstance.RuleTargetClientRulenameDatagridDataGridNameRowsPostWithHttpInfo(target, varClient, rulename, dataGridName, dataGridRow);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDatagridDataGridNameRowsPostWithHttpInfo: " + e.Message);
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
| **dataGridName** | **string** | Name of the Data Grid that will be updated |  |
| **dataGridRow** | [**DataGridRow?**](DataGridRow?.md) | Data grid rows | [optional]  |

### Return type

[**RuleAndStateResponse**](RuleAndStateResponse.md)

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

<a id="ruletargetclientrulenamedelete"></a>
# **RuleTargetClientRulenameDelete**
> RuleList RuleTargetClientRulenameDelete (TargetEnum target, string varClient, string rulename)

Unpublish a specific rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Unpublish a specific rule.
                RuleList result = apiInstance.RuleTargetClientRulenameDelete(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unpublish a specific rule.
    ApiResponse<RuleList> response = apiInstance.RuleTargetClientRulenameDeleteWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDeleteWithHttpInfo: " + e.Message);
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

[**RuleList**](RuleList.md)

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

<a id="ruletargetclientrulenamedesignerget"></a>
# **RuleTargetClientRulenameDesignerGet**
> RuleList RuleTargetClientRulenameDesignerGet (TargetEnum target, string varClient, string rulename)

Get the rule designer JSON for a specific rule. This is normally used by the Rule designer user interface

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
    public class RuleTargetClientRulenameDesignerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Get the rule designer JSON for a specific rule. This is normally used by the Rule designer user interface
                RuleList result = apiInstance.RuleTargetClientRulenameDesignerGet(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDesignerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameDesignerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the rule designer JSON for a specific rule. This is normally used by the Rule designer user interface
    ApiResponse<RuleList> response = apiInstance.RuleTargetClientRulenameDesignerGetWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDesignerGetWithHttpInfo: " + e.Message);
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

[**RuleList**](RuleList.md)

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

<a id="ruletargetclientrulenamedesignerpost"></a>
# **RuleTargetClientRulenameDesignerPost**
> RuleDesignerResponse RuleTargetClientRulenameDesignerPost (TargetEnum target, string varClient, string rulename, bool? validate = null, RuleData? ruleData = null)

Save or validate the rule designer JSON for a rule

This will change the structure and the values within the rule, as defined by the rule designer. If the   new rule structure is not valid and the rule is running then this call will fail unless you are only validating the rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameDesignerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var validate = true;  // bool? | Set to 'True' to only validate the JSON (and not save it) (optional) 
            var ruleData = new RuleData?(); // RuleData? | Specify the rule designer JSON for the updated rule. Ensure wrapped in {} (optional) 

            try
            {
                // Save or validate the rule designer JSON for a rule
                RuleDesignerResponse result = apiInstance.RuleTargetClientRulenameDesignerPost(target, varClient, rulename, validate, ruleData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDesignerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameDesignerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save or validate the rule designer JSON for a rule
    ApiResponse<RuleDesignerResponse> response = apiInstance.RuleTargetClientRulenameDesignerPostWithHttpInfo(target, varClient, rulename, validate, ruleData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDesignerPostWithHttpInfo: " + e.Message);
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
| **validate** | **bool?** | Set to &#39;True&#39; to only validate the JSON (and not save it) | [optional]  |
| **ruleData** | [**RuleData?**](RuleData?.md) | Specify the rule designer JSON for the updated rule. Ensure wrapped in {} | [optional]  |

### Return type

[**RuleDesignerResponse**](RuleDesignerResponse.md)

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

<a id="ruletargetclientrulenamedesignerput"></a>
# **RuleTargetClientRulenameDesignerPut**
> ApiResponse RuleTargetClientRulenameDesignerPut (TargetEnum target, string varClient, string rulename, bool? validate = null, bool? download = null, string? body = null)

Add a new rule via the rule designer JSON.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameDesignerPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var validate = true;  // bool? | Set to 'True' to only validate the JSON (and not save it) (optional) 
            var download = true;  // bool? | Download the posted rule designer JSON as a .ktr file (optional) 
            var body = "body_example";  // string? | Specify the rule designer JSON for the updated rule. Ensure wrapped in {} (optional) 

            try
            {
                // Add a new rule via the rule designer JSON.
                ApiResponse result = apiInstance.RuleTargetClientRulenameDesignerPut(target, varClient, rulename, validate, download, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDesignerPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameDesignerPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new rule via the rule designer JSON.
    ApiResponse<ApiResponse> response = apiInstance.RuleTargetClientRulenameDesignerPutWithHttpInfo(target, varClient, rulename, validate, download, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameDesignerPutWithHttpInfo: " + e.Message);
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
| **validate** | **bool?** | Set to &#39;True&#39; to only validate the JSON (and not save it) | [optional]  |
| **download** | **bool?** | Download the posted rule designer JSON as a .ktr file | [optional]  |
| **body** | **string?** | Specify the rule designer JSON for the updated rule. Ensure wrapped in {} | [optional]  |

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

<a id="ruletargetclientrulenameget"></a>
# **RuleTargetClientRulenameGet**
> RuleList RuleTargetClientRulenameGet (TargetEnum target, string varClient, string rulename, HealthScoreTimeFrame? healthScore = null, bool? includeStatistics = null, bool? checkTemplateLatestVersion = null)

Get information about one specific, published rule.

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
    public class RuleTargetClientRulenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var healthScore = new HealthScoreTimeFrame?(); // HealthScoreTimeFrame? | Time Frame for calculating the health score of a rule. Allowed values are hour, day, min (optional) 
            var includeStatistics = true;  // bool? | Should the results include the execution statistics for each rule? Default true (optional) 
            var checkTemplateLatestVersion = true;  // bool? | Should a check to verify rule has the latest templates version be performed? (optional) 

            try
            {
                // Get information about one specific, published rule.
                RuleList result = apiInstance.RuleTargetClientRulenameGet(target, varClient, rulename, healthScore, includeStatistics, checkTemplateLatestVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about one specific, published rule.
    ApiResponse<RuleList> response = apiInstance.RuleTargetClientRulenameGetWithHttpInfo(target, varClient, rulename, healthScore, includeStatistics, checkTemplateLatestVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameGetWithHttpInfo: " + e.Message);
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
| **healthScore** | [**HealthScoreTimeFrame?**](HealthScoreTimeFrame?.md) | Time Frame for calculating the health score of a rule. Allowed values are hour, day, min | [optional]  |
| **includeStatistics** | **bool?** | Should the results include the execution statistics for each rule? Default true | [optional]  |
| **checkTemplateLatestVersion** | **bool?** | Should a check to verify rule has the latest templates version be performed? | [optional]  |

### Return type

[**RuleList**](RuleList.md)

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

<a id="ruletargetclientrulenameparameterpost"></a>
# **RuleTargetClientRulenameParameterPost**
> RuleAndStateResponse RuleTargetClientRulenameParameterPost (TargetEnum target, string varClient, string rulename, Object? body = null)

update the default values for parameters.

this will update the rule with new default parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameParameterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var body = {"parameterName":"parameterValue"};  // Object? | key value pairs of param name and value. Ensure wrapped in {} (optional) 

            try
            {
                // update the default values for parameters.
                RuleAndStateResponse result = apiInstance.RuleTargetClientRulenameParameterPost(target, varClient, rulename, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameParameterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameParameterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update the default values for parameters.
    ApiResponse<RuleAndStateResponse> response = apiInstance.RuleTargetClientRulenameParameterPostWithHttpInfo(target, varClient, rulename, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameParameterPostWithHttpInfo: " + e.Message);
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
| **body** | **Object?** | key value pairs of param name and value. Ensure wrapped in {} | [optional]  |

### Return type

[**RuleAndStateResponse**](RuleAndStateResponse.md)

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

<a id="ruletargetclientrulenamepausedelete"></a>
# **RuleTargetClientRulenamePauseDelete**
> ApiResponse RuleTargetClientRulenamePauseDelete (TargetEnum target, string varClient, string rulename)

Pause this rule

Cause this rule to go to 'waiting' state.  A rule that is paused will return an error code if it receives   traffic (i.e. is invoked). Restart the rule to allow it to serve traffic again

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenamePauseDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Pause this rule
                ApiResponse result = apiInstance.RuleTargetClientRulenamePauseDelete(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenamePauseDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenamePauseDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pause this rule
    ApiResponse<ApiResponse> response = apiInstance.RuleTargetClientRulenamePauseDeleteWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenamePauseDeleteWithHttpInfo: " + e.Message);
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

<a id="ruletargetclientrulenamepost"></a>
# **RuleTargetClientRulenamePost**
> ApiResponse RuleTargetClientRulenamePost (TargetEnum target, string varClient, string rulename)

Start or restart one specific, published rule.

Cause this rule to be re-read from disk and restarted. If this rule was previously paused then it will be unpaused. If it was previously snoozed then it will be unsnoozed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Start or restart one specific, published rule.
                ApiResponse result = apiInstance.RuleTargetClientRulenamePost(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start or restart one specific, published rule.
    ApiResponse<ApiResponse> response = apiInstance.RuleTargetClientRulenamePostWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenamePostWithHttpInfo: " + e.Message);
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

<a id="ruletargetclientrulenamepriorityweightingpost"></a>
# **RuleTargetClientRulenamePriorityWeightingPost**
> RuleAndStateResponse RuleTargetClientRulenamePriorityWeightingPost (TargetEnum target, string varClient, string rulename, Object? body = null)

Update the rule's priority weighting

This will set a new value for a rule's priority weighting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenamePriorityWeightingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var body = null;  // Object? | key value pairs of param name and value. Ensure wrapped in {} (optional) 

            try
            {
                // Update the rule's priority weighting
                RuleAndStateResponse result = apiInstance.RuleTargetClientRulenamePriorityWeightingPost(target, varClient, rulename, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenamePriorityWeightingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenamePriorityWeightingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the rule's priority weighting
    ApiResponse<RuleAndStateResponse> response = apiInstance.RuleTargetClientRulenamePriorityWeightingPostWithHttpInfo(target, varClient, rulename, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenamePriorityWeightingPostWithHttpInfo: " + e.Message);
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
| **body** | **Object?** | key value pairs of param name and value. Ensure wrapped in {} | [optional]  |

### Return type

[**RuleAndStateResponse**](RuleAndStateResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, example


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ruletargetclientrulenameresetdelete"></a>
# **RuleTargetClientRulenameResetDelete**
> ApiResponse RuleTargetClientRulenameResetDelete (TargetEnum target, string varClient, string rulename)

Perform extended actions to rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameResetDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Perform extended actions to rules
                ApiResponse result = apiInstance.RuleTargetClientRulenameResetDelete(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameResetDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameResetDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Perform extended actions to rules
    ApiResponse<ApiResponse> response = apiInstance.RuleTargetClientRulenameResetDeleteWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameResetDeleteWithHttpInfo: " + e.Message);
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

<a id="ruletargetclientrulenamesampledataget"></a>
# **RuleTargetClientRulenameSampleDataGet**
> ApiJSONArrayResponse RuleTargetClientRulenameSampleDataGet (TargetEnum target, string varClient, string rulename)

Get JSON Schema representation of the data expected by the rule

Generates a JSON Schema object, following json-schema.org specification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameSampleDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Get JSON Schema representation of the data expected by the rule
                ApiJSONArrayResponse result = apiInstance.RuleTargetClientRulenameSampleDataGet(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameSampleDataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameSampleDataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get JSON Schema representation of the data expected by the rule
    ApiResponse<ApiJSONArrayResponse> response = apiInstance.RuleTargetClientRulenameSampleDataGetWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameSampleDataGetWithHttpInfo: " + e.Message);
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

[**ApiJSONArrayResponse**](ApiJSONArrayResponse.md)

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

<a id="ruletargetclientrulenamesnoozepost"></a>
# **RuleTargetClientRulenameSnoozePost**
> ApiResponse RuleTargetClientRulenameSnoozePost (TargetEnum target, string varClient, string rulename)

Make this rule start snoozing

Snoozed rules are paused, and use no resources. They automatically start when invoked; there will be a short delay while the rule starts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameSnoozePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Make this rule start snoozing
                ApiResponse result = apiInstance.RuleTargetClientRulenameSnoozePost(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameSnoozePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameSnoozePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make this rule start snoozing
    ApiResponse<ApiResponse> response = apiInstance.RuleTargetClientRulenameSnoozePostWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameSnoozePostWithHttpInfo: " + e.Message);
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

<a id="ruletargetclientrulenametestdatadelete"></a>
# **RuleTargetClientRulenameTestDataDelete**
> ApiResponse RuleTargetClientRulenameTestDataDelete (TargetEnum target, string varClient, string rulename)

Delete all test data

Deletes all of user defined test data for this rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameTestDataDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Delete all test data
                ApiResponse result = apiInstance.RuleTargetClientRulenameTestDataDelete(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameTestDataDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameTestDataDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all test data
    ApiResponse<ApiResponse> response = apiInstance.RuleTargetClientRulenameTestDataDeleteWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameTestDataDeleteWithHttpInfo: " + e.Message);
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

<a id="ruletargetclientrulenametestdataget"></a>
# **RuleTargetClientRulenameTestDataGet**
> TestDataResponse RuleTargetClientRulenameTestDataGet (TargetEnum target, string varClient, string rulename)

Get the rule's test data and headers information

Returns the test data and header information as specified in the rule's Realtime Input step

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameTestDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name

            try
            {
                // Get the rule's test data and headers information
                TestDataResponse result = apiInstance.RuleTargetClientRulenameTestDataGet(target, varClient, rulename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameTestDataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameTestDataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the rule's test data and headers information
    ApiResponse<TestDataResponse> response = apiInstance.RuleTargetClientRulenameTestDataGetWithHttpInfo(target, varClient, rulename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameTestDataGetWithHttpInfo: " + e.Message);
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

[**TestDataResponse**](TestDataResponse.md)

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

<a id="ruletargetclientrulenametestdatapost"></a>
# **RuleTargetClientRulenameTestDataPost**
> ApiResponse RuleTargetClientRulenameTestDataPost (TargetEnum target, string varClient, string rulename, List<TestData>? testData = null)

Add test data to rule

User defined test data rows will be stored for this rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class RuleTargetClientRulenameTestDataPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var varClient = "varClient_example";  // string | Client name
            var rulename = "rulename_example";  // string | Rule name
            var testData = new List<TestData>?(); // List<TestData>? |  (optional) 

            try
            {
                // Add test data to rule
                ApiResponse result = apiInstance.RuleTargetClientRulenameTestDataPost(target, varClient, rulename, testData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameTestDataPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetClientRulenameTestDataPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add test data to rule
    ApiResponse<ApiResponse> response = apiInstance.RuleTargetClientRulenameTestDataPostWithHttpInfo(target, varClient, rulename, testData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetClientRulenameTestDataPostWithHttpInfo: " + e.Message);
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
| **testData** | [**List&lt;TestData&gt;?**](TestData.md) |  | [optional]  |

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

<a id="ruletargetget"></a>
# **RuleTargetGet**
> RuleList RuleTargetGet (TargetEnum target, int? from = null, int? to = null, string? sortProperty = null, string? sortDescending = null, string? createdRuleUrl = null, HealthScoreTimeFrame? healthScore = null, bool? includeStatistics = null, string? searchText = null, string? parameterName = null, string? parameterValue = null, string? templateFilter = null, bool? includePublic = null, bool? checkTemplateLatestVersion = null, List<string>? iClients = null)

Get information about all rules published by all clients to the given target

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
    public class RuleTargetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RulesApi(config);
            var target = new TargetEnum(); // TargetEnum | Target - is where rule is published.
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var sortProperty = "sortProperty_example";  // string? | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. (optional) 
            var sortDescending = "sortDescending_example";  // string? | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty (optional) 
            var createdRuleUrl = "createdRuleUrl_example";  // string? | The url the rule was published to. Only rule with this url will be returned. In the format of:   target/client/rule_name (optional) 
            var healthScore = new HealthScoreTimeFrame?(); // HealthScoreTimeFrame? | Time Frame for calculating the health score of a rule. Allowed values are hour, day, min (optional) 
            var includeStatistics = true;  // bool? | Should the results include the execution statistics for each rule? Default true (optional) 
            var searchText = "searchText_example";  // string? | Filter results to those which contain this text (optional) 
            var parameterName = "parameterName_example";  // string? | Get the report for a specific parameter (optional) 
            var parameterValue = "parameterValue_example";  // string? | Get a list of rules which have a specific parameter value (optional) 
            var templateFilter = "templateFilter_example";  // string? | Filter to return only rules using specified template (optional) 
            var includePublic = true;  // bool? | Flag to indicate whether rules from the public client should be included in the results, please use   iClients=public instead (optional) 
            var checkTemplateLatestVersion = true;  // bool? | Should a check to verify rule has the latest templates version be performed? (optional) 
            var iClients = new List<string>?(); // List<string>? | Only include these client(s) (optional) 

            try
            {
                // Get information about all rules published by all clients to the given target
                RuleList result = apiInstance.RuleTargetGet(target, from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.RuleTargetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RuleTargetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about all rules published by all clients to the given target
    ApiResponse<RuleList> response = apiInstance.RuleTargetGetWithHttpInfo(target, from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.RuleTargetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **target** | [**TargetEnum**](TargetEnum.md) | Target - is where rule is published. |  |
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **sortProperty** | **string?** | List of comma-separated values, by which the returned rules will be sorted by. The possible values   are: name, client, description, businessGoal, dataType, isConfidential, isVisible, isEditable, isForcedValue. | [optional]  |
| **sortDescending** | **string?** | List of comma-separated true/false values indicating either ascending (false) or descending (true)   order of each sortProperty | [optional]  |
| **createdRuleUrl** | **string?** | The url the rule was published to. Only rule with this url will be returned. In the format of:   target/client/rule_name | [optional]  |
| **healthScore** | [**HealthScoreTimeFrame?**](HealthScoreTimeFrame?.md) | Time Frame for calculating the health score of a rule. Allowed values are hour, day, min | [optional]  |
| **includeStatistics** | **bool?** | Should the results include the execution statistics for each rule? Default true | [optional]  |
| **searchText** | **string?** | Filter results to those which contain this text | [optional]  |
| **parameterName** | **string?** | Get the report for a specific parameter | [optional]  |
| **parameterValue** | **string?** | Get a list of rules which have a specific parameter value | [optional]  |
| **templateFilter** | **string?** | Filter to return only rules using specified template | [optional]  |
| **includePublic** | **bool?** | Flag to indicate whether rules from the public client should be included in the results, please use   iClients&#x3D;public instead | [optional]  |
| **checkTemplateLatestVersion** | **bool?** | Should a check to verify rule has the latest templates version be performed? | [optional]  |
| **iClients** | [**List&lt;string&gt;?**](string.md) | Only include these client(s) | [optional]  |

### Return type

[**RuleList**](RuleList.md)

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

