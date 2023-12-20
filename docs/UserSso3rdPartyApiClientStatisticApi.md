# SonicWallGen7.Api.UserSso3rdPartyApiClientStatisticApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingSsoStatisticThirdPartyApiClientsGet**](UserSso3rdPartyApiClientStatisticApi.md#reportingssostatisticthirdpartyapiclientsget) | **GET** /reporting/sso-statistic/third-party-api-clients |  |
| [**ReportingSsoStatisticThirdPartyApiClientsNameNAMEDelete**](UserSso3rdPartyApiClientStatisticApi.md#reportingssostatisticthirdpartyapiclientsnamenamedelete) | **DELETE** /reporting/sso-statistic/third-party-api-clients/name/{NAME} |  |
| [**ReportingSsoStatisticThirdPartyApiClientsNameNAMEGet**](UserSso3rdPartyApiClientStatisticApi.md#reportingssostatisticthirdpartyapiclientsnamenameget) | **GET** /reporting/sso-statistic/third-party-api-clients/name/{NAME} |  |

<a id="reportingssostatisticthirdpartyapiclientsget"></a>
# **ReportingSsoStatisticThirdPartyApiClientsGet**
> List&lt;ShowStatusThirdPartyApiClientListInner&gt; ReportingSsoStatisticThirdPartyApiClientsGet ()



Retrieve user SSO third party api client statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSsoStatisticThirdPartyApiClientsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientStatisticApi(config);

            try
            {
                List<ShowStatusThirdPartyApiClientListInner> result = apiInstance.ReportingSsoStatisticThirdPartyApiClientsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientStatisticApi.ReportingSsoStatisticThirdPartyApiClientsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSsoStatisticThirdPartyApiClientsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusThirdPartyApiClientListInner>> response = apiInstance.ReportingSsoStatisticThirdPartyApiClientsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientStatisticApi.ReportingSsoStatisticThirdPartyApiClientsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusThirdPartyApiClientListInner&gt;**](ShowStatusThirdPartyApiClientListInner.md)

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

<a id="reportingssostatisticthirdpartyapiclientsnamenamedelete"></a>
# **ReportingSsoStatisticThirdPartyApiClientsNameNAMEDelete**
> ApiStatus ReportingSsoStatisticThirdPartyApiClientsNameNAMEDelete (string NAME)



clear user SSO third party api client statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSsoStatisticThirdPartyApiClientsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientStatisticApi(config);
            var NAME = "\"abc\"";  // string | SSO third party api client host name. (default to "abc")

            try
            {
                ApiStatus result = apiInstance.ReportingSsoStatisticThirdPartyApiClientsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientStatisticApi.ReportingSsoStatisticThirdPartyApiClientsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSsoStatisticThirdPartyApiClientsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingSsoStatisticThirdPartyApiClientsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientStatisticApi.ReportingSsoStatisticThirdPartyApiClientsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | SSO third party api client host name. | [default to &quot;abc&quot;] |

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

<a id="reportingssostatisticthirdpartyapiclientsnamenameget"></a>
# **ReportingSsoStatisticThirdPartyApiClientsNameNAMEGet**
> ShowStatusThirdPartyApiClientDetail ReportingSsoStatisticThirdPartyApiClientsNameNAMEGet (string NAME)



Retrieve user SSO third party api client statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSsoStatisticThirdPartyApiClientsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientStatisticApi(config);
            var NAME = "\"abc\"";  // string | SSO third party api client host name. (default to "abc")

            try
            {
                ShowStatusThirdPartyApiClientDetail result = apiInstance.ReportingSsoStatisticThirdPartyApiClientsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientStatisticApi.ReportingSsoStatisticThirdPartyApiClientsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSsoStatisticThirdPartyApiClientsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusThirdPartyApiClientDetail> response = apiInstance.ReportingSsoStatisticThirdPartyApiClientsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientStatisticApi.ReportingSsoStatisticThirdPartyApiClientsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | SSO third party api client host name. | [default to &quot;abc&quot;] |

### Return type

[**ShowStatusThirdPartyApiClientDetail**](ShowStatusThirdPartyApiClientDetail.md)

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

