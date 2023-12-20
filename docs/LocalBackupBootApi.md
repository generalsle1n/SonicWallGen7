# SonicWallGen7.Api.LocalBackupBootApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LocalBackupBootNamePREFNAMEDelayDELAYTIMEGet**](LocalBackupBootApi.md#localbackupbootnameprefnamedelaydelaytimeget) | **GET** /local-backup-boot/name/{PREFNAME}/delay/{DELAY_TIME} |  |
| [**LocalBackupBootNamePREFNAMEDelayDELAYTIMEPost**](LocalBackupBootApi.md#localbackupbootnameprefnamedelaydelaytimepost) | **POST** /local-backup-boot/name/{PREFNAME}/delay/{DELAY_TIME} |  |
| [**LocalBackupBootNamePREFNAMEGet**](LocalBackupBootApi.md#localbackupbootnameprefnameget) | **GET** /local-backup-boot/name/{PREFNAME} |  |
| [**LocalBackupBootNamePREFNAMEPost**](LocalBackupBootApi.md#localbackupbootnameprefnamepost) | **POST** /local-backup-boot/name/{PREFNAME} |  |

<a id="localbackupbootnameprefnamedelaydelaytimeget"></a>
# **LocalBackupBootNamePREFNAMEDelayDELAYTIMEGet**
> Object LocalBackupBootNamePREFNAMEDelayDELAYTIMEGet (string PREFNAME, decimal DELAY_TIME)



Show local backup boot schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LocalBackupBootNamePREFNAMEDelayDELAYTIMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LocalBackupBootApi(config);
            var PREFNAME = "\"abc\"";  // string | Local backup name. (default to "abc")
            var DELAY_TIME = 8.14D;  // decimal | Integer in the form: D OR 0xHHHH

            try
            {
                Object result = apiInstance.LocalBackupBootNamePREFNAMEDelayDELAYTIMEGet(PREFNAME, DELAY_TIME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalBackupBootApi.LocalBackupBootNamePREFNAMEDelayDELAYTIMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocalBackupBootNamePREFNAMEDelayDELAYTIMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.LocalBackupBootNamePREFNAMEDelayDELAYTIMEGetWithHttpInfo(PREFNAME, DELAY_TIME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocalBackupBootApi.LocalBackupBootNamePREFNAMEDelayDELAYTIMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PREFNAME** | **string** | Local backup name. | [default to &quot;abc&quot;] |
| **DELAY_TIME** | **decimal** | Integer in the form: D OR 0xHHHH |  |

### Return type

**Object**

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

<a id="localbackupbootnameprefnamedelaydelaytimepost"></a>
# **LocalBackupBootNamePREFNAMEDelayDELAYTIMEPost**
> ApiStatus LocalBackupBootNamePREFNAMEDelayDELAYTIMEPost (string PREFNAME, decimal DELAY_TIME, Object? body = null)



Boot local backup SonicOS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LocalBackupBootNamePREFNAMEDelayDELAYTIMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LocalBackupBootApi(config);
            var PREFNAME = "\"abc\"";  // string | Local backup name. (default to "abc")
            var DELAY_TIME = 8.14D;  // decimal | Integer in the form: D OR 0xHHHH
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LocalBackupBootNamePREFNAMEDelayDELAYTIMEPost(PREFNAME, DELAY_TIME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalBackupBootApi.LocalBackupBootNamePREFNAMEDelayDELAYTIMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocalBackupBootNamePREFNAMEDelayDELAYTIMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LocalBackupBootNamePREFNAMEDelayDELAYTIMEPostWithHttpInfo(PREFNAME, DELAY_TIME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocalBackupBootApi.LocalBackupBootNamePREFNAMEDelayDELAYTIMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PREFNAME** | **string** | Local backup name. | [default to &quot;abc&quot;] |
| **DELAY_TIME** | **decimal** | Integer in the form: D OR 0xHHHH |  |
| **body** | **Object?** |  | [optional]  |

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

<a id="localbackupbootnameprefnameget"></a>
# **LocalBackupBootNamePREFNAMEGet**
> Object LocalBackupBootNamePREFNAMEGet (string PREFNAME)



Show local backup boot schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LocalBackupBootNamePREFNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LocalBackupBootApi(config);
            var PREFNAME = "\"abc\"";  // string | Local backup name. (default to "abc")

            try
            {
                Object result = apiInstance.LocalBackupBootNamePREFNAMEGet(PREFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalBackupBootApi.LocalBackupBootNamePREFNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocalBackupBootNamePREFNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.LocalBackupBootNamePREFNAMEGetWithHttpInfo(PREFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocalBackupBootApi.LocalBackupBootNamePREFNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PREFNAME** | **string** | Local backup name. | [default to &quot;abc&quot;] |

### Return type

**Object**

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

<a id="localbackupbootnameprefnamepost"></a>
# **LocalBackupBootNamePREFNAMEPost**
> ApiStatus LocalBackupBootNamePREFNAMEPost (string PREFNAME, Object? body = null)



Boot local backup SonicOS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LocalBackupBootNamePREFNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LocalBackupBootApi(config);
            var PREFNAME = "\"abc\"";  // string | Local backup name. (default to "abc")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LocalBackupBootNamePREFNAMEPost(PREFNAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalBackupBootApi.LocalBackupBootNamePREFNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocalBackupBootNamePREFNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LocalBackupBootNamePREFNAMEPostWithHttpInfo(PREFNAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocalBackupBootApi.LocalBackupBootNamePREFNAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PREFNAME** | **string** | Local backup name. | [default to &quot;abc&quot;] |
| **body** | **Object?** |  | [optional]  |

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

