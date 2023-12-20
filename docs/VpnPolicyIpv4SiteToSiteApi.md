# SonicWallGen7.Api.VpnPolicyIpv4SiteToSiteApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnPoliciesIpv4SiteToSiteGet**](VpnPolicyIpv4SiteToSiteApi.md#vpnpoliciesipv4sitetositeget) | **GET** /vpn/policies/ipv4/site-to-site |  |
| [**VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDelete**](VpnPolicyIpv4SiteToSiteApi.md#vpnpoliciesipv4sitetositenamesitetositenamedelete) | **DELETE** /vpn/policies/ipv4/site-to-site/name/{SITE_TO_SITE_NAME} |  |
| [**VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGet**](VpnPolicyIpv4SiteToSiteApi.md#vpnpoliciesipv4sitetositenamesitetositenameget) | **GET** /vpn/policies/ipv4/site-to-site/name/{SITE_TO_SITE_NAME} |  |
| [**VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatch**](VpnPolicyIpv4SiteToSiteApi.md#vpnpoliciesipv4sitetositenamesitetositenamepatch) | **PATCH** /vpn/policies/ipv4/site-to-site/name/{SITE_TO_SITE_NAME} |  |
| [**VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPut**](VpnPolicyIpv4SiteToSiteApi.md#vpnpoliciesipv4sitetositenamesitetositenameput) | **PUT** /vpn/policies/ipv4/site-to-site/name/{SITE_TO_SITE_NAME} |  |
| [**VpnPoliciesIpv4SiteToSitePatch**](VpnPolicyIpv4SiteToSiteApi.md#vpnpoliciesipv4sitetositepatch) | **PATCH** /vpn/policies/ipv4/site-to-site |  |
| [**VpnPoliciesIpv4SiteToSitePost**](VpnPolicyIpv4SiteToSiteApi.md#vpnpoliciesipv4sitetositepost) | **POST** /vpn/policies/ipv4/site-to-site |  |
| [**VpnPoliciesIpv4SiteToSitePut**](VpnPolicyIpv4SiteToSiteApi.md#vpnpoliciesipv4sitetositeput) | **PUT** /vpn/policies/ipv4/site-to-site |  |

<a id="vpnpoliciesipv4sitetositeget"></a>
# **VpnPoliciesIpv4SiteToSiteGet**
> VpnPolicyIpv4SiteToSiteCollection VpnPoliciesIpv4SiteToSiteGet ()



Retrieve IPv4 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4SiteToSiteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4SiteToSiteApi(config);

            try
            {
                VpnPolicyIpv4SiteToSiteCollection result = apiInstance.VpnPoliciesIpv4SiteToSiteGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4SiteToSiteGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4SiteToSiteCollection> response = apiInstance.VpnPoliciesIpv4SiteToSiteGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VpnPolicyIpv4SiteToSiteCollection**](VpnPolicyIpv4SiteToSiteCollection.md)

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

<a id="vpnpoliciesipv4sitetositenamesitetositenamedelete"></a>
# **VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDelete**
> ApiStatus VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDelete (string SITE_TO_SITE_NAME)



Delete a IPv4 site-to-site VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4SiteToSiteApi(config);
            var SITE_TO_SITE_NAME = "\"Remote Office\"";  // string | Site-to-site VPN policy name. (default to "Remote Office")

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDelete(SITE_TO_SITE_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDeleteWithHttpInfo(SITE_TO_SITE_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SITE_TO_SITE_NAME** | **string** | Site-to-site VPN policy name. | [default to &quot;Remote Office&quot;] |

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

<a id="vpnpoliciesipv4sitetositenamesitetositenameget"></a>
# **VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGet**
> VpnPolicyIpv4SiteToSiteCollection VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGet (string SITE_TO_SITE_NAME)



Retrieve IPv4 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4SiteToSiteApi(config);
            var SITE_TO_SITE_NAME = "\"Remote Office\"";  // string | Site-to-site VPN policy name. (default to "Remote Office")

            try
            {
                VpnPolicyIpv4SiteToSiteCollection result = apiInstance.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGet(SITE_TO_SITE_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4SiteToSiteCollection> response = apiInstance.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGetWithHttpInfo(SITE_TO_SITE_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SITE_TO_SITE_NAME** | **string** | Site-to-site VPN policy name. | [default to &quot;Remote Office&quot;] |

### Return type

[**VpnPolicyIpv4SiteToSiteCollection**](VpnPolicyIpv4SiteToSiteCollection.md)

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

<a id="vpnpoliciesipv4sitetositenamesitetositenamepatch"></a>
# **VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatch**
> ApiStatus VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatch (string SITE_TO_SITE_NAME, VpnPolicyIpv4SiteToSiteCollection? vpnPolicyIpv4SiteToSiteCollection = null)



Patch IPv4 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4SiteToSiteApi(config);
            var SITE_TO_SITE_NAME = "\"Remote Office\"";  // string | Site-to-site VPN policy name. (default to "Remote Office")
            var vpnPolicyIpv4SiteToSiteCollection = new VpnPolicyIpv4SiteToSiteCollection?(); // VpnPolicyIpv4SiteToSiteCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatch(SITE_TO_SITE_NAME, vpnPolicyIpv4SiteToSiteCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatchWithHttpInfo(SITE_TO_SITE_NAME, vpnPolicyIpv4SiteToSiteCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SITE_TO_SITE_NAME** | **string** | Site-to-site VPN policy name. | [default to &quot;Remote Office&quot;] |
| **vpnPolicyIpv4SiteToSiteCollection** | [**VpnPolicyIpv4SiteToSiteCollection?**](VpnPolicyIpv4SiteToSiteCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4sitetositenamesitetositenameput"></a>
# **VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPut**
> ApiStatus VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPut (string SITE_TO_SITE_NAME, VpnPolicyIpv4SiteToSiteCollection? vpnPolicyIpv4SiteToSiteCollection = null)



Edit IPv4 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4SiteToSiteApi(config);
            var SITE_TO_SITE_NAME = "\"Remote Office\"";  // string | Site-to-site VPN policy name. (default to "Remote Office")
            var vpnPolicyIpv4SiteToSiteCollection = new VpnPolicyIpv4SiteToSiteCollection?(); // VpnPolicyIpv4SiteToSiteCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPut(SITE_TO_SITE_NAME, vpnPolicyIpv4SiteToSiteCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPutWithHttpInfo(SITE_TO_SITE_NAME, vpnPolicyIpv4SiteToSiteCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSiteNameSITETOSITENAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SITE_TO_SITE_NAME** | **string** | Site-to-site VPN policy name. | [default to &quot;Remote Office&quot;] |
| **vpnPolicyIpv4SiteToSiteCollection** | [**VpnPolicyIpv4SiteToSiteCollection?**](VpnPolicyIpv4SiteToSiteCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4sitetositepatch"></a>
# **VpnPoliciesIpv4SiteToSitePatch**
> ApiStatus VpnPoliciesIpv4SiteToSitePatch (VpnPolicyIpv4SiteToSiteCollection? vpnPolicyIpv4SiteToSiteCollection = null)



Patch IPv4 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4SiteToSitePatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4SiteToSiteApi(config);
            var vpnPolicyIpv4SiteToSiteCollection = new VpnPolicyIpv4SiteToSiteCollection?(); // VpnPolicyIpv4SiteToSiteCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4SiteToSitePatch(vpnPolicyIpv4SiteToSiteCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSitePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4SiteToSitePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4SiteToSitePatchWithHttpInfo(vpnPolicyIpv4SiteToSiteCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSitePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4SiteToSiteCollection** | [**VpnPolicyIpv4SiteToSiteCollection?**](VpnPolicyIpv4SiteToSiteCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4sitetositepost"></a>
# **VpnPoliciesIpv4SiteToSitePost**
> ApiStatus VpnPoliciesIpv4SiteToSitePost (VpnPolicyIpv4SiteToSiteCollection? vpnPolicyIpv4SiteToSiteCollection = null)



Create a new   IPv4 site-to-site VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4SiteToSitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4SiteToSiteApi(config);
            var vpnPolicyIpv4SiteToSiteCollection = new VpnPolicyIpv4SiteToSiteCollection?(); // VpnPolicyIpv4SiteToSiteCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4SiteToSitePost(vpnPolicyIpv4SiteToSiteCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4SiteToSitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4SiteToSitePostWithHttpInfo(vpnPolicyIpv4SiteToSiteCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4SiteToSiteCollection** | [**VpnPolicyIpv4SiteToSiteCollection?**](VpnPolicyIpv4SiteToSiteCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4sitetositeput"></a>
# **VpnPoliciesIpv4SiteToSitePut**
> ApiStatus VpnPoliciesIpv4SiteToSitePut (VpnPolicyIpv4SiteToSiteCollection? vpnPolicyIpv4SiteToSiteCollection = null)



Edit IPv4 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4SiteToSitePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4SiteToSiteApi(config);
            var vpnPolicyIpv4SiteToSiteCollection = new VpnPolicyIpv4SiteToSiteCollection?(); // VpnPolicyIpv4SiteToSiteCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4SiteToSitePut(vpnPolicyIpv4SiteToSiteCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSitePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4SiteToSitePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4SiteToSitePutWithHttpInfo(vpnPolicyIpv4SiteToSiteCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4SiteToSiteApi.VpnPoliciesIpv4SiteToSitePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4SiteToSiteCollection** | [**VpnPolicyIpv4SiteToSiteCollection?**](VpnPolicyIpv4SiteToSiteCollection?.md) |  | [optional]  |

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

