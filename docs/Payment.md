# IO.Swagger.Model.Payment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ______ | [optional] 
**ClientId** | **string** | ______ | [optional] 
**InvitationId** | **string** | ______ | [optional] 
**ClientContactId** | **string** | ______ | [optional] 
**UserId** | **string** | ______ | [optional] 
**TypeId** | **string** | The Payment Type ID | [optional] 
**Date** | **string** | The Payment date | [optional] 
**TransactionReference** | **string** | The transaction reference as defined by the payment gateway | [optional] 
**AssignedUserId** | **string** | ______ | [optional] 
**PrivateNotes** | **string** | ______ | [optional] 
**IsManual** | **bool?** | ______ | [optional] 
**IsDeleted** | **bool?** | ______ | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | The amount of this payment | [optional] 
**Refunded** | [**decimal?**](BigDecimal.md) | The refunded amount of this payment | [optional] 
**UpdatedAt** | [**decimal?**](BigDecimal.md) | Timestamp | [optional] 
**ArchivedAt** | [**decimal?**](BigDecimal.md) | Timestamp | [optional] 
**CompanyGatewayId** | **string** | The company gateway id | [optional] 
**Paymentables** | [**Paymentable**](Paymentable.md) |  | [optional] 
**Invoices** | [**List&lt;InvoicePaymentable&gt;**](InvoicePaymentable.md) |  | [optional] 
**Credits** | [**List&lt;CreditPaymentable&gt;**](CreditPaymentable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

