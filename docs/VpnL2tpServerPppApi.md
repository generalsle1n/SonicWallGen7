# SonicWallGen7.Api.VpnL2tpServerPppApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnL2tpServerPppGet**](VpnL2tpServerPppApi.md#vpnl2tpserverpppget) | **GET** /vpn/l2tp-server/ppp |  |
| [**VpnL2tpServerPppPatch**](VpnL2tpServerPppApi.md#vpnl2tpserverppppatch) | **PATCH** /vpn/l2tp-server/ppp |  |
| [**VpnL2tpServerPppProtocolPROTONAMEDelete**](VpnL2tpServerPppApi.md#vpnl2tpserverpppprotocolprotonamedelete) | **DELETE** /vpn/l2tp-server/ppp/protocol/{PROTONAME} |  |
| [**VpnL2tpServerPppProtocolPROTONAMEGet**](VpnL2tpServerPppApi.md#vpnl2tpserverpppprotocolprotonameget) | **GET** /vpn/l2tp-server/ppp/protocol/{PROTONAME} |  |
| [**VpnL2tpServerPppProtocolPROTONAMEPatch**](VpnL2tpServerPppApi.md#vpnl2tpserverpppprotocolprotonamepatch) | **PATCH** /vpn/l2tp-server/ppp/protocol/{PROTONAME} |  |
| [**VpnL2tpServerPppProtocolPROTONAMEPut**](VpnL2tpServerPppApi.md#vpnl2tpserverpppprotocolprotonameput) | **PUT** /vpn/l2tp-server/ppp/protocol/{PROTONAME} |  |
| [**VpnL2tpServerPppPut**](VpnL2tpServerPppApi.md#vpnl2tpserverpppput) | **PUT** /vpn/l2tp-server/ppp |  |

<a id="vpnl2tpserverpppget"></a>
# **VpnL2tpServerPppGet**
> VpnL2tpServerPppCollection VpnL2tpServerPppGet ()



Retrieve VPN L2TP server PPP settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnL2tpServerPppGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnL2tpServerPppApi(config);

            try
            {
                VpnL2tpServerPppCollection result = apiInstance.VpnL2tpServerPppGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnL2tpServerPppGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnL2tpServerPppCollection> response = apiInstance.VpnL2tpServerPppGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VpnL2tpServerPppCollection**](VpnL2tpServerPppCollection.md)

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

<a id="vpnl2tpserverppppatch"></a>
# **VpnL2tpServerPppPatch**
> ApiStatus VpnL2tpServerPppPatch (VpnL2tpServerPppCollection? vpnL2tpServerPppCollection = null)



Patch VPN L2TP server PPP settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnL2tpServerPppPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnL2tpServerPppApi(config);
            var vpnL2tpServerPppCollection = new VpnL2tpServerPppCollection?(); // VpnL2tpServerPppCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnL2tpServerPppPatch(vpnL2tpServerPppCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnL2tpServerPppPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnL2tpServerPppPatchWithHttpInfo(vpnL2tpServerPppCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnL2tpServerPppCollection** | [**VpnL2tpServerPppCollection?**](VpnL2tpServerPppCollection?.md) |  | [optional]  |

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

<a id="vpnl2tpserverpppprotocolprotonamedelete"></a>
# **VpnL2tpServerPppProtocolPROTONAMEDelete**
> ApiStatus VpnL2tpServerPppProtocolPROTONAMEDelete (string PROTONAME)



Remove specified PPP authentication protocol.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnL2tpServerPppProtocolPROTONAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnL2tpServerPppApi(config);
            var PROTONAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.VpnL2tpServerPppProtocolPROTONAMEDelete(PROTONAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppProtocolPROTONAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnL2tpServerPppProtocolPROTONAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnL2tpServerPppProtocolPROTONAMEDeleteWithHttpInfo(PROTONAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppProtocolPROTONAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTONAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

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

<a id="vpnl2tpserverpppprotocolprotonameget"></a>
# **VpnL2tpServerPppProtocolPROTONAMEGet**
> VpnL2tpServerPppCollection VpnL2tpServerPppProtocolPROTONAMEGet (string PROTONAME)



Retrieve VPN L2TP server PPP settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnL2tpServerPppProtocolPROTONAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnL2tpServerPppApi(config);
            var PROTONAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                VpnL2tpServerPppCollection result = apiInstance.VpnL2tpServerPppProtocolPROTONAMEGet(PROTONAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppProtocolPROTONAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnL2tpServerPppProtocolPROTONAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnL2tpServerPppCollection> response = apiInstance.VpnL2tpServerPppProtocolPROTONAMEGetWithHttpInfo(PROTONAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppProtocolPROTONAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTONAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**VpnL2tpServerPppCollection**](VpnL2tpServerPppCollection.md)

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

<a id="vpnl2tpserverpppprotocolprotonamepatch"></a>
# **VpnL2tpServerPppProtocolPROTONAMEPatch**
> ApiStatus VpnL2tpServerPppProtocolPROTONAMEPatch (string PROTONAME, VpnL2tpServerPppCollection? vpnL2tpServerPppCollection = null)



Patch VPN L2TP server PPP settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnL2tpServerPppProtocolPROTONAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnL2tpServerPppApi(config);
            var PROTONAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var vpnL2tpServerPppCollection = new VpnL2tpServerPppCollection?(); // VpnL2tpServerPppCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnL2tpServerPppProtocolPROTONAMEPatch(PROTONAME, vpnL2tpServerPppCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppProtocolPROTONAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnL2tpServerPppProtocolPROTONAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnL2tpServerPppProtocolPROTONAMEPatchWithHttpInfo(PROTONAME, vpnL2tpServerPppCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppProtocolPROTONAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTONAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **vpnL2tpServerPppCollection** | [**VpnL2tpServerPppCollection?**](VpnL2tpServerPppCollection?.md) |  | [optional]  |

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

<a id="vpnl2tpserverpppprotocolprotonameput"></a>
# **VpnL2tpServerPppProtocolPROTONAMEPut**
> ApiStatus VpnL2tpServerPppProtocolPROTONAMEPut (string PROTONAME, VpnL2tpServerPppCollection? vpnL2tpServerPppCollection = null)



Edit VPN L2TP server PPP settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnL2tpServerPppProtocolPROTONAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnL2tpServerPppApi(config);
            var PROTONAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var vpnL2tpServerPppCollection = new VpnL2tpServerPppCollection?(); // VpnL2tpServerPppCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnL2tpServerPppProtocolPROTONAMEPut(PROTONAME, vpnL2tpServerPppCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppProtocolPROTONAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnL2tpServerPppProtocolPROTONAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnL2tpServerPppProtocolPROTONAMEPutWithHttpInfo(PROTONAME, vpnL2tpServerPppCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppProtocolPROTONAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PROTONAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **vpnL2tpServerPppCollection** | [**VpnL2tpServerPppCollection?**](VpnL2tpServerPppCollection?.md) |  | [optional]  |

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

<a id="vpnl2tpserverpppput"></a>
# **VpnL2tpServerPppPut**
> ApiStatus VpnL2tpServerPppPut (VpnL2tpServerPppCollection? vpnL2tpServerPppCollection = null)



Edit VPN L2TP server PPP settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnL2tpServerPppPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnL2tpServerPppApi(config);
            var vpnL2tpServerPppCollection = new VpnL2tpServerPppCollection?(); // VpnL2tpServerPppCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnL2tpServerPppPut(vpnL2tpServerPppCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnL2tpServerPppPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnL2tpServerPppPutWithHttpInfo(vpnL2tpServerPppCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnL2tpServerPppApi.VpnL2tpServerPppPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnL2tpServerPppCollection** | [**VpnL2tpServerPppCollection?**](VpnL2tpServerPppCollection?.md) |  | [optional]  |

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

