# SonicWallGen7.Api.VpnPolicyIpv4ProvisionServerApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnPoliciesIpv4ProvisionServerGet**](VpnPolicyIpv4ProvisionServerApi.md#vpnpoliciesipv4provisionserverget) | **GET** /vpn/policies/ipv4/provision-server |  |
| [**VpnPoliciesIpv4ProvisionServerNameVPNNAMEDelete**](VpnPolicyIpv4ProvisionServerApi.md#vpnpoliciesipv4provisionservernamevpnnamedelete) | **DELETE** /vpn/policies/ipv4/provision-server/name/{VPN_NAME} |  |
| [**VpnPoliciesIpv4ProvisionServerNameVPNNAMEGet**](VpnPolicyIpv4ProvisionServerApi.md#vpnpoliciesipv4provisionservernamevpnnameget) | **GET** /vpn/policies/ipv4/provision-server/name/{VPN_NAME} |  |
| [**VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatch**](VpnPolicyIpv4ProvisionServerApi.md#vpnpoliciesipv4provisionservernamevpnnamepatch) | **PATCH** /vpn/policies/ipv4/provision-server/name/{VPN_NAME} |  |
| [**VpnPoliciesIpv4ProvisionServerNameVPNNAMEPut**](VpnPolicyIpv4ProvisionServerApi.md#vpnpoliciesipv4provisionservernamevpnnameput) | **PUT** /vpn/policies/ipv4/provision-server/name/{VPN_NAME} |  |
| [**VpnPoliciesIpv4ProvisionServerPatch**](VpnPolicyIpv4ProvisionServerApi.md#vpnpoliciesipv4provisionserverpatch) | **PATCH** /vpn/policies/ipv4/provision-server |  |
| [**VpnPoliciesIpv4ProvisionServerPost**](VpnPolicyIpv4ProvisionServerApi.md#vpnpoliciesipv4provisionserverpost) | **POST** /vpn/policies/ipv4/provision-server |  |
| [**VpnPoliciesIpv4ProvisionServerPut**](VpnPolicyIpv4ProvisionServerApi.md#vpnpoliciesipv4provisionserverput) | **PUT** /vpn/policies/ipv4/provision-server |  |

<a id="vpnpoliciesipv4provisionserverget"></a>
# **VpnPoliciesIpv4ProvisionServerGet**
> VpnPolicyIpv4ProvisionServerCollection VpnPoliciesIpv4ProvisionServerGet ()



Retrieve SonicWALL auto provisioning server VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionServerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionServerApi(config);

            try
            {
                VpnPolicyIpv4ProvisionServerCollection result = apiInstance.VpnPoliciesIpv4ProvisionServerGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionServerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4ProvisionServerCollection> response = apiInstance.VpnPoliciesIpv4ProvisionServerGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VpnPolicyIpv4ProvisionServerCollection**](VpnPolicyIpv4ProvisionServerCollection.md)

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

<a id="vpnpoliciesipv4provisionservernamevpnnamedelete"></a>
# **VpnPoliciesIpv4ProvisionServerNameVPNNAMEDelete**
> ApiStatus VpnPoliciesIpv4ProvisionServerNameVPNNAMEDelete (string VPN_NAME)



Delete a SonicWALL auto provisioning server VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionServerNameVPNNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionServerApi(config);
            var VPN_NAME = "\"SonicWALL auto provision server Policy\"";  // string | SonicWALL auto provisioning server VPN policy name. (default to "SonicWALL auto provision server Policy")

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEDelete(VPN_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerNameVPNNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionServerNameVPNNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEDeleteWithHttpInfo(VPN_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerNameVPNNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPN_NAME** | **string** | SonicWALL auto provisioning server VPN policy name. | [default to &quot;SonicWALL auto provision server Policy&quot;] |

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

<a id="vpnpoliciesipv4provisionservernamevpnnameget"></a>
# **VpnPoliciesIpv4ProvisionServerNameVPNNAMEGet**
> VpnPolicyIpv4ProvisionServerCollection VpnPoliciesIpv4ProvisionServerNameVPNNAMEGet (string VPN_NAME)



Retrieve SonicWALL auto provisioning server VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionServerNameVPNNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionServerApi(config);
            var VPN_NAME = "\"SonicWALL auto provision server Policy\"";  // string | SonicWALL auto provisioning server VPN policy name. (default to "SonicWALL auto provision server Policy")

            try
            {
                VpnPolicyIpv4ProvisionServerCollection result = apiInstance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEGet(VPN_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerNameVPNNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionServerNameVPNNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4ProvisionServerCollection> response = apiInstance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEGetWithHttpInfo(VPN_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerNameVPNNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPN_NAME** | **string** | SonicWALL auto provisioning server VPN policy name. | [default to &quot;SonicWALL auto provision server Policy&quot;] |

### Return type

[**VpnPolicyIpv4ProvisionServerCollection**](VpnPolicyIpv4ProvisionServerCollection.md)

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

<a id="vpnpoliciesipv4provisionservernamevpnnamepatch"></a>
# **VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatch**
> ApiStatus VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatch (string VPN_NAME, VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null)



Patch SonicWALL auto provisioning server VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionServerApi(config);
            var VPN_NAME = "\"SonicWALL auto provision server Policy\"";  // string | SonicWALL auto provisioning server VPN policy name. (default to "SonicWALL auto provision server Policy")
            var vpnPolicyIpv4ProvisionServerCollection = new VpnPolicyIpv4ProvisionServerCollection?(); // VpnPolicyIpv4ProvisionServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatch(VPN_NAME, vpnPolicyIpv4ProvisionServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatchWithHttpInfo(VPN_NAME, vpnPolicyIpv4ProvisionServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPN_NAME** | **string** | SonicWALL auto provisioning server VPN policy name. | [default to &quot;SonicWALL auto provision server Policy&quot;] |
| **vpnPolicyIpv4ProvisionServerCollection** | [**VpnPolicyIpv4ProvisionServerCollection?**](VpnPolicyIpv4ProvisionServerCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4provisionservernamevpnnameput"></a>
# **VpnPoliciesIpv4ProvisionServerNameVPNNAMEPut**
> ApiStatus VpnPoliciesIpv4ProvisionServerNameVPNNAMEPut (string VPN_NAME, VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null)



Edit SonicWALL auto provisioning server VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionServerNameVPNNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionServerApi(config);
            var VPN_NAME = "\"SonicWALL auto provision server Policy\"";  // string | SonicWALL auto provisioning server VPN policy name. (default to "SonicWALL auto provision server Policy")
            var vpnPolicyIpv4ProvisionServerCollection = new VpnPolicyIpv4ProvisionServerCollection?(); // VpnPolicyIpv4ProvisionServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPut(VPN_NAME, vpnPolicyIpv4ProvisionServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionServerNameVPNNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPutWithHttpInfo(VPN_NAME, vpnPolicyIpv4ProvisionServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPN_NAME** | **string** | SonicWALL auto provisioning server VPN policy name. | [default to &quot;SonicWALL auto provision server Policy&quot;] |
| **vpnPolicyIpv4ProvisionServerCollection** | [**VpnPolicyIpv4ProvisionServerCollection?**](VpnPolicyIpv4ProvisionServerCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4provisionserverpatch"></a>
# **VpnPoliciesIpv4ProvisionServerPatch**
> ApiStatus VpnPoliciesIpv4ProvisionServerPatch (VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null)



Patch SonicWALL auto provisioning server VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionServerPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionServerApi(config);
            var vpnPolicyIpv4ProvisionServerCollection = new VpnPolicyIpv4ProvisionServerCollection?(); // VpnPolicyIpv4ProvisionServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionServerPatch(vpnPolicyIpv4ProvisionServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionServerPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionServerPatchWithHttpInfo(vpnPolicyIpv4ProvisionServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4ProvisionServerCollection** | [**VpnPolicyIpv4ProvisionServerCollection?**](VpnPolicyIpv4ProvisionServerCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4provisionserverpost"></a>
# **VpnPoliciesIpv4ProvisionServerPost**
> ApiStatus VpnPoliciesIpv4ProvisionServerPost (VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null)



Create a new SonicWALL auto provisioning server VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionServerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionServerApi(config);
            var vpnPolicyIpv4ProvisionServerCollection = new VpnPolicyIpv4ProvisionServerCollection?(); // VpnPolicyIpv4ProvisionServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionServerPost(vpnPolicyIpv4ProvisionServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionServerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionServerPostWithHttpInfo(vpnPolicyIpv4ProvisionServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4ProvisionServerCollection** | [**VpnPolicyIpv4ProvisionServerCollection?**](VpnPolicyIpv4ProvisionServerCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4provisionserverput"></a>
# **VpnPoliciesIpv4ProvisionServerPut**
> ApiStatus VpnPoliciesIpv4ProvisionServerPut (VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null)



Edit SonicWALL auto provisioning server VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4ProvisionServerPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4ProvisionServerApi(config);
            var vpnPolicyIpv4ProvisionServerCollection = new VpnPolicyIpv4ProvisionServerCollection?(); // VpnPolicyIpv4ProvisionServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4ProvisionServerPut(vpnPolicyIpv4ProvisionServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4ProvisionServerPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4ProvisionServerPutWithHttpInfo(vpnPolicyIpv4ProvisionServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4ProvisionServerApi.VpnPoliciesIpv4ProvisionServerPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4ProvisionServerCollection** | [**VpnPolicyIpv4ProvisionServerCollection?**](VpnPolicyIpv4ProvisionServerCollection?.md) |  | [optional]  |

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

