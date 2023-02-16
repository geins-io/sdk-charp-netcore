# Org.OpenAPITools.Model.OrderModelsPaymentDetail
Data carrier for a payment detail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier for this payment detail. Exception: For some payment options this field can be 0. These orders only have one payment detail. | [optional] 
**PaymentId** | **int** | Payment method id | [optional] 
**Name** | **string** | The name of the payment method | [optional] 
**DisplayName** | **string** | The display name of the payment method | [optional] 
**TransactionId** | **string** | The transaction id (external reference). | [optional] 
**SecondaryTransactionId** | **string** | The secondary transaction id, if any (external reference). | [optional] 
**ReservationNumber** | **string** | The reservation number. This field is not available for all payment methods. | [optional] 
**ReservationDate** | **DateTime** | Reservation date | [optional] 
**PaymentDate** | **DateTime** | Payment date | [optional] 
**Total** | **double** | Total | [optional] 
**Payed** | **bool** | Shows if the order is paid using this payment method | [optional] 
**PaymentFee** | **double** | The payment fee | [optional] 
**ShippingFee** | **double** | The shipping fee | [optional] 
**PaymentOption** | **string** | The name of the payment option, if any.  This doesn&#39;t have to be the same as the payment name. Eg \&quot;Direct bank payment\&quot;, \&quot;Card\&quot;, \&quot;Invoice\&quot; etc. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

