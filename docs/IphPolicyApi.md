# SonicWallGen7.Api.IphPolicyApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IpHelperPoliciesGet**](IphPolicyApi.md#iphelperpoliciesget) | **GET** /ip-helper/policies |  |
| [**IpHelperPoliciesPatch**](IphPolicyApi.md#iphelperpoliciespatch) | **PATCH** /ip-helper/policies |  |
| [**IpHelperPoliciesPost**](IphPolicyApi.md#iphelperpoliciespost) | **POST** /ip-helper/policies |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceDelete**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcedelete) | **DELETE** /ip-helper/policies/protocol/{PROTOCOL}/source |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceGet**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourceget) | **GET** /ip-helper/policies/protocol/{PROTOCOL}/source |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDelete**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcegroupgroupnamedelete) | **DELETE** /ip-helper/policies/protocol/{PROTOCOL}/source/group/{GROUPNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGet**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcegroupgroupnameget) | **GET** /ip-helper/policies/protocol/{PROTOCOL}/source/group/{GROUPNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatch**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcegroupgroupnamepatch) | **PATCH** /ip-helper/policies/protocol/{PROTOCOL}/source/group/{GROUPNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPut**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcegroupgroupnameput) | **PUT** /ip-helper/policies/protocol/{PROTOCOL}/source/group/{GROUPNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDelete**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourceinterfaceifnamedelete) | **DELETE** /ip-helper/policies/protocol/{PROTOCOL}/source/interface/{IFNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGet**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourceinterfaceifnameget) | **GET** /ip-helper/policies/protocol/{PROTOCOL}/source/interface/{IFNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatch**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourceinterfaceifnamepatch) | **PATCH** /ip-helper/policies/protocol/{PROTOCOL}/source/interface/{IFNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPut**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourceinterfaceifnameput) | **PUT** /ip-helper/policies/protocol/{PROTOCOL}/source/interface/{IFNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDelete**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcenamenetworknamedelete) | **DELETE** /ip-helper/policies/protocol/{PROTOCOL}/source/name/{NETWORKNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGet**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcenamenetworknameget) | **GET** /ip-helper/policies/protocol/{PROTOCOL}/source/name/{NETWORKNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatch**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcenamenetworknamepatch) | **PATCH** /ip-helper/policies/protocol/{PROTOCOL}/source/name/{NETWORKNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPut**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcenamenetworknameput) | **PUT** /ip-helper/policies/protocol/{PROTOCOL}/source/name/{NETWORKNAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourcePatch**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcepatch) | **PATCH** /ip-helper/policies/protocol/{PROTOCOL}/source |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourcePut**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourceput) | **PUT** /ip-helper/policies/protocol/{PROTOCOL}/source |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDelete**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcezonezonenamedelete) | **DELETE** /ip-helper/policies/protocol/{PROTOCOL}/source/zone/{ZONENAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGet**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcezonezonenameget) | **GET** /ip-helper/policies/protocol/{PROTOCOL}/source/zone/{ZONENAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatch**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcezonezonenamepatch) | **PATCH** /ip-helper/policies/protocol/{PROTOCOL}/source/zone/{ZONENAME} |  |
| [**IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPut**](IphPolicyApi.md#iphelperpoliciesprotocolprotocolsourcezonezonenameput) | **PUT** /ip-helper/policies/protocol/{PROTOCOL}/source/zone/{ZONENAME} |  |
| [**IpHelperPoliciesPut**](IphPolicyApi.md#iphelperpoliciesput) | **PUT** /ip-helper/policies |  |

<a id="iphelperpoliciesget"></a>
# **IpHelperPoliciesGet**
> IphPolicyCollection IpHelperPoliciesGet ()



Retrieve IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);

            try
            {
                IphPolicyCollection result = apiInstance.IpHelperPoliciesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IphPolicyCollection> response = apiInstance.IpHelperPoliciesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**IphPolicyCollection**](IphPolicyCollection.md)

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

<a id="iphelperpoliciespatch"></a>
# **IpHelperPoliciesPatch**
> ApiStatus IpHelperPoliciesPatch (IphPolicyCollection? iphPolicyCollection = null)



Patch IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesPatch(iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesPatchWithHttpInfo(iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciespost"></a>
# **IpHelperPoliciesPost**
> ApiStatus IpHelperPoliciesPost (IphPolicyCollection? iphPolicyCollection = null)



Create a new IP helper policy object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesPost(iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesPostWithHttpInfo(iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourcedelete"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceDelete**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceDelete (string PROTOCOL)



DELETE IP helper policy objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceDelete(PROTOCOL);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceDeleteWithHttpInfo(PROTOCOL);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |

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

<a id="iphelperpoliciesprotocolprotocolsourceget"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceGet**
> IphPolicyCollection IpHelperPoliciesProtocolPROTOCOLSourceGet (string PROTOCOL)



Retrieve IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")

            try
            {
                IphPolicyCollection result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGet(PROTOCOL);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IphPolicyCollection> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGetWithHttpInfo(PROTOCOL);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |

### Return type

[**IphPolicyCollection**](IphPolicyCollection.md)

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

<a id="iphelperpoliciesprotocolprotocolsourcegroupgroupnamedelete"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDelete**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDelete (string PROTOCOL, string GROUPNAME)



DELETE IP helper policy objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var GROUPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDelete(PROTOCOL, GROUPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDeleteWithHttpInfo(PROTOCOL, GROUPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **GROUPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |

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

<a id="iphelperpoliciesprotocolprotocolsourcegroupgroupnameget"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGet**
> IphPolicyCollection IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGet (string PROTOCOL, string GROUPNAME)



Retrieve IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var GROUPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")

            try
            {
                IphPolicyCollection result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGet(PROTOCOL, GROUPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IphPolicyCollection> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGetWithHttpInfo(PROTOCOL, GROUPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **GROUPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |

### Return type

[**IphPolicyCollection**](IphPolicyCollection.md)

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

<a id="iphelperpoliciesprotocolprotocolsourcegroupgroupnamepatch"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatch**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatch (string PROTOCOL, string GROUPNAME, IphPolicyCollection? iphPolicyCollection = null)



Patch IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var GROUPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatch(PROTOCOL, GROUPNAME, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatchWithHttpInfo(PROTOCOL, GROUPNAME, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **GROUPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourcegroupgroupnameput"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPut**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPut (string PROTOCOL, string GROUPNAME, IphPolicyCollection? iphPolicyCollection = null)



Update IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var GROUPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPut(PROTOCOL, GROUPNAME, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPutWithHttpInfo(PROTOCOL, GROUPNAME, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceGroupGROUPNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **GROUPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourceinterfaceifnamedelete"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDelete**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDelete (string PROTOCOL, string IFNAME)



DELETE IP helper policy objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var IFNAME = "\"X1\"";  // string | IP helper interface name. (default to "X1")

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDelete(PROTOCOL, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDeleteWithHttpInfo(PROTOCOL, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **IFNAME** | **string** | IP helper interface name. | [default to &quot;X1&quot;] |

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

<a id="iphelperpoliciesprotocolprotocolsourceinterfaceifnameget"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGet**
> IphPolicyCollection IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGet (string PROTOCOL, string IFNAME)



Retrieve IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var IFNAME = "\"X1\"";  // string | IP helper interface name. (default to "X1")

            try
            {
                IphPolicyCollection result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGet(PROTOCOL, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IphPolicyCollection> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGetWithHttpInfo(PROTOCOL, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **IFNAME** | **string** | IP helper interface name. | [default to &quot;X1&quot;] |

### Return type

[**IphPolicyCollection**](IphPolicyCollection.md)

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

<a id="iphelperpoliciesprotocolprotocolsourceinterfaceifnamepatch"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatch**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatch (string PROTOCOL, string IFNAME, IphPolicyCollection? iphPolicyCollection = null)



Patch IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var IFNAME = "\"X1\"";  // string | IP helper interface name. (default to "X1")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatch(PROTOCOL, IFNAME, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatchWithHttpInfo(PROTOCOL, IFNAME, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **IFNAME** | **string** | IP helper interface name. | [default to &quot;X1&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourceinterfaceifnameput"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPut**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPut (string PROTOCOL, string IFNAME, IphPolicyCollection? iphPolicyCollection = null)



Update IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var IFNAME = "\"X1\"";  // string | IP helper interface name. (default to "X1")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPut(PROTOCOL, IFNAME, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPutWithHttpInfo(PROTOCOL, IFNAME, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceInterfaceIFNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **IFNAME** | **string** | IP helper interface name. | [default to &quot;X1&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourcenamenetworknamedelete"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDelete**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDelete (string PROTOCOL, string NETWORKNAME)



DELETE IP helper policy objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var NETWORKNAME = "\"Sales Network\"";  // string | Network address object name. (default to "Sales Network")

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDelete(PROTOCOL, NETWORKNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDeleteWithHttpInfo(PROTOCOL, NETWORKNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **NETWORKNAME** | **string** | Network address object name. | [default to &quot;Sales Network&quot;] |

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

<a id="iphelperpoliciesprotocolprotocolsourcenamenetworknameget"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGet**
> IphPolicyCollection IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGet (string PROTOCOL, string NETWORKNAME)



Retrieve IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var NETWORKNAME = "\"Sales Network\"";  // string | Network address object name. (default to "Sales Network")

            try
            {
                IphPolicyCollection result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGet(PROTOCOL, NETWORKNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IphPolicyCollection> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGetWithHttpInfo(PROTOCOL, NETWORKNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **NETWORKNAME** | **string** | Network address object name. | [default to &quot;Sales Network&quot;] |

### Return type

[**IphPolicyCollection**](IphPolicyCollection.md)

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

<a id="iphelperpoliciesprotocolprotocolsourcenamenetworknamepatch"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatch**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatch (string PROTOCOL, string NETWORKNAME, IphPolicyCollection? iphPolicyCollection = null)



Patch IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var NETWORKNAME = "\"Sales Network\"";  // string | Network address object name. (default to "Sales Network")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatch(PROTOCOL, NETWORKNAME, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatchWithHttpInfo(PROTOCOL, NETWORKNAME, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **NETWORKNAME** | **string** | Network address object name. | [default to &quot;Sales Network&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourcenamenetworknameput"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPut**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPut (string PROTOCOL, string NETWORKNAME, IphPolicyCollection? iphPolicyCollection = null)



Update IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var NETWORKNAME = "\"Sales Network\"";  // string | Network address object name. (default to "Sales Network")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPut(PROTOCOL, NETWORKNAME, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPutWithHttpInfo(PROTOCOL, NETWORKNAME, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceNameNETWORKNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **NETWORKNAME** | **string** | Network address object name. | [default to &quot;Sales Network&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourcepatch"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourcePatch**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourcePatch (string PROTOCOL, IphPolicyCollection? iphPolicyCollection = null)



Patch IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourcePatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourcePatch(PROTOCOL, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourcePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourcePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourcePatchWithHttpInfo(PROTOCOL, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourcePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourceput"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourcePut**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourcePut (string PROTOCOL, IphPolicyCollection? iphPolicyCollection = null)



Update IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourcePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourcePut(PROTOCOL, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourcePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourcePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourcePutWithHttpInfo(PROTOCOL, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourcePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourcezonezonenamedelete"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDelete**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDelete (string PROTOCOL, string ZONENAME)



DELETE IP helper policy objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var ZONENAME = "\"DMZ\"";  // string | Zone object name. (default to "DMZ")

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDelete(PROTOCOL, ZONENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDeleteWithHttpInfo(PROTOCOL, ZONENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **ZONENAME** | **string** | Zone object name. | [default to &quot;DMZ&quot;] |

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

<a id="iphelperpoliciesprotocolprotocolsourcezonezonenameget"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGet**
> IphPolicyCollection IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGet (string PROTOCOL, string ZONENAME)



Retrieve IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var ZONENAME = "\"DMZ\"";  // string | Zone object name. (default to "DMZ")

            try
            {
                IphPolicyCollection result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGet(PROTOCOL, ZONENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IphPolicyCollection> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGetWithHttpInfo(PROTOCOL, ZONENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **ZONENAME** | **string** | Zone object name. | [default to &quot;DMZ&quot;] |

### Return type

[**IphPolicyCollection**](IphPolicyCollection.md)

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

<a id="iphelperpoliciesprotocolprotocolsourcezonezonenamepatch"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatch**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatch (string PROTOCOL, string ZONENAME, IphPolicyCollection? iphPolicyCollection = null)



Patch IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var ZONENAME = "\"DMZ\"";  // string | Zone object name. (default to "DMZ")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatch(PROTOCOL, ZONENAME, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatchWithHttpInfo(PROTOCOL, ZONENAME, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **ZONENAME** | **string** | Zone object name. | [default to &quot;DMZ&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesprotocolprotocolsourcezonezonenameput"></a>
# **IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPut**
> ApiStatus IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPut (string PROTOCOL, string ZONENAME, IphPolicyCollection? iphPolicyCollection = null)



Update IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var PROTOCOL = "\"mydns\"";  // string | IP Helper relay protocol name. (default to "mydns")
            var ZONENAME = "\"DMZ\"";  // string | Zone object name. (default to "DMZ")
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPut(PROTOCOL, ZONENAME, iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPutWithHttpInfo(PROTOCOL, ZONENAME, iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesProtocolPROTOCOLSourceZoneZONENAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTOCOL** | **string** | IP Helper relay protocol name. | [default to &quot;mydns&quot;] |
| **ZONENAME** | **string** | Zone object name. | [default to &quot;DMZ&quot;] |
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

<a id="iphelperpoliciesput"></a>
# **IpHelperPoliciesPut**
> ApiStatus IpHelperPoliciesPut (IphPolicyCollection? iphPolicyCollection = null)



Update IP helper policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IpHelperPoliciesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphPolicyApi(config);
            var iphPolicyCollection = new IphPolicyCollection?(); // IphPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IpHelperPoliciesPut(iphPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IpHelperPoliciesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IpHelperPoliciesPutWithHttpInfo(iphPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphPolicyApi.IpHelperPoliciesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iphPolicyCollection** | [**IphPolicyCollection?**](IphPolicyCollection?.md) |  | [optional]  |

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

