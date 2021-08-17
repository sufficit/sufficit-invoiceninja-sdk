# IO.Swagger.Api.WebcronApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Webcron**](WebcronApi.md#webcron) | **GET** /api/v1/webcron | Executes the task scheduler via a webcron service

<a name="webcron"></a>
# **Webcron**
> void Webcron (string xApiSecret, string xRequestedWith)

Executes the task scheduler via a webcron service

Executes the task scheduler via a webcron service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebcronExample
    {
        public void main()
        {
            var apiInstance = new WebcronApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Executes the task scheduler via a webcron service
                apiInstance.Webcron(xApiSecret, xRequestedWith);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebcronApi.Webcron: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
