# SonicWallGen7.Api.VlanTranslationApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VlanTranslationsGet**](VlanTranslationApi.md#vlantranslationsget) | **GET** /vlan-translations |  |
| [**VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDelete**](VlanTranslationApi.md#vlantranslationsingressinterfaceingressifvlaningressidegressinterfaceegressifvlanegressiddelete) | **DELETE** /vlan-translations/ingress/interface/{INGRESSIF}/vlan/{INGRESSID}/egress/interface/{EGRESSIF}/vlan/{EGRESSID} |  |
| [**VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGet**](VlanTranslationApi.md#vlantranslationsingressinterfaceingressifvlaningressidegressinterfaceegressifvlanegressidget) | **GET** /vlan-translations/ingress/interface/{INGRESSIF}/vlan/{INGRESSID}/egress/interface/{EGRESSIF}/vlan/{EGRESSID} |  |
| [**VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatch**](VlanTranslationApi.md#vlantranslationsingressinterfaceingressifvlaningressidegressinterfaceegressifvlanegressidpatch) | **PATCH** /vlan-translations/ingress/interface/{INGRESSIF}/vlan/{INGRESSID}/egress/interface/{EGRESSIF}/vlan/{EGRESSID} |  |
| [**VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPut**](VlanTranslationApi.md#vlantranslationsingressinterfaceingressifvlaningressidegressinterfaceegressifvlanegressidput) | **PUT** /vlan-translations/ingress/interface/{INGRESSIF}/vlan/{INGRESSID}/egress/interface/{EGRESSIF}/vlan/{EGRESSID} |  |
| [**VlanTranslationsPatch**](VlanTranslationApi.md#vlantranslationspatch) | **PATCH** /vlan-translations |  |
| [**VlanTranslationsPost**](VlanTranslationApi.md#vlantranslationspost) | **POST** /vlan-translations |  |
| [**VlanTranslationsPut**](VlanTranslationApi.md#vlantranslationsput) | **PUT** /vlan-translations |  |

<a id="vlantranslationsget"></a>
# **VlanTranslationsGet**
> VlanTranslationCollection VlanTranslationsGet ()



Retrieve vlan translation configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VlanTranslationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VlanTranslationApi(config);

            try
            {
                VlanTranslationCollection result = apiInstance.VlanTranslationsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VlanTranslationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VlanTranslationCollection> response = apiInstance.VlanTranslationsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VlanTranslationCollection**](VlanTranslationCollection.md)

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

<a id="vlantranslationsingressinterfaceingressifvlaningressidegressinterfaceegressifvlanegressiddelete"></a>
# **VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDelete**
> ApiStatus VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDelete (string INGRESSIF, decimal INGRESSID, string EGRESSIF, decimal EGRESSID)



Delete a vlan translation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VlanTranslationApi(config);
            var INGRESSIF = "\"X0\"";  // string | Ingress interface name. (default to "X0")
            var INGRESSID = 8.14D;  // decimal | Interface VLAN id.
            var EGRESSIF = "\"X0\"";  // string | Egress interface name. (default to "X0")
            var EGRESSID = 8.14D;  // decimal | Interface VLAN id.

            try
            {
                ApiStatus result = apiInstance.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDelete(INGRESSIF, INGRESSID, EGRESSIF, EGRESSID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDeleteWithHttpInfo(INGRESSIF, INGRESSID, EGRESSIF, EGRESSID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INGRESSIF** | **string** | Ingress interface name. | [default to &quot;X0&quot;] |
| **INGRESSID** | **decimal** | Interface VLAN id. |  |
| **EGRESSIF** | **string** | Egress interface name. | [default to &quot;X0&quot;] |
| **EGRESSID** | **decimal** | Interface VLAN id. |  |

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

<a id="vlantranslationsingressinterfaceingressifvlaningressidegressinterfaceegressifvlanegressidget"></a>
# **VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGet**
> VlanTranslationCollection VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGet (string INGRESSIF, decimal INGRESSID, string EGRESSIF, decimal EGRESSID)



Retrieve vlan translation configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VlanTranslationApi(config);
            var INGRESSIF = "\"X0\"";  // string | Ingress interface name. (default to "X0")
            var INGRESSID = 8.14D;  // decimal | Interface VLAN id.
            var EGRESSIF = "\"X0\"";  // string | Egress interface name. (default to "X0")
            var EGRESSID = 8.14D;  // decimal | Interface VLAN id.

            try
            {
                VlanTranslationCollection result = apiInstance.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGet(INGRESSIF, INGRESSID, EGRESSIF, EGRESSID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VlanTranslationCollection> response = apiInstance.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGetWithHttpInfo(INGRESSIF, INGRESSID, EGRESSIF, EGRESSID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INGRESSIF** | **string** | Ingress interface name. | [default to &quot;X0&quot;] |
| **INGRESSID** | **decimal** | Interface VLAN id. |  |
| **EGRESSIF** | **string** | Egress interface name. | [default to &quot;X0&quot;] |
| **EGRESSID** | **decimal** | Interface VLAN id. |  |

### Return type

[**VlanTranslationCollection**](VlanTranslationCollection.md)

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

<a id="vlantranslationsingressinterfaceingressifvlaningressidegressinterfaceegressifvlanegressidpatch"></a>
# **VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatch**
> ApiStatus VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatch (string INGRESSIF, decimal INGRESSID, string EGRESSIF, decimal EGRESSID, VlanTranslationCollection? vlanTranslationCollection = null)



Patch vlan translation configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VlanTranslationApi(config);
            var INGRESSIF = "\"X0\"";  // string | Ingress interface name. (default to "X0")
            var INGRESSID = 8.14D;  // decimal | Interface VLAN id.
            var EGRESSIF = "\"X0\"";  // string | Egress interface name. (default to "X0")
            var EGRESSID = 8.14D;  // decimal | Interface VLAN id.
            var vlanTranslationCollection = new VlanTranslationCollection?(); // VlanTranslationCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatch(INGRESSIF, INGRESSID, EGRESSIF, EGRESSID, vlanTranslationCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatchWithHttpInfo(INGRESSIF, INGRESSID, EGRESSIF, EGRESSID, vlanTranslationCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INGRESSIF** | **string** | Ingress interface name. | [default to &quot;X0&quot;] |
| **INGRESSID** | **decimal** | Interface VLAN id. |  |
| **EGRESSIF** | **string** | Egress interface name. | [default to &quot;X0&quot;] |
| **EGRESSID** | **decimal** | Interface VLAN id. |  |
| **vlanTranslationCollection** | [**VlanTranslationCollection?**](VlanTranslationCollection?.md) |  | [optional]  |

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

<a id="vlantranslationsingressinterfaceingressifvlaningressidegressinterfaceegressifvlanegressidput"></a>
# **VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPut**
> ApiStatus VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPut (string INGRESSIF, decimal INGRESSID, string EGRESSIF, decimal EGRESSID, VlanTranslationCollection? vlanTranslationCollection = null)



Edit vlan translation configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VlanTranslationApi(config);
            var INGRESSIF = "\"X0\"";  // string | Ingress interface name. (default to "X0")
            var INGRESSID = 8.14D;  // decimal | Interface VLAN id.
            var EGRESSIF = "\"X0\"";  // string | Egress interface name. (default to "X0")
            var EGRESSID = 8.14D;  // decimal | Interface VLAN id.
            var vlanTranslationCollection = new VlanTranslationCollection?(); // VlanTranslationCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPut(INGRESSIF, INGRESSID, EGRESSIF, EGRESSID, vlanTranslationCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPutWithHttpInfo(INGRESSIF, INGRESSID, EGRESSIF, EGRESSID, vlanTranslationCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsIngressInterfaceINGRESSIFVlanINGRESSIDEgressInterfaceEGRESSIFVlanEGRESSIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INGRESSIF** | **string** | Ingress interface name. | [default to &quot;X0&quot;] |
| **INGRESSID** | **decimal** | Interface VLAN id. |  |
| **EGRESSIF** | **string** | Egress interface name. | [default to &quot;X0&quot;] |
| **EGRESSID** | **decimal** | Interface VLAN id. |  |
| **vlanTranslationCollection** | [**VlanTranslationCollection?**](VlanTranslationCollection?.md) |  | [optional]  |

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

<a id="vlantranslationspatch"></a>
# **VlanTranslationsPatch**
> ApiStatus VlanTranslationsPatch (VlanTranslationCollection? vlanTranslationCollection = null)



Patch vlan translation configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VlanTranslationsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VlanTranslationApi(config);
            var vlanTranslationCollection = new VlanTranslationCollection?(); // VlanTranslationCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VlanTranslationsPatch(vlanTranslationCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VlanTranslationsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VlanTranslationsPatchWithHttpInfo(vlanTranslationCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vlanTranslationCollection** | [**VlanTranslationCollection?**](VlanTranslationCollection?.md) |  | [optional]  |

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

<a id="vlantranslationspost"></a>
# **VlanTranslationsPost**
> ApiStatus VlanTranslationsPost (VlanTranslationCollection? vlanTranslationCollection = null)



Create a new vlan translation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VlanTranslationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VlanTranslationApi(config);
            var vlanTranslationCollection = new VlanTranslationCollection?(); // VlanTranslationCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VlanTranslationsPost(vlanTranslationCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VlanTranslationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VlanTranslationsPostWithHttpInfo(vlanTranslationCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vlanTranslationCollection** | [**VlanTranslationCollection?**](VlanTranslationCollection?.md) |  | [optional]  |

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

<a id="vlantranslationsput"></a>
# **VlanTranslationsPut**
> ApiStatus VlanTranslationsPut (VlanTranslationCollection? vlanTranslationCollection = null)



Edit vlan translation configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VlanTranslationsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VlanTranslationApi(config);
            var vlanTranslationCollection = new VlanTranslationCollection?(); // VlanTranslationCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VlanTranslationsPut(vlanTranslationCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VlanTranslationsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VlanTranslationsPutWithHttpInfo(vlanTranslationCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VlanTranslationApi.VlanTranslationsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vlanTranslationCollection** | [**VlanTranslationCollection?**](VlanTranslationCollection?.md) |  | [optional]  |

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

