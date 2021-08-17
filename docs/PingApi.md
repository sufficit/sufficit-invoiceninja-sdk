# IO.Swagger.Api.PingApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPing**](PingApi.md#getping) | **GET** /api/v1/ping | Attempts to ping the API

<a name="getping"></a>
# **GetPing**
> void GetPing (string xApiSecret, string xRequestedWith)

Attempts to ping the API

Attempts to ping the API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPingExample
    {
        public void main()
        {
            var apiInstance = new PingApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Attempts to ping the API
                apiInstance.GetPing(xApiSecret, xRequestedWith);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PingApi.GetPing: " + e.Message );
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
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
