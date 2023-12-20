# SonicWallGen7.Api.VpnPolicyIpv4ProvisionClientApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnPoliciesIpv4ProvisionClientGet**](VpnPolicyIpv4ProvisionClientApi.md#vpnpoliciesipv4provisionclientget) | **GET** /vpn/policies/ipv4/provision-client |  |
| [**VpnPoliciesIpv4ProvisionClientNameVPNNAMEDelete**](VpnPolicyIpv4ProvisionClientApi.md#vpnpoliciesipv4provisionclientnamevpnnamedelete) | **DELETE** /vpn/policies/ipv4/provision-client/name/{VPN_NAME} |  |
| [**VpnPoliciesIpv4ProvisionClientNameVPNNAMEGet**](VpnPolicyIpv4ProvisionClientApi.md#vpnpoliciesipv4provisionclientnamevpnnameget) | **GET** /vpn/policies/ipv4/provision-client/name/{VPN_NAME} |  |
| [**VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatch**](VpnPolicyIpv4ProvisionClientApi.md#vpnpoliciesipv4provisionclientnamevpnnamepatch) | **PATCH** /vpn/policies/ipv4/provision-client/name/{VPN_NAME} |  |
| [**VpnPoliciesIpv4ProvisionClientNameVPNNAMEPut**](VpnPolicyIpv4ProvisionClientApi.md#vpnpoliciesipv4provisionclientnamevpnnameput) | **PUT** /vpn/policies/ipv4/provision-client/name/{VPN_NAME} |  |
| [**VpnPoliciesIpv4ProvisionClientPatch**](VpnPolicyIpv4ProvisionClientApi.md#vpnpoliciesipv4provisionclientpatch) | **PATCH** /vpn/policies/ipv4/provision-client |  |
| [**VpnPoliciesIpv4ProvisionClientPost**](VpnPolicyIpv4ProvisionClientApi.md#vpnpoliciesipv4provisionclientpost) | **POST** /vpn/policies/ipv4/provision-client |  |
| [**VpnPoliciesIpv4ProvisionClientPut**](VpnPolicyIpv4ProvisionClientApi.md#vpnpoliciesipv4provisionclientput) | **PUT** /vpn/policies/ipv4/provision-client |  |

<a id="vpnpoliciesipv4provisionclientget"></a>
# **VpnPoliciesIpv4ProvisionClientGet**
> VpnPolicyIpv4ProvisionClientCollection VpnPoliciesIpv4ProvisionClientGet ()



Retrieve SonicWALL auto provisioning client VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionClientApi(config);

            try
            {
                VpnPolicyIpv4ProvisionClientCollection result = apiInstance.VpnPoliciesIpv4ProvisionClientGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4ProvisionClientCollection> response = apiInstance.VpnPoliciesIpv4ProvisionClientGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VpnPolicyIpv4ProvisionClientCollection**](VpnPolicyIpv4ProvisionClientCollection.md)

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

<a id="vpnpoliciesipv4provisionclientnamevpnnamedelete"></a>
# **VpnPoliciesIpv4ProvisionClientNameVPNNAMEDelete**
> ApiStatus VpnPoliciesIpv4ProvisionClientNameVPNNAMEDelete (string VPN_NAME)



Delete a SonicWALL auto provisioning client VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionClientNameVPNNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionClientApi(config);
            var VPN_NAME = "\"SonicWALL auto provision client Policy\"";  // string | SonicWALL auto provisioning client VPN policy name. (default to "SonicWALL auto provision client Policy")

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionClientNameVPNNAMEDelete(VPN_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientNameVPNNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionClientNameVPNNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionClientNameVPNNAMEDeleteWithHttpInfo(VPN_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientNameVPNNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPN_NAME** | **string** | SonicWALL auto provisioning client VPN policy name. | [default to &quot;SonicWALL auto provision client Policy&quot;] |

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

<a id="vpnpoliciesipv4provisionclientnamevpnnameget"></a>
# **VpnPoliciesIpv4ProvisionClientNameVPNNAMEGet**
> VpnPolicyIpv4ProvisionClientCollection VpnPoliciesIpv4ProvisionClientNameVPNNAMEGet (string VPN_NAME)



Retrieve SonicWALL auto provisioning client VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionClientNameVPNNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionClientApi(config);
            var VPN_NAME = "\"SonicWALL auto provision client Policy\"";  // string | SonicWALL auto provisioning client VPN policy name. (default to "SonicWALL auto provision client Policy")

            try
            {
                VpnPolicyIpv4ProvisionClientCollection result = apiInstance.VpnPoliciesIpv4ProvisionClientNameVPNNAMEGet(VPN_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientNameVPNNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionClientNameVPNNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4ProvisionClientCollection> response = apiInstance.VpnPoliciesIpv4ProvisionClientNameVPNNAMEGetWithHttpInfo(VPN_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientNameVPNNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPN_NAME** | **string** | SonicWALL auto provisioning client VPN policy name. | [default to &quot;SonicWALL auto provision client Policy&quot;] |

### Return type

[**VpnPolicyIpv4ProvisionClientCollection**](VpnPolicyIpv4ProvisionClientCollection.md)

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

<a id="vpnpoliciesipv4provisionclientnamevpnnamepatch"></a>
# **VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatch**
> ApiStatus VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatch (string VPN_NAME, VpnPolicyIpv4ProvisionClientCollection? vpnPolicyIpv4ProvisionClientCollection = null)



Patch SonicWALL auto provisioning client VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionClientApi(config);
            var VPN_NAME = "\"SonicWALL auto provision client Policy\"";  // string | SonicWALL auto provisioning client VPN policy name. (default to "SonicWALL auto provision client Policy")
            var vpnPolicyIpv4ProvisionClientCollection = new VpnPolicyIpv4ProvisionClientCollection?(); // VpnPolicyIpv4ProvisionClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatch(VPN_NAME, vpnPolicyIpv4ProvisionClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatchWithHttpInfo(VPN_NAME, vpnPolicyIpv4ProvisionClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientNameVPNNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPN_NAME** | **string** | SonicWALL auto provisioning client VPN policy name. | [default to &quot;SonicWALL auto provision client Policy&quot;] |
| **vpnPolicyIpv4ProvisionClientCollection** | [**VpnPolicyIpv4ProvisionClientCollection?**](VpnPolicyIpv4ProvisionClientCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4provisionclientnamevpnnameput"></a>
# **VpnPoliciesIpv4ProvisionClientNameVPNNAMEPut**
> ApiStatus VpnPoliciesIpv4ProvisionClientNameVPNNAMEPut (string VPN_NAME, VpnPolicyIpv4ProvisionClientCollection? vpnPolicyIpv4ProvisionClientCollection = null)



Edit SonicWALL auto provisioning client VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionClientNameVPNNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionClientApi(config);
            var VPN_NAME = "\"SonicWALL auto provision client Policy\"";  // string | SonicWALL auto provisioning client VPN policy name. (default to "SonicWALL auto provision client Policy")
            var vpnPolicyIpv4ProvisionClientCollection = new VpnPolicyIpv4ProvisionClientCollection?(); // VpnPolicyIpv4ProvisionClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionClientNameVPNNAMEPut(VPN_NAME, vpnPolicyIpv4ProvisionClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientNameVPNNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionClientNameVPNNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionClientNameVPNNAMEPutWithHttpInfo(VPN_NAME, vpnPolicyIpv4ProvisionClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientNameVPNNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPN_NAME** | **string** | SonicWALL auto provisioning client VPN policy name. | [default to &quot;SonicWALL auto provision client Policy&quot;] |
| **vpnPolicyIpv4ProvisionClientCollection** | [**VpnPolicyIpv4ProvisionClientCollection?**](VpnPolicyIpv4ProvisionClientCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4provisionclientpatch"></a>
# **VpnPoliciesIpv4ProvisionClientPatch**
> ApiStatus VpnPoliciesIpv4ProvisionClientPatch (VpnPolicyIpv4ProvisionClientCollection? vpnPolicyIpv4ProvisionClientCollection = null)



Patch SonicWALL auto provisioning client VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionClientPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionClientApi(config);
            var vpnPolicyIpv4ProvisionClientCollection = new VpnPolicyIpv4ProvisionClientCollection?(); // VpnPolicyIpv4ProvisionClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionClientPatch(vpnPolicyIpv4ProvisionClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionClientPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionClientPatchWithHttpInfo(vpnPolicyIpv4ProvisionClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4ProvisionClientCollection** | [**VpnPolicyIpv4ProvisionClientCollection?**](VpnPolicyIpv4ProvisionClientCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4provisionclientpost"></a>
# **VpnPoliciesIpv4ProvisionClientPost**
> ApiStatus VpnPoliciesIpv4ProvisionClientPost (VpnPolicyIpv4ProvisionClientCollection? vpnPolicyIpv4ProvisionClientCollection = null)



Create a new SonicWALL auto provisioning client VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionClientPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionClientApi(config);
            var vpnPolicyIpv4ProvisionClientCollection = new VpnPolicyIpv4ProvisionClientCollection?(); // VpnPolicyIpv4ProvisionClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionClientPost(vpnPolicyIpv4ProvisionClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionClientPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionClientPostWithHttpInfo(vpnPolicyIpv4ProvisionClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4ProvisionClientCollection** | [**VpnPolicyIpv4ProvisionClientCollection?**](VpnPolicyIpv4ProvisionClientCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4provisionclientput"></a>
# **VpnPoliciesIpv4ProvisionClientPut**
> ApiStatus VpnPoliciesIpv4ProvisionClientPut (VpnPolicyIpv4ProvisionClientCollection? vpnPolicyIpv4ProvisionClientCollection = null)



Edit SonicWALL auto provisioning client VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionClientPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionClientApi(config);
            var vpnPolicyIpv4ProvisionClientCollection = new VpnPolicyIpv4ProvisionClientCollection?(); // VpnPolicyIpv4ProvisionClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionClientPut(vpnPolicyIpv4ProvisionClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionClientPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionClientPutWithHttpInfo(vpnPolicyIpv4ProvisionClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionClientApi.VpnPoliciesIpv4ProvisionClientPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4ProvisionClientCollection** | [**VpnPolicyIpv4ProvisionClientCollection?**](VpnPolicyIpv4ProvisionClientCollection?.md) |  | [optional]  |

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

