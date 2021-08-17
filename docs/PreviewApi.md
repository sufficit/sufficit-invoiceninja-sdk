# IO.Swagger.Api.PreviewApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPreview**](PreviewApi.md#getpreview) | **POST** /api/v1/preview | Returns a pdf preview

<a name="getpreview"></a>
# **GetPreview**
> void GetPreview (string xApiSecret, string xRequestedWith)

Returns a pdf preview

Returns a pdf preview.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPreviewExample
    {
        public void main()
        {
            var apiInstance = new PreviewApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Returns a pdf preview
                apiInstance.GetPreview(xApiSecret, xRequestedWith);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreviewApi.GetPreview: " + e.Message );
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
