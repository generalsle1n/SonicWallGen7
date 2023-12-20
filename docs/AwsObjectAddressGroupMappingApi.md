# SonicWallGen7.Api.AwsObjectAddressGroupMappingApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AmazonWebServicesObjectsGroupMappingsGet**](AwsObjectAddressGroupMappingApi.md#amazonwebservicesobjectsgroupmappingsget) | **GET** /amazon-web-services/objects/group-mappings |  |
| [**AmazonWebServicesObjectsGroupMappingsIndexINDEXDelete**](AwsObjectAddressGroupMappingApi.md#amazonwebservicesobjectsgroupmappingsindexindexdelete) | **DELETE** /amazon-web-services/objects/group-mappings/index/{INDEX} |  |
| [**AmazonWebServicesObjectsGroupMappingsIndexINDEXGet**](AwsObjectAddressGroupMappingApi.md#amazonwebservicesobjectsgroupmappingsindexindexget) | **GET** /amazon-web-services/objects/group-mappings/index/{INDEX} |  |
| [**AmazonWebServicesObjectsGroupMappingsIndexINDEXPut**](AwsObjectAddressGroupMappingApi.md#amazonwebservicesobjectsgroupmappingsindexindexput) | **PUT** /amazon-web-services/objects/group-mappings/index/{INDEX} |  |
| [**AmazonWebServicesObjectsGroupMappingsPost**](AwsObjectAddressGroupMappingApi.md#amazonwebservicesobjectsgroupmappingspost) | **POST** /amazon-web-services/objects/group-mappings |  |
| [**AmazonWebServicesObjectsGroupMappingsPut**](AwsObjectAddressGroupMappingApi.md#amazonwebservicesobjectsgroupmappingsput) | **PUT** /amazon-web-services/objects/group-mappings |  |

<a id="amazonwebservicesobjectsgroupmappingsget"></a>
# **AmazonWebServicesObjectsGroupMappingsGet**
> AwsObjectAddressGroupMappingCollection AmazonWebServicesObjectsGroupMappingsGet ()



Retrieve amazon web services object address group mapping configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AmazonWebServicesObjectsGroupMappingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AwsObjectAddressGroupMappingApi(config);

            try
            {
                AwsObjectAddressGroupMappingCollection result = apiInstance.AmazonWebServicesObjectsGroupMappingsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AmazonWebServicesObjectsGroupMappingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AwsObjectAddressGroupMappingCollection> response = apiInstance.AmazonWebServicesObjectsGroupMappingsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AwsObjectAddressGroupMappingCollection**](AwsObjectAddressGroupMappingCollection.md)

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

<a id="amazonwebservicesobjectsgroupmappingsindexindexdelete"></a>
# **AmazonWebServicesObjectsGroupMappingsIndexINDEXDelete**
> ApiStatus AmazonWebServicesObjectsGroupMappingsIndexINDEXDelete (decimal INDEX)



Delete amazon web services object address group mapping configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AmazonWebServicesObjectsGroupMappingsIndexINDEXDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AwsObjectAddressGroupMappingApi(config);
            var INDEX = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH

            try
            {
                ApiStatus result = apiInstance.AmazonWebServicesObjectsGroupMappingsIndexINDEXDelete(INDEX);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsIndexINDEXDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AmazonWebServicesObjectsGroupMappingsIndexINDEXDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AmazonWebServicesObjectsGroupMappingsIndexINDEXDeleteWithHttpInfo(INDEX);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsIndexINDEXDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INDEX** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |

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

<a id="amazonwebservicesobjectsgroupmappingsindexindexget"></a>
# **AmazonWebServicesObjectsGroupMappingsIndexINDEXGet**
> AwsObjectAddressGroupMappingCollection AmazonWebServicesObjectsGroupMappingsIndexINDEXGet (decimal INDEX)



Retrieve amazon web services object address group mapping configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AmazonWebServicesObjectsGroupMappingsIndexINDEXGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AwsObjectAddressGroupMappingApi(config);
            var INDEX = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH

            try
            {
                AwsObjectAddressGroupMappingCollection result = apiInstance.AmazonWebServicesObjectsGroupMappingsIndexINDEXGet(INDEX);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsIndexINDEXGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AmazonWebServicesObjectsGroupMappingsIndexINDEXGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AwsObjectAddressGroupMappingCollection> response = apiInstance.AmazonWebServicesObjectsGroupMappingsIndexINDEXGetWithHttpInfo(INDEX);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsIndexINDEXGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INDEX** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |

### Return type

[**AwsObjectAddressGroupMappingCollection**](AwsObjectAddressGroupMappingCollection.md)

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

<a id="amazonwebservicesobjectsgroupmappingsindexindexput"></a>
# **AmazonWebServicesObjectsGroupMappingsIndexINDEXPut**
> ApiStatus AmazonWebServicesObjectsGroupMappingsIndexINDEXPut (decimal INDEX, AwsObjectAddressGroupMappingCollection? awsObjectAddressGroupMappingCollection = null)



Update amazon web services object address group mapping configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AmazonWebServicesObjectsGroupMappingsIndexINDEXPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AwsObjectAddressGroupMappingApi(config);
            var INDEX = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH
            var awsObjectAddressGroupMappingCollection = new AwsObjectAddressGroupMappingCollection?(); // AwsObjectAddressGroupMappingCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AmazonWebServicesObjectsGroupMappingsIndexINDEXPut(INDEX, awsObjectAddressGroupMappingCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsIndexINDEXPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AmazonWebServicesObjectsGroupMappingsIndexINDEXPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AmazonWebServicesObjectsGroupMappingsIndexINDEXPutWithHttpInfo(INDEX, awsObjectAddressGroupMappingCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsIndexINDEXPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INDEX** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |
| **awsObjectAddressGroupMappingCollection** | [**AwsObjectAddressGroupMappingCollection?**](AwsObjectAddressGroupMappingCollection?.md) |  | [optional]  |

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

<a id="amazonwebservicesobjectsgroupmappingspost"></a>
# **AmazonWebServicesObjectsGroupMappingsPost**
> ApiStatus AmazonWebServicesObjectsGroupMappingsPost (AwsObjectAddressGroupMappingCollection? awsObjectAddressGroupMappingCollection = null)



Create amazon web services object address group mapping configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AmazonWebServicesObjectsGroupMappingsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AwsObjectAddressGroupMappingApi(config);
            var awsObjectAddressGroupMappingCollection = new AwsObjectAddressGroupMappingCollection?(); // AwsObjectAddressGroupMappingCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AmazonWebServicesObjectsGroupMappingsPost(awsObjectAddressGroupMappingCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AmazonWebServicesObjectsGroupMappingsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AmazonWebServicesObjectsGroupMappingsPostWithHttpInfo(awsObjectAddressGroupMappingCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **awsObjectAddressGroupMappingCollection** | [**AwsObjectAddressGroupMappingCollection?**](AwsObjectAddressGroupMappingCollection?.md) |  | [optional]  |

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

<a id="amazonwebservicesobjectsgroupmappingsput"></a>
# **AmazonWebServicesObjectsGroupMappingsPut**
> ApiStatus AmazonWebServicesObjectsGroupMappingsPut (AwsObjectAddressGroupMappingCollection? awsObjectAddressGroupMappingCollection = null)



Update amazon web services object address group mapping configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AmazonWebServicesObjectsGroupMappingsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AwsObjectAddressGroupMappingApi(config);
            var awsObjectAddressGroupMappingCollection = new AwsObjectAddressGroupMappingCollection?(); // AwsObjectAddressGroupMappingCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AmazonWebServicesObjectsGroupMappingsPut(awsObjectAddressGroupMappingCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AmazonWebServicesObjectsGroupMappingsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AmazonWebServicesObjectsGroupMappingsPutWithHttpInfo(awsObjectAddressGroupMappingCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AwsObjectAddressGroupMappingApi.AmazonWebServicesObjectsGroupMappingsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **awsObjectAddressGroupMappingCollection** | [**AwsObjectAddressGroupMappingCollection?**](AwsObjectAddressGroupMappingCollection?.md) |  | [optional]  |

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

