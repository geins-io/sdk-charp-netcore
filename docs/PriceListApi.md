# Org.OpenAPITools.Api.PriceListApi

All URIs are relative to *https://mgmtapi.carismar.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListPriceLists**](PriceListApi.md#listpricelists) | **GET** /API/PriceList/List | Get all price list definitions |
| [**UpdatePricelistPrices**](PriceListApi.md#updatepricelistprices) | **PUT** /API/PriceList/Price | Updates price list prices |

<a name="listpricelists"></a>
# **ListPriceLists**
> List&lt;PriceListModelsPriceList&gt; ListPriceLists ()

Get all price list definitions

- Prices on campaign price lists (id: xxxxxx2) can not be updated. Any such entries will be ignored.  - ID for Ordinary, Sale and Campaign price lists starts from 1000000.   The ID is calculated by this formula, Market ID * 1000000 + Type of price list (Ordinary=0, Sale=1, Capaign=2)  So :  Ordinary price list for market with ID 1 has ID = 1000000  Sale price list for market with ID 1 has ID = 1000001  Campaign price list for market with ID 1 has ID = 1000002  Ordinary price list for market with ID 2 has ID = 2000000  And so on ...

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListPriceListsExample
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

            var apiInstance = new PriceListApi(config);

            try
            {
                // Get all price list definitions
                List<PriceListModelsPriceList> result = apiInstance.ListPriceLists();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.ListPriceLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPriceListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all price list definitions
    ApiResponse<List<PriceListModelsPriceList>> response = apiInstance.ListPriceListsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.ListPriceListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PriceListModelsPriceList&gt;**](PriceListModelsPriceList.md)

### Authorization

[apiKey](../README.md#apiKey), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepricelistprices"></a>
# **UpdatePricelistPrices**
> PriceListModelsPriceListPriceResponse UpdatePricelistPrices (List<PriceListModelsWritePriceListPrice> priceListPrices, int? productIdType = null, bool? pricesIncVat = null)

Updates price list prices

- Prices on campaign price lists (id: xxxxxx2) can not be updated. Any such entries will be ignored.  - ID for Ordinary, Sale and Campaign price lists starts from 1000000.   The ID is calculated by this formula, Market ID * 1000000 + Type of price list (Ordinary=0, Sale=1, Capaign=2)  So :  Ordinary price list for market with ID 1 has ID = 1000000  Sale price list for market with ID 1 has ID = 1000001  Campaign price list for market with ID 1 has ID = 1000002  Ordinary price list for market with ID 2 has ID = 2000000  And so on ...

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdatePricelistPricesExample
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

            var apiInstance = new PriceListApi(config);
            var priceListPrices = new List<PriceListModelsWritePriceListPrice>(); // List<PriceListModelsWritePriceListPrice> | List of new price list prices.
            var productIdType = 0;  // int? | The type of product id supplied in {priceListPrices} (optional) 
            var pricesIncVat = true;  // bool? | Set to true if prices in {priceListPrices} includes VAT. Leave blank or set to false if they exclude VAT. (optional) 

            try
            {
                // Updates price list prices
                PriceListModelsPriceListPriceResponse result = apiInstance.UpdatePricelistPrices(priceListPrices, productIdType, pricesIncVat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.UpdatePricelistPrices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePricelistPricesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates price list prices
    ApiResponse<PriceListModelsPriceListPriceResponse> response = apiInstance.UpdatePricelistPricesWithHttpInfo(priceListPrices, productIdType, pricesIncVat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.UpdatePricelistPricesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **priceListPrices** | [**List&lt;PriceListModelsWritePriceListPrice&gt;**](PriceListModelsWritePriceListPrice.md) | List of new price list prices. |  |
| **productIdType** | **int?** | The type of product id supplied in {priceListPrices} | [optional]  |
| **pricesIncVat** | **bool?** | Set to true if prices in {priceListPrices} includes VAT. Leave blank or set to false if they exclude VAT. | [optional]  |

### Return type

[**PriceListModelsPriceListPriceResponse**](PriceListModelsPriceListPriceResponse.md)

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

