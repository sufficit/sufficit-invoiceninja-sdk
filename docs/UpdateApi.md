# IO.Swagger.Api.UpdateApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SelfUpdate**](UpdateApi.md#selfupdate) | **POST** /api/v1/self-update | Performs a system update

<a name="selfupdate"></a>
# **SelfUpdate**
> void SelfUpdate (string xApiSecret, string xApiToken, string xApiPassword, string xRequestedWith, string include = null)

Performs a system update

Performs a system update

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfUpdateExample
    {
        public void main()
        {
            var apiInstance = new UpdateApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xApiPassword = xApiPassword_example;  // string | The login password when challenged
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Performs a system update
                apiInstance.SelfUpdate(xApiSecret, xApiToken, xApiPassword, xRequestedWith, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdateApi.SelfUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xApiPassword** | **string**| The login password when challenged | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
