# Org.OpenAPITools.Model.ShippingModelsShippingQuery
A query to filter shipping options by.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **int** | The site ID the delivery options belong to. Required. | [optional] 
**CountryId** | **int** | The country ID where the order should be shipped to. | [optional] 
**ShippingId** | **int** | Carismar Shipping Option ID | [optional] 
**DeliveryOptionId** | **Guid** | Unifaun Delivery Option ID | [optional] 
**Order** | [**OrderCheckoutOrder**](OrderCheckoutOrder.md) |  | [optional] 
**MinimumFreeShippingLimit** | **double** | The cart sum limit for free shipping - to be used for conditions in the delivery checkout portal | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

