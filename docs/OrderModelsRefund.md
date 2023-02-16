# Org.OpenAPITools.Model.OrderModelsRefund
Data carrier for a refund

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier for this refund | [optional] 
**OrderRowId** | **int** | Reference to the order row that has been refunded | [optional] 
**PaymentDetailId** | **int** | Reference to the payment detail that has been refunded | [optional] 
**ReturnId** | **int** | Id number of the return. Can be used to group refunds. | [optional] 
**ArticleNumber** | **string** | Article number. If the refund is not bound to an order row this field contains an optional refund article number. | [optional] 
**CreatedAt** | **DateTime** | Datetime when the refund was created | [optional] 
**Total** | **double** | Total amount refunded | [optional] 
**ReasonCode** | **int** | Reason code for the refund | [optional] 
**Reason** | **string** | Reason for refund | [optional] 
**ToBalance** | **bool** | Shows if the refund was deposited to the customers balance | [optional] 
**Vat** | **double** | Vat percent in decimals for the refunded amount | [optional] 
**ItemId** | **int** | Item ID (SKU). | [optional] 
**RefundType** | **string** | Refund Type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

