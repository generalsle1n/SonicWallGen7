# SonicWallGen7.Api.UserSsoTerminalServiceAgentStatisticApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingSsoStatisticTerminalServicesAgentsGet**](UserSsoTerminalServiceAgentStatisticApi.md#reportingssostatisticterminalservicesagentsget) | **GET** /reporting/sso-statistic/terminal-services-agents |  |
| [**ReportingSsoStatisticTerminalServicesAgentsNameNAMEDelete**](UserSsoTerminalServiceAgentStatisticApi.md#reportingssostatisticterminalservicesagentsnamenamedelete) | **DELETE** /reporting/sso-statistic/terminal-services-agents/name/{NAME} |  |
| [**ReportingSsoStatisticTerminalServicesAgentsNameNAMEGet**](UserSsoTerminalServiceAgentStatisticApi.md#reportingssostatisticterminalservicesagentsnamenameget) | **GET** /reporting/sso-statistic/terminal-services-agents/name/{NAME} |  |

<a id="reportingssostatisticterminalservicesagentsget"></a>
# **ReportingSsoStatisticTerminalServicesAgentsGet**
> List&lt;ShowStatusSsoTsaAgentListInner&gt; ReportingSsoStatisticTerminalServicesAgentsGet ()



Retrieve user SSO terminal services agent statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSsoStatisticTerminalServicesAgentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServiceAgentStatisticApi(config);

            try
            {
                List<ShowStatusSsoTsaAgentListInner> result = apiInstance.ReportingSsoStatisticTerminalServicesAgentsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServiceAgentStatisticApi.ReportingSsoStatisticTerminalServicesAgentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSsoStatisticTerminalServicesAgentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusSsoTsaAgentListInner>> response = apiInstance.ReportingSsoStatisticTerminalServicesAgentsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServiceAgentStatisticApi.ReportingSsoStatisticTerminalServicesAgentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusSsoTsaAgentListInner&gt;**](ShowStatusSsoTsaAgentListInner.md)

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

<a id="reportingssostatisticterminalservicesagentsnamenamedelete"></a>
# **ReportingSsoStatisticTerminalServicesAgentsNameNAMEDelete**
> ApiStatus ReportingSsoStatisticTerminalServicesAgentsNameNAMEDelete (string NAME)



clear user SSO terminal services agent statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSsoStatisticTerminalServicesAgentsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServiceAgentStatisticApi(config);
            var NAME = "\"SSO-Terminal-Services-Agent\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "SSO-Terminal-Services-Agent")

            try
            {
                ApiStatus result = apiInstance.ReportingSsoStatisticTerminalServicesAgentsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServiceAgentStatisticApi.ReportingSsoStatisticTerminalServicesAgentsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSsoStatisticTerminalServicesAgentsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingSsoStatisticTerminalServicesAgentsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServiceAgentStatisticApi.ReportingSsoStatisticTerminalServicesAgentsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;SSO-Terminal-Services-Agent&quot;] |

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

<a id="reportingssostatisticterminalservicesagentsnamenameget"></a>
# **ReportingSsoStatisticTerminalServicesAgentsNameNAMEGet**
> ShowStatusSsoTsaAgentDetail ReportingSsoStatisticTerminalServicesAgentsNameNAMEGet (string NAME)



Retrieve user SSO terminal services agent statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSsoStatisticTerminalServicesAgentsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServiceAgentStatisticApi(config);
            var NAME = "\"SSO-Terminal-Services-Agent\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "SSO-Terminal-Services-Agent")

            try
            {
                ShowStatusSsoTsaAgentDetail result = apiInstance.ReportingSsoStatisticTerminalServicesAgentsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServiceAgentStatisticApi.ReportingSsoStatisticTerminalServicesAgentsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSsoStatisticTerminalServicesAgentsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusSsoTsaAgentDetail> response = apiInstance.ReportingSsoStatisticTerminalServicesAgentsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServiceAgentStatisticApi.ReportingSsoStatisticTerminalServicesAgentsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;SSO-Terminal-Services-Agent&quot;] |

### Return type

[**ShowStatusSsoTsaAgentDetail**](ShowStatusSsoTsaAgentDetail.md)

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

