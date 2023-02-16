# Org.OpenAPITools.Model.PriceListModelsReadPriceListPrice
A price for a product on a specific price list.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **int** | The id of the product that this price applies to. | [optional] 
**PriceListId** | **int** | The id of the price list that this price is associated with. | [optional] 
**PriceListName** | **string** | The name of the price list that this price is associated with. | [optional] 
**PriceIncVat** | **double** | The price, inc VAT, in the currency of the associated price list. | [optional] 
**PriceExVat** | **double** | The price, ex VAT, in the currency of the associated price list. | [optional] 
**VatRate** | **double** | The Vat Rate | [optional] 
**Country** | **string** | The 2-letter ISO country code for this price. | [optional] 
**Currency** | **string** | The 3-letter ISO 4217 currency code for this price. | [optional] 
**StaggeredCount** | **int** | Staggered count for this price. Defaults to 1. | [optional] 
**ValidFrom** | **DateTime** | The date the price is valid from. | [optional] 
**ValidTo** | **DateTime** | The date the price is valid to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

