# SonicWallGen7.Api.VpnPolicyIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnPoliciesIpv6SiteToSiteGet**](VpnPolicyIpv6Api.md#vpnpoliciesipv6sitetositeget) | **GET** /vpn/policies/ipv6/site-to-site |  |
| [**VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDelete**](VpnPolicyIpv6Api.md#vpnpoliciesipv6sitetositenameipv6sitetositenamedelete) | **DELETE** /vpn/policies/ipv6/site-to-site/name/{IPV6_SITE_TO_SITE_NAME} |  |
| [**VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGet**](VpnPolicyIpv6Api.md#vpnpoliciesipv6sitetositenameipv6sitetositenameget) | **GET** /vpn/policies/ipv6/site-to-site/name/{IPV6_SITE_TO_SITE_NAME} |  |
| [**VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatch**](VpnPolicyIpv6Api.md#vpnpoliciesipv6sitetositenameipv6sitetositenamepatch) | **PATCH** /vpn/policies/ipv6/site-to-site/name/{IPV6_SITE_TO_SITE_NAME} |  |
| [**VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPut**](VpnPolicyIpv6Api.md#vpnpoliciesipv6sitetositenameipv6sitetositenameput) | **PUT** /vpn/policies/ipv6/site-to-site/name/{IPV6_SITE_TO_SITE_NAME} |  |
| [**VpnPoliciesIpv6SiteToSitePatch**](VpnPolicyIpv6Api.md#vpnpoliciesipv6sitetositepatch) | **PATCH** /vpn/policies/ipv6/site-to-site |  |
| [**VpnPoliciesIpv6SiteToSitePost**](VpnPolicyIpv6Api.md#vpnpoliciesipv6sitetositepost) | **POST** /vpn/policies/ipv6/site-to-site |  |
| [**VpnPoliciesIpv6SiteToSitePut**](VpnPolicyIpv6Api.md#vpnpoliciesipv6sitetositeput) | **PUT** /vpn/policies/ipv6/site-to-site |  |

<a id="vpnpoliciesipv6sitetositeget"></a>
# **VpnPoliciesIpv6SiteToSiteGet**
> VpnPolicyIpv6Collection VpnPoliciesIpv6SiteToSiteGet ()



Retrieve IPv6 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv6SiteToSiteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv6Api(config);

            try
            {
                VpnPolicyIpv6Collection result = apiInstance.VpnPoliciesIpv6SiteToSiteGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv6SiteToSiteGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv6Collection> response = apiInstance.VpnPoliciesIpv6SiteToSiteGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VpnPolicyIpv6Collection**](VpnPolicyIpv6Collection.md)

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

<a id="vpnpoliciesipv6sitetositenameipv6sitetositenamedelete"></a>
# **VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDelete**
> ApiStatus VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDelete (string iPV6SITETOSITENAME)



Delete an IPv6 site-to-site VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv6Api(config);
            var iPV6SITETOSITENAME = "\"Remote Office\"";  // string | IPv6 Site-to-site VPN policy name. (default to "Remote Office")

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDelete(iPV6SITETOSITENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDeleteWithHttpInfo(iPV6SITETOSITENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iPV6SITETOSITENAME** | **string** | IPv6 Site-to-site VPN policy name. | [default to &quot;Remote Office&quot;] |

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

<a id="vpnpoliciesipv6sitetositenameipv6sitetositenameget"></a>
# **VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGet**
> VpnPolicyIpv6Collection VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGet (string iPV6SITETOSITENAME)



Retrieve IPv6 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv6Api(config);
            var iPV6SITETOSITENAME = "\"Remote Office\"";  // string | IPv6 Site-to-site VPN policy name. (default to "Remote Office")

            try
            {
                VpnPolicyIpv6Collection result = apiInstance.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGet(iPV6SITETOSITENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv6Collection> response = apiInstance.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGetWithHttpInfo(iPV6SITETOSITENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iPV6SITETOSITENAME** | **string** | IPv6 Site-to-site VPN policy name. | [default to &quot;Remote Office&quot;] |

### Return type

[**VpnPolicyIpv6Collection**](VpnPolicyIpv6Collection.md)

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

<a id="vpnpoliciesipv6sitetositenameipv6sitetositenamepatch"></a>
# **VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatch**
> ApiStatus VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatch (string iPV6SITETOSITENAME, VpnPolicyIpv6Collection? vpnPolicyIpv6Collection = null)



Patch an IPv6 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv6Api(config);
            var iPV6SITETOSITENAME = "\"Remote Office\"";  // string | IPv6 Site-to-site VPN policy name. (default to "Remote Office")
            var vpnPolicyIpv6Collection = new VpnPolicyIpv6Collection?(); // VpnPolicyIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatch(iPV6SITETOSITENAME, vpnPolicyIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatchWithHttpInfo(iPV6SITETOSITENAME, vpnPolicyIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iPV6SITETOSITENAME** | **string** | IPv6 Site-to-site VPN policy name. | [default to &quot;Remote Office&quot;] |
| **vpnPolicyIpv6Collection** | [**VpnPolicyIpv6Collection?**](VpnPolicyIpv6Collection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv6sitetositenameipv6sitetositenameput"></a>
# **VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPut**
> ApiStatus VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPut (string iPV6SITETOSITENAME, VpnPolicyIpv6Collection? vpnPolicyIpv6Collection = null)



Edit an IPv6 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv6Api(config);
            var iPV6SITETOSITENAME = "\"Remote Office\"";  // string | IPv6 Site-to-site VPN policy name. (default to "Remote Office")
            var vpnPolicyIpv6Collection = new VpnPolicyIpv6Collection?(); // VpnPolicyIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPut(iPV6SITETOSITENAME, vpnPolicyIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPutWithHttpInfo(iPV6SITETOSITENAME, vpnPolicyIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSiteNameIPV6SITETOSITENAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iPV6SITETOSITENAME** | **string** | IPv6 Site-to-site VPN policy name. | [default to &quot;Remote Office&quot;] |
| **vpnPolicyIpv6Collection** | [**VpnPolicyIpv6Collection?**](VpnPolicyIpv6Collection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv6sitetositepatch"></a>
# **VpnPoliciesIpv6SiteToSitePatch**
> ApiStatus VpnPoliciesIpv6SiteToSitePatch (VpnPolicyIpv6Collection? vpnPolicyIpv6Collection = null)



Patch an IPv6 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv6SiteToSitePatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv6Api(config);
            var vpnPolicyIpv6Collection = new VpnPolicyIpv6Collection?(); // VpnPolicyIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv6SiteToSitePatch(vpnPolicyIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSitePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv6SiteToSitePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv6SiteToSitePatchWithHttpInfo(vpnPolicyIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSitePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv6Collection** | [**VpnPolicyIpv6Collection?**](VpnPolicyIpv6Collection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv6sitetositepost"></a>
# **VpnPoliciesIpv6SiteToSitePost**
> ApiStatus VpnPoliciesIpv6SiteToSitePost (VpnPolicyIpv6Collection? vpnPolicyIpv6Collection = null)



Create a new IPv6 site-to-site VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv6SiteToSitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv6Api(config);
            var vpnPolicyIpv6Collection = new VpnPolicyIpv6Collection?(); // VpnPolicyIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv6SiteToSitePost(vpnPolicyIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv6SiteToSitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv6SiteToSitePostWithHttpInfo(vpnPolicyIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv6Collection** | [**VpnPolicyIpv6Collection?**](VpnPolicyIpv6Collection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv6sitetositeput"></a>
# **VpnPoliciesIpv6SiteToSitePut**
> ApiStatus VpnPoliciesIpv6SiteToSitePut (VpnPolicyIpv6Collection? vpnPolicyIpv6Collection = null)



Edit an IPv6 site-to-site VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv6SiteToSitePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv6Api(config);
            var vpnPolicyIpv6Collection = new VpnPolicyIpv6Collection?(); // VpnPolicyIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv6SiteToSitePut(vpnPolicyIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSitePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv6SiteToSitePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv6SiteToSitePutWithHttpInfo(vpnPolicyIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv6Api.VpnPoliciesIpv6SiteToSitePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv6Collection** | [**VpnPolicyIpv6Collection?**](VpnPolicyIpv6Collection?.md) |  | [optional]  |

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

