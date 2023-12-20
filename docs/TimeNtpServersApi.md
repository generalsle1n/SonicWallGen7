# SonicWallGen7.Api.TimeNtpServersApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TimeNtpServersGet**](TimeNtpServersApi.md#timentpserversget) | **GET** /time/ntp-servers |  |
| [**TimeNtpServersNameNTPNAMEDelete**](TimeNtpServersApi.md#timentpserversnamentpnamedelete) | **DELETE** /time/ntp-servers/name/{NTPNAME} |  |
| [**TimeNtpServersNameNTPNAMEGet**](TimeNtpServersApi.md#timentpserversnamentpnameget) | **GET** /time/ntp-servers/name/{NTPNAME} |  |
| [**TimeNtpServersNameNTPNAMEPut**](TimeNtpServersApi.md#timentpserversnamentpnameput) | **PUT** /time/ntp-servers/name/{NTPNAME} |  |
| [**TimeNtpServersPost**](TimeNtpServersApi.md#timentpserverspost) | **POST** /time/ntp-servers |  |
| [**TimeNtpServersPut**](TimeNtpServersApi.md#timentpserversput) | **PUT** /time/ntp-servers |  |

<a id="timentpserversget"></a>
# **TimeNtpServersGet**
> TimeNtpServersCollection TimeNtpServersGet ()



Retrieve time NTP servers settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TimeNtpServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeNtpServersApi(config);

            try
            {
                TimeNtpServersCollection result = apiInstance.TimeNtpServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeNtpServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TimeNtpServersCollection> response = apiInstance.TimeNtpServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TimeNtpServersCollection**](TimeNtpServersCollection.md)

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

<a id="timentpserversnamentpnamedelete"></a>
# **TimeNtpServersNameNTPNAMEDelete**
> ApiStatus TimeNtpServersNameNTPNAMEDelete (string NTPNAME)



Delete a time NTP server object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TimeNtpServersNameNTPNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeNtpServersApi(config);
            var NTPNAME = "\"2001:cdba:0000:0000:0000:0000:3257:9652 \"";  // string | IPV4: hostname in the form: D.D.D.D or hostname IPV6: host address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652
")

            try
            {
                ApiStatus result = apiInstance.TimeNtpServersNameNTPNAMEDelete(NTPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersNameNTPNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeNtpServersNameNTPNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TimeNtpServersNameNTPNAMEDeleteWithHttpInfo(NTPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersNameNTPNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NTPNAME** | **string** | IPV4: hostname in the form: D.D.D.D or hostname IPV6: host address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652
&quot;] |

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

<a id="timentpserversnamentpnameget"></a>
# **TimeNtpServersNameNTPNAMEGet**
> TimeNtpServersCollection TimeNtpServersNameNTPNAMEGet (string NTPNAME)



Retrieve time NTP servers settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TimeNtpServersNameNTPNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeNtpServersApi(config);
            var NTPNAME = "\"2001:cdba:0000:0000:0000:0000:3257:9652 \"";  // string | IPV4: hostname in the form: D.D.D.D or hostname IPV6: host address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652
")

            try
            {
                TimeNtpServersCollection result = apiInstance.TimeNtpServersNameNTPNAMEGet(NTPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersNameNTPNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeNtpServersNameNTPNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TimeNtpServersCollection> response = apiInstance.TimeNtpServersNameNTPNAMEGetWithHttpInfo(NTPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersNameNTPNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NTPNAME** | **string** | IPV4: hostname in the form: D.D.D.D or hostname IPV6: host address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652
&quot;] |

### Return type

[**TimeNtpServersCollection**](TimeNtpServersCollection.md)

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

<a id="timentpserversnamentpnameput"></a>
# **TimeNtpServersNameNTPNAMEPut**
> ApiStatus TimeNtpServersNameNTPNAMEPut (string NTPNAME, TimeNtpServersCollection? timeNtpServersCollection = null)



Update time NTP server settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TimeNtpServersNameNTPNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeNtpServersApi(config);
            var NTPNAME = "\"2001:cdba:0000:0000:0000:0000:3257:9652 \"";  // string | IPV4: hostname in the form: D.D.D.D or hostname IPV6: host address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652
")
            var timeNtpServersCollection = new TimeNtpServersCollection?(); // TimeNtpServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TimeNtpServersNameNTPNAMEPut(NTPNAME, timeNtpServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersNameNTPNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeNtpServersNameNTPNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TimeNtpServersNameNTPNAMEPutWithHttpInfo(NTPNAME, timeNtpServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersNameNTPNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NTPNAME** | **string** | IPV4: hostname in the form: D.D.D.D or hostname IPV6: host address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652
&quot;] |
| **timeNtpServersCollection** | [**TimeNtpServersCollection?**](TimeNtpServersCollection?.md) |  | [optional]  |

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

<a id="timentpserverspost"></a>
# **TimeNtpServersPost**
> ApiStatus TimeNtpServersPost (TimeNtpServersCollection? timeNtpServersCollection = null)



Create a new time NTP server object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TimeNtpServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeNtpServersApi(config);
            var timeNtpServersCollection = new TimeNtpServersCollection?(); // TimeNtpServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TimeNtpServersPost(timeNtpServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeNtpServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TimeNtpServersPostWithHttpInfo(timeNtpServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timeNtpServersCollection** | [**TimeNtpServersCollection?**](TimeNtpServersCollection?.md) |  | [optional]  |

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

<a id="timentpserversput"></a>
# **TimeNtpServersPut**
> ApiStatus TimeNtpServersPut (TimeNtpServersCollection? timeNtpServersCollection = null)



Update time NTP server settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TimeNtpServersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeNtpServersApi(config);
            var timeNtpServersCollection = new TimeNtpServersCollection?(); // TimeNtpServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TimeNtpServersPut(timeNtpServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeNtpServersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TimeNtpServersPutWithHttpInfo(timeNtpServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeNtpServersApi.TimeNtpServersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timeNtpServersCollection** | [**TimeNtpServersCollection?**](TimeNtpServersCollection?.md) |  | [optional]  |

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

