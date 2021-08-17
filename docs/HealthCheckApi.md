# IO.Swagger.Api.HealthCheckApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHealthCheck**](HealthCheckApi.md#gethealthcheck) | **GET** /api/v1/health_check | Attempts to get a health check from the API

<a name="gethealthcheck"></a>
# **GetHealthCheck**
> void GetHealthCheck (string xApiSecret, string xRequestedWith)

Attempts to get a health check from the API

Attempts to get a health check from the API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHealthCheckExample
    {
        public void main()
        {
            var apiInstance = new HealthCheckApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Attempts to get a health check from the API
                apiInstance.GetHealthCheck(xApiSecret, xRequestedWith);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthCheckApi.GetHealthCheck: " + e.Message );
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
