# IO.Swagger.Api.TemplatesApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetShowTemplate**](TemplatesApi.md#getshowtemplate) | **POST** /api/v1/templates | Returns a entity template with the template variables replaced with the Entities

<a name="getshowtemplate"></a>
# **GetShowTemplate**
> Template GetShowTemplate (Body5 body, string xApiSecret, string xRequestedWith)

Returns a entity template with the template variables replaced with the Entities

Returns a entity template with the template variables replaced with the Entities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShowTemplateExample
    {
        public void main()
        {
            var apiInstance = new TemplatesApi();
            var body = new Body5(); // Body5 | The template subject and body
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Returns a entity template with the template variables replaced with the Entities
                Template result = apiInstance.GetShowTemplate(body, xApiSecret, xRequestedWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetShowTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body5**](Body5.md)| The template subject and body | 
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
