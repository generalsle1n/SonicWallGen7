# SonicWallGen7.Api.SslControlWhitelistCertificatesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SslControlWhitelistCertificatesCommonNameCNAMEDelete**](SslControlWhitelistCertificatesApi.md#sslcontrolwhitelistcertificatescommonnamecnamedelete) | **DELETE** /ssl-control/whitelist-certificates/common-name/{CNAME} |  |
| [**SslControlWhitelistCertificatesCommonNameCNAMEGet**](SslControlWhitelistCertificatesApi.md#sslcontrolwhitelistcertificatescommonnamecnameget) | **GET** /ssl-control/whitelist-certificates/common-name/{CNAME} |  |
| [**SslControlWhitelistCertificatesCommonNameCNAMEPut**](SslControlWhitelistCertificatesApi.md#sslcontrolwhitelistcertificatescommonnamecnameput) | **PUT** /ssl-control/whitelist-certificates/common-name/{CNAME} |  |
| [**SslControlWhitelistCertificatesGet**](SslControlWhitelistCertificatesApi.md#sslcontrolwhitelistcertificatesget) | **GET** /ssl-control/whitelist-certificates |  |
| [**SslControlWhitelistCertificatesPost**](SslControlWhitelistCertificatesApi.md#sslcontrolwhitelistcertificatespost) | **POST** /ssl-control/whitelist-certificates |  |
| [**SslControlWhitelistCertificatesPut**](SslControlWhitelistCertificatesApi.md#sslcontrolwhitelistcertificatesput) | **PUT** /ssl-control/whitelist-certificates |  |

<a id="sslcontrolwhitelistcertificatescommonnamecnamedelete"></a>
# **SslControlWhitelistCertificatesCommonNameCNAMEDelete**
> ApiStatus SslControlWhitelistCertificatesCommonNameCNAMEDelete (string CNAME)



Delete whitelist certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlWhitelistCertificatesCommonNameCNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlWhitelistCertificatesApi(config);
            var CNAME = "\"certificateName\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "certificateName")

            try
            {
                ApiStatus result = apiInstance.SslControlWhitelistCertificatesCommonNameCNAMEDelete(CNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesCommonNameCNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlWhitelistCertificatesCommonNameCNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslControlWhitelistCertificatesCommonNameCNAMEDeleteWithHttpInfo(CNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesCommonNameCNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="sslcontrolwhitelistcertificatescommonnamecnameget"></a>
# **SslControlWhitelistCertificatesCommonNameCNAMEGet**
> SslControlWhitelistCertificatesCollection SslControlWhitelistCertificatesCommonNameCNAMEGet (string CNAME)



Retrieve SSL control whitelist certificates configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlWhitelistCertificatesCommonNameCNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlWhitelistCertificatesApi(config);
            var CNAME = "\"certificateName\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "certificateName")

            try
            {
                SslControlWhitelistCertificatesCollection result = apiInstance.SslControlWhitelistCertificatesCommonNameCNAMEGet(CNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesCommonNameCNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlWhitelistCertificatesCommonNameCNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslControlWhitelistCertificatesCollection> response = apiInstance.SslControlWhitelistCertificatesCommonNameCNAMEGetWithHttpInfo(CNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesCommonNameCNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;certificateName&quot;] |

### Return type

[**SslControlWhitelistCertificatesCollection**](SslControlWhitelistCertificatesCollection.md)

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

<a id="sslcontrolwhitelistcertificatescommonnamecnameput"></a>
# **SslControlWhitelistCertificatesCommonNameCNAMEPut**
> ApiStatus SslControlWhitelistCertificatesCommonNameCNAMEPut (string CNAME, SslControlWhitelistCertificatesCollection? sslControlWhitelistCertificatesCollection = null)



Edit a whitelist certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlWhitelistCertificatesCommonNameCNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlWhitelistCertificatesApi(config);
            var CNAME = "\"certificateName\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "certificateName")
            var sslControlWhitelistCertificatesCollection = new SslControlWhitelistCertificatesCollection?(); // SslControlWhitelistCertificatesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslControlWhitelistCertificatesCommonNameCNAMEPut(CNAME, sslControlWhitelistCertificatesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesCommonNameCNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlWhitelistCertificatesCommonNameCNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslControlWhitelistCertificatesCommonNameCNAMEPutWithHttpInfo(CNAME, sslControlWhitelistCertificatesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesCommonNameCNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;certificateName&quot;] |
| **sslControlWhitelistCertificatesCollection** | [**SslControlWhitelistCertificatesCollection?**](SslControlWhitelistCertificatesCollection?.md) |  | [optional]  |

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

<a id="sslcontrolwhitelistcertificatesget"></a>
# **SslControlWhitelistCertificatesGet**
> SslControlWhitelistCertificatesCollection SslControlWhitelistCertificatesGet ()



Retrieve SSL control whitelist certificates configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlWhitelistCertificatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlWhitelistCertificatesApi(config);

            try
            {
                SslControlWhitelistCertificatesCollection result = apiInstance.SslControlWhitelistCertificatesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlWhitelistCertificatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslControlWhitelistCertificatesCollection> response = apiInstance.SslControlWhitelistCertificatesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SslControlWhitelistCertificatesCollection**](SslControlWhitelistCertificatesCollection.md)

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

<a id="sslcontrolwhitelistcertificatespost"></a>
# **SslControlWhitelistCertificatesPost**
> ApiStatus SslControlWhitelistCertificatesPost (SslControlWhitelistCertificatesCollection? sslControlWhitelistCertificatesCollection = null)



Add whitelist certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlWhitelistCertificatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlWhitelistCertificatesApi(config);
            var sslControlWhitelistCertificatesCollection = new SslControlWhitelistCertificatesCollection?(); // SslControlWhitelistCertificatesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslControlWhitelistCertificatesPost(sslControlWhitelistCertificatesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlWhitelistCertificatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslControlWhitelistCertificatesPostWithHttpInfo(sslControlWhitelistCertificatesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslControlWhitelistCertificatesCollection** | [**SslControlWhitelistCertificatesCollection?**](SslControlWhitelistCertificatesCollection?.md) |  | [optional]  |

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

<a id="sslcontrolwhitelistcertificatesput"></a>
# **SslControlWhitelistCertificatesPut**
> ApiStatus SslControlWhitelistCertificatesPut (SslControlWhitelistCertificatesCollection? sslControlWhitelistCertificatesCollection = null)



Edit a whitelist certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslControlWhitelistCertificatesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslControlWhitelistCertificatesApi(config);
            var sslControlWhitelistCertificatesCollection = new SslControlWhitelistCertificatesCollection?(); // SslControlWhitelistCertificatesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslControlWhitelistCertificatesPut(sslControlWhitelistCertificatesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslControlWhitelistCertificatesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslControlWhitelistCertificatesPutWithHttpInfo(sslControlWhitelistCertificatesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslControlWhitelistCertificatesApi.SslControlWhitelistCertificatesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslControlWhitelistCertificatesCollection** | [**SslControlWhitelistCertificatesCollection?**](SslControlWhitelistCertificatesCollection?.md) |  | [optional]  |

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

