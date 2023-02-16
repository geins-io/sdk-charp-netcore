# Org.OpenAPITools.Model.PriceListModelsPriceListPriceResponse
The response of a PriceListPrice request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | Information about the outcome of the request. | [optional] 
**Invalid** | [**List&lt;PriceListModelsWritePriceListPrice&gt;**](PriceListModelsWritePriceListPrice.md) | Supplied PriceList prices that failed validation. | [optional] 
**NotFound** | [**List&lt;PriceListModelsWritePriceListPrice&gt;**](PriceListModelsWritePriceListPrice.md) | Supplied PriceList prices that were technically valid, but couldn&#39;t be found. | [optional] 
**UpdateCount** | **int** | Number of price updates resulting from the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

