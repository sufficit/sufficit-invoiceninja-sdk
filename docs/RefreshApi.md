# IO.Swagger.Api.RefreshApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Refresh**](RefreshApi.md#refresh) | **POST** /api/v1/refresh | Refreshes the dataset

<a name="refresh"></a>
# **Refresh**
> CompanyUser Refresh (string xApiSecret, string xApiToken, string xRequestedWith, string include = null, string includeStatic = null, string clearCache = null)

Refreshes the dataset

Refreshes the dataset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RefreshExample
    {
        public void main()
        {
            var apiInstance = new RefreshApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 
            var includeStatic = includeStatic_example;  // string | Returns static variables (optional) 
            var clearCache = clearCache_example;  // string | Clears the static cache (optional) 

            try
            {
                // Refreshes the dataset
                CompanyUser result = apiInstance.Refresh(xApiSecret, xApiToken, xRequestedWith, include, includeStatic, clearCache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefreshApi.Refresh: " + e.Message );
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
 **includeStatic** | **string**| Returns static variables | [optional] 
 **clearCache** | **string**| Clears the static cache | [optional] 

### Return type

[**CompanyUser**](CompanyUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
