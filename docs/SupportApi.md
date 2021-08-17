# IO.Swagger.Api.SupportApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SupportMessage**](SupportApi.md#supportmessage) | **POST** /api/v1/support/messages/send | Sends a support message to Invoice Ninja team

<a name="supportmessage"></a>
# **SupportMessage**
> List<string> SupportMessage (string body, string xApiSecret, string xApiToken, string xRequestedWith)

Sends a support message to Invoice Ninja team

Allows a user to send a support message to the Invoice Ninja Team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SupportMessageExample
    {
        public void main()
        {
            var apiInstance = new SupportApi();
            var body = new string(); // string | The message
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Sends a support message to Invoice Ninja team
                List&lt;string&gt; result = apiInstance.SupportMessage(body, xApiSecret, xApiToken, xRequestedWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupportApi.SupportMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**string**](string.md)| The message | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
