# Org.OpenAPITools.Api.OrderApi

All URIs are relative to *https://mgmtapi.carismar.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddCommentToOrder**](OrderApi.md#addcommenttoorder) | **POST** /API/Order/{id}/Comment | Adds a comment to the order |
| [**CreateOrder**](OrderApi.md#createorder) | **POST** /API/Order | Post a new order |
| [**CreateOrderId**](OrderApi.md#createorderid) | **POST** /API/Order/Id | Create a new order id |
| [**DeleteOrder**](OrderApi.md#deleteorder) | **DELETE** /API/Order/{id} | Deletes or deactivates an order |
| [**GetCaptureById**](OrderApi.md#getcapturebyid) | **GET** /API/Order/Capture/{captureId} | Get Capture by Id |
| [**GetOrderById**](OrderApi.md#getorderbyid) | **GET** /API/Order/{id}/{include} | Get an instance of a order |
| [**GetOrderStatuses**](OrderApi.md#getorderstatuses) | **GET** /API/Order/Statuses | Get a list of available order statuses |
| [**GetRefundById**](OrderApi.md#getrefundbyid) | **GET** /API/Order/Refund/{refundId} | Get Refund by Id |
| [**PartialUpdateOfOrder**](OrderApi.md#partialupdateoforder) | **PATCH** /API/Order/{id} | Partial update of an order |
| [**QueryOrders**](OrderApi.md#queryorders) | **POST** /API/Order/Query | Query the order repository |
| [**SetCaptureAsProcessed**](OrderApi.md#setcaptureasprocessed) | **POST** /API/Order/Capture/SetAsProcessed | Set a capture as processed (&#x3D; captured) |
| [**SetPaymentAsPayed**](OrderApi.md#setpaymentaspayed) | **POST** /API/Order/PaymentDetail/{paymentDetailId}/SetAsPayed | Set Payment Detail as payed |
| [**SetRefundAsProcessed**](OrderApi.md#setrefundasprocessed) | **POST** /API/Order/Refund/SetAsProcessed | Set a refund as processed (&#x3D; settled) |
| [**UpdateOrderStatus**](OrderApi.md#updateorderstatus) | **POST** /API/Order/{id}/Status/{status}/{transactionId}/{secondaryTransactionId} | Update order status |
| [**UpdateTransactionData**](OrderApi.md#updatetransactiondata) | **POST** /API/Order/{id}/TransactionData | Updates transaction data on an order |
| [**ValidateOrder**](OrderApi.md#validateorder) | **POST** /API/Order/ValidateCreation | Validates order data for order creation. |

<a name="addcommenttoorder"></a>
# **AddCommentToOrder**
> Object AddCommentToOrder (int id, APIOrderOrderComment orderComment)

Adds a comment to the order

This add to (not replace) any previous comments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddCommentToOrderExample
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

            var apiInstance = new OrderApi(config);
            var id = 56;  // int | Order ID.
            var orderComment = new APIOrderOrderComment(); // APIOrderOrderComment | The comment

            try
            {
                // Adds a comment to the order
                Object result = apiInstance.AddCommentToOrder(id, orderComment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AddCommentToOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddCommentToOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a comment to the order
    ApiResponse<Object> response = apiInstance.AddCommentToOrderWithHttpInfo(id, orderComment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.AddCommentToOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Order ID. |  |
| **orderComment** | [**APIOrderOrderComment**](APIOrderOrderComment.md) | The comment |  |

### Return type

**Object**

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

<a name="createorder"></a>
# **CreateOrder**
> EnvelopeInt CreateOrder (OrderModelsOrder order)

Post a new order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOrderExample
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

            var apiInstance = new OrderApi(config);
            var order = new OrderModelsOrder(); // OrderModelsOrder | The order object.

            try
            {
                // Post a new order
                EnvelopeInt result = apiInstance.CreateOrder(order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Post a new order
    ApiResponse<EnvelopeInt> response = apiInstance.CreateOrderWithHttpInfo(order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **order** | [**OrderModelsOrder**](OrderModelsOrder.md) | The order object. |  |

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

<a name="createorderid"></a>
# **CreateOrderId**
> EnvelopeInt CreateOrderId ()

Create a new order id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOrderIdExample
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

            var apiInstance = new OrderApi(config);

            try
            {
                // Create a new order id
                EnvelopeInt result = apiInstance.CreateOrderId();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateOrderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new order id
    ApiResponse<EnvelopeInt> response = apiInstance.CreateOrderIdWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateOrderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EnvelopeInt**](EnvelopeInt.md)

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

<a name="deleteorder"></a>
# **DeleteOrder**
> Object DeleteOrder (int id, int operation)

Deletes or deactivates an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteOrderExample
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

            var apiInstance = new OrderApi(config);
            var id = 56;  // int | The ID of the order to delete.
            var operation = 0;  // int | The method of deletion desired.

            try
            {
                // Deletes or deactivates an order
                Object result = apiInstance.DeleteOrder(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.DeleteOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes or deactivates an order
    ApiResponse<Object> response = apiInstance.DeleteOrderWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.DeleteOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the order to delete. |  |
| **operation** | **int** | The method of deletion desired. |  |

### Return type

**Object**

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

<a name="getcapturebyid"></a>
# **GetCaptureById**
> OrderCapture GetCaptureById (Guid captureId)

Get Capture by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCaptureByIdExample
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

            var apiInstance = new OrderApi(config);
            var captureId = "captureId_example";  // Guid | Capture ID.

            try
            {
                // Get Capture by Id
                OrderCapture result = apiInstance.GetCaptureById(captureId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetCaptureById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCaptureByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Capture by Id
    ApiResponse<OrderCapture> response = apiInstance.GetCaptureByIdWithHttpInfo(captureId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetCaptureByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **captureId** | **Guid** | Capture ID. |  |

### Return type

[**OrderCapture**](OrderCapture.md)

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

<a name="getorderbyid"></a>
# **GetOrderById**
> OrderModelsOrder GetOrderById (int id, string include, bool? combineProductContainerRows = null)

Get an instance of a order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOrderByIdExample
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

            var apiInstance = new OrderApi(config);
            var id = 56;  // int | The ID of the order to get.
            var include = "include_example";  // string | A comma separated string of what related collections to include with this result set. The  possible values are: rows, paymentdetails, shippingdetails and refunds.
            var combineProductContainerRows = true;  // bool? | If true, will combine all order rows that are part of a container into a single container row. (optional) 

            try
            {
                // Get an instance of a order
                OrderModelsOrder result = apiInstance.GetOrderById(id, include, combineProductContainerRows);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an instance of a order
    ApiResponse<OrderModelsOrder> response = apiInstance.GetOrderByIdWithHttpInfo(id, include, combineProductContainerRows);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetOrderByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the order to get. |  |
| **include** | **string** | A comma separated string of what related collections to include with this result set. The  possible values are: rows, paymentdetails, shippingdetails and refunds. |  |
| **combineProductContainerRows** | **bool?** | If true, will combine all order rows that are part of a container into a single container row. | [optional]  |

### Return type

[**OrderModelsOrder**](OrderModelsOrder.md)

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

<a name="getorderstatuses"></a>
# **GetOrderStatuses**
> List&lt;OrderModelsOrderStatus&gt; GetOrderStatuses ()

Get a list of available order statuses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOrderStatusesExample
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

            var apiInstance = new OrderApi(config);

            try
            {
                // Get a list of available order statuses
                List<OrderModelsOrderStatus> result = apiInstance.GetOrderStatuses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderStatuses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderStatusesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of available order statuses
    ApiResponse<List<OrderModelsOrderStatus>> response = apiInstance.GetOrderStatusesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetOrderStatusesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;OrderModelsOrderStatus&gt;**](OrderModelsOrderStatus.md)

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

<a name="getrefundbyid"></a>
# **GetRefundById**
> OrderRefund GetRefundById (Guid refundId)

Get Refund by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRefundByIdExample
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

            var apiInstance = new OrderApi(config);
            var refundId = "refundId_example";  // Guid | Refund ID.

            try
            {
                // Get Refund by Id
                OrderRefund result = apiInstance.GetRefundById(refundId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetRefundById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRefundByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Refund by Id
    ApiResponse<OrderRefund> response = apiInstance.GetRefundByIdWithHttpInfo(refundId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetRefundByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refundId** | **Guid** | Refund ID. |  |

### Return type

[**OrderRefund**](OrderRefund.md)

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

<a name="partialupdateoforder"></a>
# **PartialUpdateOfOrder**
> Object PartialUpdateOfOrder (int id, OrderModelsOrderUpdate order)

Partial update of an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PartialUpdateOfOrderExample
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

            var apiInstance = new OrderApi(config);
            var id = 56;  // int | The orderId of the order to update
            var order = new OrderModelsOrderUpdate(); // OrderModelsOrderUpdate | The order object containing the properties that should be updated.

            try
            {
                // Partial update of an order
                Object result = apiInstance.PartialUpdateOfOrder(id, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.PartialUpdateOfOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PartialUpdateOfOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Partial update of an order
    ApiResponse<Object> response = apiInstance.PartialUpdateOfOrderWithHttpInfo(id, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.PartialUpdateOfOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The orderId of the order to update |  |
| **order** | [**OrderModelsOrderUpdate**](OrderModelsOrderUpdate.md) | The order object containing the properties that should be updated. |  |

### Return type

**Object**

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

<a name="queryorders"></a>
# **QueryOrders**
> List&lt;OrderModelsOrder&gt; QueryOrders (OrderModelsOrderQuery query)

Query the order repository

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QueryOrdersExample
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

            var apiInstance = new OrderApi(config);
            var query = new OrderModelsOrderQuery(); // OrderModelsOrderQuery | The details of the query.

            try
            {
                // Query the order repository
                List<OrderModelsOrder> result = apiInstance.QueryOrders(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.QueryOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query the order repository
    ApiResponse<List<OrderModelsOrder>> response = apiInstance.QueryOrdersWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.QueryOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**OrderModelsOrderQuery**](OrderModelsOrderQuery.md) | The details of the query. |  |

### Return type

[**List&lt;OrderModelsOrder&gt;**](OrderModelsOrder.md)

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

<a name="setcaptureasprocessed"></a>
# **SetCaptureAsProcessed**
> Object SetCaptureAsProcessed (OrderProcessedCapture processedCapture)

Set a capture as processed (= captured)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SetCaptureAsProcessedExample
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

            var apiInstance = new OrderApi(config);
            var processedCapture = new OrderProcessedCapture(); // OrderProcessedCapture | Contains CaptureId and optional metadata about capture.

            try
            {
                // Set a capture as processed (= captured)
                Object result = apiInstance.SetCaptureAsProcessed(processedCapture);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SetCaptureAsProcessed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetCaptureAsProcessedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a capture as processed (= captured)
    ApiResponse<Object> response = apiInstance.SetCaptureAsProcessedWithHttpInfo(processedCapture);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.SetCaptureAsProcessedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processedCapture** | [**OrderProcessedCapture**](OrderProcessedCapture.md) | Contains CaptureId and optional metadata about capture. |  |

### Return type

**Object**

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

<a name="setpaymentaspayed"></a>
# **SetPaymentAsPayed**
> Object SetPaymentAsPayed (int paymentDetailId)

Set Payment Detail as payed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SetPaymentAsPayedExample
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

            var apiInstance = new OrderApi(config);
            var paymentDetailId = 56;  // int | Payment Detail ID.

            try
            {
                // Set Payment Detail as payed
                Object result = apiInstance.SetPaymentAsPayed(paymentDetailId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SetPaymentAsPayed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPaymentAsPayedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Payment Detail as payed
    ApiResponse<Object> response = apiInstance.SetPaymentAsPayedWithHttpInfo(paymentDetailId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.SetPaymentAsPayedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentDetailId** | **int** | Payment Detail ID. |  |

### Return type

**Object**

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

<a name="setrefundasprocessed"></a>
# **SetRefundAsProcessed**
> Object SetRefundAsProcessed (OrderProcessedRefund processedRefund)

Set a refund as processed (= settled)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SetRefundAsProcessedExample
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

            var apiInstance = new OrderApi(config);
            var processedRefund = new OrderProcessedRefund(); // OrderProcessedRefund | Contains RefundId and optional metadata about refund.

            try
            {
                // Set a refund as processed (= settled)
                Object result = apiInstance.SetRefundAsProcessed(processedRefund);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SetRefundAsProcessed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetRefundAsProcessedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a refund as processed (= settled)
    ApiResponse<Object> response = apiInstance.SetRefundAsProcessedWithHttpInfo(processedRefund);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.SetRefundAsProcessedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processedRefund** | [**OrderProcessedRefund**](OrderProcessedRefund.md) | Contains RefundId and optional metadata about refund. |  |

### Return type

**Object**

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

<a name="updateorderstatus"></a>
# **UpdateOrderStatus**
> Object UpdateOrderStatus (int id, int status, string transactionId, string secondaryTransactionId)

Update order status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrderStatusExample
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

            var apiInstance = new OrderApi(config);
            var id = 56;  // int | Order ID.
            var status = 0;  // int | Order status. These statuses can be set: cancelled, on-hold, inactive, out-of-stock,  backorder, completed, pending.
            var transactionId = "transactionId_example";  // string | A transaction id can be set here if status is set to pending.
            var secondaryTransactionId = "secondaryTransactionId_example";  // string | A secondary transaction id, if any, can be set here if status is set to pending.

            try
            {
                // Update order status
                Object result = apiInstance.UpdateOrderStatus(id, status, transactionId, secondaryTransactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.UpdateOrderStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrderStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update order status
    ApiResponse<Object> response = apiInstance.UpdateOrderStatusWithHttpInfo(id, status, transactionId, secondaryTransactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.UpdateOrderStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Order ID. |  |
| **status** | **int** | Order status. These statuses can be set: cancelled, on-hold, inactive, out-of-stock,  backorder, completed, pending. |  |
| **transactionId** | **string** | A transaction id can be set here if status is set to pending. |  |
| **secondaryTransactionId** | **string** | A secondary transaction id, if any, can be set here if status is set to pending. |  |

### Return type

**Object**

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

<a name="updatetransactiondata"></a>
# **UpdateTransactionData**
> Object UpdateTransactionData (int id, APIOrderTransactionData transactionData)

Updates transaction data on an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateTransactionDataExample
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

            var apiInstance = new OrderApi(config);
            var id = 56;  // int | Order ID.
            var transactionData = new APIOrderTransactionData(); // APIOrderTransactionData | The transaction data

            try
            {
                // Updates transaction data on an order
                Object result = apiInstance.UpdateTransactionData(id, transactionData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.UpdateTransactionData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates transaction data on an order
    ApiResponse<Object> response = apiInstance.UpdateTransactionDataWithHttpInfo(id, transactionData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.UpdateTransactionDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Order ID. |  |
| **transactionData** | [**APIOrderTransactionData**](APIOrderTransactionData.md) | The transaction data |  |

### Return type

**Object**

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

<a name="validateorder"></a>
# **ValidateOrder**
> Object ValidateOrder (OrderValidateOrderCreationRequest request)

Validates order data for order creation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ValidateOrderExample
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

            var apiInstance = new OrderApi(config);
            var request = new OrderValidateOrderCreationRequest(); // OrderValidateOrderCreationRequest | The order data to validate.

            try
            {
                // Validates order data for order creation.
                Object result = apiInstance.ValidateOrder(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ValidateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validates order data for order creation.
    ApiResponse<Object> response = apiInstance.ValidateOrderWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ValidateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**OrderValidateOrderCreationRequest**](OrderValidateOrderCreationRequest.md) | The order data to validate. |  |

### Return type

**Object**

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

