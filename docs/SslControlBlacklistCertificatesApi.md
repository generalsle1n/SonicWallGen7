# SonicWallGen7.Api.SslControlBlacklistCertificatesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SslControlBlacklistCertificatesCommonNameCNAMEDelete**](SslControlBlacklistCertificatesApi.md#sslcontrolblacklistcertificatescommonnamecnamedelete) | **DELETE** /ssl-control/blacklist-certificates/common-name/{CNAME} |  |
| [**SslControlBlacklistCertificatesCommonNameCNAMEGet**](SslControlBlacklistCertificatesApi.md#sslcontrolblacklistcertificatescommonnamecnameget) | **GET** /ssl-control/blacklist-certificates/common-name/{CNAME} |  |
| [**SslControlBlacklistCertificatesCommonNameCNAMEPut**](SslControlBlacklistCertificatesApi.md#sslcontrolblacklistcertificatescommonnamecnameput) | **PUT** /ssl-control/blacklist-certificates/common-name/{CNAME} |  |
| [**SslControlBlacklistCertificatesGet**](SslControlBlacklistCertificatesApi.md#sslcontrolblacklistcertificatesget) | **GET** /ssl-control/blacklist-certificates |  |
| [**SslControlBlacklistCertificatesPost**](SslControlBlacklistCertificatesApi.md#sslcontrolblacklistcertificatespost) | **POST** /ssl-control/blacklist-certificates |  |
| [**SslControlBlacklistCertificatesPut**](SslControlBlacklistCertificatesApi.md#sslcontrolblacklistcertificatesput) | **PUT** /ssl-control/blacklist-certificates |  |

<a id="sslcontrolblacklistcertificatescommonnamecnamedelete"></a>
# **SslControlBlacklistCertificatesCommonNameCNAMEDelete**
> ApiStatus SslControlBlacklistCertificatesCommonNameCNAMEDelete (string CNAME)



Delete blacklist certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlBlacklistCertificatesCommonNameCNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlBlacklistCertificatesApi(config);
            var CNAME = "\"certificateName\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "certificateName")

            try
            {
                ApiStatus result = apiInstance.SslControlBlacklistCertificatesCommonNameCNAMEDelete(CNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesCommonNameCNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlBlacklistCertificatesCommonNameCNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslControlBlacklistCertificatesCommonNameCNAMEDeleteWithHttpInfo(CNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesCommonNameCNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;certificateName&quot;] |

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

<a id="sslcontrolblacklistcertificatescommonnamecnameget"></a>
# **SslControlBlacklistCertificatesCommonNameCNAMEGet**
> SslControlBlacklistCertificatesCollection SslControlBlacklistCertificatesCommonNameCNAMEGet (string CNAME)



Retrieve SSL control blacklist certificates configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlBlacklistCertificatesCommonNameCNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlBlacklistCertificatesApi(config);
            var CNAME = "\"certificateName\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "certificateName")

            try
            {
                SslControlBlacklistCertificatesCollection result = apiInstance.SslControlBlacklistCertificatesCommonNameCNAMEGet(CNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesCommonNameCNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlBlacklistCertificatesCommonNameCNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslControlBlacklistCertificatesCollection> response = apiInstance.SslControlBlacklistCertificatesCommonNameCNAMEGetWithHttpInfo(CNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesCommonNameCNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;certificateName&quot;] |

### Return type

[**SslControlBlacklistCertificatesCollection**](SslControlBlacklistCertificatesCollection.md)

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

<a id="sslcontrolblacklistcertificatescommonnamecnameput"></a>
# **SslControlBlacklistCertificatesCommonNameCNAMEPut**
> ApiStatus SslControlBlacklistCertificatesCommonNameCNAMEPut (string CNAME, SslControlBlacklistCertificatesCollection? sslControlBlacklistCertificatesCollection = null)



Edit a blacklist certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlBlacklistCertificatesCommonNameCNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlBlacklistCertificatesApi(config);
            var CNAME = "\"certificateName\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "certificateName")
            var sslControlBlacklistCertificatesCollection = new SslControlBlacklistCertificatesCollection?(); // SslControlBlacklistCertificatesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslControlBlacklistCertificatesCommonNameCNAMEPut(CNAME, sslControlBlacklistCertificatesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesCommonNameCNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlBlacklistCertificatesCommonNameCNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslControlBlacklistCertificatesCommonNameCNAMEPutWithHttpInfo(CNAME, sslControlBlacklistCertificatesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesCommonNameCNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;certificateName&quot;] |
| **sslControlBlacklistCertificatesCollection** | [**SslControlBlacklistCertificatesCollection?**](SslControlBlacklistCertificatesCollection?.md) |  | [optional]  |

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

<a id="sslcontrolblacklistcertificatesget"></a>
# **SslControlBlacklistCertificatesGet**
> SslControlBlacklistCertificatesCollection SslControlBlacklistCertificatesGet ()



Retrieve SSL control blacklist certificates configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlBlacklistCertificatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlBlacklistCertificatesApi(config);

            try
            {
                SslControlBlacklistCertificatesCollection result = apiInstance.SslControlBlacklistCertificatesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlBlacklistCertificatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslControlBlacklistCertificatesCollection> response = apiInstance.SslControlBlacklistCertificatesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SslControlBlacklistCertificatesCollection**](SslControlBlacklistCertificatesCollection.md)

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

<a id="sslcontrolblacklistcertificatespost"></a>
# **SslControlBlacklistCertificatesPost**
> ApiStatus SslControlBlacklistCertificatesPost (SslControlBlacklistCertificatesCollection? sslControlBlacklistCertificatesCollection = null)



Add blacklist certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlBlacklistCertificatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlBlacklistCertificatesApi(config);
            var sslControlBlacklistCertificatesCollection = new SslControlBlacklistCertificatesCollection?(); // SslControlBlacklistCertificatesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslControlBlacklistCertificatesPost(sslControlBlacklistCertificatesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlBlacklistCertificatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslControlBlacklistCertificatesPostWithHttpInfo(sslControlBlacklistCertificatesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslControlBlacklistCertificatesCollection** | [**SslControlBlacklistCertificatesCollection?**](SslControlBlacklistCertificatesCollection?.md) |  | [optional]  |

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

<a id="sslcontrolblacklistcertificatesput"></a>
# **SslControlBlacklistCertificatesPut**
> ApiStatus SslControlBlacklistCertificatesPut (SslControlBlacklistCertificatesCollection? sslControlBlacklistCertificatesCollection = null)



Edit a blacklist certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlBlacklistCertificatesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlBlacklistCertificatesApi(config);
            var sslControlBlacklistCertificatesCollection = new SslControlBlacklistCertificatesCollection?(); // SslControlBlacklistCertificatesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslControlBlacklistCertificatesPut(sslControlBlacklistCertificatesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlBlacklistCertificatesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslControlBlacklistCertificatesPutWithHttpInfo(sslControlBlacklistCertificatesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlBlacklistCertificatesApi.SslControlBlacklistCertificatesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslControlBlacklistCertificatesCollection** | [**SslControlBlacklistCertificatesCollection?**](SslControlBlacklistCertificatesCollection?.md) |  | [optional]  |

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

