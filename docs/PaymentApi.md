# Org.OpenAPITools.Api.PaymentApi

All URIs are relative to *https://mgmtapi.carismar.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**QueryPaymentOptions**](PaymentApi.md#querypaymentoptions) | **POST** /API/Payment/Query | Query payment options |

<a name="querypaymentoptions"></a>
# **QueryPaymentOptions**
> List&lt;PaymentModelsPaymentOption&gt; QueryPaymentOptions (PaymentModelsPaymentOptionQuery query)

Query payment options

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QueryPaymentOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.carismar.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PaymentApi(config);
            var query = new PaymentModelsPaymentOptionQuery(); // PaymentModelsPaymentOptionQuery | The payment query

            try
            {
                // Query payment options
                List<PaymentModelsPaymentOption> result = apiInstance.QueryPaymentOptions(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentApi.QueryPaymentOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryPaymentOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query payment options
    ApiResponse<List<PaymentModelsPaymentOption>> response = apiInstance.QueryPaymentOptionsWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentApi.QueryPaymentOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**PaymentModelsPaymentOptionQuery**](PaymentModelsPaymentOptionQuery.md) | The payment query |  |

### Return type

[**List&lt;PaymentModelsPaymentOption&gt;**](PaymentModelsPaymentOption.md)

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

