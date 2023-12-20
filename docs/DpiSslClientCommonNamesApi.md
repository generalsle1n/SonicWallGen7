# SonicWallGen7.Api.DpiSslClientCommonNamesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DpiSslClientCommonNamesGet**](DpiSslClientCommonNamesApi.md#dpisslclientcommonnamesget) | **GET** /dpi-ssl/client/common-names |  |
| [**DpiSslClientCommonNamesNameCNAMEDelete**](DpiSslClientCommonNamesApi.md#dpisslclientcommonnamesnamecnamedelete) | **DELETE** /dpi-ssl/client/common-names/name/{CNAME} |  |
| [**DpiSslClientCommonNamesNameCNAMEGet**](DpiSslClientCommonNamesApi.md#dpisslclientcommonnamesnamecnameget) | **GET** /dpi-ssl/client/common-names/name/{CNAME} |  |
| [**DpiSslClientCommonNamesPost**](DpiSslClientCommonNamesApi.md#dpisslclientcommonnamespost) | **POST** /dpi-ssl/client/common-names |  |

<a id="dpisslclientcommonnamesget"></a>
# **DpiSslClientCommonNamesGet**
> DpiSslClientCommonNamesCollection DpiSslClientCommonNamesGet ()



Retrieve DPI-SSL client common names settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslClientCommonNamesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientCommonNamesApi(config);

            try
            {
                DpiSslClientCommonNamesCollection result = apiInstance.DpiSslClientCommonNamesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientCommonNamesApi.DpiSslClientCommonNamesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslClientCommonNamesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DpiSslClientCommonNamesCollection> response = apiInstance.DpiSslClientCommonNamesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientCommonNamesApi.DpiSslClientCommonNamesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DpiSslClientCommonNamesCollection**](DpiSslClientCommonNamesCollection.md)

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

<a id="dpisslclientcommonnamesnamecnamedelete"></a>
# **DpiSslClientCommonNamesNameCNAMEDelete**
> ApiStatus DpiSslClientCommonNamesNameCNAMEDelete (string CNAME)



Delete a DPI-SSL client common name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslClientCommonNamesNameCNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientCommonNamesApi(config);
            var CNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.DpiSslClientCommonNamesNameCNAMEDelete(CNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientCommonNamesApi.DpiSslClientCommonNamesNameCNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslClientCommonNamesNameCNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DpiSslClientCommonNamesNameCNAMEDeleteWithHttpInfo(CNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientCommonNamesApi.DpiSslClientCommonNamesNameCNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

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

<a id="dpisslclientcommonnamesnamecnameget"></a>
# **DpiSslClientCommonNamesNameCNAMEGet**
> DpiSslClientCommonNamesCollection DpiSslClientCommonNamesNameCNAMEGet (string CNAME)



Retrieve DPI-SSL client common names settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslClientCommonNamesNameCNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientCommonNamesApi(config);
            var CNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                DpiSslClientCommonNamesCollection result = apiInstance.DpiSslClientCommonNamesNameCNAMEGet(CNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientCommonNamesApi.DpiSslClientCommonNamesNameCNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslClientCommonNamesNameCNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DpiSslClientCommonNamesCollection> response = apiInstance.DpiSslClientCommonNamesNameCNAMEGetWithHttpInfo(CNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientCommonNamesApi.DpiSslClientCommonNamesNameCNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**DpiSslClientCommonNamesCollection**](DpiSslClientCommonNamesCollection.md)

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

<a id="dpisslclientcommonnamespost"></a>
# **DpiSslClientCommonNamesPost**
> ApiStatus DpiSslClientCommonNamesPost (DpiSslClientCommonNamesCollection? dpiSslClientCommonNamesCollection = null)



Add a DPI-SSL Client common name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslClientCommonNamesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientCommonNamesApi(config);
            var dpiSslClientCommonNamesCollection = new DpiSslClientCommonNamesCollection?(); // DpiSslClientCommonNamesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DpiSslClientCommonNamesPost(dpiSslClientCommonNamesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientCommonNamesApi.DpiSslClientCommonNamesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslClientCommonNamesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DpiSslClientCommonNamesPostWithHttpInfo(dpiSslClientCommonNamesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientCommonNamesApi.DpiSslClientCommonNamesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dpiSslClientCommonNamesCollection** | [**DpiSslClientCommonNamesCollection?**](DpiSslClientCommonNamesCollection?.md) |  | [optional]  |

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

