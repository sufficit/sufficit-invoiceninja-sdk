# IO.Swagger.Model.Company
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The company hash id | [optional] 
**SizeId** | **string** | The company size ID | [optional] 
**IndustryId** | **string** | The company industry ID | [optional] 
**SlackWebhookUrl** | **string** | The slack webhook notification URL | [optional] 
**GoogleAnalyticsKey** | **string** | The google analytics key | [optional] 
**PortalMode** | **string** | Determines the client facing urls ie: subdomain,domain,iframe | [optional] 
**Subdomain** | **string** | Specifies the first part of the company domain ie acme in acme.domain.com | [optional] 
**PortalDomain** | **string** | The fully qualified domain for client facing URLS | [optional] 
**EnabledTaxRates** | **int?** | Number of taxes rates used per entity | [optional] 
**FillProducts** | **bool?** | Toggles filling a product description based on product key | [optional] 
**ConvertProducts** | **bool?** | ___________ | [optional] 
**UpdateProducts** | **bool?** | Toggles updating a product description which description changes | [optional] 
**ShowProductDetails** | **bool?** | Toggles showing a product description which description changes | [optional] 
**CustomFields** | **Object** | Custom fields map | [optional] 
**EnableProductCost** | **bool?** | ______________ | [optional] 
**EnableProductQuantity** | **bool?** | ______________ | [optional] 
**DefaultQuantity** | **bool?** | ______________ | [optional] 
**CustomSurchargeTaxes1** | **bool?** | Toggles charging taxes on custom surcharge amounts | [optional] 
**CustomSurchargeTaxes2** | **bool?** | Toggles charging taxes on custom surcharge amounts | [optional] 
**CustomSurchargeTaxes3** | **bool?** | Toggles charging taxes on custom surcharge amounts | [optional] 
**CustomSurchargeTaxes4** | **bool?** | Toggles charging taxes on custom surcharge amounts | [optional] 
**Logo** | **Object** | The company logo - binary | [optional] 
**Settings** | [**CompanySettings**](CompanySettings.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

