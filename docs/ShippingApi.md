# Org.OpenAPITools.Api.ShippingApi

All URIs are relative to *https://mgmtapi.geins.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateParcelGroup**](ShippingApi.md#createparcelgroup) | **POST** /API/Shipping/ParcelGroup | Create a new parcel group |
| [**QueryShippingOptions**](ShippingApi.md#queryshippingoptions) | **POST** /API/Shipping/Query | Query shipping options |

<a name="createparcelgroup"></a>
# **CreateParcelGroup**
> EnvelopeInt CreateParcelGroup (ShippingModelsParcelGroupOptions parcelGroupOptions)

Create a new parcel group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateParcelGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShippingApi(config);
            var parcelGroupOptions = new ShippingModelsParcelGroupOptions(); // ShippingModelsParcelGroupOptions | Options for the new parcel group.

            try
            {
                // Create a new parcel group
                EnvelopeInt result = apiInstance.CreateParcelGroup(parcelGroupOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingApi.CreateParcelGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateParcelGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new parcel group
    ApiResponse<EnvelopeInt> response = apiInstance.CreateParcelGroupWithHttpInfo(parcelGroupOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingApi.CreateParcelGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parcelGroupOptions** | [**ShippingModelsParcelGroupOptions**](ShippingModelsParcelGroupOptions.md) | Options for the new parcel group. |  |

### Return type

[**EnvelopeInt**](EnvelopeInt.md)

### Authorization

[apiKey](../README.md#apiKey), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryshippingoptions"></a>
# **QueryShippingOptions**
> List&lt;ShippingModelsShippingOption&gt; QueryShippingOptions (ShippingModelsShippingQuery shippingQuery)

Query shipping options

No response envelope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QueryShippingOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShippingApi(config);
            var shippingQuery = new ShippingModelsShippingQuery(); // ShippingModelsShippingQuery | The query to filter shipping options by.

            try
            {
                // Query shipping options
                List<ShippingModelsShippingOption> result = apiInstance.QueryShippingOptions(shippingQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingApi.QueryShippingOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryShippingOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query shipping options
    ApiResponse<List<ShippingModelsShippingOption>> response = apiInstance.QueryShippingOptionsWithHttpInfo(shippingQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingApi.QueryShippingOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shippingQuery** | [**ShippingModelsShippingQuery**](ShippingModelsShippingQuery.md) | The query to filter shipping options by. |  |

### Return type

[**List&lt;ShippingModelsShippingOption&gt;**](ShippingModelsShippingOption.md)

### Authorization

[apiKey](../README.md#apiKey), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

