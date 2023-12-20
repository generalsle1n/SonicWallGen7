# SonicWallGen7.Api.SslVpnDeviceProfileApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SslVpnDeviceProfilesGet**](SslVpnDeviceProfileApi.md#sslvpndeviceprofilesget) | **GET** /ssl-vpn/device-profiles |  |
| [**SslVpnDeviceProfilesNameNAMEGet**](SslVpnDeviceProfileApi.md#sslvpndeviceprofilesnamenameget) | **GET** /ssl-vpn/device-profiles/name/{NAME} |  |
| [**SslVpnDeviceProfilesNameNAMEPatch**](SslVpnDeviceProfileApi.md#sslvpndeviceprofilesnamenamepatch) | **PATCH** /ssl-vpn/device-profiles/name/{NAME} |  |
| [**SslVpnDeviceProfilesNameNAMEPut**](SslVpnDeviceProfileApi.md#sslvpndeviceprofilesnamenameput) | **PUT** /ssl-vpn/device-profiles/name/{NAME} |  |
| [**SslVpnDeviceProfilesPatch**](SslVpnDeviceProfileApi.md#sslvpndeviceprofilespatch) | **PATCH** /ssl-vpn/device-profiles |  |
| [**SslVpnDeviceProfilesPut**](SslVpnDeviceProfileApi.md#sslvpndeviceprofilesput) | **PUT** /ssl-vpn/device-profiles |  |

<a id="sslvpndeviceprofilesget"></a>
# **SslVpnDeviceProfilesGet**
> SslVpnDeviceProfileCollection SslVpnDeviceProfilesGet ()



Retrieve SSL VPN device profile object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnDeviceProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnDeviceProfileApi(config);

            try
            {
                SslVpnDeviceProfileCollection result = apiInstance.SslVpnDeviceProfilesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnDeviceProfilesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslVpnDeviceProfileCollection> response = apiInstance.SslVpnDeviceProfilesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SslVpnDeviceProfileCollection**](SslVpnDeviceProfileCollection.md)

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

<a id="sslvpndeviceprofilesnamenameget"></a>
# **SslVpnDeviceProfilesNameNAMEGet**
> SslVpnDeviceProfileCollection SslVpnDeviceProfilesNameNAMEGet (string NAME)



Retrieve SSL VPN device profile object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnDeviceProfilesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnDeviceProfileApi(config);
            var NAME = "\"Default Device Profile\"";  // string | Device name in the form: WORD or \"QUOTED STRING\" (default to "Default Device Profile")

            try
            {
                SslVpnDeviceProfileCollection result = apiInstance.SslVpnDeviceProfilesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnDeviceProfilesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslVpnDeviceProfileCollection> response = apiInstance.SslVpnDeviceProfilesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Device name in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;Default Device Profile&quot;] |

### Return type

[**SslVpnDeviceProfileCollection**](SslVpnDeviceProfileCollection.md)

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

<a id="sslvpndeviceprofilesnamenamepatch"></a>
# **SslVpnDeviceProfilesNameNAMEPatch**
> ApiStatus SslVpnDeviceProfilesNameNAMEPatch (string NAME, SslVpnDeviceProfileCollection? sslVpnDeviceProfileCollection = null)



Patch SSL VPN device profile object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnDeviceProfilesNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnDeviceProfileApi(config);
            var NAME = "\"Default Device Profile\"";  // string | Device name in the form: WORD or \"QUOTED STRING\" (default to "Default Device Profile")
            var sslVpnDeviceProfileCollection = new SslVpnDeviceProfileCollection?(); // SslVpnDeviceProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnDeviceProfilesNameNAMEPatch(NAME, sslVpnDeviceProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnDeviceProfilesNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnDeviceProfilesNameNAMEPatchWithHttpInfo(NAME, sslVpnDeviceProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Device name in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;Default Device Profile&quot;] |
| **sslVpnDeviceProfileCollection** | [**SslVpnDeviceProfileCollection?**](SslVpnDeviceProfileCollection?.md) |  | [optional]  |

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

<a id="sslvpndeviceprofilesnamenameput"></a>
# **SslVpnDeviceProfilesNameNAMEPut**
> ApiStatus SslVpnDeviceProfilesNameNAMEPut (string NAME, SslVpnDeviceProfileCollection? sslVpnDeviceProfileCollection = null)



Edit SSL VPN device profile object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnDeviceProfilesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnDeviceProfileApi(config);
            var NAME = "\"Default Device Profile\"";  // string | Device name in the form: WORD or \"QUOTED STRING\" (default to "Default Device Profile")
            var sslVpnDeviceProfileCollection = new SslVpnDeviceProfileCollection?(); // SslVpnDeviceProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnDeviceProfilesNameNAMEPut(NAME, sslVpnDeviceProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnDeviceProfilesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnDeviceProfilesNameNAMEPutWithHttpInfo(NAME, sslVpnDeviceProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Device name in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;Default Device Profile&quot;] |
| **sslVpnDeviceProfileCollection** | [**SslVpnDeviceProfileCollection?**](SslVpnDeviceProfileCollection?.md) |  | [optional]  |

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

<a id="sslvpndeviceprofilespatch"></a>
# **SslVpnDeviceProfilesPatch**
> ApiStatus SslVpnDeviceProfilesPatch (SslVpnDeviceProfileCollection? sslVpnDeviceProfileCollection = null)



Patch SSL VPN device profile object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnDeviceProfilesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnDeviceProfileApi(config);
            var sslVpnDeviceProfileCollection = new SslVpnDeviceProfileCollection?(); // SslVpnDeviceProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnDeviceProfilesPatch(sslVpnDeviceProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnDeviceProfilesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnDeviceProfilesPatchWithHttpInfo(sslVpnDeviceProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslVpnDeviceProfileCollection** | [**SslVpnDeviceProfileCollection?**](SslVpnDeviceProfileCollection?.md) |  | [optional]  |

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

<a id="sslvpndeviceprofilesput"></a>
# **SslVpnDeviceProfilesPut**
> ApiStatus SslVpnDeviceProfilesPut (SslVpnDeviceProfileCollection? sslVpnDeviceProfileCollection = null)



Edit SSL VPN device profile object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnDeviceProfilesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnDeviceProfileApi(config);
            var sslVpnDeviceProfileCollection = new SslVpnDeviceProfileCollection?(); // SslVpnDeviceProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnDeviceProfilesPut(sslVpnDeviceProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnDeviceProfilesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnDeviceProfilesPutWithHttpInfo(sslVpnDeviceProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnDeviceProfileApi.SslVpnDeviceProfilesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslVpnDeviceProfileCollection** | [**SslVpnDeviceProfileCollection?**](SslVpnDeviceProfileCollection?.md) |  | [optional]  |

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

