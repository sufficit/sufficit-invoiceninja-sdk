# IO.Swagger.Api.EmailsApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendEmailTemplate**](EmailsApi.md#sendemailtemplate) | **POST** /api/v1/emails | Sends an email for an entity

<a name="sendemailtemplate"></a>
# **SendEmailTemplate**
> Template SendEmailTemplate (Body3 body, string xApiSecret, string xRequestedWith)

Sends an email for an entity

Sends an email for an entity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendEmailTemplateExample
    {
        public void main()
        {
            var apiInstance = new EmailsApi();
            var body = new Body3(); // Body3 | The template subject and body
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Sends an email for an entity
                Template result = apiInstance.SendEmailTemplate(body, xApiSecret, xRequestedWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.SendEmailTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body3**](Body3.md)| The template subject and body | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 

### Return type

[**Template**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
