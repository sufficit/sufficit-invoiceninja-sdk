# IO.Swagger.Api.ImportsApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Preimport**](ImportsApi.md#preimport) | **POST** /api/v1/preimport | Pre Import checks - returns a reference to the job and the headers of the CSV

<a name="preimport"></a>
# **Preimport**
> void Preimport (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Pre Import checks - returns a reference to the job and the headers of the CSV

Pre Import checks - returns a reference to the job and the headers of the CSV

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PreimportExample
    {
        public void main()
        {
            var apiInstance = new ImportsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Pre Import checks - returns a reference to the job and the headers of the CSV
                apiInstance.Preimport(xApiSecret, xApiToken, xRequestedWith, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportsApi.Preimport: " + e.Message );
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
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
