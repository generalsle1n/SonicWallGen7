# SonicWallGen7.Api.SecurityActionProfilesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecurityActionProfilesGet**](SecurityActionProfilesApi.md#securityactionprofilesget) | **GET** /security-action-profiles |  |
| [**SecurityActionProfilesNameNAMEDelete**](SecurityActionProfilesApi.md#securityactionprofilesnamenamedelete) | **DELETE** /security-action-profiles/name/{NAME} |  |
| [**SecurityActionProfilesNameNAMEGet**](SecurityActionProfilesApi.md#securityactionprofilesnamenameget) | **GET** /security-action-profiles/name/{NAME} |  |
| [**SecurityActionProfilesNameNAMEPatch**](SecurityActionProfilesApi.md#securityactionprofilesnamenamepatch) | **PATCH** /security-action-profiles/name/{NAME} |  |
| [**SecurityActionProfilesNameNAMEPut**](SecurityActionProfilesApi.md#securityactionprofilesnamenameput) | **PUT** /security-action-profiles/name/{NAME} |  |
| [**SecurityActionProfilesPatch**](SecurityActionProfilesApi.md#securityactionprofilespatch) | **PATCH** /security-action-profiles |  |
| [**SecurityActionProfilesPost**](SecurityActionProfilesApi.md#securityactionprofilespost) | **POST** /security-action-profiles |  |
| [**SecurityActionProfilesPut**](SecurityActionProfilesApi.md#securityactionprofilesput) | **PUT** /security-action-profiles |  |
| [**SecurityActionProfilesUuidUUIDDelete**](SecurityActionProfilesApi.md#securityactionprofilesuuiduuiddelete) | **DELETE** /security-action-profiles/uuid/{UUID} |  |
| [**SecurityActionProfilesUuidUUIDGet**](SecurityActionProfilesApi.md#securityactionprofilesuuiduuidget) | **GET** /security-action-profiles/uuid/{UUID} |  |
| [**SecurityActionProfilesUuidUUIDPatch**](SecurityActionProfilesApi.md#securityactionprofilesuuiduuidpatch) | **PATCH** /security-action-profiles/uuid/{UUID} |  |
| [**SecurityActionProfilesUuidUUIDPut**](SecurityActionProfilesApi.md#securityactionprofilesuuiduuidput) | **PUT** /security-action-profiles/uuid/{UUID} |  |

<a id="securityactionprofilesget"></a>
# **SecurityActionProfilesGet**
> SecurityActionProfilesCollection SecurityActionProfilesGet ()



Retrieve a security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);

            try
            {
                SecurityActionProfilesCollection result = apiInstance.SecurityActionProfilesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecurityActionProfilesCollection> response = apiInstance.SecurityActionProfilesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SecurityActionProfilesCollection**](SecurityActionProfilesCollection.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesnamenamedelete"></a>
# **SecurityActionProfilesNameNAMEDelete**
> ApiStatus SecurityActionProfilesNameNAMEDelete (string NAME)



Delete a security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var NAME = "\"MySecurityActionProfile\"";  // string | Security action profile name. (default to "MySecurityActionProfile")

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Security action profile name. | [default to &quot;MySecurityActionProfile&quot;] |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesnamenameget"></a>
# **SecurityActionProfilesNameNAMEGet**
> SecurityActionProfilesCollection SecurityActionProfilesNameNAMEGet (string NAME)



Retrieve a security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var NAME = "\"MySecurityActionProfile\"";  // string | Security action profile name. (default to "MySecurityActionProfile")

            try
            {
                SecurityActionProfilesCollection result = apiInstance.SecurityActionProfilesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecurityActionProfilesCollection> response = apiInstance.SecurityActionProfilesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Security action profile name. | [default to &quot;MySecurityActionProfile&quot;] |

### Return type

[**SecurityActionProfilesCollection**](SecurityActionProfilesCollection.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesnamenamepatch"></a>
# **SecurityActionProfilesNameNAMEPatch**
> ApiStatus SecurityActionProfilesNameNAMEPatch (string NAME, SecurityActionProfilesCollection? securityActionProfilesCollection = null)



Patch an existing security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var NAME = "\"MySecurityActionProfile\"";  // string | Security action profile name. (default to "MySecurityActionProfile")
            var securityActionProfilesCollection = new SecurityActionProfilesCollection?(); // SecurityActionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesNameNAMEPatch(NAME, securityActionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesNameNAMEPatchWithHttpInfo(NAME, securityActionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Security action profile name. | [default to &quot;MySecurityActionProfile&quot;] |
| **securityActionProfilesCollection** | [**SecurityActionProfilesCollection?**](SecurityActionProfilesCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesnamenameput"></a>
# **SecurityActionProfilesNameNAMEPut**
> ApiStatus SecurityActionProfilesNameNAMEPut (string NAME, SecurityActionProfilesCollection? securityActionProfilesCollection = null)



Edit an existing security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var NAME = "\"MySecurityActionProfile\"";  // string | Security action profile name. (default to "MySecurityActionProfile")
            var securityActionProfilesCollection = new SecurityActionProfilesCollection?(); // SecurityActionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesNameNAMEPut(NAME, securityActionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesNameNAMEPutWithHttpInfo(NAME, securityActionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Security action profile name. | [default to &quot;MySecurityActionProfile&quot;] |
| **securityActionProfilesCollection** | [**SecurityActionProfilesCollection?**](SecurityActionProfilesCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilespatch"></a>
# **SecurityActionProfilesPatch**
> ApiStatus SecurityActionProfilesPatch (SecurityActionProfilesCollection? securityActionProfilesCollection = null)



Patch an existing security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var securityActionProfilesCollection = new SecurityActionProfilesCollection?(); // SecurityActionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesPatch(securityActionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesPatchWithHttpInfo(securityActionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityActionProfilesCollection** | [**SecurityActionProfilesCollection?**](SecurityActionProfilesCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilespost"></a>
# **SecurityActionProfilesPost**
> ApiStatus SecurityActionProfilesPost (SecurityActionProfilesCollection? securityActionProfilesCollection = null)



Create a new security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var securityActionProfilesCollection = new SecurityActionProfilesCollection?(); // SecurityActionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesPost(securityActionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesPostWithHttpInfo(securityActionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityActionProfilesCollection** | [**SecurityActionProfilesCollection?**](SecurityActionProfilesCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesput"></a>
# **SecurityActionProfilesPut**
> ApiStatus SecurityActionProfilesPut (SecurityActionProfilesCollection? securityActionProfilesCollection = null)



Edit an existing security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var securityActionProfilesCollection = new SecurityActionProfilesCollection?(); // SecurityActionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesPut(securityActionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesPutWithHttpInfo(securityActionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityActionProfilesCollection** | [**SecurityActionProfilesCollection?**](SecurityActionProfilesCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesuuiduuiddelete"></a>
# **SecurityActionProfilesUuidUUIDDelete**
> ApiStatus SecurityActionProfilesUuidUUIDDelete (string UUID)



Delete a security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesUuidUUIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesuuiduuidget"></a>
# **SecurityActionProfilesUuidUUIDGet**
> SecurityActionProfilesCollection SecurityActionProfilesUuidUUIDGet (string UUID)



Retrieve a security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                SecurityActionProfilesCollection result = apiInstance.SecurityActionProfilesUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecurityActionProfilesCollection> response = apiInstance.SecurityActionProfilesUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**SecurityActionProfilesCollection**](SecurityActionProfilesCollection.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesuuiduuidpatch"></a>
# **SecurityActionProfilesUuidUUIDPatch**
> ApiStatus SecurityActionProfilesUuidUUIDPatch (string UUID, SecurityActionProfilesCollection? securityActionProfilesCollection = null)



Patch an existing security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesUuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var securityActionProfilesCollection = new SecurityActionProfilesCollection?(); // SecurityActionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesUuidUUIDPatch(UUID, securityActionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesUuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesUuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesUuidUUIDPatchWithHttpInfo(UUID, securityActionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesUuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **securityActionProfilesCollection** | [**SecurityActionProfilesCollection?**](SecurityActionProfilesCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securityactionprofilesuuiduuidput"></a>
# **SecurityActionProfilesUuidUUIDPut**
> ApiStatus SecurityActionProfilesUuidUUIDPut (string UUID, SecurityActionProfilesCollection? securityActionProfilesCollection = null)



Edit an existing security action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityActionProfilesUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfilesApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var securityActionProfilesCollection = new SecurityActionProfilesCollection?(); // SecurityActionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityActionProfilesUuidUUIDPut(UUID, securityActionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityActionProfilesUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityActionProfilesUuidUUIDPutWithHttpInfo(UUID, securityActionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfilesApi.SecurityActionProfilesUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **securityActionProfilesCollection** | [**SecurityActionProfilesCollection?**](SecurityActionProfilesCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

