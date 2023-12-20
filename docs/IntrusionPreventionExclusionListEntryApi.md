# SonicWallGen7.Api.IntrusionPreventionExclusionListEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDelete**](IntrusionPreventionExclusionListEntryApi.md#intrusionpreventionexclusionlistentriesfromfromiptotoipdelete) | **DELETE** /intrusion-prevention/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGet**](IntrusionPreventionExclusionListEntryApi.md#intrusionpreventionexclusionlistentriesfromfromiptotoipget) | **GET** /intrusion-prevention/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatch**](IntrusionPreventionExclusionListEntryApi.md#intrusionpreventionexclusionlistentriesfromfromiptotoippatch) | **PATCH** /intrusion-prevention/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPut**](IntrusionPreventionExclusionListEntryApi.md#intrusionpreventionexclusionlistentriesfromfromiptotoipput) | **PUT** /intrusion-prevention/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**IntrusionPreventionExclusionListEntriesGet**](IntrusionPreventionExclusionListEntryApi.md#intrusionpreventionexclusionlistentriesget) | **GET** /intrusion-prevention/exclusion-list/entries |  |
| [**IntrusionPreventionExclusionListEntriesPatch**](IntrusionPreventionExclusionListEntryApi.md#intrusionpreventionexclusionlistentriespatch) | **PATCH** /intrusion-prevention/exclusion-list/entries |  |
| [**IntrusionPreventionExclusionListEntriesPost**](IntrusionPreventionExclusionListEntryApi.md#intrusionpreventionexclusionlistentriespost) | **POST** /intrusion-prevention/exclusion-list/entries |  |
| [**IntrusionPreventionExclusionListEntriesPut**](IntrusionPreventionExclusionListEntryApi.md#intrusionpreventionexclusionlistentriesput) | **PUT** /intrusion-prevention/exclusion-list/entries |  |

<a id="intrusionpreventionexclusionlistentriesfromfromiptotoipdelete"></a>
# **IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDelete**
> ApiStatus IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDelete (string FROMIP, string TOIP)



Delete an existing intrusion prevention exclusion entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionExclusionListEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | IPS Exclusion List entry begin IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | IPS Exclusion List entry end IPv4 in the form: D.D.D.D. (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDelete(FROMIP, TOIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo(FROMIP, TOIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | IPS Exclusion List entry begin IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | IPS Exclusion List entry end IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |

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

<a id="intrusionpreventionexclusionlistentriesfromfromiptotoipget"></a>
# **IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGet**
> IntrusionPreventionExclusionListEntryCollection IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGet (string FROMIP, string TOIP)



Retrieve intrusion prevention exclusion entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionExclusionListEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | IPS Exclusion List entry begin IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | IPS Exclusion List entry end IPv4 in the form: D.D.D.D. (default to "192.168.168.168")

            try
            {
                IntrusionPreventionExclusionListEntryCollection result = apiInstance.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGet(FROMIP, TOIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionExclusionListEntryCollection> response = apiInstance.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo(FROMIP, TOIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | IPS Exclusion List entry begin IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | IPS Exclusion List entry end IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |

### Return type

[**IntrusionPreventionExclusionListEntryCollection**](IntrusionPreventionExclusionListEntryCollection.md)

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

<a id="intrusionpreventionexclusionlistentriesfromfromiptotoippatch"></a>
# **IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatch**
> ApiStatus IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatch (string FROMIP, string TOIP, IntrusionPreventionExclusionListEntryCollection? intrusionPreventionExclusionListEntryCollection = null)



Patch intrusion prevention exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionExclusionListEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | IPS Exclusion List entry begin IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | IPS Exclusion List entry end IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var intrusionPreventionExclusionListEntryCollection = new IntrusionPreventionExclusionListEntryCollection?(); // IntrusionPreventionExclusionListEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatch(FROMIP, TOIP, intrusionPreventionExclusionListEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo(FROMIP, TOIP, intrusionPreventionExclusionListEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | IPS Exclusion List entry begin IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | IPS Exclusion List entry end IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **intrusionPreventionExclusionListEntryCollection** | [**IntrusionPreventionExclusionListEntryCollection?**](IntrusionPreventionExclusionListEntryCollection?.md) |  | [optional]  |

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

<a id="intrusionpreventionexclusionlistentriesfromfromiptotoipput"></a>
# **IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPut**
> ApiStatus IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPut (string FROMIP, string TOIP, IntrusionPreventionExclusionListEntryCollection? intrusionPreventionExclusionListEntryCollection = null)



Edit intrusion prevention exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionExclusionListEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | IPS Exclusion List entry begin IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | IPS Exclusion List entry end IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var intrusionPreventionExclusionListEntryCollection = new IntrusionPreventionExclusionListEntryCollection?(); // IntrusionPreventionExclusionListEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPut(FROMIP, TOIP, intrusionPreventionExclusionListEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo(FROMIP, TOIP, intrusionPreventionExclusionListEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | IPS Exclusion List entry begin IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | IPS Exclusion List entry end IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **intrusionPreventionExclusionListEntryCollection** | [**IntrusionPreventionExclusionListEntryCollection?**](IntrusionPreventionExclusionListEntryCollection?.md) |  | [optional]  |

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

<a id="intrusionpreventionexclusionlistentriesget"></a>
# **IntrusionPreventionExclusionListEntriesGet**
> IntrusionPreventionExclusionListEntryCollection IntrusionPreventionExclusionListEntriesGet ()



Retrieve intrusion prevention exclusion entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionExclusionListEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionExclusionListEntryApi(config);

            try
            {
                IntrusionPreventionExclusionListEntryCollection result = apiInstance.IntrusionPreventionExclusionListEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionExclusionListEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionExclusionListEntryCollection> response = apiInstance.IntrusionPreventionExclusionListEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**IntrusionPreventionExclusionListEntryCollection**](IntrusionPreventionExclusionListEntryCollection.md)

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

<a id="intrusionpreventionexclusionlistentriespatch"></a>
# **IntrusionPreventionExclusionListEntriesPatch**
> ApiStatus IntrusionPreventionExclusionListEntriesPatch (IntrusionPreventionExclusionListEntryCollection? intrusionPreventionExclusionListEntryCollection = null)



Patch intrusion prevention exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionExclusionListEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionExclusionListEntryApi(config);
            var intrusionPreventionExclusionListEntryCollection = new IntrusionPreventionExclusionListEntryCollection?(); // IntrusionPreventionExclusionListEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionExclusionListEntriesPatch(intrusionPreventionExclusionListEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionExclusionListEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionExclusionListEntriesPatchWithHttpInfo(intrusionPreventionExclusionListEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **intrusionPreventionExclusionListEntryCollection** | [**IntrusionPreventionExclusionListEntryCollection?**](IntrusionPreventionExclusionListEntryCollection?.md) |  | [optional]  |

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

<a id="intrusionpreventionexclusionlistentriespost"></a>
# **IntrusionPreventionExclusionListEntriesPost**
> ApiStatus IntrusionPreventionExclusionListEntriesPost (IntrusionPreventionExclusionListEntryCollection? intrusionPreventionExclusionListEntryCollection = null)



Create a new intrusion prevention exclusion entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionExclusionListEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionExclusionListEntryApi(config);
            var intrusionPreventionExclusionListEntryCollection = new IntrusionPreventionExclusionListEntryCollection?(); // IntrusionPreventionExclusionListEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionExclusionListEntriesPost(intrusionPreventionExclusionListEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionExclusionListEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionExclusionListEntriesPostWithHttpInfo(intrusionPreventionExclusionListEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **intrusionPreventionExclusionListEntryCollection** | [**IntrusionPreventionExclusionListEntryCollection?**](IntrusionPreventionExclusionListEntryCollection?.md) |  | [optional]  |

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

<a id="intrusionpreventionexclusionlistentriesput"></a>
# **IntrusionPreventionExclusionListEntriesPut**
> ApiStatus IntrusionPreventionExclusionListEntriesPut (IntrusionPreventionExclusionListEntryCollection? intrusionPreventionExclusionListEntryCollection = null)



Edit intrusion prevention exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionExclusionListEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionExclusionListEntryApi(config);
            var intrusionPreventionExclusionListEntryCollection = new IntrusionPreventionExclusionListEntryCollection?(); // IntrusionPreventionExclusionListEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionExclusionListEntriesPut(intrusionPreventionExclusionListEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionExclusionListEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionExclusionListEntriesPutWithHttpInfo(intrusionPreventionExclusionListEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionExclusionListEntryApi.IntrusionPreventionExclusionListEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **intrusionPreventionExclusionListEntryCollection** | [**IntrusionPreventionExclusionListEntryCollection?**](IntrusionPreventionExclusionListEntryCollection?.md) |  | [optional]  |

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

