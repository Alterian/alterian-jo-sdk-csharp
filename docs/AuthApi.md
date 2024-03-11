# Alterian.JO.Api.AuthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthPermissionGet**](AuthApi.md#authpermissionget) | **GET** /auth/permission | Get a list of all permissions |
| [**AuthRoleGet**](AuthApi.md#authroleget) | **GET** /auth/role | Get a list of roles |
| [**AuthRoleNameClientClientNameDelete**](AuthApi.md#authrolenameclientclientnamedelete) | **DELETE** /auth/role/{name}/client/{clientName} | Remove client from a role |
| [**AuthRoleNameClientClientNamePost**](AuthApi.md#authrolenameclientclientnamepost) | **POST** /auth/role/{name}/client/{clientName} | Add client to a role |
| [**AuthRoleNameClientGet**](AuthApi.md#authrolenameclientget) | **GET** /auth/role/{name}/client | Get the list of clients for a role |
| [**AuthRoleNameDelete**](AuthApi.md#authrolenamedelete) | **DELETE** /auth/role/{name} | Remove a role |
| [**AuthRoleNameGet**](AuthApi.md#authrolenameget) | **GET** /auth/role/{name} | Get information about a specific role |
| [**AuthRoleNamePermissionDelete**](AuthApi.md#authrolenamepermissiondelete) | **DELETE** /auth/role/{name}/{permission} | Remove permission from a role |
| [**AuthRoleNamePermissionGet**](AuthApi.md#authrolenamepermissionget) | **GET** /auth/role/{name}/permission | Get the list of permissions granted by a specific role |
| [**AuthRoleNamePermissionPost**](AuthApi.md#authrolenamepermissionpost) | **POST** /auth/role/{name}/{permission} | Add permission to a role |
| [**AuthRolePost**](AuthApi.md#authrolepost) | **POST** /auth/role | Create a new role |
| [**AuthSiteGet**](AuthApi.md#authsiteget) | **GET** /auth/site | Get a list of sites |
| [**AuthSiteIdDelete**](AuthApi.md#authsiteiddelete) | **DELETE** /auth/site/{id} | Remove a site |
| [**AuthSiteIdGet**](AuthApi.md#authsiteidget) | **GET** /auth/site/{id} | Get information about specified site |
| [**AuthSiteIdUserGet**](AuthApi.md#authsiteiduserget) | **GET** /auth/site/{id}/user | Get the list of site users |
| [**AuthSiteIdUserNameDelete**](AuthApi.md#authsiteidusernamedelete) | **DELETE** /auth/site/{id}/user/{name} | Remove user from a site |
| [**AuthSiteIdUserNamePost**](AuthApi.md#authsiteidusernamepost) | **POST** /auth/site/{id}/user/{name} | Add user to a site |
| [**AuthSitePost**](AuthApi.md#authsitepost) | **POST** /auth/site | Create a new site |
| [**AuthUserGet**](AuthApi.md#authuserget) | **GET** /auth/user | Get a list of users |
| [**AuthUserNameClientClientNameDelete**](AuthApi.md#authusernameclientclientnamedelete) | **DELETE** /auth/user/{name}/client/{clientName} | Remove client access from user |
| [**AuthUserNameClientClientNamePost**](AuthApi.md#authusernameclientclientnamepost) | **POST** /auth/user/{name}/client/{clientName} | Add client access to user |
| [**AuthUserNameClientGet**](AuthApi.md#authusernameclientget) | **GET** /auth/user/{name}/client | Get the list of clients to which a user has been granted access |
| [**AuthUserNameDelete**](AuthApi.md#authusernamedelete) | **DELETE** /auth/user/{name} | Remove a user |
| [**AuthUserNameGet**](AuthApi.md#authusernameget) | **GET** /auth/user/{name} | Get information about specified user |
| [**AuthUserNamePermissionGet**](AuthApi.md#authusernamepermissionget) | **GET** /auth/user/{name}/permission | Get the list of user permission |
| [**AuthUserNamePermissionPermissionDelete**](AuthApi.md#authusernamepermissionpermissiondelete) | **DELETE** /auth/user/{name}/permission/{permission} | Remove permission from a user |
| [**AuthUserNamePermissionPermissionPost**](AuthApi.md#authusernamepermissionpermissionpost) | **POST** /auth/user/{name}/permission/{permission} | Add permission to a user |
| [**AuthUserNameRoleGet**](AuthApi.md#authusernameroleget) | **GET** /auth/user/{name}/role | Get the list of the roles which have been assigned to a user |
| [**AuthUserNameRoleRoleNameDelete**](AuthApi.md#authusernamerolerolenamedelete) | **DELETE** /auth/user/{name}/role/{roleName} | Remove role from a user |
| [**AuthUserNameRoleRoleNamePost**](AuthApi.md#authusernamerolerolenamepost) | **POST** /auth/user/{name}/role/{roleName} | Assign role to user |
| [**AuthUserNameTokenTokenNameDelete**](AuthApi.md#authusernametokentokennamedelete) | **DELETE** /auth/user/{name}/token/{tokenName} | Remove static access token from user |
| [**AuthUserNameTokenTokenNamePost**](AuthApi.md#authusernametokentokennamepost) | **POST** /auth/user/{name}/token/{tokenName} | Add static access token to user |
| [**AuthUserPost**](AuthApi.md#authuserpost) | **POST** /auth/user | Create a new user |

<a id="authpermissionget"></a>
# **AuthPermissionGet**
> PermissionList AuthPermissionGet (int? from = null, int? to = null)

Get a list of all permissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthPermissionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 

            try
            {
                // Get a list of all permissions
                PermissionList result = apiInstance.AuthPermissionGet(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthPermissionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthPermissionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of all permissions
    ApiResponse<PermissionList> response = apiInstance.AuthPermissionGetWithHttpInfo(from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthPermissionGetWithHttpInfo: " + e.Message);
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

[**PermissionList**](PermissionList.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Permissions that the system knows about |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authroleget"></a>
# **AuthRoleGet**
> RoleList AuthRoleGet (int? from = null, int? to = null)

Get a list of roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 

            try
            {
                // Get a list of roles
                RoleList result = apiInstance.AuthRoleGet(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of roles
    ApiResponse<RoleList> response = apiInstance.AuthRoleGetWithHttpInfo(from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleGetWithHttpInfo: " + e.Message);
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

[**RoleList**](RoleList.md)

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

<a id="authrolenameclientclientnamedelete"></a>
# **AuthRoleNameClientClientNameDelete**
> ApiResponse AuthRoleNameClientClientNameDelete (string name, string clientName)

Remove client from a role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleNameClientClientNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Role Name
            var clientName = "clientName_example";  // string | Client that will have this role removed from it

            try
            {
                // Remove client from a role
                ApiResponse result = apiInstance.AuthRoleNameClientClientNameDelete(name, clientName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleNameClientClientNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleNameClientClientNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove client from a role
    ApiResponse<ApiResponse> response = apiInstance.AuthRoleNameClientClientNameDeleteWithHttpInfo(name, clientName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleNameClientClientNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Role Name |  |
| **clientName** | **string** | Client that will have this role removed from it |  |

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

<a id="authrolenameclientclientnamepost"></a>
# **AuthRoleNameClientClientNamePost**
> ApiResponse AuthRoleNameClientClientNamePost (string name, string clientName)

Add client to a role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleNameClientClientNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Role Name
            var clientName = "clientName_example";  // string | Client to add

            try
            {
                // Add client to a role
                ApiResponse result = apiInstance.AuthRoleNameClientClientNamePost(name, clientName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleNameClientClientNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleNameClientClientNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add client to a role
    ApiResponse<ApiResponse> response = apiInstance.AuthRoleNameClientClientNamePostWithHttpInfo(name, clientName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleNameClientClientNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Role Name |  |
| **clientName** | **string** | Client to add |  |

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

<a id="authrolenameclientget"></a>
# **AuthRoleNameClientGet**
> RefList AuthRoleNameClientGet (string name)

Get the list of clients for a role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleNameClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Role Name

            try
            {
                // Get the list of clients for a role
                RefList result = apiInstance.AuthRoleNameClientGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleNameClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleNameClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of clients for a role
    ApiResponse<RefList> response = apiInstance.AuthRoleNameClientGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleNameClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Role Name |  |

### Return type

[**RefList**](RefList.md)

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

<a id="authrolenamedelete"></a>
# **AuthRoleNameDelete**
> ApiResponse AuthRoleNameDelete (string name)

Remove a role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Name of role to delete

            try
            {
                // Remove a role
                ApiResponse result = apiInstance.AuthRoleNameDelete(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a role
    ApiResponse<ApiResponse> response = apiInstance.AuthRoleNameDeleteWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of role to delete |  |

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

<a id="authrolenameget"></a>
# **AuthRoleNameGet**
> RoleList AuthRoleNameGet (string name)

Get information about a specific role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | The role to retrieve

            try
            {
                // Get information about a specific role
                RoleList result = apiInstance.AuthRoleNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about a specific role
    ApiResponse<RoleList> response = apiInstance.AuthRoleNameGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The role to retrieve |  |

### Return type

[**RoleList**](RoleList.md)

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

<a id="authrolenamepermissiondelete"></a>
# **AuthRoleNamePermissionDelete**
> ApiResponse AuthRoleNamePermissionDelete (string name, string permission)

Remove permission from a role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleNamePermissionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Role to alter
            var permission = "permission_example";  // string | Permission to remove from role

            try
            {
                // Remove permission from a role
                ApiResponse result = apiInstance.AuthRoleNamePermissionDelete(name, permission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleNamePermissionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleNamePermissionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove permission from a role
    ApiResponse<ApiResponse> response = apiInstance.AuthRoleNamePermissionDeleteWithHttpInfo(name, permission);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleNamePermissionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Role to alter |  |
| **permission** | **string** | Permission to remove from role |  |

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

<a id="authrolenamepermissionget"></a>
# **AuthRoleNamePermissionGet**
> PermissionList AuthRoleNamePermissionGet (string name)

Get the list of permissions granted by a specific role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleNamePermissionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Role Name

            try
            {
                // Get the list of permissions granted by a specific role
                PermissionList result = apiInstance.AuthRoleNamePermissionGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleNamePermissionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleNamePermissionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of permissions granted by a specific role
    ApiResponse<PermissionList> response = apiInstance.AuthRoleNamePermissionGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleNamePermissionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Role Name |  |

### Return type

[**PermissionList**](PermissionList.md)

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

<a id="authrolenamepermissionpost"></a>
# **AuthRoleNamePermissionPost**
> ApiResponse AuthRoleNamePermissionPost (string name, string permission)

Add permission to a role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRoleNamePermissionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | Role to alter
            var permission = "permission_example";  // string | Permission to add

            try
            {
                // Add permission to a role
                ApiResponse result = apiInstance.AuthRoleNamePermissionPost(name, permission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRoleNamePermissionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRoleNamePermissionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add permission to a role
    ApiResponse<ApiResponse> response = apiInstance.AuthRoleNamePermissionPostWithHttpInfo(name, permission);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRoleNamePermissionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Role to alter |  |
| **permission** | **string** | Permission to add |  |

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

<a id="authrolepost"></a>
# **AuthRolePost**
> ApiResponse AuthRolePost (Role role)

Create a new role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthRolePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var role = new Role(); // Role | 

            try
            {
                // Create a new role
                ApiResponse result = apiInstance.AuthRolePost(role);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRolePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRolePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new role
    ApiResponse<ApiResponse> response = apiInstance.AuthRolePostWithHttpInfo(role);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRolePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **role** | [**Role**](Role.md) |  |  |

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

<a id="authsiteget"></a>
# **AuthSiteGet**
> SiteList AuthSiteGet (int? from = null, int? to = null)

Get a list of sites

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthSiteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 

            try
            {
                // Get a list of sites
                SiteList result = apiInstance.AuthSiteGet(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSiteGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSiteGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of sites
    ApiResponse<SiteList> response = apiInstance.AuthSiteGetWithHttpInfo(from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthSiteGetWithHttpInfo: " + e.Message);
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

[**SiteList**](SiteList.md)

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

<a id="authsiteiddelete"></a>
# **AuthSiteIdDelete**
> ApiResponse AuthSiteIdDelete (string id)

Remove a site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthSiteIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var id = "id_example";  // string | Site identifer

            try
            {
                // Remove a site
                ApiResponse result = apiInstance.AuthSiteIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSiteIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSiteIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a site
    ApiResponse<ApiResponse> response = apiInstance.AuthSiteIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthSiteIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Site identifer |  |

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

<a id="authsiteidget"></a>
# **AuthSiteIdGet**
> SiteList AuthSiteIdGet (string id)

Get information about specified site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthSiteIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var id = "id_example";  // string | The site to retrieve

            try
            {
                // Get information about specified site
                SiteList result = apiInstance.AuthSiteIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSiteIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSiteIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about specified site
    ApiResponse<SiteList> response = apiInstance.AuthSiteIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthSiteIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The site to retrieve |  |

### Return type

[**SiteList**](SiteList.md)

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

<a id="authsiteiduserget"></a>
# **AuthSiteIdUserGet**
> RefList AuthSiteIdUserGet (string id)

Get the list of site users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthSiteIdUserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var id = "id_example";  // string | Site identifier

            try
            {
                // Get the list of site users
                RefList result = apiInstance.AuthSiteIdUserGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSiteIdUserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSiteIdUserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of site users
    ApiResponse<RefList> response = apiInstance.AuthSiteIdUserGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthSiteIdUserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Site identifier |  |

### Return type

[**RefList**](RefList.md)

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

<a id="authsiteidusernamedelete"></a>
# **AuthSiteIdUserNameDelete**
> ApiResponse AuthSiteIdUserNameDelete (string id, string name)

Remove user from a site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthSiteIdUserNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var id = "id_example";  // string | Site identifier
            var name = "name_example";  // string | User to remove from site

            try
            {
                // Remove user from a site
                ApiResponse result = apiInstance.AuthSiteIdUserNameDelete(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSiteIdUserNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSiteIdUserNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove user from a site
    ApiResponse<ApiResponse> response = apiInstance.AuthSiteIdUserNameDeleteWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthSiteIdUserNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Site identifier |  |
| **name** | **string** | User to remove from site |  |

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

<a id="authsiteidusernamepost"></a>
# **AuthSiteIdUserNamePost**
> ApiResponse AuthSiteIdUserNamePost (string id, string name)

Add user to a site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthSiteIdUserNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var id = "id_example";  // string | Site identifier
            var name = "name_example";  // string | User Name

            try
            {
                // Add user to a site
                ApiResponse result = apiInstance.AuthSiteIdUserNamePost(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSiteIdUserNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSiteIdUserNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add user to a site
    ApiResponse<ApiResponse> response = apiInstance.AuthSiteIdUserNamePostWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthSiteIdUserNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Site identifier |  |
| **name** | **string** | User Name |  |

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

<a id="authsitepost"></a>
# **AuthSitePost**
> ApiResponse AuthSitePost (string body)

Create a new site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthSitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var body = {"extendedInfo":"a site","siteId":"abcde-12345"};  // string | A block of JSON describing the resource to create

            try
            {
                // Create a new site
                ApiResponse result = apiInstance.AuthSitePost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new site
    ApiResponse<ApiResponse> response = apiInstance.AuthSitePostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthSitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | A block of JSON describing the resource to create |  |

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

<a id="authuserget"></a>
# **AuthUserGet**
> UserList AuthUserGet (int? from = null, int? to = null, bool? getAllDetails = null)

Get a list of users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var from = 56;  // int? | The zero-based index of the first item to return. (optional) 
            var to = 56;  // int? | The zero-based index of the last item to return. (optional) 
            var getAllDetails = true;  // bool? | Do we want to retrieve details of user tokens. (default) false will return only token names (optional) 

            try
            {
                // Get a list of users
                UserList result = apiInstance.AuthUserGet(from, to, getAllDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of users
    ApiResponse<UserList> response = apiInstance.AuthUserGetWithHttpInfo(from, to, getAllDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **int?** | The zero-based index of the first item to return. | [optional]  |
| **to** | **int?** | The zero-based index of the last item to return. | [optional]  |
| **getAllDetails** | **bool?** | Do we want to retrieve details of user tokens. (default) false will return only token names | [optional]  |

### Return type

[**UserList**](UserList.md)

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

<a id="authusernameclientclientnamedelete"></a>
# **AuthUserNameClientClientNameDelete**
> ApiResponse AuthUserNameClientClientNameDelete (string name, string clientName)

Remove client access from user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameClientClientNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name
            var clientName = "clientName_example";  // string | Client to remove from user

            try
            {
                // Remove client access from user
                ApiResponse result = apiInstance.AuthUserNameClientClientNameDelete(name, clientName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameClientClientNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameClientClientNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove client access from user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNameClientClientNameDeleteWithHttpInfo(name, clientName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameClientClientNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |
| **clientName** | **string** | Client to remove from user |  |

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

<a id="authusernameclientclientnamepost"></a>
# **AuthUserNameClientClientNamePost**
> ApiResponse AuthUserNameClientClientNamePost (string name, string clientName)

Add client access to user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameClientClientNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | User Name
            var clientName = "clientName_example";  // string | Client name

            try
            {
                // Add client access to user
                ApiResponse result = apiInstance.AuthUserNameClientClientNamePost(name, clientName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameClientClientNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameClientClientNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add client access to user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNameClientClientNamePostWithHttpInfo(name, clientName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameClientClientNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | User Name |  |
| **clientName** | **string** | Client name |  |

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

<a id="authusernameclientget"></a>
# **AuthUserNameClientGet**
> RefList AuthUserNameClientGet (string name)

Get the list of clients to which a user has been granted access

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name

            try
            {
                // Get the list of clients to which a user has been granted access
                RefList result = apiInstance.AuthUserNameClientGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of clients to which a user has been granted access
    ApiResponse<RefList> response = apiInstance.AuthUserNameClientGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |

### Return type

[**RefList**](RefList.md)

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

<a id="authusernamedelete"></a>
# **AuthUserNameDelete**
> ApiResponse AuthUserNameDelete (string name)

Remove a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name

            try
            {
                // Remove a user
                ApiResponse result = apiInstance.AuthUserNameDelete(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNameDeleteWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |

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

<a id="authusernameget"></a>
# **AuthUserNameGet**
> UserList AuthUserNameGet (string name, bool? getAllDetails = null)

Get information about specified user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | The user to retrieve
            var getAllDetails = true;  // bool? | Do we want to retrieve details of user tokens. (default) false will return only token names (optional) 

            try
            {
                // Get information about specified user
                UserList result = apiInstance.AuthUserNameGet(name, getAllDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about specified user
    ApiResponse<UserList> response = apiInstance.AuthUserNameGetWithHttpInfo(name, getAllDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The user to retrieve |  |
| **getAllDetails** | **bool?** | Do we want to retrieve details of user tokens. (default) false will return only token names | [optional]  |

### Return type

[**UserList**](UserList.md)

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

<a id="authusernamepermissionget"></a>
# **AuthUserNamePermissionGet**
> PermissionList AuthUserNamePermissionGet (string name)

Get the list of user permission

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNamePermissionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name

            try
            {
                // Get the list of user permission
                PermissionList result = apiInstance.AuthUserNamePermissionGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNamePermissionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNamePermissionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of user permission
    ApiResponse<PermissionList> response = apiInstance.AuthUserNamePermissionGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNamePermissionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |

### Return type

[**PermissionList**](PermissionList.md)

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

<a id="authusernamepermissionpermissiondelete"></a>
# **AuthUserNamePermissionPermissionDelete**
> ApiResponse AuthUserNamePermissionPermissionDelete (string name, string permission)

Remove permission from a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNamePermissionPermissionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name
            var permission = "permission_example";  // string | Permission to remove from user

            try
            {
                // Remove permission from a user
                ApiResponse result = apiInstance.AuthUserNamePermissionPermissionDelete(name, permission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNamePermissionPermissionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNamePermissionPermissionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove permission from a user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNamePermissionPermissionDeleteWithHttpInfo(name, permission);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNamePermissionPermissionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |
| **permission** | **string** | Permission to remove from user |  |

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

<a id="authusernamepermissionpermissionpost"></a>
# **AuthUserNamePermissionPermissionPost**
> ApiResponse AuthUserNamePermissionPermissionPost (string name, string permission)

Add permission to a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNamePermissionPermissionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | User Name
            var permission = "permission_example";  // string | Permission to add to user

            try
            {
                // Add permission to a user
                ApiResponse result = apiInstance.AuthUserNamePermissionPermissionPost(name, permission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNamePermissionPermissionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNamePermissionPermissionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add permission to a user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNamePermissionPermissionPostWithHttpInfo(name, permission);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNamePermissionPermissionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | User Name |  |
| **permission** | **string** | Permission to add to user |  |

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

<a id="authusernameroleget"></a>
# **AuthUserNameRoleGet**
> RefList AuthUserNameRoleGet (string name)

Get the list of the roles which have been assigned to a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameRoleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name

            try
            {
                // Get the list of the roles which have been assigned to a user
                RefList result = apiInstance.AuthUserNameRoleGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameRoleGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameRoleGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of the roles which have been assigned to a user
    ApiResponse<RefList> response = apiInstance.AuthUserNameRoleGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameRoleGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |

### Return type

[**RefList**](RefList.md)

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

<a id="authusernamerolerolenamedelete"></a>
# **AuthUserNameRoleRoleNameDelete**
> ApiResponse AuthUserNameRoleRoleNameDelete (string name, string roleName)

Remove role from a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameRoleRoleNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name
            var roleName = "roleName_example";  // string | Role to remove from user

            try
            {
                // Remove role from a user
                ApiResponse result = apiInstance.AuthUserNameRoleRoleNameDelete(name, roleName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameRoleRoleNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameRoleRoleNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove role from a user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNameRoleRoleNameDeleteWithHttpInfo(name, roleName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameRoleRoleNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |
| **roleName** | **string** | Role to remove from user |  |

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

<a id="authusernamerolerolenamepost"></a>
# **AuthUserNameRoleRoleNamePost**
> ApiResponse AuthUserNameRoleRoleNamePost (string name, string roleName)

Assign role to user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameRoleRoleNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name
            var roleName = "roleName_example";  // string | Role to add

            try
            {
                // Assign role to user
                ApiResponse result = apiInstance.AuthUserNameRoleRoleNamePost(name, roleName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameRoleRoleNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameRoleRoleNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign role to user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNameRoleRoleNamePostWithHttpInfo(name, roleName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameRoleRoleNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |
| **roleName** | **string** | Role to add |  |

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

<a id="authusernametokentokennamedelete"></a>
# **AuthUserNameTokenTokenNameDelete**
> ApiResponse AuthUserNameTokenTokenNameDelete (string name, string tokenName)

Remove static access token from user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameTokenTokenNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | user Name
            var tokenName = "tokenName_example";  // string | Descriptive name for the token

            try
            {
                // Remove static access token from user
                ApiResponse result = apiInstance.AuthUserNameTokenTokenNameDelete(name, tokenName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameTokenTokenNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameTokenTokenNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove static access token from user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNameTokenTokenNameDeleteWithHttpInfo(name, tokenName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameTokenTokenNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | user Name |  |
| **tokenName** | **string** | Descriptive name for the token |  |

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

<a id="authusernametokentokennamepost"></a>
# **AuthUserNameTokenTokenNamePost**
> ApiResponse AuthUserNameTokenTokenNamePost (string name, string tokenName)

Add static access token to user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserNameTokenTokenNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var name = "name_example";  // string | User Name
            var tokenName = "tokenName_example";  // string | Descriptive name for the token

            try
            {
                // Add static access token to user
                ApiResponse result = apiInstance.AuthUserNameTokenTokenNamePost(name, tokenName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserNameTokenTokenNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserNameTokenTokenNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add static access token to user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserNameTokenTokenNamePostWithHttpInfo(name, tokenName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserNameTokenTokenNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | User Name |  |
| **tokenName** | **string** | Descriptive name for the token |  |

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

<a id="authuserpost"></a>
# **AuthUserPost**
> ApiResponse AuthUserPost (string body)

Create a new user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JO.Api;
using Alterian.JO.Client;
using Alterian.JO.Model;

namespace Example
{
    public class AuthUserPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AuthApi(config);
            var body = {"name":"name"};  // string | A block of JSON describing the resource to create

            try
            {
                // Create a new user
                ApiResponse result = apiInstance.AuthUserPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUserPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUserPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new user
    ApiResponse<ApiResponse> response = apiInstance.AuthUserPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUserPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | A block of JSON describing the resource to create |  |

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

