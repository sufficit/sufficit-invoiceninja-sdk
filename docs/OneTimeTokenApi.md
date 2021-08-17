# IO.Swagger.Api.OneTimeTokenApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OneTimeToken**](OneTimeTokenApi.md#onetimetoken) | **POST** /api/v1/one_time_token | Attempts to create a one time token

<a name="onetimetoken"></a>
# **OneTimeToken**
> void OneTimeToken (string xApiSecret, string xRequestedWith)

Attempts to create a one time token

Attempts to create a one time token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OneTimeTokenExample
    {
        public void main()
        {
            var apiInstance = new OneTimeTokenApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Attempts to create a one time token
                apiInstance.OneTimeToken(xApiSecret, xRequestedWith);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OneTimeTokenApi.OneTimeToken: " + e.Message );
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
