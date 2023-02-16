# Org.OpenAPITools.Model.OrderModelsOrderQuery
Data carrying class for order queries

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Updated** | **DateTime** | Given a date, only orders updated after the provided date will be returned. | [optional] 
**StatusList** | **string** | Comma separated list of statuses to filter on. | [optional] 
**MarketId** | **int** | Id of a market. | [optional] 
**PaymentName** | **string** | Name of a payment method | [optional] 
**ParcelGroupId** | **int** | Id of a parcel group. | [optional] 
**CustomerId** | **int** | The ID of a customer | [optional] 
**Email** | **string** | The email of a customer | [optional] 
**Include** | **string** | Comma separated list of child-collections to also include in the query result. | [optional] 
**ExternalOrderStatus** | **int** | This status can be used by external systems to change the status of an order. Such as failed or done. | [optional] 
**CombineProductContainerRows** | **bool** | If true, will combine all order rows that are part of a container into a single container row. | [optional] 
**PackingLocationId** | **int** | The packing place to get orders from. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

